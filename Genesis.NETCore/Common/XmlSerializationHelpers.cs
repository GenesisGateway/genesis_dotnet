using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Genesis.NetCore.Entities;

namespace Genesis.NetCore.Common
{
    public static class XmlSerializationHelpers
    {
        private static XmlAttributeOverrides xmlAttributeOverrides;

        public static byte[] Serialize(IEntity entity, bool omitXmlDeclaration = false)
        {
            using (var textWriter = new StringWriterUtf8())
            {
                XmlWriterSettings settings = new XmlWriterSettings()
                {
                    Indent = false,
                    OmitXmlDeclaration = omitXmlDeclaration,
                    NewLineChars = string.Empty
                };

                using (var xmlWriter = new SortedNamespaceXmlWriter(XmlWriter.Create(textWriter, settings)))
                {
                    XmlSerializer serializer;
                    var entityType = entity.GetType();
                    serializer = GetSerializer(entityType);

                    var ns = new XmlSerializerNamespaces();
                    if (!entityType.HasXmlNamespace())
                    {
                        ns.Add(string.Empty, string.Empty);
                    }

                    serializer.Serialize(xmlWriter, entity, ns);
                }

                var documentString = textWriter.ToString();
                return Encoding.UTF8.GetBytes(documentString);
            }
        }

        public static T Deserialize<T>(byte[] data) where T : IEntity
        {
            using (var stream = new MemoryStream(data))
            {
                return Deserialize<T>(XmlReader.Create(stream));
            }
        }

        public static T Deserialize<T>(XmlReader reader) where T : IEntity
        {
            var xs = GetSerializer(typeof(T));

            var entity = (T)xs.Deserialize(reader);
            return entity;
        }

        private static XmlSerializer GetSerializer(Type type)
        {
            if (xmlAttributeOverrides == null)
            {
                InitializeXmlAttributeOverrides();
            }

            return new XmlSerializer(type, xmlAttributeOverrides);
        }

        private static void InitializeXmlAttributeOverrides()
        {
            xmlAttributeOverrides = new XmlAttributeOverrides();
            // Adding xml attributes to the Response classes properties from the interfaces.

            var assemblyName = typeof(XmlSerializationHelpers).Assembly.GetName();
            var nameSpaceError = assemblyName.Name + ".Entities.Responses.Error";
            var nameSpaceSuccessful = assemblyName.Name + ".Entities.Responses.Successful";

            var assembly = Assembly.Load(assemblyName);
            var classes = assembly.GetTypes().Where(t =>
                t.IsInterface == false &&
                (t.Namespace == nameSpaceError || t.Namespace == nameSpaceSuccessful) &&
                t.GetInterfaces().Any(i => i.IsInterface)
            ).ToList();
            classes.Add(typeof(Entities.Responses.PaymentResponse));

            foreach (var type in classes)
            {
                foreach (var propertyInfo in type.GetProperties(BindingFlags.Instance | BindingFlags.FlattenHierarchy | BindingFlags.Public))
                {
                    // skip - if we have Xml attribute
                    if (propertyInfo.GetCustomAttributes().Any(attribute => attribute.GetType().Name.StartsWith("Xml")))
                    {
                        continue;
                    }

                    // search it in the interface and create override for it.
                    foreach (var typeIntreface in type.GetInterfaces())
                    {
                        var interfacePropertyFound = typeIntreface.GetProperty(propertyInfo.Name);
                        if (interfacePropertyFound != null)
                        {
                            var interfaceXmlElementAttributes = interfacePropertyFound.GetCustomAttributes<XmlElementAttribute>();
                            var interfaceXmlAttributeAttributes = interfacePropertyFound.GetCustomAttributes<XmlAttributeAttribute>();
                            var newAttributes = new XmlAttributes();

                            foreach (var interfaceXmlElementAttribute in interfaceXmlElementAttributes)
                            {
                                newAttributes.XmlElements.Add(new XmlElementAttribute(interfaceXmlElementAttribute.ElementName));
                            }
                            foreach (var interfaceXmlAttributeAttribute in interfaceXmlAttributeAttributes)
                            {
                                newAttributes.XmlAttribute = new XmlAttributeAttribute(interfaceXmlAttributeAttribute.AttributeName);
                            }

                            if (newAttributes.XmlElements.Count > 0 || newAttributes.XmlAttribute != null)
                            {
                                xmlAttributeOverrides.Add(type, propertyInfo.Name, newAttributes);
                            }

                            break;
                        }
                    }
                }
            }
        }
    }
}
