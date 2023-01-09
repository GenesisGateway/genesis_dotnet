using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial
{
    [TestClass]
    public class describe_paybyvoucher
    {
        EntityMock<PayByVoucher> payByVoucherMock;

        [TestInitialize]
        public void before_each()
        {
            payByVoucherMock = RequestMocksFactory.CreateValidPayByVoucher();
        }

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            payByVoucherMock.Instance.should_serialize_and_deserialize<PayByVoucher>();
        }

        [TestMethod]
        public void it_should_serialize_to_the_correct_xml()
        {
            payByVoucherMock.Instance.should_serialize_to(payByVoucherMock.Xml);
        }

        [TestMethod]
        public void it_should_validate_required_properties()
        {
            payByVoucherMock.Instance.on_validation_should_behave_like_required("Id", "ProductName", "ProductCategory", "CardHolder",
                "CustomerPhone", "CustomerEmail", "CustomerIdNumber", "CustomerBankId", "BankAccountNumber");
        }

        [TestMethod]
        public void it_should_validate_amount()
        {
            payByVoucherMock.Instance.on_validation_should_behave_like_amount("Amount");
        }
    }
}
