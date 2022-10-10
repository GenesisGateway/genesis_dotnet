using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
using Genesis.Net.Entities;

namespace Genesis.Net.Common
{
    public static class Extensions
    {
        public static XDocument ToXDocument(this Entity entity)
        {
            var bytes = XmlSerializationHelpers.Serialize(entity);
            using (var stream = new MemoryStream(bytes))
            {
                return XDocument.Load(stream);
            }
        }

        public static string ToUrlName(this Environments environment)
        {
            switch (environment)
            {
                case Environments.Production:
                    return string.Empty;
                case Environments.Staging:
                    return "staging";
            }

            return string.Empty;
        }

        public static string ToApiPathName(this WpfLocales locale)
        {
            return locale.ToString().ToLowerInvariant();
        }

        public static string GuessParamaterNameByPropertyName(this string propertyName)
        {
            var sb = new StringBuilder(propertyName.Length);
            for (int i = 0; i < propertyName.Length; i++)
            {
                if (Char.IsUpper(propertyName[i]))
                {
                    if (i != 0)
                    {
                        sb.Append('_');
                    }

                    sb.Append(Char.ToLowerInvariant(propertyName[i]));
                }
                else
                {
                    sb.Append(Char.ToLowerInvariant(propertyName[i]));
                }
            }

            return sb.ToString();
        }

        public static string GuessPropertyNameByParameterName(this string apiParameterName)
        {
            var sb = new StringBuilder(apiParameterName.Length);
            for (int i = 0; i < apiParameterName.Length; i++)
            {
                if (apiParameterName[i] == '_')
                {
                    i++;
                    if (i < apiParameterName.Length) {
                        sb.Append(Char.ToUpper(apiParameterName[i]));
                    }
                }
                else
                {
                    sb.Append(apiParameterName[i]);
                }
            }

            return sb.ToString();
        }

        public static string ToApiDate(this DateTime input, string format = Formatter.DATE_FORMAT_DMY)
        {
            return Formatter.FormatToString(input, format);
        }

        public static DateTime ParseApiDate(this string input, string format = Formatter.DATE_FORMAT_DMY)
        {
            return Formatter.ParseDate(input, format);
        }

        internal static void SetNamespace(this XDocument xDocument, XNamespace xNamespace)
        {
            foreach (var element in xDocument.Descendants())
            {
                element.Name = xNamespace + element.Name.LocalName;
            }
        }

        internal static bool HasXmlNamespace(this Type type)
        {
            var xmlNamespace = type.GetXmlNamespace();
            return !string.IsNullOrEmpty(xmlNamespace);
        }

        internal static string GetXmlNamespace(this Type type)
        {
            var xmlRoot = type.GetCustomAttributes(false).FirstOrDefault(a => a is XmlRootAttribute) as XmlRootAttribute;
            if (xmlRoot != null)
            {
                return xmlRoot.Namespace;
            }

            return string.Empty;
        }

        public static object ParseEnumByTheNameInXMLEnumAttribute(this string inputValue, Type enumType)
        {
            if (string.IsNullOrEmpty(inputValue))
            {
                throw new NullReferenceException("Can't parse null or empty value.");
            }

            foreach (var enumValue in Enum.GetValues(enumType))
            {
                var enumMembers = enumType.GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
                foreach (var enumMember in enumMembers)
                {
                    var enumXmlName = Enumerable.Cast<XmlEnumAttribute>(enumMember.GetCustomAttributes((Type)typeof(XmlEnumAttribute), (bool)false)).First().Name;
                    if (enumXmlName == inputValue)
                    {
                        return Enum.ToObject(enumType, enumMember.GetValue(enumValue));
                    }
                }
            }

            throw new ArgumentException(string.Format("Can't find valid value in XMLEnum attributes name of {0} type.", enumType.Name));
        }
    }
}
