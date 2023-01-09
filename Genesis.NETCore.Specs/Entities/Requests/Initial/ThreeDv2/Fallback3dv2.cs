using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial.ThreeDv2
{
    [TestClass]
    public class describe_Fallback3dv2 : InitialRequestValidation<InitRecurringSale3d>
    {
        public describe_Fallback3dv2() : base(() => RequestMocksFactory.CreateValidFallback3dv2())
        {
        }
    }
}
