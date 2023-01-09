using Genesis.NetCore.Entities.Requests.Query;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Query
{
    [TestClass]
    public class descibe_single_reconcile
    {
        EntityMock<SingleReconcile> singleReconcileMock;

        [TestInitialize]
        public void before_each()
        {
            singleReconcileMock = RequestMocksFactory.CreateValidSingleReconcile();
        }

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            singleReconcileMock.Instance.should_serialize_and_deserialize<SingleReconcile>();
        }

        [TestMethod]
        public void it_should_validate_required_properties()
        {
            singleReconcileMock.Instance.on_validation_should_behave_like_required("UniqueId");
        }

        [TestMethod]
        public void it_should_serialize_to_the_correct_xml()
        {
            singleReconcileMock.Instance.should_serialize_to(singleReconcileMock.Xml);
        }
    }
}