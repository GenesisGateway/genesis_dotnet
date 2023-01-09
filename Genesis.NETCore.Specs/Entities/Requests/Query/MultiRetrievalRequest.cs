using Genesis.NetCore.Entities.Requests.Query;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Query
{
    [TestClass]
    public class describe_multi_retrieval_request
    {
        EntityMock<MultiRetrievalRequest> multiRetrievalRequestMock;

        [TestInitialize]
        public void before_each()
        {
            multiRetrievalRequestMock = RequestMocksFactory.CreateValidMultiRetrievalRequest();
        }

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            multiRetrievalRequestMock.Instance.should_serialize_and_deserialize<MultiRetrievalRequest>();
        }

        [TestMethod]
        public void it_should_serialize_to_the_correct_xml()
        {
            multiRetrievalRequestMock.Instance.should_serialize_to(multiRetrievalRequestMock.Xml);
        }
    }
}
