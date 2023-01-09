using Genesis.NetCore.Entities.Requests.Query;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Query
{
    [TestClass]
    public class describe_single_chargeback
    {
        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            var singleChargeback = RequestMocksFactory.CreateValidSingleChargeback("Fake arn").Instance;
            singleChargeback.should_serialize_and_deserialize<SingleChargeback>();
        }

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly_2()
        {
            var singleChargeback = RequestMocksFactory.CreateValidSingleChargeback(string.Empty, "Fake transaction id").Instance;
            singleChargeback.should_serialize_and_deserialize<SingleChargeback>();
        }

        [TestMethod]
        public void it_should_serialize_to_the_correct_xml()
        {
            var singleChargebackMock = RequestMocksFactory.CreateValidSingleChargeback("74537604221431003881865");
            singleChargebackMock.Instance.should_serialize_to(singleChargebackMock.Xml);
        }

        [TestMethod]
        public void it_should_serialize_to_the_correct_xml_2()
        {
            var singleChargebackMock = RequestMocksFactory.CreateValidSingleChargeback(string.Empty, "74537604221431003881865");
            singleChargebackMock.Instance.should_serialize_to(singleChargebackMock.Xml);
        }
    }
}