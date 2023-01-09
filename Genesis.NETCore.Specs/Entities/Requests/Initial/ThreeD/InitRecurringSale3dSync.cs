using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial.ThreeD
{
    [TestClass]
    public class describe_init_recurring_sale_3d_sync : InitialRequestValidation<InitRecurringSale3d>
    {
        public describe_init_recurring_sale_3d_sync() : base(() => RequestMocksFactory.CreateValidInitRecurringSale3dSync())
        {
        }
    }
}
