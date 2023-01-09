using Genesis.NetCore.Entities.Requests.Referential;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Query
{
    [TestClass]
    public class descibe_wpf_reconcile
    {
        EntityMock<WpfReconcile> wpfReconcileMock;

        [TestInitialize]
        public void before_each()
        {
            wpfReconcileMock = RequestMocksFactory.CreateValidWpfReconcile();
        }

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            wpfReconcileMock.Instance.should_serialize_and_deserialize<WpfReconcile>();
        }

        [TestMethod]
        public void it_should_validate_required_properties()
        {
            wpfReconcileMock.Instance.on_validation_should_behave_like_required("UniqueId");
        }

        [TestMethod]
        public void it_should_serialize_to_the_correct_xml()
        {
            wpfReconcileMock.Instance.should_serialize_to(wpfReconcileMock.Xml);
        }
    }
}