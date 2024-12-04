using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial.Recurring
{
    [TestClass]
    public class describe_recurring_sale : InitialRequestValidation<Sale>
    {
        public describe_recurring_sale() : base(() => RequestMocksFactory.CreateValidSaleRecurring(), -0.01m)
        {
        }
    }
}
