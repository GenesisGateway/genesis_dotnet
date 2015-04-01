using System;
using System.Globalization;
using System.Linq;

namespace Genesis.Net
{
    public static class Formatter
    {
        public static object FormatFromString(Type type, string value)
        {
            if (type == typeof(string))
            {
                return value;
            }
            else if (type == typeof(bool))
            {
                return Convert.ToBoolean(value);
            }
            else if (type == typeof(int))
            {
                return Convert.ToInt32(value);
            }
            else if (type == typeof(DateTime))
            {
                return DateTime.Parse(value, null, DateTimeStyles.RoundtripKind);
            }

            throw new NotSupportedException(String.Format("Values of type {0} are not supported.", type.FullName));
        }

        public static int FormatStringToMonth(string value)
        {
            return Convert.ToInt32(value);
        }

        public static int FormatStringToYear(string value)
        {
            return Convert.ToInt32(value);
        }

        public static string FormatMonthToString(int month)
        {
            return month.ToString("00");
        }

        public static string FormatYearToString(int year)
        {
            return year.ToString("0000");
        }

        public static string FormatToString(DateTime value)
        {
            return value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
        }

        public static DateTime FormatFromString(string value)
        {
            return DateTime.Parse(value, null, DateTimeStyles.RoundtripKind);
        }
    }
}