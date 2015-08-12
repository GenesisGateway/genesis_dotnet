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
    class describe_paybyvoucher : nspec
    {
        EntityMock<PayByVoucher> payByVoucherMock;

        void before_each()
        {
            payByVoucherMock = RequestMocksFactory.CreateValidPayByVoucher();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            payByVoucherMock.Instance.should_serialize_and_deserialize<PayByVoucher>();
        }

        void it_should_serialize_to_the_correct_xml()
        {
            payByVoucherMock.Instance.should_serialize_to(payByVoucherMock.Xml);
        }

        void it_should_validate_required_properties()
        {
            payByVoucherMock.Instance.on_validation_should_behave_like_required("Id", "ProductName", "ProductCategory", "CardHolder",
                "CustomerPhone", "CustomerEmail", "CustomerIdNumber", "CustomerBankId", "BankAccountNumber");
        }

        void it_should_validate_amount()
        {
            payByVoucherMock.Instance.on_validation_should_behave_like_amount("Amount");
        }
    }
}
