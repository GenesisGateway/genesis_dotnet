using System;
using System.Collections.Generic;
using System.Linq;

namespace ModelsDependenciesResolver
{
    public static class Requests
    {
        public static readonly List<Tuple<string, HashSet<string>>> Models = new List<Tuple<string, HashSet<string>>>()
        {
            new Tuple<string, HashSet<string>>("Authorize3d", new HashSet<string>()
            {
                "gaming", "risk_params", "dynamic_descriptor_params",
                "transaction_type", "transaction_id", "usage", "amount", "currency", "remote_ip", "moto", "card_holder", "expiration_month", "expiration_year", "customer_email", "customer_phone", "card_number", "cvv", "billing_address", "shipping_address"
            }),
            new Tuple<string, HashSet<string>>("Authorize3dAsync", new HashSet<string>()
            {
                "notification_url", "return_success_url", "return_failure_url",
                "gaming", "risk_params", "dynamic_descriptor_params",
                "transaction_type", "transaction_id", "usage", "amount", "currency", "remote_ip", "moto", "card_holder", "expiration_month", "expiration_year", "customer_email", "customer_phone", "card_number", "cvv", "billing_address", "shipping_address"
            }),
            new Tuple<string, HashSet<string>>("Authorize3dSync", new HashSet<string>()
            {
                "mpi_params",
                "gaming", "risk_params", "dynamic_descriptor_params",
                "transaction_type", "transaction_id", "usage", "amount", "currency", "remote_ip", "moto", "card_holder", "expiration_month", "expiration_year", "customer_email", "customer_phone", "card_number", "cvv", "billing_address", "shipping_address"
            }),
            new Tuple<string, HashSet<string>>("InitRecurringSale3d", new HashSet<string>()
            {
                "risk_params", "dynamic_descriptor_params",
                "transaction_type", "transaction_id", "usage", "amount", "currency", "remote_ip", "moto", "card_holder", "expiration_month", "expiration_year", "customer_email", "customer_phone", "card_number", "cvv", "billing_address", "shipping_address"
            }),
            new Tuple<string, HashSet<string>>("InitRecurringSale3dAsync", new HashSet<string>()
            {
                "notification_url", "return_success_url", "return_failure_url",
                "risk_params", "dynamic_descriptor_params",
                "transaction_type", "transaction_id", "usage", "amount", "currency", "remote_ip", "moto", "card_holder", "expiration_month", "expiration_year", "customer_email", "customer_phone", "card_number", "cvv", "billing_address", "shipping_address"
            }),
            new Tuple<string, HashSet<string>>("InitRecurringSale3dSync", new HashSet<string>()
            {
                "mpi_params",
                "risk_params", "dynamic_descriptor_params",
                "transaction_type", "transaction_id", "usage", "amount", "currency", "remote_ip", "moto", "card_holder", "expiration_month", "expiration_year", "customer_email", "customer_phone", "card_number", "cvv", "billing_address", "shipping_address"
            }),
            new Tuple<string, HashSet<string>>("Sale3d", new HashSet<string>()
            {
                "gaming", "risk_params", "dynamic_descriptor_params",
                "transaction_type", "transaction_id", "usage", "amount", "currency", "remote_ip", "moto", "card_holder", "expiration_month", "expiration_year", "customer_email", "customer_phone", "card_number", "cvv", "billing_address", "shipping_address"
            }),
            new Tuple<string, HashSet<string>>("Sale3dAsync", new HashSet<string>()
            {
                "notification_url", "return_success_url", "return_failure_url",
                "gaming", "risk_params", "dynamic_descriptor_params",
                "transaction_type", "transaction_id", "usage", "amount", "currency", "remote_ip", "moto", "card_holder", "expiration_month", "expiration_year", "customer_email", "customer_phone", "card_number", "cvv", "billing_address", "shipping_address"
            }),
            new Tuple<string, HashSet<string>>("Sale3dSync", new HashSet<string>()
            {
                "mpi_params",
                "gaming", "risk_params", "dynamic_descriptor_params",
                "transaction_type", "transaction_id", "usage", "amount", "currency", "remote_ip", "moto", "card_holder", "expiration_month", "expiration_year", "customer_email", "customer_phone", "card_number", "cvv", "billing_address", "shipping_address"
            }),
            new Tuple<string, HashSet<string>>("AccountVerification", new HashSet<string>()
            {
                "risk_params",
                "transaction_type", "transaction_id", "usage", "amount", "currency", "remote_ip", "moto", "card_holder", "expiration_month", "expiration_year", "customer_email", "customer_phone", "card_number", "cvv", "billing_address", "shipping_address"
            }),
            new Tuple<string, HashSet<string>>("Authorize", new HashSet<string>()
            {
                "gaming", "risk_params", "dynamic_descriptor_params",
                "transaction_type", "transaction_id", "usage", "amount", "currency", "remote_ip", "moto", "card_holder", "expiration_month", "expiration_year", "customer_email", "customer_phone", "card_number", "cvv", "billing_address", "shipping_address"
            }),
            new Tuple<string, HashSet<string>>("Avs", new HashSet<string>()
            {
                "risk_params",
                "transaction_type", "transaction_id", "usage", "amount", "currency", "remote_ip", "moto", "card_holder", "expiration_month", "expiration_year", "customer_email", "customer_phone", "card_number", "cvv", "billing_address", "shipping_address"
            }),
            new Tuple<string, HashSet<string>>("InitRecurringSale", new HashSet<string>()
            {
                "risk_params", "dynamic_descriptor_params",
                "transaction_type", "transaction_id", "usage", "amount", "currency", "remote_ip", "moto", "card_holder", "expiration_month", "expiration_year", "customer_email", "customer_phone", "card_number", "cvv", "billing_address", "shipping_address"
            }),
            new Tuple<string, HashSet<string>>("Payout", new HashSet<string>()
            {
                "transaction_type", "transaction_id", "usage", "amount", "currency", "remote_ip", "moto", "card_holder", "expiration_month", "expiration_year", "customer_email", "customer_phone", "card_number", "cvv", "billing_address", "shipping_address"
            }),
            new Tuple<string, HashSet<string>>("Sale", new HashSet<string>()
            {
                "gaming", "risk_params", "dynamic_descriptor_params",
                "transaction_type", "transaction_id", "usage", "amount", "currency", "remote_ip", "moto", "card_holder", "expiration_month", "expiration_year", "customer_email", "customer_phone", "card_number", "cvv", "billing_address", "shipping_address"
            }),
            new Tuple<string, HashSet<string>>("WpfCreate", new HashSet<string>()
            {
                "transaction_id", "amount", "currency", "usage", "description", "customer_email", "customer_phone", "notification_url", "return_success_url", "return_failure_url", "return_cancel_url", "billing_address", "shipping_address", "transaction_types", "risk_params"
            }),
            new Tuple<string, HashSet<string>>("Blacklist", new HashSet<string>()
            {
                "card_number", "terminal_token"
            }),
            new Tuple<string, HashSet<string>>("MultiChargeback", new HashSet<string>()
            {
                "start_date", "end_date", "page"
            }),
            new Tuple<string, HashSet<string>>("MultiReconcile", new HashSet<string>()
            {
                "start_date", "end_date", "page"
            }),
            new Tuple<string, HashSet<string>>("MultiRetrievalRequest", new HashSet<string>()
            {
                "start_date", "end_date", "page"
            }),
            new Tuple<string, HashSet<string>>("SingleChargeback", new HashSet<string>()
            {
                "arn", "original_transaction_unique_id"
            }),
            new Tuple<string, HashSet<string>>("SingleReconcile", new HashSet<string>()
            {
                "unique_id",
            }),
            new Tuple<string, HashSet<string>>("SingleRetrievalRequest", new HashSet<string>()
            {
                "arn", "original_transaction_unique_id"
            }),
            new Tuple<string, HashSet<string>>("Capture", new HashSet<string>()
            {
                "amount", "currency",
                "transaction_type", "transaction_id", "usage", "remote_ip", "reference_id"
            }),
            new Tuple<string, HashSet<string>>("Credit", new HashSet<string>()
            {
                "amount", "currency",
                "transaction_type", "transaction_id", "usage", "remote_ip", "reference_id"
            }),
            new Tuple<string, HashSet<string>>("RecurringSale", new HashSet<string>()
            {
                "amount", "currency",
                "transaction_type", "transaction_id", "usage", "remote_ip", "reference_id"
            }),
            new Tuple<string, HashSet<string>>("Refund", new HashSet<string>()
            {
                "amount", "currency",
                "transaction_type", "transaction_id", "usage", "remote_ip", "reference_id"
            }),
            new Tuple<string, HashSet<string>>("VoidRequest", new HashSet<string>()
            {
                "transaction_type", "transaction_id", "usage", "remote_ip", "reference_id"
            }),
            new Tuple<string, HashSet<string>>("WpfReconcile", new HashSet<string>()
            {
                "unique_id"
            })
        };
    }
}
