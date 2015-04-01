using System;
using System.Collections.Generic;
using System.Linq;

namespace ModelsDependenciesResolver
{
    public static class Responses
    {
        public static readonly List<Tuple<string, HashSet<string>>> Models = new List<Tuple<string, HashSet<string>>>()
        {
            //Success
            new Tuple<string, HashSet<string>>("AccountVerificationSuccessResponse", new HashSet<string>()
            {
                "authorization_code", "avs_response_code", "avs_response_text",
                "sent_to_acquirer", "moto", "response_code",
                "transaction_type",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            new Tuple<string, HashSet<string>>("Authorize3dSuccessResponse", new HashSet<string>()
            {
                "authorization_code", "redirect_url",
                "gaming", "moto", "dynamic_descriptor_params", "sent_to_acquirer",
                "response_code", 
                "amount", "currency", "partial_approval",
                "transaction_type",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            new Tuple<string, HashSet<string>>("AuthorizeSuccessResponse", new HashSet<string>()
            {
                "authorization_code", "code", "message", "technical_message",
                "gaming", "moto", "dynamic_descriptor_params", "sent_to_acquirer",
                "response_code", 
                "amount", "currency", "partial_approval",
                "transaction_type",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            new Tuple<string, HashSet<string>>("AvsSuccessResponse", new HashSet<string>()
            {
                "authorization_code", "avs_response_code", "avs_response_text",
                "sent_to_acquirer", "moto", "response_code",
                "transaction_type",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            new Tuple<string, HashSet<string>>("BlacklistSuccessResponse", new HashSet<string>()
            {
                "blacklisted"
            }),
            new Tuple<string, HashSet<string>>("CaptureSuccessResponse", new HashSet<string>()
            {
                "code", "message", "technical_message",
                "sent_to_acquirer",
                "amount", "currency", "partial_approval",
                "transaction_type",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            new Tuple<string, HashSet<string>>("CreditSuccessResponse", new HashSet<string>()
            {
                "authorization_code",
                "response_code",
                "amount", "currency", "partial_approval",
                "transaction_type",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            new Tuple<string, HashSet<string>>("InitRecurringSale3dSuccessResponse", new HashSet<string>()
            {
                "redirect_url",
                "authorization_code", "sent_to_acquirer", "moto", "dynamic_descriptor_params",
                "recurring_advice_code", "recurring_advice_text",
                "response_code",
                "amount", "currency", "partial_approval",
                "transaction_type",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            new Tuple<string, HashSet<string>>("InitRecurringSaleSuccessResponse", new HashSet<string>()
            {
                "authorization_code", "sent_to_acquirer", "moto", "dynamic_descriptor_params",
                "recurring_advice_code", "recurring_advice_text",
                "response_code",
                "amount", "currency", "partial_approval",
                "transaction_type",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            new Tuple<string, HashSet<string>>("MultiChargebackSuccessResponse", new HashSet<string>()
            {
                "chargeback_response",
                "per_page", "page", "total_count", "pages_count"
            }),
            new Tuple<string, HashSet<string>>("MultiReconcileSuccessResponse", new HashSet<string>()
            {
                "payment_response",
                "per_page", "page", "total_count", "pages_count"
            }),
            new Tuple<string, HashSet<string>>("MultiRetrievalRequestSuccessResponse", new HashSet<string>()
            {
                "retrieval_request_response",
                "per_page", "page", "total_count", "pages_count"
            }),
            new Tuple<string, HashSet<string>>("PayoutSuccessResponse", new HashSet<string>()
            {
                "authorization_code",
                "sent_to_acquirer",
                "response_code",
                "amount", "currency", "partial_approval",
                "transaction_type",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            new Tuple<string, HashSet<string>>("RecurringSaleSuccessResponse", new HashSet<string>()
            {
                "sent_to_acquirer", "authorization_code",
                "recurring_advice_code", "recurring_advice_text",
                "response_code",
                "amount", "currency", "partial_approval",
                "transaction_type",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            new Tuple<string, HashSet<string>>("RefundSuccessResponse", new HashSet<string>()
            {
                "authorization_code",
                "response_code",
                "amount", "currency", "partial_approval",
                "transaction_type",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            new Tuple<string, HashSet<string>>("Sale3dSuccessResponse", new HashSet<string>()
            {
                "authorization_code",
                "redirect_url",
                "gaming", "moto", "dynamic_descriptor_params", "sent_to_acquirer",
                "response_code",

                "amount", "currency", "partial_approval",
                "transaction_type",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            new Tuple<string, HashSet<string>>("SaleSuccessResponse", new HashSet<string>()
            {
                "authorization_code",
                "gaming", "moto", "dynamic_descriptor_params", "sent_to_acquirer",
                "response_code",
                "amount", "currency", "partial_approval",
                "transaction_type",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            new Tuple<string, HashSet<string>>("SingleChargebackSuccessResponse", new HashSet<string>()
            {
                "amount", "currency", "partial_approval",
                "type", "arn", "post_date", "reason_code", "reason_description", "authorization_code", "card_number", "card_brand", "customer_email", "customer_phone", "transaction_type", "original_transaction_unique_id"
            }),
            new Tuple<string, HashSet<string>>("SingleReconcileSuccessResponse", new HashSet<string>()
            {
                "sent_to_acquirer", "authorization_code", "billing_address", "shipping_address", "terminal_token", "customer_email", "customer_phone",
                "code", "technical_message", "message",
                "response_code",
                "amount", "currency", "partial_approval",
                "transaction_type",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            new Tuple<string, HashSet<string>>("SingleRetrievalRequestSuccessResponse", new HashSet<string>()
            {
                "type", "arn", "post_date", "reason_code", "reason_description", "authorization_code", "card_number", "card_brand", "customer_email", "customer_phone", "transaction_type", "original_transaction_unique_id"
            }),
            new Tuple<string, HashSet<string>>("VoidSuccessResponse", new HashSet<string>()
            {
                "authorization_code",
                "sent_to_acquirer",
                "response_code",
                "amount", "currency", "partial_approval",
                "transaction_type",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            new Tuple<string, HashSet<string>>("WpfCreateSuccessResponse", new HashSet<string>()
            {
                "redirect_url",
                "code", "technical_message", "message", "amount", "currency", "partial_approval",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            new Tuple<string, HashSet<string>>("WpfReconcileSuccessResponse", new HashSet<string>()
            {
                "payment_transaction",
                "code", "technical_message", "message", "amount", "currency", "partial_approval",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            // -----


            // Error
            new Tuple<string, HashSet<string>>("AccountVerificationErrorResponse", new HashSet<string>()
            {
                "code", "technical_message", "message",
                "sent_to_acquirer", "moto", "response_code",
                "transaction_type",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            new Tuple<string, HashSet<string>>("Authorize3dErrorResponse", new HashSet<string>()
            {
                "code", "technical_message", "message",
                "gaming", "moto", "dynamic_descriptor_params", "sent_to_acquirer",
                "response_code",
                "amount", "currency", "partial_approval",
                "transaction_type",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            new Tuple<string, HashSet<string>>("AuthorizeErrorResponse", new HashSet<string>()
            {
                "code", "technical_message", "message",
                "gaming", "moto", "dynamic_descriptor_params", "sent_to_acquirer",
                "response_code",
                "amount", "currency", "partial_approval",
                "transaction_type",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            new Tuple<string, HashSet<string>>("AvsErrorResponse", new HashSet<string>()
            {
                "code", "technical_message", "message",
                "sent_to_acquirer", "moto", "response_code",
                "transaction_type",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            new Tuple<string, HashSet<string>>("BlacklistErrorResponse", new HashSet<string>()
            {
                "code", "technical_message", "message"
            }),
            new Tuple<string, HashSet<string>>("CaptureErrorResponse", new HashSet<string>()
            {
                "code", "technical_message", "message",
                "sent_to_acquirer",
                "amount", "currency", "partial_approval",
                "transaction_type",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            new Tuple<string, HashSet<string>>("CreditErrorResponse", new HashSet<string>()
            {
                "code", "technical_message", "message",
                "response_code",
                "amount", "currency", "partial_approval",
                "transaction_type",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            new Tuple<string, HashSet<string>>("InitRecurringSale3dErrorResponse", new HashSet<string>()
            {
                "code", "technical_message", "message",
                "gaming", "moto", "dynamic_descriptor_params", "sent_to_acquirer",
                "response_code",
                "amount", "currency", "partial_approval",
                "transaction_type",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            new Tuple<string, HashSet<string>>("InitRecurringSaleErrorResponse", new HashSet<string>()
            {
                "code", "technical_message", "message", "sent_to_acquirer",
                "amount", "currency", "partial_approval",
                "transaction_type",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            new Tuple<string, HashSet<string>>("MultiChargebackErrorResponse", new HashSet<string>()
            {
                "status",
                "code", "technical_message", "message"
            }),
            new Tuple<string, HashSet<string>>("MultiReconcileErrorResponse", new HashSet<string>()
            {
                "status",
                "code", "technical_message", "message"
            }),
            new Tuple<string, HashSet<string>>("MultiRetrievalRequestErrorResponse", new HashSet<string>()
            {
                "status",
                "code", "technical_message", "message"
            }),
            new Tuple<string, HashSet<string>>("PayoutErrorResponse", new HashSet<string>()
            {
                "code", "technical_message", "message",
                "sent_to_acquirer",
                "response_code",
                "amount", "currency", "partial_approval",
                "transaction_type",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            new Tuple<string, HashSet<string>>("RecurringSaleErrorResponse", new HashSet<string>()
            {
                "code", "technical_message", "message", "sent_to_acquirer",
                "response_code",
                "amount", "currency", "partial_approval",
                "transaction_type",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            new Tuple<string, HashSet<string>>("RefundErrorResponse", new HashSet<string>()
            {
                "code", "technical_message", "message",
                "response_code",
                "amount", "currency", "partial_approval",
                "transaction_type",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            new Tuple<string, HashSet<string>>("Sale3dErrorResponse", new HashSet<string>()
            {
                "code", "technical_message", "message",
                "gaming", "moto", "dynamic_descriptor_params", "sent_to_acquirer",
                "response_code",
                "amount", "currency", "partial_approval",
                "transaction_type",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            new Tuple<string, HashSet<string>>("SaleErrorResponse", new HashSet<string>()
            {
                "code", "technical_message", "message",
                "gaming", "moto", "dynamic_descriptor_params", "sent_to_acquirer",
                "response_code",
                "amount", "currency", "partial_approval",
                "transaction_type",
                "status", "unique_id", "transaction_id", "mode", "timestamp", "descriptor"
            }),
            new Tuple<string, HashSet<string>>("SingleChargebackErrorResponse", new HashSet<string>()
            {
                "status",
                "code", "technical_message", "message"
            }),
            new Tuple<string, HashSet<string>>("SingleReconcileErrorResponse", new HashSet<string>()
            {
                "status",
                "code", "technical_message", "message"
            }),
            new Tuple<string, HashSet<string>>("SingleRetrievalRequestErrorResponse", new HashSet<string>()
            {
                "status",
                "code", "technical_message", "message"
            }),
            new Tuple<string, HashSet<string>>("VoidErrorResponse", new HashSet<string>()
            {
                "code", "technical_message", "message",
                "sent_to_acquirer",
                "response_code",
                "amount", "currency", "partial_approval"
            }),
            new Tuple<string, HashSet<string>>("WpfCreateErrorResponse", new HashSet<string>()
            {
                "status",
                "code", "technical_message", "message"
            }),
            new Tuple<string, HashSet<string>>("WpfReconcileErrorResponse", new HashSet<string>()
            {
                "status",
                "code", "technical_message", "message"
            }),
        };
    }
}
