using System;
using System.Linq;
using Genesis.Net.Entities.Requests.Initial;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs.Entities.Requests.Initial
{
    class describe_sofort_ideal : nspec
    {
        EntityMock<SofortiDeal> sofortiDealMock;

        void before_each()
        {
            sofortiDealMock = RequestMocksFactory.CreateValidSofortiDeal();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            sofortiDealMock.Instance.should_serialize_and_deserialize<SofortiDeal>();
        }

        void it_should_validate_required_properties()
        {
            sofortiDealMock.Instance.on_validation_should_behave_like_required("Id", "RemoteIp",
                "ReturnSuccessUrl", "ReturnFailureUrl", "CustomerBankId", "BankAccountNumber");
        }

        void it_should_validate_amount()
        {
            sofortiDealMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        void it_should_validate_ipv4Address()
        {
            sofortiDealMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        void it_should_serialize_to_the_correct_xml()
        {
            sofortiDealMock.Instance.should_serialize_to(sofortiDealMock.Xml);
        }
    }
}
