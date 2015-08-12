namespace Genesis.Net.Errors
{
    public enum ErrorCodes
    {
        NoneError = 0,
        UndefinedError = 1,

        SystemError = 100,
        MaintenanceError = 101,
        AuthenticationError = 110,
        ConfigurationError = 120,

        CommunicationError = 200,
        ConnectionError = 210,
        AccountError = 220,
        TimeoutError = 230,
        ResponseError = 240,
        ParsingError = 250,

        InputDataError = 300,
        InvalidTransactionTypeError = 310,
        InputDataMissingError = 320,
        InputDataFormatError = 330,
        InputDataInvalidError = 340,
        InvalidXmlError = 350,
        InvalidContentTypeError = 360,

        WorkflowError = 400,
        ReferenceNotFoundError = 410,
        ReferenceWorkflowError = 420,
        ReferenceInvalidatedError = 430,
        ReferenceMismatchError = 440,
        DoubletTransactionError = 450,
        TransactionNotFoundError = 460,
        ChargebackNotFoundError = 470,
        RetrievalRequestNotFoundError = 480,

        ProcessingError = 500,
        InvalidCardError = 510,
        ExpiredCardError = 520,
        TransactionPendingError = 530,
        CreditExceededError = 540,

        RiskError = 600,
        BinCountryCheckError = 609,
        CardBlacklistError = 610,
        BinBlacklistError = 611,
        CountryBlacklistError = 612,
        IpBlacklistError = 613,
        BlacklistError = 614,
        CardWhitelistError = 615,
        CardLimitExceededError = 620,
        TerminalLimitExceededError = 621,
        ContractLimitExceededError = 622,
        CardVelocityExceededError = 623,
        CardTicketSizeExceededError = 624,
        UserLimitExceededError = 625,
        MultipleFailureDetectionError = 626,
        CSDetectionError = 627,
        RecurringLimitExceededError = 628,
        AvsError = 690,
        MaxMindRiskError = 691,
        ThreatMetrixRiskError = 692,

        RemoteError = 900,
        RemoteSystemError = 910,
        RemoteConfigurationError = 920,
        RemoteDataError = 930,
        RemoteWorkflowError = 940,
        RemoteTimeoutError = 950,
        RemoteConnectionError = 960
    }
}
