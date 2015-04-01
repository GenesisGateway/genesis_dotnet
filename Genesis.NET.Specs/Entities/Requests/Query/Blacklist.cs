using System;
using System.Linq;
using Genesis.Net.Entities.Requests.Query;
using NSpec;
using Genesis.Net.Specs.Mocks;

namespace Genesis.Net.Specs.Entities.Requests.Query
{
    class descibe_blacklist : nspec
    {
        EntityMock<Blacklist> blacklistMock;

        void before_each()
        {
            blacklistMock = RequestMocksFactory.CreateValidBlacklist();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            blacklistMock.Instance.should_serialize_and_deserialize<Blacklist>();
        }

        void it_should_validate_required_properties()
        {
            blacklistMock.Instance.on_validation_should_behave_like_required("CardNumber");
        }

        void it_should_validate_card_number()
        {
            blacklistMock.Instance.on_validation_should_behave_like_card_number("CardNumber");
        }

        void it_should_serialize_to_the_correct_xml()
        {
            blacklistMock.Instance.should_serialize_to(blacklistMock.Xml);
        }
    }
}