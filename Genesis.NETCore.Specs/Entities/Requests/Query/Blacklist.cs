using Genesis.NetCore.Entities.Requests.Query;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Query
{
    [TestClass]
    public class descibe_blacklist
    {
        EntityMock<Blacklist> blacklistMock;

        [TestInitialize]
        public void before_each()
        {
            blacklistMock = RequestMocksFactory.CreateValidBlacklist();
        }

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            blacklistMock.Instance.should_serialize_and_deserialize<Blacklist>();
        }

        [TestMethod]
        public void it_should_validate_required_properties()
        {
            blacklistMock.Instance.on_validation_should_behave_like_required("CardNumber");
        }

        [TestMethod]
        public void it_should_validate_card_number()
        {
            blacklistMock.Instance.on_validation_should_behave_like_card_number("CardNumber");
        }

        [TestMethod]
        public void it_should_serialize_to_the_correct_xml()
        {
            blacklistMock.Instance.should_serialize_to(blacklistMock.Xml);
        }
    }
}