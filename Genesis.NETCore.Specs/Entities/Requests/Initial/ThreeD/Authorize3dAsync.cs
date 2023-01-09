using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial.ThreeD
{
    [TestClass]
    public class describe_authorize_3d_async : InitialRequestValidation3dAsync<Authorize3d>
    {
        public describe_authorize_3d_async() : base(() => RequestMocksFactory.CreateValidAuthorize3dAsync())
        {
        }
    }
}