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
    class describe_googlepay : nspec
    {
        EntityMock<GooglePay> googlePayMock;

        void before_each()
        {
            googlePayMock = RequestMocksFactory.CreateValidGooglePay();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            googlePayMock.Instance.should_serialize_and_deserialize<GooglePay>();
        }

        void it_should_serialize_to_the_correct_xml()
        {
            googlePayMock.Instance.should_serialize_to(googlePayMock.Xml);
        }

        void it_should_validate_required_properties()
        {
            googlePayMock.Instance.on_validation_should_behave_like_required("Id", "PaymentToken", "Subtype");
        }

        void it_should_validate_amount()
        {
            googlePayMock.Instance.on_validation_should_behave_like_amount("Amount");
        }
    }
}
