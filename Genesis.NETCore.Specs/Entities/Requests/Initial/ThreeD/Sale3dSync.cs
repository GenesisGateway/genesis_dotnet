using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial.ThreeD
{
    [TestClass]
    public class describe_sale_3d_sync : InitialRequestValidation<Sale3d>
    {
        public describe_sale_3d_sync() : base(() => RequestMocksFactory.CreateValidSale3dSync(), -0.01m)
        {
        }
    }
}
