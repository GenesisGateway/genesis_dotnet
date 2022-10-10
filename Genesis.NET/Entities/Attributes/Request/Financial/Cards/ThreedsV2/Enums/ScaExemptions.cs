using System.Xml.Serialization;

namespace Genesis.Net.Entities.Attributes.Request.Financial.Cards.ThreedsV2.Enums
{
    /// <summary>
    /// Exemption for the Strong Customer Authentication.
    /// </summary>
    public enum ScaExemptions
    {
        ///<remarks />
        [XmlEnum("low_value")]
        LowValue,

        ///<remarks />
        [XmlEnum("low_risk")]
        LowRisk,

        /////<remarks />
        //[XmlEnum("trusted_merchant")]
        //TrustedMerchant,
        
        /////<remarks />
        //[XmlEnum("corporate_payment")]
        //CorporatePayment,
            
        /////<remarks />
        //[XmlEnum("delegated_authentication")]
        //DelegatedAuthentication,
    }
}
