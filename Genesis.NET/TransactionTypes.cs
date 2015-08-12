using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Genesis.Net
{
    public class TransactionTypes
    {
        internal static readonly Lazy<Dictionary<String, TransactionTypes>> TransactionTypesByName = new Lazy<Dictionary<string, TransactionTypes>>(() =>
        {
            return typeof(TransactionTypes)
                .GetFields(BindingFlags.Public | BindingFlags.Static)
                .ToDictionary(f => ((TransactionTypes)f.GetValue(null)).Name, f => (TransactionTypes)f.GetValue(null));
        });

        public static readonly TransactionTypes Authorize = new TransactionTypes(1, "authorize");

        public static readonly TransactionTypes Authorize3d = new TransactionTypes(2, "authorize3d");

        public static readonly TransactionTypes Capture = new TransactionTypes(3, "capture");

        public static readonly TransactionTypes Sale = new TransactionTypes(4, "sale");

        public static readonly TransactionTypes Sale3d = new TransactionTypes(5, "sale3d");

        public static readonly TransactionTypes InitRecurringSale = new TransactionTypes(6, "init_recurring_sale");

        public static readonly TransactionTypes InitRecurringSale3d = new TransactionTypes(7, "init_recurring_sale3d");

        public static readonly TransactionTypes RecurringSale = new TransactionTypes(8, "recurring_sale");

        public static readonly TransactionTypes Refund = new TransactionTypes(9, "refund");

        public static readonly TransactionTypes Void = new TransactionTypes(10, "void");

        public static readonly TransactionTypes Credit = new TransactionTypes(11, "credit");

        public static readonly TransactionTypes Payout = new TransactionTypes(12, "payout");

        public static readonly TransactionTypes AccountVerification = new TransactionTypes(13, "account_verification");

        public static readonly TransactionTypes Avs = new TransactionTypes(14, "avs");

        public static readonly TransactionTypes EzeeWallet = new TransactionTypes(15, "ezeewallet");

        public static readonly TransactionTypes PayByVoucher = new TransactionTypes(16, "paybyvoucher");

        public static readonly TransactionTypes CashU = new TransactionTypes(17, "cashu");

        public static readonly TransactionTypes PaySafeCard = new TransactionTypes(18, "paysafecard");

        public static readonly TransactionTypes Sofort = new TransactionTypes(19, "sofort");

        public static readonly TransactionTypes SofortiDeal = new TransactionTypes(20, "sofort_ideal");

        public static readonly TransactionTypes Ppro = new TransactionTypes(21, "ppro");

        public readonly short Value;
        public readonly string Name;

        private TransactionTypes(short value, string name)
        {
            Value = value;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            TransactionTypes other = obj as TransactionTypes;
            if (other != null)
            {
                return Value.Equals(other.Value);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}
