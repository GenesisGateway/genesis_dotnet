using System;
using System.Globalization;
using System.Linq;

namespace Genesis.Net
{
    public static class Formatter
    {
        public const string DATE_FORMAT_YMD = "yyyy-MM-dd";
        public const string DATE_FORMAT_DMY = "dd-MM-yyyy";
        public const string TIMESTAMP_FORMAT = "yyyy-MM-dd'T'HH:mm:ssK";

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

        public static string FormatToString(DateTime value, string format = DATE_FORMAT_YMD)
        {
            return value.ToString(format, CultureInfo.InvariantCulture);
        }

        public static DateTime ParseDate(string value, string format = DATE_FORMAT_YMD)
        {
            return DateTime.ParseExact(value, format , CultureInfo.InvariantCulture);
        }

        public static DateTime FormatFromString(string value)
        {
            return DateTime.Parse(value, null, DateTimeStyles.RoundtripKind);
        }
    }
}