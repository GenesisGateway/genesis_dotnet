using Genesis.NetCore.Entities.Requests.Query;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Query
{
    [TestClass]
    public class describe_multi_reconcile
    {
        EntityMock<MultiReconcile> multiReconcile;

        [TestInitialize]
        public void before_each()
        {
            multiReconcile = RequestMocksFactory.CreateValidMultiReconcile();
        }

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            multiReconcile.Instance.should_serialize_and_deserialize<MultiReconcile>();
        }

        [TestMethod]
        public void it_should_serialize_to_the_correct_xml()
        {
            multiReconcile.Instance.should_serialize_to(multiReconcile.Xml);
        }
    }
}
