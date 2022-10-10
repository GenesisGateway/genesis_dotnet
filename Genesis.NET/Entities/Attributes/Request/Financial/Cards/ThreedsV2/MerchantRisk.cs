using Genesis.Net.Common;
using Genesis.Net.Entities.Attributes.Request.Financial.Cards.ThreedsV2.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Attributes.Request.Financial.Cards.ThreedsV2
{
    /// <summary>
    /// Merchant risk assessment params. They are all optional, but recommended.
    /// </summary>
    [XmlRoot(ElementName = "merchant_risk")]
    public partial class MerchantRisk : Entity
    {
        /// <summary>
        /// Indicator code that most accurately describes the shipping method for the cardholder specific transaction. If one or more items are included in the sale, use the Shipping Indicator code for the physical goods. If all digital goods, use the code that describes the most expensive item. Accepted values are: same_as_billing, stored_address, verified_address, pick_up, digital_goods, travel, event_tickets, other.
        /// </summary>
        [XmlElement(ElementName = "shipping_indicator")]
        public ShippingIndicators ShippingIndicator { get; set; }

        /// <summary>
        /// Indicates the merchandise delivery timeframe.
        /// </summary>
        [XmlElement(ElementName = "delivery_timeframe")]
        public DeliveryTimeframes DeliveryTimeframe { get; set; }

        /// <summary>
        /// Indicates whether the cardholder is reordering previously purchased merchandise.
        /// </summary>
        [XmlElement(ElementName = "reorder_items_indicator")]
        public ReorderItemsIndicators ReorderItemsIndicator { get; set; }

        /// <summary>
        /// Indicates whether cardholder is placing an order for merchandise with a future-availability or release date.
        /// </summary>
        [XmlElement(ElementName = "pre_order_purchase_indicator")]
        public PreOrderPurchaseIndicators PreOrderPurchaseIndicator { get; set; }

        /// <summary>
        /// Used for serialization. To set value use field <see cref="PreOrderDate"/>.
        /// </summary>
        [XmlElement(ElementName = "pre_order_date")]
        public string PreOrderDateMetadata
        {
            get
            {
                return PreOrderDate.Date.ToApiDate();
            }

            set
            {
                PreOrderDate = value.ParseApiDate().Date;
            }
        }

        /// <summary>
        /// For a pre-ordered purchase, the expected date that the merchandise will be available.
        /// </summary>
        [XmlIgnore]
        public DateTime PreOrderDate { get; set; }

        /// <summary>
        /// Prepaid or gift card purchase.
        /// </summary>
        [XmlElement(ElementName = "gift_card")]
        public bool GiftCard { get; set; }

        /// <summary>
        /// For prepaid or gift card purchase, total count of individual prepaid or gift cards/codes purchased. The value is limited to 99.
        /// </summary>
        [Range(0, 99)]
        [XmlElement(ElementName = "gift_card_count")]
        public int GiftCardCount { get; set; }
    }
}
