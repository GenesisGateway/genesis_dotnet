using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Genesis.NetCore.Common;
using Genesis.NetCore.Entities.Responses.Error;

namespace Genesis.NetCore.Entities.Responses
{
    public static class ResultFactory
    {
        public static Result<S, E> Parse<S, E>(byte[] data)
            where S : IEntity
            where E : IEntity, IErrorResponse
        {
            using (var stream = new MemoryStream(data))
            {
                return Parse<S, E>(stream);
            }
        }

        public static Result<S, E> Parse<S, E>(Stream stream)
            where S : IEntity
            where E : IEntity, IErrorResponse
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

        public static T Parse<T>(XDocument xml) where T : IEntity
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
