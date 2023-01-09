using Genesis.NetCore.Entities.Requests.Query;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Query
{
    [TestClass]
    public class describe_single_retrieval_request
    {
        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            var singleRetrievalRequest = RequestMocksFactory.CreateValidSingleRetrievalRequest("Fake arn").Instance;
            singleRetrievalRequest.should_serialize_and_deserialize<SingleRetrievalRequest>();
        }

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly_2()
        {
            var singleRetrievalRequest = RequestMocksFactory.CreateValidSingleRetrievalRequest(string.Empty, "Fake transaction id").Instance;
            singleRetrievalRequest.should_serialize_and_deserialize<SingleRetrievalRequest>();
        }

        [TestMethod]
        public void it_should_serialize_to_the_correct_xml()
        {
            var singleRetrievalRequestMock = RequestMocksFactory.CreateValidSingleRetrievalRequest("74537604221431003881865");
            singleRetrievalRequestMock.Instance.should_serialize_to(singleRetrievalRequestMock.Xml);
        }

        [TestMethod]
        public void it_should_serialize_to_the_correct_xml_2()
        {
            var singleRetrievalRequestMock = RequestMocksFactory.CreateValidSingleRetrievalRequest(string.Empty, "74537604221431003881865");
            singleRetrievalRequestMock.Instance.should_serialize_to(singleRetrievalRequestMock.Xml);
        }
    }
}
