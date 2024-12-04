using System;
using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial.ThreeD
{
    public abstract class InitialRequestValidation3dAsync<T> : InitialRequestValidation<T>
        where T : InitialRequest
    {
        public InitialRequestValidation3dAsync(Func<EntityMock<T>> getMockObject) : base(getMockObject, -0.01m)
        {
        }

        [TestMethod]
        public void it_should_validate_notification_url()
        {
            initialRequestMock.on_validation_should_behave_like_url("NotificationUrl");
        }

        [TestMethod]
        public void it_should_validate_success_url()
        {
            initialRequestMock.on_validation_should_behave_like_url("ReturnSuccessUrl");
        }

        [TestMethod]
        public void it_should_validate_failure_url()
        {
            initialRequestMock.on_validation_should_behave_like_url("ReturnFailureUrl");
        }
    }
}
