using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial
{
    [TestClass]
    public class describe_sale : InitialRequestValidation<Sale>
    {
        public describe_sale() : base(() => RequestMocksFactory.CreateValidSale())
        {
        }
    }
}