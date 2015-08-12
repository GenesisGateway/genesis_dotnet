using System;
using System.Linq;
using Genesis.Net.Entities.Requests.Initial;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs.Entities.Requests.Initial
{
    class describe_ppro : nspec
    {
        EntityMock<Ppro> pproMock;

        void before_each()
        {
            pproMock = RequestMocksFactory.CreateValidPpro();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            pproMock.Instance.should_serialize_and_deserialize<Ppro>();
        }

        void it_should_validate_required_properties()
        {
            pproMock.Instance.on_validation_should_behave_like_required("Id", "RemoteIp", "ReturnSuccessUrl", "ReturnFailureUrl", "PaymentType");
        }

        void it_should_validate_amount()
        {
            pproMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        void it_should_validate_ipv4Address()
        {
            pproMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        void it_should_serialize_to_the_correct_xml()
        {
            pproMock.Instance.should_serialize_to(pproMock.Xml);
        }
    }
}
