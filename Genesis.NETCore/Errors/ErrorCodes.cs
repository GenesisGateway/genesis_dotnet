using System.Xml.Serialization;

namespace Genesis.NetCore.Errors
{
    public enum ErrorCodes
    {
        [XmlEnum("0")]
        NoneError = 0,
        [XmlEnum("1")]
        UndefinedError = 1,

        [XmlEnum("100")]
        SystemError = 100,
        [XmlEnum("101")]
        MaintenanceError = 101,
        [XmlEnum("110")]
        AuthenticationError = 110,
        [XmlEnum("120")]
        ConfigurationError = 120,

        [XmlEnum("200")]
        CommunicationError = 200,
        [XmlEnum("210")]
        ConnectionError = 210,
        [XmlEnum("220")]
        AccountError = 220,
        [XmlEnum("230")]
        TimeoutError = 230,
        [XmlEnum("240")]
        ResponseError = 240,
        [XmlEnum("250")]
        ParsingError = 250,

        [XmlEnum("300")]
        InputDataError = 300,
        [XmlEnum("310")]
        InvalidTransactionTypeError = 310,
        [XmlEnum("320")]
        InputDataMissingError = 320,
        [XmlEnum("330")]
        InputDataFormatError = 330,
        [XmlEnum("340")]
        InputDataInvalidError = 340,
        [XmlEnum("350")]
        InvalidXmlError = 350,
        [XmlEnum("360")]
        InvalidContentTypeError = 360,

        [XmlEnum("400")]
        WorkflowError = 400,
        [XmlEnum("410")]
        ReferenceNotFoundError = 410,
        [XmlEnum("420")]
        ReferenceWorkflowError = 420,
        [XmlEnum("430")]
        ReferenceInvalidatedError = 430,
        [XmlEnum("440")]
        ReferenceMismatchError = 440,
        [XmlEnum("450")]
        DoubletTransactionError = 450,
        [XmlEnum("460")]
        TransactionNotFoundError = 460,
        [XmlEnum("470")]
        ChargebackNotFoundError = 470,
        [XmlEnum("480")]
        RetrievalRequestNotFoundError = 480,

        [XmlEnum("500")]
        ProcessingError = 500,
        [XmlEnum("510")]
        InvalidCardError = 510,
        [XmlEnum("520")]
        ExpiredCardError = 520,
        [XmlEnum("530")]
        TransactionPendingError = 530,
        [XmlEnum("540")]
        CreditExceededError = 540,

        [XmlEnum("600")]
        RiskError = 600,
        [XmlEnum("609")]
        BinCountryCheckError = 609,
        [XmlEnum("610")]
        CardBlacklistError = 610,
        [XmlEnum("611")]
        BinBlacklistError = 611,
        [XmlEnum("612")]
        CountryBlacklistError = 612,
        [XmlEnum("613")]
        IpBlacklistError = 613,
        [XmlEnum("614")]
        BlacklistError = 614,
        [XmlEnum("615")]
        CardWhitelistError = 615,
        [XmlEnum("620")]
        CardLimitExceededError = 620,
        [XmlEnum("621")]
        TerminalLimitExceededError = 621,
        [XmlEnum("622")]
        ContractLimitExceededError = 622,
        [XmlEnum("623")]
        CardVelocityExceededError = 623,
        [XmlEnum("624")]
        CardTicketSizeExceededError = 624,
        [XmlEnum("625")]
        UserLimitExceededError = 625,
        [XmlEnum("626")]
        MultipleFailureDetectionError = 626,
        [XmlEnum("627")]
        CSDetectionError = 627,
        [XmlEnum("628")]
        RecurringLimitExceededError = 628,
        [XmlEnum("690")]
        AvsError = 690,
        [XmlEnum("691")]
        MaxMindRiskError = 691,
        [XmlEnum("692")]
        ThreatMetrixRiskError = 692,

        /// <summary>
        /// Consumer with this consumer_id, email combination already exists!
        /// </summary>
        [XmlEnum("701")]
        ConsumerUniquenessError = 701,
        /// <summary>
        /// Consumer not found!
        /// </summary>
        [XmlEnum("702")]
        InvalidConsumerError = 702,
        /// <summary>
        /// Consumer is disabled!
        /// </summary>
        [XmlEnum("703")]
        DisabledConsumerError = 703,
        /// <summary>
        /// General tokenization error.
        /// </summary>
        [XmlEnum("700")]
        TokenizationError = 700,
        /// <summary>
        /// Tokenization is not enabled for the merchant or the terminal! Contact support.
        /// </summary>
        [XmlEnum("710")]
        TokenizationNotEnabledError = 710,
        /// <summary>
        /// Unsupported token type!
        /// </summary>
        [XmlEnum("720")]
        InvalidTokenTypeError = 720,
        /// <summary>
        /// Invalid token!
        /// </summary>
        [XmlEnum("730")]
        InvalidTokenError = 730,
        /// <summary>
        /// Detokenize action is forbidden!
        /// </summary>
        [XmlEnum("740")]
        DetokenizeForbiddenError = 740,
        /// <summary>
        /// Tokenize action is forbidden!
        /// </summary>
        [XmlEnum("741")]
        TokenizeForbiddenError = 741,
        /// <summary>
        /// Update token action is forbidden!
        /// </summary>
        [XmlEnum("742")]
        UpdateTokenForbiddenError = 742,
        /// <summary>
        /// Validate token action is forbidden!
        /// </summary>
        [XmlEnum("743")]
        ValidateTokenForbiddenError = 743,
        /// <summary>
        /// Delete token action is forbidden!
        /// </summary>
        [XmlEnum("744")]
        DeleteTokenForbiddenError = 744,

        /// <summary>
        ///  Client-side encryption error! 
        /// </summary>
        [XmlEnum("750")]
        ClientSideEncryptionError = 750,
        /// <summary>
        ///  Client-side Encryption is not enabled!
        /// </summary>
        [XmlEnum("751")]
        ClientSideEncryptionNotEnabledError = 751,

        /// <summary>
        /// General KYC Service Error
        /// </summary>
        [XmlEnum("800")]
        KycServiceError = 800,
        /// <summary>
        /// Uploaded document MIME type is not supported by KYC provider
        /// </summary>
        [XmlEnum("801")]
        DocumentMimeTypeUnsupportedError = 801,
        /// <summary>
        /// Passed attributes are invalid!
        /// </summary>
        [XmlEnum("802")]
        InvalidRequestAttributesError = 802,
        /// <summary>
        /// KYC Services not configured for Merchant!
        /// </summary>
        [XmlEnum("803")]
        KycServiceNotConfiguredError = 803,
        /// <summary>
        /// KYC Service provider Error!
        /// </summary>
        [XmlEnum("804")]
        KycServiceProviderError = 804,
        /// <summary>
        /// Notification already received
        /// </summary>
        [XmlEnum("805")]
        KycServiceNotificationError = 805,
        /// <summary>
        /// Merchant state does not allow using KYC Service API!
        /// </summary>
        [XmlEnum("806")]
        KycServiceUnacceptableMerchantStateError = 806,

        [XmlEnum("900")]
        RemoteError = 900,
        [XmlEnum("910")]
        RemoteSystemError = 910,
        [XmlEnum("920")]
        RemoteConfigurationError = 920,
        [XmlEnum("930")]
        RemoteDataError = 930,
        [XmlEnum("940")]
        RemoteWorkflowError = 940,
        [XmlEnum("950")]
        RemoteTimeoutError = 950,
        [XmlEnum("960")]
        RemoteConnectionError = 960
    }
}
