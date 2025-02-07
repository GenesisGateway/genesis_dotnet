﻿using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial
{
    [TestClass]
    public class describe_wpf_create_mastercard_funding
    {
        EntityMock<WpfCreate> wpfCreateMock;

        [TestInitialize]
        public void before_each()
        {
            wpfCreateMock = RequestMocksFactory.CreateValidWpfCreateWithMastercardFunding();
        }

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            wpfCreateMock.Instance.should_serialize_and_deserialize<WpfCreate>();
        }

        [TestMethod]
        public void it_should_validate_required_properties()
        {
            wpfCreateMock.Instance.on_validation_should_behave_like_required("TransactionId", "Description", "NotificationUrl", "ReturnSuccessUrl", "ReturnFailureUrl", "ReturnCancelUrl");
        }

        [TestMethod]
        public void it_should_validate_amount()
        {
            wpfCreateMock.Instance.on_validation_should_behave_like_amount("Amount", -0.01m);
        }

        [TestMethod]
        public void it_should_validate_notification_url()
        {
            wpfCreateMock.Instance.on_validation_should_behave_like_url("NotificationUrl");
        }

        [TestMethod]
        public void it_should_validate_success_url()
        {
            wpfCreateMock.Instance.on_validation_should_behave_like_url("ReturnSuccessUrl");
        }

        [TestMethod]
        public void it_should_validate_failure_url()
        {
            wpfCreateMock.Instance.on_validation_should_behave_like_url("ReturnFailureUrl");
        }

        [TestMethod]
        public void it_should_validate_cancel_url()
        {
            wpfCreateMock.Instance.on_validation_should_behave_like_url("ReturnCancelUrl");
        }

        [TestMethod]
        public void it_should_serialize_to_the_correct_xml()
        {
            wpfCreateMock.Instance.should_serialize_to(wpfCreateMock.Xml);
        }

        [TestMethod]
        public void it_should_validate_state_in_the_address()
        {
            wpfCreateMock.Instance.BillingAddress.Country = Common.Iso3166CountryCodes.US;
            wpfCreateMock.Instance.BillingAddress.State = "BS"; // invalid state in US country
            wpfCreateMock.Instance.on_validation_should_have(1, new[] { "State" }, new[] { "BS is not a valid ISO 3166-2 state code in US" });
        }
    }
}