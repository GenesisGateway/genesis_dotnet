using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial
{
    [TestClass]
    public class describe_payout : InitialRequestValidation<Payout>
    {
        public describe_payout() : base(() => RequestMocksFactory.CreateValidPayout())
        {
        }
    }
}