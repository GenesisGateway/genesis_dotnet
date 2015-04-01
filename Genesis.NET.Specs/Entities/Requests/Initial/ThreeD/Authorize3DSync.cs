using System;
using System.Linq;
using Genesis.Net.Entities.Requests.Initial.ThreeD;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs.Entities.Requests.Initial.ThreeD
{
    class describe_authorize_3d_sync : nspec
    {
        EntityMock<Authorize3dSync> authorize3dSyncMock;

        void before_each()
        {
            authorize3dSyncMock = RequestMocksFactory.CreateValidAuthorize3dSync();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            authorize3dSyncMock.Instance.should_serialize_and_deserialize<Authorize3dSync>();
        }

        void it_should_validate_required_properties()
        {
            authorize3dSyncMock.Instance.on_validation_should_behave_like_required("Id", "RemoteIp", "CardHolder", "CardNumber", "MpiParams");
        }

        void it_should_validate_amount()
        {
            authorize3dSyncMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        void it_should_validate_ipv4Address()
        {
            authorize3dSyncMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        void it_should_validate_month()
        {
            authorize3dSyncMock.Instance.on_validation_should_behave_like_month("ExpirationMonth");
        }

        void it_should_validate_year()
        {
            authorize3dSyncMock.Instance.on_validation_should_behave_like_year("ExpirationYear");
        }

        void it_should_validate_card_number()
        {
            authorize3dSyncMock.Instance.on_validation_should_behave_like_card_number("CardNumber");
        }

        void it_should_validate_cvv()
        {
            authorize3dSyncMock.Instance.on_validation_should_behave_like_cvv("Cvv");
        }

        void it_should_serialize_to_the_correct_xml()
        {
            authorize3dSyncMock.Instance.should_serialize_to(authorize3dSyncMock.Xml);
        }
    }
}