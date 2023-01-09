using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial
{
    [TestClass]
    public class describe_account_verification : InitialRequestValidation<AccountVerification>
    {
        public describe_account_verification() : base(() => RequestMocksFactory.CreateValidAccountVerification())
        {
        }
    }
}
