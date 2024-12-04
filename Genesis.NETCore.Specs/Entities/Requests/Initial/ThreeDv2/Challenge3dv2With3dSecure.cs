using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial.ThreeDv2
{
    [TestClass]
    public class describe_Challenge3dv2With3dSecure : InitialRequestValidation<Sale3d>
    {
        public describe_Challenge3dv2With3dSecure() : base(() => RequestMocksFactory.CreateValidChallenge3dv2With3dSecure(), -0.01m)
        {
        }
    }
}
