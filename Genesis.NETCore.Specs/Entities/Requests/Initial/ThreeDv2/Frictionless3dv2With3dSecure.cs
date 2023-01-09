using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial.ThreeDv2
{
    [TestClass]
    public class describe_Frictionless3dv2With3dSecure : InitialRequestValidation<InitRecurringSale3d>
    {
        public describe_Frictionless3dv2With3dSecure() : base(() => RequestMocksFactory.CreateValidFrictionless3dv2With3dSecure())
        {
        }
    }
}
