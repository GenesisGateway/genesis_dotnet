using Genesis.NetCore.Entities;
using Genesis.NetCore.Entities.Attributes.Request.Financial.Recurring;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Genesis.NetCore.Common
{
    public class Composite : Dictionary<String, object>, IXmlSerializable
    {
        // Add here the Complex Type objects for Composite
        // Key - xml element Name
        // Value - the Type of the complex object
        private Dictionary<string, Type> complexObjects = new Dictionary<string, Type>()
        {
            { "managed_recurring", typeof(ManagedRecurring) }
        };

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
                if (complexObjects.ContainsKey(reader.Name))
                {
                    var key = reader.Name;
                    var outerXml = reader.ReadOuterXml().Replace(" xmlns=\"WpfCreate\"", String.Empty);

                    object result;
                    Type valueType;
                    complexObjects.TryGetValue(key, out valueType);
                                       
                    var ser = new XmlSerializer(valueType);
                    using (var read = new StringReader(outerXml))
                    {
                        result = (IEntity)ser.Deserialize(read);
                    }

                    this.Add(key, result);
                }
                else
                {
                    reader.ReadStartElement();
                    object value;
                    if (reader.NodeType == XmlNodeType.Text)
                    {
                        value = ReadValue(reader);
                    }
                    else
                    {
                        value = reader.ReadElementContentAsObject();
                    }

                    this.Add(reader.Name, value);
                }

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
                if (!(this[key] is string))
                {
                    var res = XmlSerializationHelpers.Serialize(this[key] as IEntity, true);
                    var str = System.Text.Encoding.UTF8.GetString(res).ToCharArray();
                    var count = str.Length;
                    writer.WriteRaw(str, 0, count);
                }
                else
                {
                    writer.WriteElementString(key, this[key].ToString().ToLower());
                }
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

            foreach (string key in this.Keys)
            {
                object value, otherValue;
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
                foreach (string key in this.Keys.OrderBy(k => k))
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
