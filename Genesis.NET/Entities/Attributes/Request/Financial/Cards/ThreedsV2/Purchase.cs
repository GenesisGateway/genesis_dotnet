using Genesis.Net.Entities.Attributes.Request.Financial.Cards.ThreedsV2.Enums;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Attributes.Request.Financial.Cards.ThreedsV2
{
    /// <summary>
    /// Purchase related params providing with additional information regarding the order.
    /// </summary>
    [XmlRoot(ElementName = "purchase")]
    public partial class Purchase : Entity
    {
        /// <summary>
        /// Identifies the type of transaction being authenticated. This field is required in some markets. Accepted values are: goods, service, check_acceptance, account_funding, quasi_cash, prepaid_activation, loan.
        /// </summary>
        [XmlElement(ElementName = "category")]
        public PurchaseCategories Category { get; set; }
    }
}
