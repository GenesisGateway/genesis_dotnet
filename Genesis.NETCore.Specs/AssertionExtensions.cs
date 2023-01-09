using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Genesis.NetCore.Common;
using Genesis.NetCore.Entities;
using Genesis.NetCore.Entities.Responses;
using Genesis.NetCore.Entities.Responses.Error;
using Genesis.NetCore.Specs.Validation;
using Genesis.NetCore.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs
{
    internal static class AssertionExtensions
    {
        public static void should_be_valid(this IEntity entity)
        {
            entity.on_validation_should_have(0);
        }

        public static void on_validation_should_have(this IEntity entity, int expectedCount,
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

        public static void on_validation_should_behave_like_amount(this IEntity entity, string amountPropertyName)
        {
            var amountValidationSpecs = new describe_amount_validation(entity, amountPropertyName);
            SpecHelper.RunSpecs(amountValidationSpecs);
        }

        public static void on_validation_should_behave_like_ipv4_address(this IEntity entity, string ipv4AddressPropertyName)
        {
            var ipv4AddressValidationSpecs = new describe_ipv4_address_validation(entity, ipv4AddressPropertyName);
            SpecHelper.RunSpecs(ipv4AddressValidationSpecs);
        }

        public static void on_validation_should_behave_like_month(this IEntity entity, string monthPropertyName)
        {
            var monthValidationSpecs = new describe_month_validation(entity, monthPropertyName);
            SpecHelper.RunSpecs(monthValidationSpecs);
        }

        public static void on_validation_should_behave_like_month_with_client_side_encription(this IEntity entity, string monthPropertyName, string csePropertyName)
        {
            var monthValidationSpecs = new describe_month_validation(entity, monthPropertyName, csePropertyName);
            SpecHelper.RunSpecs(monthValidationSpecs);
        }

        public static void on_validation_should_behave_like_year(this IEntity entity, string yearPropertyName)
        {
            var yearValidationSpecs = new describe_year_validation(entity, yearPropertyName);
            SpecHelper.RunSpecs(yearValidationSpecs);
        }
        
        public static void on_validation_should_behave_like_year_with_client_side_encryption(this IEntity entity, string yearPropertyName, string csePropertyName)
        {
            var yearValidationSpecs = new describe_year_validation(entity, yearPropertyName, csePropertyName);
            SpecHelper.RunSpecs(yearValidationSpecs);
        }

        public static void on_validation_should_behave_like_card_number(this IEntity entity, string cardNumberPropertyName)
        {
            var cardNumberValidationSpecs = new describe_card_number_validation(entity, cardNumberPropertyName);
            SpecHelper.RunSpecs(cardNumberValidationSpecs);
        }

        public static void on_validation_should_behave_like_card_number_with_client_side_encryption(this IEntity entity, string cardNumberPropertyName, string csePropertyName)
        {
            var cardNumberValidationSpecs = new describe_card_number_validation(entity, cardNumberPropertyName, csePropertyName);
            SpecHelper.RunSpecs(cardNumberValidationSpecs);
        }

        public static void on_validation_should_behave_like_cvv(this IEntity entity, string cvvPropertyName)
        {
            var cvvValidationSpecs = new describe_cvv_validation(entity, cvvPropertyName);
            SpecHelper.RunSpecs(cvvValidationSpecs);
        }

        public static void on_validation_should_behave_like_cvv_with_client_side_encryption(this IEntity entity, string cvvPropertyName, string csePropertyName)
        {
            var cvvValidationSpecs = new describe_cvv_validation(entity, cvvPropertyName, csePropertyName);
            SpecHelper.RunSpecs(cvvValidationSpecs);
        }

        public static void on_validation_should_behave_like_card_holder(this IEntity entity, string cardHolderPropertyName)
        {
            var cardHolderValidationSpecs = new describe_card_holder_validation(entity, cardHolderPropertyName);
            SpecHelper.RunSpecs(cardHolderValidationSpecs);
        }

        public static void on_validation_should_behave_like_card_holder_with_client_side_encryption(this IEntity entity, string cardHolderPropertyName, string csePropertyName)
        {
            var cardHolderValidationSpecs = new describe_card_holder_validation(entity, cardHolderPropertyName, csePropertyName);
            SpecHelper.RunSpecs(cardHolderValidationSpecs);
        }

        public static void on_validation_should_behave_like_required(this IEntity entity, params string[] requiredPropertyNames)
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

        public static void on_validation_should_behave_like_url(this IEntity entity, string urlPropertyName)
        {
            var urlValidationSpecs = new describe_url(entity, urlPropertyName);
            SpecHelper.RunSpecs(urlValidationSpecs);
        }

        public static void should_serialize_and_deserialize<T>(this T entity) where T : IEntity
        {
            var actualEntity = SpecHelper.SerializeAndDeserialize<T>(entity);
            actualEntity.should_be_override(entity);
        }

        public static void should_serialize_to(this IEntity entity, string expectedXml)
        {
            var expectedXmlDocument = XDocument.Parse(expectedXml);
            var actualXmlDocument = entity.ToXDocument();
            Assert.IsTrue(string.Equals(actualXmlDocument.Declaration.ToString(), expectedXmlDocument.Declaration.ToString(), StringComparison.InvariantCultureIgnoreCase));
            Assert.IsTrue(XNode.DeepEquals(actualXmlDocument, expectedXmlDocument));
        }

        public static void should_be_parsable_from<T>(this IEntity entity, string responseXml) where T : IEntity
        {
            var bytes = Encoding.UTF8.GetBytes(responseXml);
            using (var stream = new MemoryStream(bytes))
            {
                var xml = XDocument.Load(stream);
                var parsedEntity = ResultFactory.Parse<T>(xml);
                entity.should_be_override(parsedEntity);
            }
        }

        public static void should_parse_to_success_response<S, E>(this string xmlContent)
            where S : IEntity
            where E : IEntity, IErrorResponse
        {
            xmlContent.should_parse_to_response<S, E>(new Action<Result<S, E>>((result) => result.should_be_success()));
        }

        public static void should_parse_to_error_response<S, E>(this string xmlContent)
            where S : IEntity
            where E : IEntity, IErrorResponse
        {
            xmlContent.should_parse_to_response<S, E>(new Action<Result<S, E>>((result) => result.should_be_error()));
        }

        public static void should_parse_to_response<S, E>(this string xmlContent,
            Action<Result<S, E>> assert)
            where S : IEntity
            where E : IEntity, IErrorResponse
        {
            var result = ResultFactory.Parse<S, E>(Encoding.UTF8.GetBytes(xmlContent));
            assert(result);
        }

        public static void should_be_success<S, E>(this Result<S, E> result)
            where S : IEntity
            where E : IEntity, IErrorResponse
        {
            Assert.IsTrue(result.IsSuccessful);
            Assert.IsNotNull(result.SuccessResponse);
            Assert.IsNull(result.ErrorResponse);
        }

        public static void should_be_error<S, E>(this Result<S, E> result)
            where S : IEntity
            where E : IEntity, IErrorResponse
        {
            Assert.IsFalse(result.IsSuccessful);
            Assert.IsNull(result.SuccessResponse);
            Assert.IsNotNull(result.ErrorResponse);
        }

        public static void should_be<T>(this T self, T obj)
        {
            if (typeof(T).IsArray)
            {
                Assert.IsTrue(Enumerable.SequenceEqual((IEnumerable<object>)self, (IEnumerable<object>)obj));
            }
            else
            {
                Assert.AreEqual(self, obj);
            }
        }

        public static void should_be_override(this object self, object obj)
        {
            var equalsResult = self.EntityEquals(obj);
            Assert.IsTrue(equalsResult.Item1, equalsResult.Item2);
        }

        // moved here from entity class
        public static Tuple<bool, string> EntityEquals(this object self, object obj)
        {
            if (self.GetType() != obj.GetType())
            {
                return new Tuple<bool, string>(false, string.Format("Objects are with different types: {0} != {1}", self.GetType().Name, obj.GetType().Name));
            }

            foreach (var property in self.GetType().GetProperties())
            {
                var currentEntityPropertyValue = property.GetValue(self);
                var otherEntityPropertyValue = property.GetValue(obj);

                if (currentEntityPropertyValue is IEntity)
                {
                    return currentEntityPropertyValue.EntityEquals(otherEntityPropertyValue);
                }
                else if (typeof(Array).IsAssignableFrom(property.PropertyType) ||
                    typeof(IEnumerable<>).IsAssignableFrom(property.PropertyType))
                {
                    if (!SequenceEqual((IEnumerable<object>)currentEntityPropertyValue, (IEnumerable<object>)otherEntityPropertyValue))
                    {
                        return new Tuple<bool, string>(false, string.Format("Objects of type [{1}] has array property [{0}] with different values", property.Name, self.GetType().Name));
                    }
                }
                else if (property.PropertyType.IsGenericType &&
                    typeof(IEnumerable<>).MakeGenericType(property.PropertyType.GetGenericArguments()).IsAssignableFrom(property.PropertyType))
                {
                    var currentEntityPropertyValueEnumerable = ((IEnumerable)currentEntityPropertyValue).Cast<object>();
                    var otherEntityPropertyValueEnumerable = ((IEnumerable)otherEntityPropertyValue).Cast<object>();
                    if (!Enumerable.SequenceEqual(currentEntityPropertyValueEnumerable, otherEntityPropertyValueEnumerable))
                    {
                        return new Tuple<bool, string>(false, string.Format("Objects of type [{1}] has generic array property [{0}] with different values", property.Name, self.GetType().Name));
                    }
                }
                else if ((currentEntityPropertyValue == null && otherEntityPropertyValue != null) ||
                    (currentEntityPropertyValue != null && !currentEntityPropertyValue.Equals(otherEntityPropertyValue)))
                {
                    return new Tuple<bool, string>(false, string.Format("Objects of type [{1}] has property [{0}] with different value: {2} != {3}", property.Name, self.GetType().Name, currentEntityPropertyValue, otherEntityPropertyValue));
                }
            }

            return new Tuple<bool, string>(true, "Objects are equal.");
        }

        // moved here from entity class
        private static bool SequenceEqual(IEnumerable<object> sequence, IEnumerable<object> otherSequence)
        {
            if (sequence != null && otherSequence != null)
            {
                if (typeof(IEntity).IsAssignableFrom(sequence.GetType().GetElementType()))
                {
                    var entitySequence = sequence.Cast<IEntity>();
                    var entityOtherSequence = otherSequence.Cast<IEntity>();
                    return Enumerable.SequenceEqual(entitySequence, entityOtherSequence, new EntityComparer());
                }
                else
                {
                    return Enumerable.SequenceEqual(sequence, otherSequence);
                }
            }

            return sequence == null && otherSequence == null;
        }
    }
}
