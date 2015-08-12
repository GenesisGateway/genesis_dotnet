using System;
using System.Linq;
using Genesis.Net.Entities.Requests.Referential;
using NSpec;
using Genesis.Net.Specs.Mocks;

namespace Genesis.Net.Specs.Entities.Requests.Query
{
    class descibe_wpf_reconcile : nspec
    {
        EntityMock<WpfReconcile> wpfReconcileMock;

        void before_each()
        {
            wpfReconcileMock = RequestMocksFactory.CreateValidWpfReconcile();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            wpfReconcileMock.Instance.should_serialize_and_deserialize<WpfReconcile>();
        }

        void it_should_validate_required_properties()
        {
            wpfReconcileMock.Instance.on_validation_should_behave_like_required("UniqueId");
        }

        void it_should_serialize_to_the_correct_xml()
        {
            wpfReconcileMock.Instance.should_serialize_to(wpfReconcileMock.Xml);
        }
    }
}