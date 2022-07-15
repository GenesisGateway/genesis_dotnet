using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Genesis.Net
{
    public class TransactionSubTypes
    {
        internal static readonly Lazy<Dictionary<String, TransactionSubTypes>> TransactionTypesByName = new Lazy<Dictionary<string, TransactionSubTypes>>(() =>
        {
            return typeof(TransactionSubTypes)
                .GetFields(BindingFlags.Public | BindingFlags.Static)
                .ToDictionary(f => ((TransactionSubTypes)f.GetValue(null)).Name, f => (TransactionSubTypes)f.GetValue(null));
        });

        public static readonly TransactionSubTypes Authorize = new TransactionSubTypes(1, "authorize");

        public static readonly TransactionSubTypes Sale = new TransactionSubTypes(2, "sale");

        public static readonly TransactionSubTypes InitRecurringSale = new TransactionSubTypes(3, "init_recurring_sale");

        public readonly short Value;
        public readonly string Name;

        private TransactionSubTypes(short value, string name)
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
            TransactionSubTypes other = obj as TransactionSubTypes;
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
