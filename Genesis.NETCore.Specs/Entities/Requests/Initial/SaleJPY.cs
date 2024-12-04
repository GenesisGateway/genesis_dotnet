using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial
{
    [TestClass]
    public class describe_sale_with_jpy_currency : InitialRequestValidation<Sale>
    {
        public describe_sale_with_jpy_currency() : base(() => RequestMocksFactory.CreateValidSaleWithJPYCurrency(), -1m)
        {
        }
    }
}