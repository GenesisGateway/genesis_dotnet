using System;
using System.Collections.Generic;
using System.Linq;

namespace Genesis.Net.Common
{
    public static class Iso4217Currencies
    {
        public static bool TryConvertMinorToMajor(Iso4217CurrencyCodes currencyCode, int minorValue, out decimal majorValue)
        {
            majorValue = default(decimal);

            var currency = GetCurrency(currencyCode);
            int? exponent = currency.MinorToMajorExponent;
            if (exponent.HasValue)
            {
                majorValue = minorValue / (decimal)Math.Pow(10, exponent.Value);
                return true;
            }

            return false;
        }

        public static bool TryConvertMajorToMinor(Iso4217CurrencyCodes currencyCode, decimal majorValue, out int minorValue)
        {
            minorValue = default(int);

            var currency = GetCurrency(currencyCode);
            int? exponent = currency.MinorToMajorExponent;
            if (exponent.HasValue)
            {
                var value = majorValue * (decimal)Math.Pow(10, exponent.Value);
                minorValue = (int)value;
                return true;
            }

            return false;
        }

        public static Currency GetCurrency(Iso4217CurrencyCodes currencyCode)
        {
            return currenciesByIso4217Codes[currencyCode];
        }

        private static readonly Dictionary<Iso4217CurrencyCodes, Currency> currenciesByIso4217Codes = new Dictionary<Iso4217CurrencyCodes, Currency>()
        {
            { Iso4217CurrencyCodes.Undefined, new Currency(string.Empty, string.Empty, string.Empty, null) },
            { Iso4217CurrencyCodes.AED, new Currency("UAE Dirham", "784", "UNITED ARAB EMIRATES", 2) },
            { Iso4217CurrencyCodes.AFN, new Currency("Afghani", "971", "AFGHANISTAN", 2) },
            { Iso4217CurrencyCodes.ALL, new Currency("Lek", "008", "AL BANIA", 2) },
            { Iso4217CurrencyCodes.AMD, new Currency("Armenian Dram", "051", "ARMENIA", 2) },
            { Iso4217CurrencyCodes.ANG, new Currency("Netherlands Antillean Guilder", "532", "SINT MAARTEN (DUTCH PART)", 2) },
            { Iso4217CurrencyCodes.AOA, new Currency("Kwanza", "973", "ANGOLA", 2) },
            { Iso4217CurrencyCodes.ARS, new Currency("Argentine Peso", "032", "ARGENTINA", 2) },
            { Iso4217CurrencyCodes.AUD, new Currency("Australian Dollar ", "036", "TUVALU", 2) },
            { Iso4217CurrencyCodes.AWG, new Currency("Aruban Florin", "533", "ARUBA", 2) },
            { Iso4217CurrencyCodes.AZN, new Currency("Azerbaijanian Manat", "944", "AZERBAIJAN", 2) },
            { Iso4217CurrencyCodes.BAM, new Currency("Convertible Mark", "977", "BOSNIA AND HERZEGOVINA", 2) },
            { Iso4217CurrencyCodes.BBD, new Currency("Barbados Dollar", "052", "BARBADOS", 2) },
            { Iso4217CurrencyCodes.BDT, new Currency("Taka", "050", "BANGLADESH", 2) },
            { Iso4217CurrencyCodes.BGN, new Currency("Bulgarian Lev", "975", "BULGARIA ", 2) },
            { Iso4217CurrencyCodes.BHD, new Currency("Bahraini Dinar", "048", "BAHRAIN", 3) },
            { Iso4217CurrencyCodes.BIF, new Currency("Burundi Franc", "108", "BURUNDI", 0) },
            { Iso4217CurrencyCodes.BMD, new Currency("Bermudian Dollar", "060", "BERMUDA", 2) },
            { Iso4217CurrencyCodes.BND, new Currency("Brunei Dollar", "096", "BRU NEI DARUSSALAM", 2) },
            { Iso4217CurrencyCodes.BOB, new Currency("Boliviano", "068", "BOLIVIA, PLURINAT IONAL STATE OF", 2) },
            { Iso4217CurrencyCodes.BOV, new Currency("Mvdol", "984", "BOLIVIA, PLURINATIONA L STATE OF", 2) },
            { Iso4217CurrencyCodes.BRL, new Currency("Brazilian Real", "986", "BRAZIL", 2) },
            { Iso4217CurrencyCodes.BSD, new Currency("Bahamian Dollar", "044", "BAHAMAS", 2) },
            { Iso4217CurrencyCodes.BTN, new Currency("Ngultrum", "064", "BHUTAN", 2) },
            { Iso4217CurrencyCodes.BWP, new Currency("Pula", "072", "BOTSWANA", 2) },
            { Iso4217CurrencyCodes.BYR, new Currency("Belarussian Ruble", "974", "BELARUS", 0) },
            { Iso4217CurrencyCodes.BZD, new Currency("Belize Dollar", "084", "BELIZE", 2) },
            { Iso4217CurrencyCodes.CAD, new Currency("Canadian Dollar", "124", "CANADA", 2) },
            { Iso4217CurrencyCodes.CDF, new Currency("Congolese Franc", "976", "CON GO, DEMOCRATIC REPUBLIC OF THE ", 2) },
            { Iso4217CurrencyCodes.CHE, new Currency("WIR Euro", "947", "S WITZERLAND", 2) },
            { Iso4217CurrencyCodes.CHF, new Currency("Swiss Franc", "756", "SWITZERLAND", 2) },
            { Iso4217CurrencyCodes.CHW, new Currency("WIR Franc", "948", "SWITZERLAND", 2) },
            { Iso4217CurrencyCodes.CLF, new Currency("Unidad de Fomento", "990", "CHILE", 4) },
            { Iso4217CurrencyCodes.CLP, new Currency("Chilean Peso", "152", "CHILE", 0) },
            { Iso4217CurrencyCodes.CNY, new Currency("Yuan Renminbi", "156", "CHINA", 2) },
            { Iso4217CurrencyCodes.COP, new Currency("Colombian Peso", "170", "COLOMBIA", 2) },
            { Iso4217CurrencyCodes.COU, new Currency("Unidad de Valor Real", "970", "COLOMBIA", 2) },
            { Iso4217CurrencyCodes.CRC, new Currency("Costa Rican Colon", "188", "COSTA RICA", 2) },
            { Iso4217CurrencyCodes.CUC, new Currency("Peso Convertible", "931", "CUBA", 2) },
            { Iso4217CurrencyCodes.CUP, new Currency("Cuban Peso", "192", "CUBA", 2) },
            { Iso4217CurrencyCodes.CVE, new Currency("Cabo Verde Escudo", "132", "CABO VERDE", 2) },
            { Iso4217CurrencyCodes.CZK, new Currency("Czec h Koruna", "203", "CZECH REPUBLIC", 2) },
            { Iso4217CurrencyCodes.DJF, new Currency("Djibouti Franc", "262", "DJIBOUTI", 0) },
            { Iso4217CurrencyCodes.DKK, new Currency("Danish Krone", "208", "GREENLAND", 2) },
            { Iso4217CurrencyCodes.DOP, new Currency("Dominican Peso", "214", "DOMINICAN REPUBLIC", 2) },
            { Iso4217CurrencyCodes.DZD, new Currency("Algerian Dinar", "012", "ALGERIA", 2) },
            { Iso4217CurrencyCodes.EGP, new Currency("Eg yptian Pound", "818", "EGYPT", 2) },
            { Iso4217CurrencyCodes.ERN, new Currency("Nakfa", "232", "ERITREA ", 2) },
            { Iso4217CurrencyCodes.ETB, new Currency("Ethiopian Birr", "230", "ETHIOPIA", 2) },
            { Iso4217CurrencyCodes.EUR, new Currency("Euro", "978", "SPAIN", 2) },
            { Iso4217CurrencyCodes.FJD, new Currency("Fiji Dollar", "242", "FIJI", 2) },
            { Iso4217CurrencyCodes.FKP, new Currency("Falkland Islands Pound", "238", "FALKLAND ISL ANDS (MALVINAS)", 2) },
            { Iso4217CurrencyCodes.GBP, new Currency("Pound Sterling", "826", "UNITED KING DOM", 2) },
            { Iso4217CurrencyCodes.GEL, new Currency("Lari", "981", "GEORGIA", 2) },
            { Iso4217CurrencyCodes.GHS, new Currency("Ghana Cedi", "936", "GHANA", 2) },
            { Iso4217CurrencyCodes.GIP, new Currency("Gibraltar Pound", "292", "GIBRALTAR", 2) },
            { Iso4217CurrencyCodes.GMD, new Currency("Dalasi", "270", "GAMBIA", 2) },
            { Iso4217CurrencyCodes.GNF, new Currency("Guinea Franc", "324", "GUINEA", 0) },
            { Iso4217CurrencyCodes.GTQ, new Currency("Quetzal", "320", "GUATEMALA", 2) },
            { Iso4217CurrencyCodes.GYD, new Currency("Guyana Dollar", "328", "GUYANA", 2) },
            { Iso4217CurrencyCodes.HKD, new Currency("Hong Kong Dollar", "344", "HONG KONG", 2) },
            { Iso4217CurrencyCodes.HNL, new Currency("Lempira", "340", "HONDURAS", 2) },
            { Iso4217CurrencyCodes.HRK, new Currency("Croatian Kuna ", "191", "CROATIA", 2) },
            { Iso4217CurrencyCodes.HTG, new Currency("Gourde", "332", "HAITI", 2) },
            { Iso4217CurrencyCodes.HUF, new Currency("Forint", "348", "HUNGARY", 2) },
            { Iso4217CurrencyCodes.IDR, new Currency("Rupiah", "360", "INDONESIA", 2) },
            { Iso4217CurrencyCodes.ILS, new Currency("New Israeli Sheqel", "376", "ISRAE L", 2) },
            { Iso4217CurrencyCodes.INR, new Currency("Indian Rupee", "356", "INDIA", 2) },
            { Iso4217CurrencyCodes.IQD, new Currency("Iraqi Dinar", "368", "IRAQ", 3) },
            { Iso4217CurrencyCodes.IRR, new Currency("Iranian Rial", "364", "IRAN, ISLAMIC REPUBLIC OF", 2) },
            { Iso4217CurrencyCodes.ISK, new Currency("Iceland Krona", "352", "ICELAND", 0) },
            { Iso4217CurrencyCodes.JMD, new Currency("Jamaican Dollar", "388", "JAMAICA", 2) },
            { Iso4217CurrencyCodes.JOD, new Currency("Jordanian Dinar", "400", "JORDAN", 3) },
            { Iso4217CurrencyCodes.JPY, new Currency("Yen", "392", "JAPAN", 0) },
            { Iso4217CurrencyCodes.KES, new Currency("Kenyan Shilling", "404", "KENYA", 2) },
            { Iso4217CurrencyCodes.KGS, new Currency("Som", "417", "KYRGYZSTAN", 2) },
            { Iso4217CurrencyCodes.KHR, new Currency("Riel", "116", "CAMBODIA", 2) },
            { Iso4217CurrencyCodes.KMF, new Currency("Comoro Franc", "174", "CO MOROS", 0) },
            { Iso4217CurrencyCodes.KPW, new Currency("North Korean Won", "408", "KOREA, DEMOCRATIC PEOPLE'S REPUBLIC OF", 2) },
            { Iso4217CurrencyCodes.KRW, new Currency("Won", "410", "KOREA, REPUBLIC OF", 0) },
            { Iso4217CurrencyCodes.KWD, new Currency("Kuwaiti Dinar", "414", "KUWAIT", 3) },
            { Iso4217CurrencyCodes.KYD, new Currency("Cayman Islands Dollar", "136", "CAYMAN ISLANDS", 2) },
            { Iso4217CurrencyCodes.KZT, new Currency("Tenge", "398", "KAZAKHSTAN", 2) },
            { Iso4217CurrencyCodes.LAK, new Currency("Kip", "418", "LAO PEOPLE'S DEMOCRATIC REPUBLIC", 2) },
            { Iso4217CurrencyCodes.LBP, new Currency("Lebanese Pound", "422", "LEBANON", 2) },
            { Iso4217CurrencyCodes.LKR, new Currency("Sri Lanka Rupee", "144", "SRI LANKA", 2) },
            { Iso4217CurrencyCodes.LRD, new Currency("Liberian Dollar", "430", "LIBERIA", 2) },
            { Iso4217CurrencyCodes.LSL, new Currency("Loti", "426", "LESOTHO", 2) },
            { Iso4217CurrencyCodes.LTL, new Currency("Lithuanian Litas", "440", "LITHUANIA", 2) },
            { Iso4217CurrencyCodes.LYD, new Currency("Libyan Dinar", "434", "LIBYA", 3) },
            { Iso4217CurrencyCodes.MAD, new Currency("Moroccan Dirham", "504", "WESTERN SAHARA", 2) },
            { Iso4217CurrencyCodes.MDL, new Currency("Moldovan Leu", "498", "MOLDOVA, REPUBLIC OF", 2) },
            { Iso4217CurrencyCodes.MGA, new Currency("Malaga sy Ariary", "969", "MADAGASCAR", 2) },
            { Iso4217CurrencyCodes.MKD, new Currency("Denar", "807", "MACED ONIA, THE FORMER YUGOSLAV REPUBLIC OF", 2) },
            { Iso4217CurrencyCodes.MMK, new Currency("Kyat", "104", "MYANMAR", 2) },
            { Iso4217CurrencyCodes.MNT, new Currency("Tugrik", "496", "MONGOLIA", 2) },
            { Iso4217CurrencyCodes.MOP, new Currency("Pataca", "446", "MACAO", 2) },
            { Iso4217CurrencyCodes.MRO, new Currency("Ouguiya", "478", "MAURITANIA", 2) },
            { Iso4217CurrencyCodes.MUR, new Currency("Mauritius Rupee", "480", "MAURITIUS", 2) },
            { Iso4217CurrencyCodes.MVR, new Currency("Rufiyaa", "462", "MALDIVES", 2) },
            { Iso4217CurrencyCodes.MWK, new Currency("Kw acha", "454", "MALAWI", 2) },
            { Iso4217CurrencyCodes.MXN, new Currency("Mexican Peso", "484", "MEXICO", 2) },
            { Iso4217CurrencyCodes.MXV, new Currency("Mexican Unidad de Inversion (UDI)", "979", "MEXICO", 2) },
            { Iso4217CurrencyCodes.MYR, new Currency("Malaysian Ringgit", "458", "MALAYSIA", 2) },
            { Iso4217CurrencyCodes.MZN, new Currency("Mozambique Metical", "943", "MOZAMBIQUE", 2) },
            { Iso4217CurrencyCodes.NAD, new Currency("Namibia Dollar", "516", "NAMIBIA", 2) },
            { Iso4217CurrencyCodes.NGN, new Currency("Naira", "566", "NIGERIA", 2) },
            { Iso4217CurrencyCodes.NIO, new Currency("Cordoba Oro", "558", "NICARAGUA", 2) },
            { Iso4217CurrencyCodes.NOK, new Currency("Norwegian Krone", "578", "SVALBARD AND JAN MAYEN", 2) },
            { Iso4217CurrencyCodes.NPR, new Currency("Nepalese Rupee", "524", "NEPAL", 2) },
            { Iso4217CurrencyCodes.NZD, new Currency("New Zealand Dollar", "554", "TOKELAU", 2) },
            { Iso4217CurrencyCodes.OMR, new Currency("Rial Omani", "512", "OMAN", 3) },
            { Iso4217CurrencyCodes.PAB, new Currency("Balboa", "590", "PANAMA", 2) },
            { Iso4217CurrencyCodes.PEN, new Currency("Nuevo Sol", "604", "PERU", 2) },
            { Iso4217CurrencyCodes.PGK, new Currency("Kina", "598", "PAPUA NEW GUINEA", 2) },
            { Iso4217CurrencyCodes.PHP, new Currency("Philippine Peso", "608", "PHILIPPINES", 2) },
            { Iso4217CurrencyCodes.PKR, new Currency("Pakistan Rupee", "586", "PAKISTAN", 2) },
            { Iso4217CurrencyCodes.PLN, new Currency("Zloty", "985", "POLAND", 2) },
            { Iso4217CurrencyCodes.PYG, new Currency("Guarani", "600", "PARAGUAY", 0) },
            { Iso4217CurrencyCodes.QAR, new Currency("Qatari Rial", "634", "QATAR", 2) },
            { Iso4217CurrencyCodes.RON, new Currency("New Romanian Leu", "946", "ROMANIA", 2) },
            { Iso4217CurrencyCodes.RSD, new Currency("Serbian Dinar", "941", "SERBIA", 2) },
            { Iso4217CurrencyCodes.RUB, new Currency("Russian Ruble", "643", "RUSSIAN FED ERATION", 2) },
            { Iso4217CurrencyCodes.RWF, new Currency("Rwanda Franc", "646", "RWANDA", 0) },
            { Iso4217CurrencyCodes.SAR, new Currency("Saudi Riyal", "682", "SAUDI ARABIA", 2) },
            { Iso4217CurrencyCodes.SBD, new Currency("Sol omon Islands Dollar", "090", "SOLOMON ISLANDS", 2) },
            { Iso4217CurrencyCodes.SCR, new Currency("Seyche lles Rupee", "690", "SEYCHELLES", 2) },
            { Iso4217CurrencyCodes.SDG, new Currency("Sudanese Pound", "938", "SUDAN", 2) },
            { Iso4217CurrencyCodes.SEK, new Currency("Swedish Krona", "752", "SWEDEN", 2) },
            { Iso4217CurrencyCodes.SGD, new Currency("Singapore Dollar", "702", "SINGAPORE", 2) },
            { Iso4217CurrencyCodes.SHP, new Currency("Saint Helena Pound", "654", "SAINT HELENA, ASCENSION AND TRISTAN DA CUNHA", 2) },
            { Iso4217CurrencyCodes.SLL, new Currency("Leone", "694", "SIERRA LEONE", 2) },
            { Iso4217CurrencyCodes.SOS, new Currency("Somali Shilling", "706", "SOMALIA", 2) },
            { Iso4217CurrencyCodes.SRD, new Currency("Surinam Dollar", "968", "SURINAME", 2) },
            { Iso4217CurrencyCodes.SSP, new Currency("South Sudanese Pound", "728", "SOUTH SUDAN", 2) },
            { Iso4217CurrencyCodes.STD, new Currency("Dobra", "678", "SAO TOME AND PRINCIPE", 2) },
            { Iso4217CurrencyCodes.SVC, new Currency("El Salvador Colon", "222", "EL SALVADOR", 2) },
            { Iso4217CurrencyCodes.SYP, new Currency("Syrian Pound", "760", "SYRIAN ARAB REPUBLIC", 2) },
            { Iso4217CurrencyCodes.SZL, new Currency("Lilangeni", "748", "SWAZILAND", 2) },
            { Iso4217CurrencyCodes.THB, new Currency("Baht", "764", "THAI LAND", 2) },
            { Iso4217CurrencyCodes.TJS, new Currency("Somoni", "972", "TAJIKISTAN", 2) },
            { Iso4217CurrencyCodes.TMT, new Currency("Turkmenistan New Manat", "934", "TURKMENISTAN", 2) },
            { Iso4217CurrencyCodes.TND, new Currency("Tunisian Dinar", "788", "TUNISIA", 3) },
            { Iso4217CurrencyCodes.TOP, new Currency("Pa'anga", "776", "TONGA", 2) },
            { Iso4217CurrencyCodes.TRY, new Currency("Turkish Lira", "949", "TURKEY", 2) },
            { Iso4217CurrencyCodes.TTD, new Currency("Trinidad and Tobago Dollar", "780", "TRINIDAD AND TOBAGO", 2) },
            { Iso4217CurrencyCodes.TWD, new Currency("New Taiwan Dollar", "901", "TAIWAN, PROVINCE OF CHINA", 2) },
            { Iso4217CurrencyCodes.TZS, new Currency("Tanzanian Shilling", "834", "TANZANIA, UNITED REPUBLIC OF", 2) },
            { Iso4217CurrencyCodes.UAH, new Currency("Hryvnia", "980", "UKRAINE", 2) },
            { Iso4217CurrencyCodes.UGX, new Currency("Uganda Shilling", "800", "UGANDA", 0) },
            { Iso4217CurrencyCodes.USD, new Currency("US Dollar", "840", "VIRGIN ISLANDS (U.S.)", 2) },
            { Iso4217CurrencyCodes.USN, new Currency("US Dollar (Next day)", "997", "UNITED STATES", 2) },
            { Iso4217CurrencyCodes.UYI, new Currency("Uruguay Peso en Unidades Indexadas (URUIURUI)", "940", "URUGUAY", 0) },
            { Iso4217CurrencyCodes.UYU, new Currency("Peso Uruguayo", "858", "URUGUAY", 2) },
            { Iso4217CurrencyCodes.UZS, new Currency("Uzbekistan Sum", "860", "UZBEKISTAN", 2) },
            { Iso4217CurrencyCodes.VEF, new Currency("Bolivar", "937", "VENEZUELA, BOLIVARIAN REPUBLIC OF", 2) },
            { Iso4217CurrencyCodes.VND, new Currency("Dong", "704", "VIETNAM", 0) },
            { Iso4217CurrencyCodes.VUV, new Currency("Vatu", "548", "VANUATU", 0) },
            { Iso4217CurrencyCodes.WST, new Currency("Tala", "882", "SAMOA", 2) },
            { Iso4217CurrencyCodes.XAF, new Currency("CFA Franc BEAC", "950", "GABON", 0) },
            { Iso4217CurrencyCodes.XAG, new Currency("Silver", "961", "ZZ11_Silver", null) },
            { Iso4217CurrencyCodes.XAU, new Currency("Gold", "959", "ZZ08_Gold", null) },
            { Iso4217CurrencyCodes.XBA, new Currency("Bond Markets Unit European Composite Unit (EURCO)", "955", "ZZ01_Bond Markets Unit European_EURCO", null) },
            { Iso4217CurrencyCodes.XBB, new Currency("Bon d Markets Unit European Monetary Unit (E.M.U.-6)", "956", "ZZ02_Bond Markets Unit European_EMU-6", null) },
            { Iso4217CurrencyCodes.XBC, new Currency("Bond Markets Unit European Unit of Account 9 (E.U.A.-9)", "957", "ZZ03_Bond Markets Unit European_EUA-9", null) },
            { Iso4217CurrencyCodes.XBD, new Currency("Bond Markets Unit European Unit of Account 17 (E.U.A.-17)", "958", "ZZ04_Bond Markets Unit European_EUA-17", null) },
            { Iso4217CurrencyCodes.XCD, new Currency("East Caribbean Dollar", "951", "SAINT VINCENT AND THE GRENADINES", 2) },
            { Iso4217CurrencyCodes.XDR, new Currency("SDR (Special Drawing Right)", "960", "INTERNATIONAL MONETARY FUND (IMF)", null) },
            { Iso4217CurrencyCodes.XOF, new Currency("CFA Franc BCEAO", "952", "TOGO", 0) },
            { Iso4217CurrencyCodes.XPD, new Currency("Palladium", "964", "ZZ09_Palladium", null) },
            { Iso4217CurrencyCodes.XPF, new Currency("CFP Franc", "953", "WALLIS AND FUTUNA", 0) },
            { Iso4217CurrencyCodes.XPT, new Currency("Platinum", "962", "ZZ10_Platinum", null) },
            { Iso4217CurrencyCodes.XSU, new Currency("Sucre", "994", "SISTEMA UNI TARIO DE COMPENSACION REGIONAL DE PAGOS \"SUCRE\"", null) },
            { Iso4217CurrencyCodes.XTS, new Currency("C odes specifically reserved for testing purposes", "963", "ZZ06_Testing_Code", null) },
            { Iso4217CurrencyCodes.XUA, new Currency("ADB Unit of Account", "965", "MEMBER COUNTRIES OF THE AFRICAN DEVELOPMENT BANK GROUP", null) },
            { Iso4217CurrencyCodes.XXX, new Currency("The codes assigned for transactions where no currency is involved", "999", "ZZ07_No_Currency", null) },
            { Iso4217CurrencyCodes.YER, new Currency("Yemeni Rial", "886", "YEMEN", 2) },
            { Iso4217CurrencyCodes.ZAR, new Currency("Rand", "710", "SOUTH AFRICA", 2) },
            { Iso4217CurrencyCodes.ZMW, new Currency("Zambian Kwacha", "967", "ZAMBIA", 2) },
            { Iso4217CurrencyCodes.ZWL, new Currency("Zimbabwe Dollar", "932", "ZIMBABWE", 2) }
        };
    }
}
