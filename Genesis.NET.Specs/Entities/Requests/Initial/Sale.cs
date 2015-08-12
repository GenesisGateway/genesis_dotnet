using System;
using System.Linq;
using Genesis.Net.Entities.Requests.Initial;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs.Entities.Requests.Initial
{
    class describe_sale : nspec
    {
        EntityMock<Sale> saleMock;

        void before_each()
        {
            saleMock = RequestMocksFactory.CreateValidSale();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            saleMock.Instance.should_serialize_and_deserialize<Sale>();
        }

        void it_should_validate_required_properties()
        {
            saleMock.Instance.on_validation_should_behave_like_required("Id", "RemoteIp", "CardHolder", "CardNumber");
        }

        void it_should_validate_amount()
        {
            saleMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        void it_should_validate_ipv4Address()
        {
            saleMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        void it_should_validate_month()
        {
            saleMock.Instance.on_validation_should_behave_like_month("ExpirationMonth");
        }

        void it_should_validate_year()
        {
            saleMock.Instance.on_validation_should_behave_like_year("ExpirationYear");
        }

        void it_should_validate_card_number()
        {
            saleMock.Instance.on_validation_should_behave_like_card_number("CardNumber");
        }

        void it_should_validate_cvv()
        {
            saleMock.Instance.on_validation_should_behave_like_cvv("Cvv");
        }

        void it_should_serialize_to_the_correct_xml()
        {
            saleMock.Instance.should_serialize_to(saleMock.Xml);
        }
    }
}