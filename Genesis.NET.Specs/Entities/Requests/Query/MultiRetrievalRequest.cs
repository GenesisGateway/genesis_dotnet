using Genesis.Net.Entities.Requests.Query;
using Genesis.Net.Specs.Mocks;
using NSpec;
using System;
using System.Linq;

namespace Genesis.Net.Specs.Entities.Requests.Query
{
    class describe_multi_retrieval_request : nspec
    {
        EntityMock<MultiRetrievalRequest> multiRetrievalRequestMock;

        void before_each()
        {
            multiRetrievalRequestMock = RequestMocksFactory.CreateValidMultiRetrievalRequest();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            multiRetrievalRequestMock.Instance.should_serialize_and_deserialize<MultiRetrievalRequest>();
        }

        void it_should_serialize_to_the_correct_xml()
        {
            multiRetrievalRequestMock.Instance.should_serialize_to(multiRetrievalRequestMock.Xml);
        }
    }
}
