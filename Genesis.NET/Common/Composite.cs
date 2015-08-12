using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Genesis.Net.Common
{
    public class Composite : Dictionary<String, String>, IXmlSerializable
    {
        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            bool wasEmpty = reader.IsEmptyElement;
            reader.Read();

            if (wasEmpty)
                return;

            while (reader.NodeType != XmlNodeType.EndElement)
            {
                reader.ReadStartElement();

                var value = ReadValue(reader);
                this.Add(reader.Name, value);

                reader.ReadEndElement();
                reader.MoveToContent();
            }
            reader.ReadEndElement();
        }

        private String ReadValue(XmlReader reader)
        {
            if (reader.NodeType == XmlNodeType.Text)
            {
                return reader.ReadContentAsString();
            }
            else
            {
                throw new NotSupportedException("Only String value types are supported");
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            foreach (String key in this.Keys)
            {
                writer.WriteElementString(key, this[key]);
            }
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Composite);
        }

        private bool Equals(Composite other)
        {
            if (other == null || this.Count != other.Count)
            {
                return false;
            }

            foreach(string key in this.Keys)
            {
                String value, otherValue;
                if (this.TryGetValue(key, out value) && other.TryGetValue(key, out otherValue))
                {
                    if (!String.Equals(value, otherValue))
                        return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int prime = 17;
                int hashCode = 0;
                foreach(string key in this.Keys.OrderBy(k => k))
                {
                    hashCode = hashCode * prime + key.GetHashCode();

                    var value = this[key];
                    if (value != null)
                    {
                        hashCode = hashCode * prime + value.GetHashCode();
                    }
                }
                return hashCode;
            }
        }
    }
}
