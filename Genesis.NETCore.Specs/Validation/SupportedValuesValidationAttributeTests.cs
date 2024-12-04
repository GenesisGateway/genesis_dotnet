using System.ComponentModel.DataAnnotations;
using Genesis.NetCore.Common;
using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Genesis.NetCore.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Validation
{
    [TestClass]
    public class SupportedValuesValidationAttributeTests
    {
        public Sale TestObject { get; set; }
        public Iso4217CurrencyCodes[] TestValidValues { get; private set; }
        public SupportedValuesValidationAttribute Attribute { get; private set; }
        public ValidationContext ValidationContext { get; private set; }

        [TestInitialize]
        public void before_each()
        {
            this.TestObject = RequestMocksFactory.CreateValidSale().Instance;
            this.TestValidValues = new Iso4217CurrencyCodes[] { Iso4217CurrencyCodes.EUR, Iso4217CurrencyCodes.USD, Iso4217CurrencyCodes.GBP };
            this.Attribute = new SupportedValuesValidationAttribute(nameof(this.TestObject.Currency), this.TestValidValues);
        }

        [TestMethod]
        public void it_should_be_valid_when_value_is_in_the_list()
        {
            this.TestObject.Currency = Iso4217CurrencyCodes.USD;
            var valid = this.Attribute.IsValid(TestObject);
            Assert.IsTrue(valid);
        }

        [TestMethod]
        [DataRow(Iso4217CurrencyCodes.AED)]
        [DataRow(Iso4217CurrencyCodes.Undefined)]
        [DataRow(null)]
        public void it_should_be_invalid_when_value_is_not_in_the_list(Iso4217CurrencyCodes currency)
        {
            this.TestObject.Currency = currency;
            var valid = this.Attribute.IsValid(TestObject);
            Assert.IsFalse(valid);
        }
    }
}
