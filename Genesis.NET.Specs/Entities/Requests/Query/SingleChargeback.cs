using System;
using System.Linq;
using Genesis.Net.Entities.Requests.Query;
using NSpec;
using Genesis.Net.Specs.Mocks;

namespace Genesis.Net.Specs.Entities.Requests.Query
{
    class describe_single_chargeback : nspec
    {
        void it_should_serialize_and_deserialize_correctly()
        {
            var singleChargeback = RequestMocksFactory.CreateValidSingleChargeback("Fake arn").Instance;
            singleChargeback.should_serialize_and_deserialize<SingleChargeback>();
        }

        void it_should_serialize_and_deserialize_correctly_2()
        {
            var singleChargeback = RequestMocksFactory.CreateValidSingleChargeback(string.Empty, "Fake transaction id").Instance;
            singleChargeback.should_serialize_and_deserialize<SingleChargeback>();
        }

        void it_should_serialize_to_the_correct_xml()
        {
            var singleChargebackMock = RequestMocksFactory.CreateValidSingleChargeback("74537604221431003881865");
            singleChargebackMock.Instance.should_serialize_to(singleChargebackMock.Xml);
        }

        void it_should_serialize_to_the_correct_xml_2()
        {
            var singleChargebackMock = RequestMocksFactory.CreateValidSingleChargeback(string.Empty, "74537604221431003881865");
            singleChargebackMock.Instance.should_serialize_to(singleChargebackMock.Xml);
        }
    }
}