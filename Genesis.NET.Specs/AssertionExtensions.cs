using System.Linq;
using Genesis.Net.Common;
using Genesis.Net.Entities;
using Genesis.Net.Specs.Validation;
using NSpec;
using System.Xml.Linq;
using System;
using Genesis.Net.Validations;
using System.Text;
using System.IO;
using Genesis.Net.Entities.Responses;
using Genesis.Net.Entities.Responses.Error;

namespace Genesis.Net.Specs
{
    internal static class AssertionExtensions
    {
        public static void should_be_valid(this Entity entity)
        {
            entity.on_validation_should_have(0);
        }

        public static void on_validation_should_have(this Entity entity, int expectedCount,
            string[] expectedMemberNamesInAscendingOrder = null, string[] expectedMessagesInAscendingOrder = null)
        {
            var validationErrors = EntitiesValidator.GetValidationErrors(entity);
            validationErrors.Count().should_be(expectedCount);

            if (expectedMemberNamesInAscendingOrder != null)
            {
                SpecHelper.GetMemberNamesInAscendingOrder(validationErrors).should_be(expectedMemberNamesInAscendingOrder);
            }

            if (expectedMessagesInAscendingOrder != null)
            {
                SpecHelper.GetErrorMessagesInAscendingOrder(validationErrors).should_be(expectedMessagesInAscendingOrder);
            }
        }

        public static void on_validation_should_behave_like_amount(this Entity entity, string amountPropertyName)
        {
            var amountValidationSpecs = new describe_amount_validation(entity, amountPropertyName);
            SpecHelper.RunSpecs(amountValidationSpecs);
        }

        public static void on_validation_should_behave_like_ipv4_address(this Entity entity, string ipv4AddressPropertyName)
        {
            var ipv4AddressValidationSpecs = new describe_ipv4_address_validation(entity, ipv4AddressPropertyName);
            SpecHelper.RunSpecs(ipv4AddressValidationSpecs);
        }

        public static void on_validation_should_behave_like_month(this Entity entity, string monthPropertyName)
        {
            var monthValidationSpecs = new describe_month_validation(entity, monthPropertyName);
            SpecHelper.RunSpecs(monthValidationSpecs);
        }

        public static void on_validation_should_behave_like_year(this Entity entity, string yearPropertyName)
        {
            var yearValidationSpecs = new describe_year_validation(entity, yearPropertyName);
            SpecHelper.RunSpecs(yearValidationSpecs);
        }

        public static void on_validation_should_behave_like_card_number(this Entity entity, string cardNumberPropertyName)
        {
            var cardNumberValidationSpecs = new describe_card_number_validation(entity, cardNumberPropertyName);
            SpecHelper.RunSpecs(cardNumberValidationSpecs);
        }

        public static void on_validation_should_behave_like_cvv(this Entity entity, string cvvPropertyName)
        {
            var cvvValidationSpecs = new describe_cvv_validation(entity, cvvPropertyName);
            SpecHelper.RunSpecs(cvvValidationSpecs);
        }

        public static void on_validation_should_behave_like_required(this Entity entity, params string[] requiredPropertyNames)
        {
            var type = entity.GetType();
            foreach (var requiredPropertyName in requiredPropertyNames)
            {
                type.GetProperty(requiredPropertyName).SetValue(entity, null);
            }

            var expectedErrorsCount = requiredPropertyNames.Length;
            var expectedMemberNames = requiredPropertyNames.OrderBy(m => m).ToArray();
            var expectedErrorMessages = expectedMemberNames.Select(m => ValidationMessages.Required(m)).ToArray();

            entity.on_validation_should_have(expectedErrorsCount, expectedMemberNames, expectedErrorMessages);
        }

        public static void on_validation_should_behave_like_url(this Entity entity, string urlPropertyName)
        {
            var urlValidationSpecs = new describe_url(entity, urlPropertyName);
            SpecHelper.RunSpecs(urlValidationSpecs);
        }

        public static void should_serialize_and_deserialize<T>(this T entity) where T : Entity
        {
            var actualEntity = SpecHelper.SerializeAndDeserialize<T>(entity);
            actualEntity.should_be(entity);
        }

        public static void should_serialize_to(this Entity entity, string expectedXml)
        {
            var expectedXmlDocument = XDocument.Parse(expectedXml);
            var actualXmlDocument = entity.ToXDocument();
            String.Equals(actualXmlDocument.Declaration.ToString(), expectedXmlDocument.Declaration.ToString(), StringComparison.InvariantCultureIgnoreCase).should_be_true();
            XNode.DeepEquals(actualXmlDocument, expectedXmlDocument).should_be_true();
        }

        public static void should_be_parsable_from<T>(this Entity entity, string responseXml) where T : Entity
        {
            var bytes = Encoding.UTF8.GetBytes(responseXml);
            using(var stream = new MemoryStream(bytes))
            {
                var xml = XDocument.Load(stream);
                var parsedEntity = ResultFactory.Parse<T>(xml);
                entity.should_be(parsedEntity);
            }
        }

        public static void should_parse_to_success_response<S, E>(this string xmlContent)
            where S : Entity
            where E : Entity, IErrorResponse
        {
            xmlContent.should_parse_to_response<S, E>(new Action<Result<S, E>>((result) => result.should_be_success()));
        }

        public static void should_parse_to_error_response<S, E>(this string xmlContent)
            where S : Entity
            where E : Entity, IErrorResponse
        {
            xmlContent.should_parse_to_response<S, E>(new Action<Result<S, E>>((result) => result.should_be_error()));
        }

        public static void should_parse_to_response<S, E>(this string xmlContent,
            Action<Result<S, E>> assert)
            where S : Entity
            where E : Entity, IErrorResponse
        {
            var result = ResultFactory.Parse<S, E>(Encoding.UTF8.GetBytes(xmlContent));
            assert(result);
        }

        public static void should_be_success<S, E>(this Result<S, E> result)
            where S : Entity
            where E : Entity, IErrorResponse
        {
            result.IsSuccessful.should_be_true();
            result.SuccessResponse.should_not_be_null();
            result.ErrorResponse.should_be_null();
        }

        public static void should_be_error<S, E>(this Result<S, E> result)
            where S : Entity
            where E : Entity, IErrorResponse
        {
            result.IsSuccessful.should_be_false();
            result.SuccessResponse.should_be_null();
            result.ErrorResponse.should_not_be_null();
        }
    }
}
