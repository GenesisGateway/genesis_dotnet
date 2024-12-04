using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial.ThreeDv2
{
    [TestClass]
    public class describe_Challenge3dv2 : InitialRequestValidation<Authorize3d>
    {
        public describe_Challenge3dv2() : base(() => RequestMocksFactory.CreateValidChallenge3dv2(), -0.01m)
        {
        }
    }
}
