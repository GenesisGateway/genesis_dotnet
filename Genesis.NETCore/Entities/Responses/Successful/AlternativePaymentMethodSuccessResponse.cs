﻿using Genesis.NetCore.Entities.Enums;
using Genesis.NetCore.Entities.Responses.Models;

namespace Genesis.NetCore.Entities.Responses.Successful
{
    /// <remarks />
    public class AlternativePaymentMethodSuccessResponse :
        MoneyAndTransactionModel,
        IMoneyModel,
        ITransactionModel,
        IAsyncTransactionModel,
        IAcquirerModel,
        ITechnicalMessageModel,
        ITransactionStatusModel,
        ITransactionTypeModel
    {
        public string RedirectUrl { get; set; }
        public bool SentToAcquirer { get; set; }
        public string TechnicalMessage { get; set; }
        public string Message { get; set; }
        public TransactionStates? Status { get; set; }
        public TransactionTypes TransactionType { get; set; }
    }
}
