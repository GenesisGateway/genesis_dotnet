using Genesis.NetCore.Entities.Requests.Query;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Query
{
    [TestClass]
    public class describe_multi_chargeback
    {
        EntityMock<MultiChargeback> multiChargebackMock;

        [TestInitialize]
        public void before_each()
        {
            multiChargebackMock = RequestMocksFactory.CreateValidMultiChargeback();
        }

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            multiChargebackMock.Instance.should_serialize_and_deserialize<MultiChargeback>();
        }

        [TestMethod]
        public void it_should_serialize_to_the_correct_xml()
        {
            multiChargebackMock.Instance.should_serialize_to(multiChargebackMock.Xml);
        }
    }
}