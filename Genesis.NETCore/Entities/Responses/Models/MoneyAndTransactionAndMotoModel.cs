using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    public abstract class MoneyAndTransactionAndMotoModel :
        MoneyAndTransactionModel,
        IMoneyModel,
        ITransactionModel,
        IMotoModel
    {
        [XmlElement(ElementName = "moto")]
        public bool? Moto { get; set; }

        public bool ShouldSerializeMoto()
        {
            return Moto != null;
        }
    }
}
