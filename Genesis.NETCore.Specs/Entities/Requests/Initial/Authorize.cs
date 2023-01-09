using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial
{
    [TestClass]
    public class describe_authorize : InitialRequestValidation<Authorize>
    {
        public describe_authorize() : base(() => RequestMocksFactory.CreateValidAuthorize())
        {
        }
    }
}