using System;
using System.Linq;
using Genesis.Net.Entities.Requests.Initial;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs.Entities.Requests.Initial
{
    class describe_payout : nspec
    {
        EntityMock<Payout> payoutMock;

        void before_each()
        {
            payoutMock = RequestMocksFactory.CreateValidPayout();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            payoutMock.Instance.should_serialize_and_deserialize<Payout>();
        }

        void it_should_validate_required_properties()
        {
            payoutMock.Instance.on_validation_should_behave_like_required("Id", "RemoteIp", "CardHolder", "CardNumber");
        }

        void it_should_validate_amount()
        {
            payoutMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        void it_should_validate_ipv4Address()
        {
            payoutMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        void it_should_validate_month()
        {
            payoutMock.Instance.on_validation_should_behave_like_month("ExpirationMonth");
        }

        void it_should_validate_year()
        {
            payoutMock.Instance.on_validation_should_behave_like_year("ExpirationYear");
        }

        void it_should_validate_card_number()
        {
            payoutMock.Instance.on_validation_should_behave_like_card_number("CardNumber");
        }

        void it_should_validate_cvv()
        {
            payoutMock.Instance.on_validation_should_behave_like_cvv("Cvv");
        }

        void it_should_serialize_to_the_correct_xml()
        {
            payoutMock.Instance.should_serialize_to(payoutMock.Xml);
        }
    }
}