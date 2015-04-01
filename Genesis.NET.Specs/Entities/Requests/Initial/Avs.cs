using System;
using System.Linq;
using Genesis.Net.Common;
using Genesis.Net.Entities;
using Genesis.Net.Entities.Requests.Initial;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs.Entities.Requests.Initial
{
    class describe_avs : nspec
    {
        EntityMock<Avs> avsMock;
        
        void before_each()
        {
            avsMock = RequestMocksFactory.CreateValidAvs();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            avsMock.Instance.should_serialize_and_deserialize<Avs>();
        }

        void it_should_validate_required_properties()
        {
            avsMock.Instance.on_validation_should_behave_like_required("Id", "RemoteIp", "CardHolder", "CardNumber");
        }

        void it_should_validate_amount()
        {
            avsMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        void it_should_validate_ipv4Address()
        {
            avsMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        void it_should_validate_month()
        {
            avsMock.Instance.on_validation_should_behave_like_month("ExpirationMonth");
        }

        void it_should_validate_year()
        {
            avsMock.Instance.on_validation_should_behave_like_year("ExpirationYear");
        }

        void it_should_validate_card_number()
        {
            avsMock.Instance.on_validation_should_behave_like_card_number("CardNumber");
        }

        void it_should_validate_cvv()
        {
            avsMock.Instance.on_validation_should_behave_like_cvv("Cvv");
        }

        void it_should_serialize_to_the_correct_xml()
        {
            avsMock.Instance.should_serialize_to(avsMock.Xml);
        }
    }
}