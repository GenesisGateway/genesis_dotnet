using System;
using System.IO;
using System.Linq;
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
            switch(environment)
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
                return xmlRoot.Namespace;

            return string.Empty;
        }
    }
}
