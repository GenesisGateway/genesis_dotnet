using System;
using System.Globalization;
using System.Linq;
using Genesis.Net.Common;

namespace Genesis.Net.Entities
{
    public class Money : Entity
    {
        private string nativeAmount;
        private bool? isNativeAmountMinor;

        private int minorAmount;
        private decimal majorAmount;
        private Iso4217CurrencyCodes currencyCode;

        public Iso4217CurrencyCodes CurrencyCode
        {
            get
            {
                return currencyCode;
            }
            set
            {
                currencyCode = value;
                UpdateAmounts();
            }
        }

        internal string NativeAmount
        {
            get
            {
                return nativeAmount;
            }
            set
            {
                SetNativeAmount(value);
            }
        }

        public int MinorAmount
        {
            get
            {
                return minorAmount;
            }
            set
            {
                SetNativeAmount(value.ToString(), isMinor: true);
            }
        }

        public decimal MajorAmount
        {
            get
            {
                return majorAmount;
            }
            set
            {
                SetNativeAmount(value.ToString(), isMinor: false);
            }
        }

        private void SetNativeAmount(string value, bool? isMinor = null)
        {
            nativeAmount = value;
            isNativeAmountMinor = isMinor;

            UpdateAmounts();
        }

        private void UpdateAmounts()
        {
            if (CanUpdateAmounts())
            {
                if ((!isNativeAmountMinor.HasValue || isNativeAmountMinor.Value) && TryUpdateAmountsFromMinor())
                {
                    isNativeAmountMinor = true;
                    return;
                }

                isNativeAmountMinor = false;
                UpdateAmountsFromMajor();
            }
        }

        private bool CanUpdateAmounts()
        {
            return !string.IsNullOrEmpty(nativeAmount) && CurrencyCode != Iso4217CurrencyCodes.Undefined;
        }

        private bool TryUpdateAmountsFromMinor()
        {
            if (int.TryParse(nativeAmount, out minorAmount))
            {
                Iso4217Currencies.TryConvertMinorToMajor(CurrencyCode, minorAmount, out majorAmount);
                return true;
            }
            return false;
        }

        private void UpdateAmountsFromMajor()
        {
            majorAmount = decimal.Parse(nativeAmount, NumberStyles.Currency, CultureInfo.InvariantCulture);
            Iso4217Currencies.TryConvertMajorToMinor(CurrencyCode, majorAmount, out minorAmount);
        }
    }
}
