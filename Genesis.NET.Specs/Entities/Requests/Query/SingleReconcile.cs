using System;
using System.Linq;
using Genesis.Net.Entities.Requests.Query;
using NSpec;
using Genesis.Net.Specs.Mocks;

namespace Genesis.Net.Specs.Entities.Requests.Query
{
    class descibe_single_reconcile : nspec
    {
        EntityMock<SingleReconcile> singleReconcileMock;

        void before_each()
        {
            singleReconcileMock = RequestMocksFactory.CreateValidSingleReconcile();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            singleReconcileMock.Instance.should_serialize_and_deserialize<SingleReconcile>();
        }

        void it_should_validate_required_properties()
        {
            singleReconcileMock.Instance.on_validation_should_behave_like_required("UniqueId");
        }

        void it_should_serialize_to_the_correct_xml()
        {
            singleReconcileMock.Instance.should_serialize_to(singleReconcileMock.Xml);
        }
    }
}