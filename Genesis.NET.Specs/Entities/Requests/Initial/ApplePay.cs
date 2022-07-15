using Genesis.Net.Entities.Requests.Initial;
using Genesis.Net.Specs.Mocks;
using NSpec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genesis.Net.Specs.Entities.Requests.Initial
{
    class describe_applepay : nspec
    {
        EntityMock<ApplePay> applePayMock;

        void before_each()
        {
            applePayMock = RequestMocksFactory.CreateValidApplePay();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            applePayMock.Instance.should_serialize_and_deserialize<ApplePay>();
        }

        void it_should_serialize_to_the_correct_xml()
        {
            applePayMock.Instance.should_serialize_to(applePayMock.Xml);
        }

        void it_should_validate_required_properties()
        {
            applePayMock.Instance.on_validation_should_behave_like_required("Id", "PaymentToken", "Subtype");
        }

        void it_should_validate_amount()
        {
            applePayMock.Instance.on_validation_should_behave_like_amount("Amount");
        }
    }
}
