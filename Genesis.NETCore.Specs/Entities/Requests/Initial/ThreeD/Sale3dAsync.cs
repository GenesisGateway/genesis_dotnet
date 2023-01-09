using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial.ThreeD
{
    [TestClass]
    public class describe_sale_3d_async : InitialRequestValidation3dAsync<Sale3d>
    {
        public describe_sale_3d_async() : base(() => RequestMocksFactory.CreateValidSale3dAsync())
        {
        }
    }
}