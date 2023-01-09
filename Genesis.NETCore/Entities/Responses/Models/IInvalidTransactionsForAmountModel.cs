using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    public interface IInvalidTransactionsForAmountModel
    {
        [XmlElement("invalid_transactions_for_amount")]
        string InvalidTransactionsForAmount { get; set; }
    }
}
