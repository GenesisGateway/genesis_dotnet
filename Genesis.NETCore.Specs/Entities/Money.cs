using Genesis.NetCore.Common;
using Genesis.NetCore.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities
{
    [TestClass]
    public class describe_money
    {
        Money money;

        [TestInitialize]
        public void before_each()
        {
            money = new Money() { };
        }

        [TestMethod]
        public void it_should_properly_convert_major_to_minor_units()
        {
            money.CurrencyCode = Iso4217CurrencyCodes.USD;
            money.MajorAmount = 3.14M;
            money.MinorAmount.ToString().should_be("314");
        }

        [TestMethod]
        public void it_should_recognise_minor_amount_from_string()
        {
            money.NativeAmount = "10";
            money.MinorAmount.should_be(0);
            money.MajorAmount.should_be(0);

            money.CurrencyCode = Iso4217CurrencyCodes.USD;
            money.MinorAmount.should_be(10);
            money.MajorAmount.should_be(0.1m);
        }

        [TestMethod]
        public void it_should_recognise_major_amount_from_string()
        {
            money.NativeAmount = "0.1";
            money.MinorAmount.should_be(0);
            money.MajorAmount.should_be(0);

            money.CurrencyCode = Iso4217CurrencyCodes.USD;
            money.MinorAmount.should_be(10);
            money.MajorAmount.should_be(0.1m);
        }

        [TestMethod]
        public void it_should_accept_currency_before_amount()
        {
            money.CurrencyCode = Iso4217CurrencyCodes.USD;
            Assert.IsNull(money.NativeAmount);

            money.NativeAmount = "10";
            money.MinorAmount.should_be(10);
            money.MajorAmount.should_be(0.1m);
        }

        [TestMethod]
        public void it_should_update_amount_via_MinorAmount()
        {
            money.CurrencyCode = Iso4217CurrencyCodes.USD;
            money.MinorAmount = 10;

            money.MinorAmount.should_be(10);
            money.MajorAmount.should_be(0.1m);
        }

        [TestMethod]
        public void it_should_update_amount_via_MajorAmount()
        {
            money.CurrencyCode = Iso4217CurrencyCodes.USD;
            money.MajorAmount = 10;

            money.MinorAmount.should_be(1000);
            money.MajorAmount.should_be(10);
        }
    }
}
