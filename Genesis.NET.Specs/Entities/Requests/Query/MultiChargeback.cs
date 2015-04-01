using System;
using System.Linq;
using NSpec;
using Genesis.Net.Entities.Requests.Query;
using Genesis.Net.Specs.Mocks;

namespace Genesis.Net.Specs.Entities.Requests.Query
{
    class describe_multi_chargeback : nspec
    {
        EntityMock<MultiChargeback> multiChargebackMock;

        void before_each()
        {
            multiChargebackMock = RequestMocksFactory.CreateValidMultiChargeback();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            multiChargebackMock.Instance.should_serialize_and_deserialize<MultiChargeback>();
        }

        void it_should_serialize_to_the_correct_xml()
        {
            multiChargebackMock.Instance.should_serialize_to(multiChargebackMock.Xml);
        }
    }
}