using Genesis.Net.Common;
using Genesis.Net.Entities;
using NSpec;
using System;
using System.Linq;

namespace Genesis.Net.Specs.Entities
{
    class describe_money : nspec
    {
        Money money;

        void before_each()
        {
            money = new Money() { };
        }

        void it_should_recognise_minor_amount_from_string()
        {
            money.NativeAmount = "10";
            money.MinorAmount.should_be(0);
            money.MajorAmount.should_be(0);

            money.CurrencyCode = Iso4217CurrencyCodes.USD;
            money.MinorAmount.should_be(10);
            money.MajorAmount.should_be(0.1);
        }

        void it_should_recognise_major_amount_from_string()
        {
            money.NativeAmount = "0.1";
            money.MinorAmount.should_be(0);
            money.MajorAmount.should_be(0);

            money.CurrencyCode = Iso4217CurrencyCodes.USD;
            money.MinorAmount.should_be(10);
            money.MajorAmount.should_be(0.1);
        }

        void it_should_accept_currency_before_amount()
        {
            money.CurrencyCode = Iso4217CurrencyCodes.USD;
            money.NativeAmount.should_be_empty();

            money.NativeAmount = "10";
            money.MinorAmount.should_be(10);
            money.MajorAmount.should_be(0.1);
        }

        void it_should_update_amount_via_MinorAmount()
        {
            money.CurrencyCode = Iso4217CurrencyCodes.USD;
            money.MinorAmount = 10;

            money.MinorAmount.should_be(10);
            money.MajorAmount.should_be(0.1);
        }

        void it_should_update_amount_via_MajorAmount()
        {
            money.CurrencyCode = Iso4217CurrencyCodes.USD;
            money.MajorAmount = 10;

            money.MinorAmount.should_be(1000);
            money.MajorAmount.should_be(10);
        }
    }
}
