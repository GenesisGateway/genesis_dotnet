using System;
using System.Linq;
using Genesis.Net.Entities.Requests.Query;
using NSpec;
using Genesis.Net.Specs.Mocks;

namespace Genesis.Net.Specs.Entities.Requests.Query
{
    class describe_single_retrieval_request : nspec
    {
        void it_should_serialize_and_deserialize_correctly()
        {
            var singleRetrievalRequest = RequestMocksFactory.CreateValidSingleRetrievalRequest("Fake arn").Instance;
            singleRetrievalRequest.should_serialize_and_deserialize<SingleRetrievalRequest>();
        }

        void it_should_serialize_and_deserialize_correctly_2()
        {
            var singleRetrievalRequest = RequestMocksFactory.CreateValidSingleRetrievalRequest(string.Empty, "Fake transaction id").Instance;
            singleRetrievalRequest.should_serialize_and_deserialize<SingleRetrievalRequest>();
        }

        void it_should_serialize_to_the_correct_xml()
        {
            var singleRetrievalRequestMock = RequestMocksFactory.CreateValidSingleRetrievalRequest("74537604221431003881865");
            singleRetrievalRequestMock.Instance.should_serialize_to(singleRetrievalRequestMock.Xml);
        }

        void it_should_serialize_to_the_correct_xml_2()
        {
            var singleRetrievalRequestMock = RequestMocksFactory.CreateValidSingleRetrievalRequest(string.Empty, "74537604221431003881865");
            singleRetrievalRequestMock.Instance.should_serialize_to(singleRetrievalRequestMock.Xml);
        }
    }
}
