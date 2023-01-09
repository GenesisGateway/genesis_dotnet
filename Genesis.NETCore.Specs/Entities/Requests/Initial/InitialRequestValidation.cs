using System;
using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial
{
    public abstract class InitialRequestValidation<T>
        where T : InitialRequest
    {
        protected T initialRequestMock;
        protected string initialRequestMockXml;
        private readonly Func<EntityMock<T>> getMockObjectFunk;

        public InitialRequestValidation(Func<EntityMock<T>> getMockObject)
        {
            getMockObjectFunk = getMockObject;
        }

        [TestInitialize]
        public void before_each()
        {
            var mockObject = getMockObjectFunk.Invoke();
            initialRequestMock = mockObject.Instance;
            initialRequestMockXml = mockObject.Xml;
        }

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            initialRequestMock.should_serialize_and_deserialize<T>();
        }

        [TestMethod]
        public void it_should_validate_required_properties()
        {
            initialRequestMock.on_validation_should_behave_like_required("Id", "CardHolder", "CardNumber", "ExpirationMonth", "ExpirationYear");
        }

        [TestMethod]
        public void it_should_validate_amount()
        {
            initialRequestMock.on_validation_should_behave_like_amount("Amount");
        }

        [TestMethod]
        public void it_should_validate_ipv4Address()
        {
            initialRequestMock.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        [TestMethod]
        public void it_should_validate_month()
        {
            initialRequestMock.on_validation_should_behave_like_month("ExpirationMonth");
        }

        [TestMethod]
        public void it_should_validate_month_with_client_side_encryption()
        {
            initialRequestMock.on_validation_should_behave_like_month_with_client_side_encription("ExpirationMonth", "ClientSideEncryption");
        }

        [TestMethod]
        public void it_should_validate_year()
        {
            initialRequestMock.on_validation_should_behave_like_year("ExpirationYear");
        }

        [TestMethod]
        public void it_should_validate_year_with_client_side_encryption()
        {
            initialRequestMock.on_validation_should_behave_like_year_with_client_side_encryption("ExpirationYear", "ClientSideEncryption");
        }

        [TestMethod]
        public void it_should_validate_card_number()
        {
            initialRequestMock.on_validation_should_behave_like_card_number("CardNumber");
        }

        [TestMethod]
        public void it_should_validate_card_number_with_client_side_encryption()
        {
            initialRequestMock.on_validation_should_behave_like_card_number_with_client_side_encryption("CardNumber", "ClientSideEncryption");
        }

        [TestMethod]
        public void it_should_validate_card_holder()
        {
            initialRequestMock.on_validation_should_behave_like_card_holder("CardHolder");
        }

        [TestMethod]
        public void it_should_validate_card_holder_with_client_side_encryption()
        {
            initialRequestMock.on_validation_should_behave_like_card_holder_with_client_side_encryption("CardHolder", "ClientSideEncryption");
        }

        [TestMethod]
        public void it_should_validate_cvv()
        {
            initialRequestMock.on_validation_should_behave_like_cvv("Cvv");
        }

        [TestMethod]
        public void it_should_validate_cvv_with_client_side_encryption()
        {
            initialRequestMock.on_validation_should_behave_like_cvv_with_client_side_encryption("Cvv", "ClientSideEncryption");
        }

        [TestMethod]
        public void it_should_serialize_to_the_correct_xml()
        {
            initialRequestMock.should_serialize_to(initialRequestMockXml);
        }
    }
}
