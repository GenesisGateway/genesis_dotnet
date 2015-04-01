using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses
{
    internal class TransactionTypeModel
    {
        [XmlIgnore]
        public TransactionTypes TransactionType { get; set; }

        [XmlElement(ElementName = "transaction_type")]
        public string ProxyTransactionType
        {
            get
            {
                if (TransactionType != null)
                {
                    return TransactionType.ToString();
                }
                return string.Empty;
            }
            set
            {
                TransactionType = TransactionTypes.TransactionTypesByName.Value[value];
            }
        }
    }
}