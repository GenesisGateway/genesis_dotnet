using Genesis.Net.Entities.Requests.Query;
using Genesis.Net.Specs.Mocks;
using NSpec;
using System;
using System.Linq;

namespace Genesis.Net.Specs.Entities.Requests.Query
{
    class describe_multi_reconcile : nspec
    {
        EntityMock<MultiReconcile> multiReconcile;

        void before_each()
        {
            multiReconcile = RequestMocksFactory.CreateValidMultiReconcile();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            multiReconcile.Instance.should_serialize_and_deserialize<MultiReconcile>();
        }

        void it_should_serialize_to_the_correct_xml()
        {
            multiReconcile.Instance.should_serialize_to(multiReconcile.Xml);
        }
    }
}
