using System;
using System.Linq;
using System.Xml.Linq;
using Genesis.Net.Common;
using Genesis.Net.Entities.Responses.Error;
using System.IO;

namespace Genesis.Net.Entities.Responses
{
    internal static class ResultFactory
    {
        public static Result<S, E> Parse<S, E>(byte[] data)
            where S : Entity
            where E : Entity, IErrorResponse
        {
            using (var stream = new MemoryStream(data))
            {
                return Parse<S, E>(stream);
            }
        }

        public static Result<S, E> Parse<S, E>(Stream stream)
            where S : Entity
            where E : Entity, IErrorResponse
        {
            stream.Seek(0, SeekOrigin.Begin);
            var xml = XDocument.Load(stream);

            if (IsError(xml))
            {
                var error = Parse<E>(xml);
                return new Result<S, E>(error);
            }
            else
            {
                var success = Parse<S>(xml);
                return new Result<S, E>(success);
            }
        }

        private static bool IsError(XDocument xml)
        {
            var codeElement = xml.Root.Elements().FirstOrDefault(e => e.Name == "code");
            if (codeElement != null)
            {
                int value;
                if (Int32.TryParse(codeElement.Value, out value))
                {
                    return value > 0;
                }
                throw new InvalidDataException(String.Format("The element code has an invalid format. Its value ({0}) must be integer.", codeElement.Value));
            }
            return false;
        }

        public static T Parse<T>(XDocument xml) where T : Entity
        {
            var xDocument = new XDocument(xml);
            xDocument.SetNamespace(typeof(T).GetXmlNamespace());

            using (var reader = xDocument.CreateReader())
            {
                return XmlSerializationHelpers.Deserialize<T>(reader);
            }
        }
    }
}
