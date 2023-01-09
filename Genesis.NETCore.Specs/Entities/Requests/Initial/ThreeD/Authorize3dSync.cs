using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial.ThreeD
{
    [TestClass]
    public class describe_authorize_3d_sync : InitialRequestValidation<Authorize3d>
    {
        public describe_authorize_3d_sync() : base(() => RequestMocksFactory.CreateValidAuthorize3dSync())
        {
        }
    }
}