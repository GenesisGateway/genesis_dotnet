using System;
using System.Linq;
using Genesis.Net.Entities.Requests.Initial.ThreeD;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs.Entities.Requests.Initial.ThreeD
{
    class describe_init_recurring_sale_3d_sync : nspec
    {
        EntityMock<InitRecurringSale3dSync> initRecurringSale3dSyncMock;

        void before_each()
        {
            initRecurringSale3dSyncMock = RequestMocksFactory.CreateValidInitRecurringSale3dSync();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            initRecurringSale3dSyncMock.Instance.should_serialize_and_deserialize<InitRecurringSale3dSync>();
        }

        void it_should_validate_required_properties()
        {
            initRecurringSale3dSyncMock.Instance.on_validation_should_behave_like_required("Id", "RemoteIp", "CardHolder", "CardNumber", "MpiParams");
        }

        void it_should_validate_amount()
        {
            initRecurringSale3dSyncMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        void it_should_validate_ipv4Address()
        {
            initRecurringSale3dSyncMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        void it_should_validate_month()
        {
            initRecurringSale3dSyncMock.Instance.on_validation_should_behave_like_month("ExpirationMonth");
        }

        void it_should_validate_year()
        {
            initRecurringSale3dSyncMock.Instance.on_validation_should_behave_like_year("ExpirationYear");
        }

        void it_should_validate_card_number()
        {
            initRecurringSale3dSyncMock.Instance.on_validation_should_behave_like_card_number("CardNumber");
        }

        void it_should_validate_cvv()
        {
            initRecurringSale3dSyncMock.Instance.on_validation_should_behave_like_cvv("Cvv");
        }

        void it_should_serialize_to_the_correct_xml()
        {
            initRecurringSale3dSyncMock.Instance.should_serialize_to(initRecurringSale3dSyncMock.Xml);
        }
    }
}
