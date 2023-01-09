using System.Xml.Serialization;
using Genesis.NetCore.Entities.Attributes.Request.Financial.Cards.ThreedsV2.Enums;

namespace Genesis.NetCore.Entities.Attributes.Request.Financial.Cards.ThreedsV2
{
    /// <summary>
    /// Purchase related params providing with additional information regarding the order.
    /// </summary>
    [XmlRoot(ElementName = "purchase")]
    public partial class Purchase : IEntity
    {
        /// <summary>
        /// Identifies the type of transaction being authenticated. This field is required in some markets. Accepted values are: goods, service, check_acceptance, account_funding, quasi_cash, prepaid_activation, loan.
        /// </summary>
        [XmlElement(ElementName = "category")]
        public PurchaseCategories Category { get; set; }
    }
}
