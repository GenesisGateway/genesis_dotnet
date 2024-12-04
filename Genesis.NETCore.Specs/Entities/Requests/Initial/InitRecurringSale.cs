using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial
{
    [TestClass]
    public class describe_init_recurring_sale : InitialRequestValidation<InitRecurringSale>
    {
        public describe_init_recurring_sale() : base(() => RequestMocksFactory.CreateValidInitRecurringSale(), -0.01m)
        {
        }
    }
}