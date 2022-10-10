﻿using System.Xml.Serialization;
using Genesis.Net.Entities.Enums.ThreeDS;

namespace Genesis.Net.Entities.Responses
{
    /// <remarks />
    public class RedirectUrlsModel
    {
        /// <summary>
        /// URL where the consumer has to be redirected to complete the payment process unless a 3DSecure Method is required. This redirect_url will not be included in the response if a 3DS-Method submission is required.
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// The type of the redirect URL in the 3DS scope. It will be present only for asynchronous 3D transactions when an interaction between consumer and issuer is required.
        /// </summary>
        [XmlElement("redirect_url_type")]
        public RedirectUrlTypes RedirectUrlType { get; set; }
    }
}
