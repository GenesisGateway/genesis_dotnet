using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial
{
    [TestClass]
    public class describe_avs : InitialRequestValidation<Avs>
    {
        public describe_avs() : base(() => RequestMocksFactory.CreateValidAvs())
        {
        }
    }
}