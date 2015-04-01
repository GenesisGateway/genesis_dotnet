using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Genesis.Net.Entities;

namespace Genesis.Net.Common
{
    public static class XmlSerializationHelpers
    {
        public static byte[] Serialize(Entity entity)
        {
            using (var textWriter = new StringWriterUtf8())
            {
                XmlWriterSettings settings = new XmlWriterSettings()
                {
                    Indent = false,
                    OmitXmlDeclaration = false,
                    NewLineChars = string.Empty
                };

                using (var xmlWriter = XmlWriter.Create(textWriter, settings))
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

        public static T Deserialize<T>(byte[] data) where T : Entity
        {
            using (var stream = new MemoryStream(data))
            {
                return Deserialize<T>(XmlReader.Create(stream));
            }
        }

        public static T Deserialize<T>(XmlReader reader) where T : Entity
        {
            var xs = GetSerializer(typeof(T));

            var entity = (T)xs.Deserialize(reader);
            return entity;
        }

        private static XmlSerializer GetSerializer(Type type)
        {
#if GenerateXmlSerializers
            return new XmlSerializer(type);
#else
            var serializerContract = new Microsoft.Xml.Serialization.GeneratedAssembly.XmlSerializerContract();
            return serializerContract.GetSerializer(type);
#endif
        }
    }
}
