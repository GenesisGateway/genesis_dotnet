using System;
using System.Linq;

namespace Genesis.Net.Common
{
    public class Currency
    {
        public readonly string Name;
        public readonly string Code;
        public readonly string Country;
        public readonly int? MinorToMajorExponent;

        internal Currency(string name, string code, string country, int? minorToMajorExponent)
        {
            Name = name;
            Code = code;
            Country = country;
            MinorToMajorExponent = minorToMajorExponent;
        }
    }
}
