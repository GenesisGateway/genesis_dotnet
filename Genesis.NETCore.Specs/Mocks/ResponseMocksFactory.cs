﻿using Genesis.NetCore.Common;
using Genesis.NetCore.Entities;
using Genesis.NetCore.Entities.Enums;
using Genesis.NetCore.Entities.Enums.ThreeDS;
using Genesis.NetCore.Entities.Responses;
using Genesis.NetCore.Entities.Responses.Error;
using Genesis.NetCore.Entities.Responses.Models;
using Genesis.NetCore.Entities.Responses.Successful;
using Genesis.NetCore.Errors;

namespace Genesis.NetCore.Specs.Mocks
{
    static class ResponseMocksFactory
    {
        public static EntityMock<CardTransactionSuccessResponse> CreateAuthorize3dSyncSuccessResponse()
        {
            var successResponse = new CardTransactionSuccessResponse()
            {
                TransactionType = TransactionTypes.Authorize3d,
                Status = TransactionStates.Approved,
                AuthorizationCode = "345678",
                ResponseCode = "00",
                UniqueId = "011e8d5cc1a56058cc50440c264f5063",
                TransactionId = "43671",
                Descriptor = "Descriptor One",
                Mode = "live",
                ProxyTime = "2007-08-30T17:46:11Z",
                Amount = 50,
                Currency = Iso4217CurrencyCodes.USD,
                SentToAcquirer = true
            };

            var successResponseXml =
                                    "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                    "<payment_response>" +
                                    "<transaction_type>authorize3d</transaction_type>" +
                                    "<status>approved</status>" +
                                    "<authorization_code>345678</authorization_code>" +
                                    "<response_code>00</response_code>" +
                                    "<unique_id>011e8d5cc1a56058cc50440c264f5063</unique_id>" +
                                    "<transaction_id>43671</transaction_id>" +
                                    "<mode>live</mode>" +
                                    "<timestamp>2007-08-30T17:46:11Z</timestamp>" +
                                    "<descriptor>Descriptor One</descriptor>" +
                                    "<amount>5000</amount>" +
                                    "<currency>USD</currency>" +
                                    "<sent_to_acquirer>true</sent_to_acquirer>" +
                                    "</payment_response>";

            return new EntityMock<CardTransactionSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<CardTransactionSuccessResponse> CreateAuthorize3dAsyncSuccessResponse()
        {
            var successResponse = new CardTransactionSuccessResponse()
            {
                TransactionType = TransactionTypes.Authorize3d,
                Status = TransactionStates.PendingAsync,
                AuthorizationCode = "345678",
                ResponseCode = "00",
                UniqueId = "011e8d5cc1a56058cc50440c264f5063",
                TransactionId = "43671",
                TechnicalMessage = "Transaction successful!",
                Message = "Transaction successful!",
                Descriptor = "Descriptor One",
                Mode = "live",
                RedirectUrl = "https://gateway/8245201941/30ec0f2387",
                ProxyTime = "2007-08-30T17:46:11Z",
                Amount = 50,
                Currency = Iso4217CurrencyCodes.USD,
                SentToAcquirer = true,
                PartialApproval = true
            };

            var successResponseXml =
                                    "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                    "<payment_response>" +
                                    "<transaction_type>authorize3d</transaction_type>" +
                                    "<status>pending_async</status>" +
                                    "<authorization_code>345678</authorization_code>" +
                                    "<response_code>00</response_code>" +
                                    "<unique_id>011e8d5cc1a56058cc50440c264f5063</unique_id>" +
                                    "<transaction_id>43671</transaction_id>" +
                                    "<technical_message>Transaction successful!</technical_message>" +
                                    "<message>Transaction successful!</message>" +
                                    "<mode>live</mode>" +
                                    "<redirect_url>https://gateway/8245201941/30ec0f2387</redirect_url>" +
                                    "<timestamp>2007-08-30T17:46:11Z</timestamp>" +
                                    "<descriptor>Descriptor One</descriptor>" +
                                    "<amount>5000</amount>" +
                                    "<currency>USD</currency>" +
                                    "<sent_to_acquirer>true</sent_to_acquirer>" +
                                    "<partial_approval>true</partial_approval>" +
                                    "</payment_response>";

            return new EntityMock<CardTransactionSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<CardTransactionErrorResponse> CreateAuthorize3dErrorResponse()
        {
            var errorResponse = new CardTransactionErrorResponse()
            {
                TransactionType = TransactionTypes.Authorize3d,
                Status = TransactionStates.Error,
                ResponseCode = "57",
                UniqueId = "011e8d5cc1a56058cc50440c264f5063",
                TransactionId = "43671",
                Code = ErrorCodes.InputDataInvalidError,
                TechnicalMessage = "’expiration_year’ is invalid",
                Message = "’expiration_year’ is invalid",
                Mode = "live",
                ProxyTime = "2007-08-30T17:46:11Z",
                Descriptor = "Descriptor One",
                Amount = 50,
                Currency = Iso4217CurrencyCodes.USD,
                SentToAcquirer = false
            };

            var errorResponseXml =
                                  "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                  "<payment_response>" +
                                  "<transaction_type>authorize3d</transaction_type>" +
                                  "<status>error</status>" +
                                  "<response_code>57</response_code>" +
                                  "<unique_id>011e8d5cc1a56058cc50440c264f5063</unique_id>" +
                                  "<transaction_id>43671</transaction_id>" +
                                  "<code>340</code>" +
                                  "<technical_message>’expiration_year’ is invalid</technical_message>" +
                                  "<message>’expiration_year’ is invalid</message>" +
                                  "<mode>live</mode>" +
                                  "<timestamp>2007-08-30T17:46:11Z</timestamp>" +
                                  "<descriptor>Descriptor One</descriptor>" +
                                  "<amount>5000</amount>" +
                                  "<currency>USD</currency>" +
                                  "<sent_to_acquirer>false</sent_to_acquirer>" +
                                  "</payment_response>";

            return new EntityMock<CardTransactionErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<CardTransactionSuccessResponse> CreateInitRecurringSale3dSyncSuccessResponse()
        {
            var successResponse = new CardTransactionSuccessResponse()
            {
                TransactionType = TransactionTypes.InitRecurringSale3d,
                Status = TransactionStates.Approved,
                AuthorizationCode = "345678",
                ResponseCode = "00",
                UniqueId = "5e2cbbad71d2b13432323153c208223a",
                TransactionId = "119643250547501c79d8295",
                Amount = 90,
                Currency = Iso4217CurrencyCodes.USD,
                Descriptor = "descriptor one",
                Mode = "live",
                ProxyTime = "2007-11-30T14:21:48Z",
                SentToAcquirer = true
            };

            var successResponseXml =
                                    "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                    "<payment_response>" +
                                    "<transaction_type>init_recurring_sale3d</transaction_type>" +
                                    "<status>approved</status>" +
                                    "<authorization_code>345678</authorization_code>" +
                                    "<response_code>00</response_code>" +
                                    "<unique_id>5e2cbbad71d2b13432323153c208223a</unique_id>" +
                                    "<transaction_id>119643250547501c79d8295</transaction_id>" +
                                    "<mode>live</mode>" +
                                    "<timestamp>2007-11-30T14:21:48Z</timestamp>" +
                                    "<descriptor>descriptor one</descriptor>" +
                                    "<amount>9000</amount>" +
                                    "<currency>USD</currency>" +
                                    "<sent_to_acquirer>true</sent_to_acquirer>" +
                                    "</payment_response>";

            return new EntityMock<CardTransactionSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<CardTransactionSuccessResponse> CreateInitRecurringSale3dAsyncSuccessResponse()
        {
            var successResponse = new CardTransactionSuccessResponse()
            {
                TransactionType = TransactionTypes.InitRecurringSale3d,
                Status = TransactionStates.PendingAsync,
                UniqueId = "5e2cbbad71d2b13432323153c208223a",
                TransactionId = "119643250547501c79d8295",
                RedirectUrl = "https://gateway/8245201941/30ec0f2387",
                Amount = 90,
                Currency = Iso4217CurrencyCodes.USD,
                Descriptor = "descriptor one",
                Mode = "live",
                ProxyTime = "2007-11-30T14:21:48Z",
                PartialApproval = true
            };

            var successResponseXml =
                                    "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                    "<payment_response>" +
                                    "<transaction_type>init_recurring_sale3d</transaction_type>" +
                                    "<status>pending_async</status>" +
                                    "<unique_id>5e2cbbad71d2b13432323153c208223a</unique_id>" +
                                    "<transaction_id>119643250547501c79d8295</transaction_id>" +
                                    "<redirect_url>https://gateway/8245201941/30ec0f2387</redirect_url>" +
                                    "<mode>live</mode>" +
                                    "<timestamp>2007-11-30T14:21:48Z</timestamp>" +
                                    "<descriptor>descriptor one</descriptor>" +
                                    "<amount>9000</amount>" +
                                    "<currency>USD</currency>" +
                                    "<partial_approval>true</partial_approval>" +
                                    "</payment_response>";

            return new EntityMock<CardTransactionSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<CardTransactionErrorResponse> CreateInitRecurringSale3dErrorResponse()
        {
            var errorResponse = new CardTransactionErrorResponse()
            {
                TransactionType = TransactionTypes.InitRecurringSale3d,
                Status = TransactionStates.Error,
                ResponseCode = "57",
                UniqueId = "d0231d21e0e50afbba1909eadc2f2d6b",
                TransactionId = "345345",
                Code = ErrorCodes.InputDataInvalidError,
                TechnicalMessage = "'billing_address[country]' is invalid!",
                Message = "Please check input data for errors!",
                Mode = "test",
                ProxyTime = "2014-11-18T16:18:39Z",
                Descriptor = "Testing MID",
                Amount = 100,
                Currency = Iso4217CurrencyCodes.USD,
                SentToAcquirer = false
            };

            var errorResponseXml =
                                  "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                  "<payment_response>" +
                                  "<transaction_type>init_recurring_sale3d</transaction_type>" +
                                  "<status>error</status>" +
                                  "<response_code>57</response_code>" +
                                  "<unique_id>d0231d21e0e50afbba1909eadc2f2d6b</unique_id>" +
                                  "<transaction_id>345345</transaction_id>" +
                                  "<code>340</code>" +
                                  "<technical_message>'billing_address[country]' is invalid!</technical_message>" +
                                  "<message>Please check input data for errors!</message>" +
                                  "<mode>test</mode>" +
                                  "<timestamp>2014-11-18T16:18:39Z</timestamp>" +
                                  "<descriptor>Testing MID</descriptor>" +
                                  "<amount>10000</amount>" +
                                  "<currency>USD</currency>" +
                                  "<sent_to_acquirer>false</sent_to_acquirer>" +
                                  "</payment_response>";

            return new EntityMock<CardTransactionErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<CardTransactionSuccessResponse> CreateSale3dSyncSuccessResponse()
        {
            var successResponse = new CardTransactionSuccessResponse()
            {
                TransactionType = TransactionTypes.Sale3d,
                Amount = 90,
                Currency = Iso4217CurrencyCodes.USD,
                AuthorizationCode = "345678",
                Descriptor = "descriptor one",
                Status = TransactionStates.Approved,
                ResponseCode = "00",
                UniqueId = "5e2cbbad71d2b13432323153c208223a",
                TransactionId = "119643250547501c79d8295",
                Mode = "live",
                ProxyTime = "2007-11-30T14:21:48Z",
                SentToAcquirer = true
            };

            var successResponseXml =
                                    "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                    "<payment_response>" +
                                    "<transaction_type>sale3d</transaction_type>" +
                                    "<status>approved</status>" +
                                    "<authorization_code>345678</authorization_code>" +
                                    "<response_code>00</response_code>" +
                                    "<unique_id>5e2cbbad71d2b13432323153c208223a</unique_id>" +
                                    "<transaction_id>119643250547501c79d8295</transaction_id>" +
                                    "<mode>live</mode>" +
                                    "<timestamp>2007-11-30T14:21:48Z</timestamp>" +
                                    "<descriptor>descriptor one</descriptor>" +
                                    "<amount>9000</amount>" +
                                    "<currency>USD</currency>" +
                                    "<sent_to_acquirer>true</sent_to_acquirer>" +
                                    "</payment_response>";

            return new EntityMock<CardTransactionSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<CardTransactionSuccessResponse> CreateSale3dAsyncSuccessResponse()
        {
            var successResponse = new CardTransactionSuccessResponse()
            {
                TransactionType = TransactionTypes.Sale3d,
                Amount = 90,
                Currency = Iso4217CurrencyCodes.USD,
                Descriptor = "descriptor one",
                Status = TransactionStates.PendingAsync,
                ResponseCode = "00",
                UniqueId = "5e2cbbad71d2b13432323153c208223a",
                TransactionId = "119643250547501c79d8295",
                Mode = "live",
                ProxyTime = "2007-11-30T14:21:48Z",
                RedirectUrl = "https://gateway/8245201941/30ec0f2387",
                PartialApproval = true
            };

            var successResponseXml =
                                    "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                    "<payment_response>" +
                                    "<transaction_type>sale3d</transaction_type>" +
                                    "<status>pending_async</status>" +
                                    "<response_code>00</response_code>" +
                                    "<unique_id>5e2cbbad71d2b13432323153c208223a</unique_id>" +
                                    "<transaction_id>119643250547501c79d8295</transaction_id>" +
                                    "<redirect_url>https://gateway/8245201941/30ec0f2387</redirect_url>" +
                                    "<mode>live</mode>" +
                                    "<timestamp>2007-11-30T14:21:48Z</timestamp>" +
                                    "<descriptor>descriptor one</descriptor>" +
                                    "<amount>9000</amount>" +
                                    "<currency>USD</currency>" +
                                    "<partial_approval>true</partial_approval>" +
                                    "</payment_response>";

            return new EntityMock<CardTransactionSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<CardTransactionSuccessResponse> Create3dV2FrictionlessSuccessResponse()
        {
            var successResponse = new CardTransactionSuccessResponse()
            {
                TransactionType = TransactionTypes.InitRecurringSale3d,
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                Descriptor = "Descriptor one",
                Status = TransactionStates.Approved,
                ResponseCode = "00",
                UniqueId = "44177a21403427eb96664a6d7e5d5d48",
                TransactionId = "119643250547501c79d8295",
                Mode = "test",
                ProxyTime = "2022-05-24T17:25:08Z",
                SentToAcquirer = true,
                ThreeDS = new ThreeDSElementModel()
                {
                    Eci = "05"
                }
            };

            var successResponseXml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
                <payment_response>
                  <transaction_type>init_recurring_sale3d</transaction_type>
                  <status>approved</status>
                  <mode>test</mode>
                  <transaction_id>119643250547501c79d8295</transaction_id>
                  <response_code>00</response_code>
                  <unique_id>44177a21403427eb96664a6d7e5d5d48</unique_id>
                  <timestamp>2022-05-24T17:25:08Z</timestamp>
                  <descriptor>Descriptor one</descriptor>
                  <amount>100</amount>
                  <currency>USD</currency>
                  <sent_to_acquirer>true</sent_to_acquirer>
                  <threeds>
                    <eci>05</eci>
                  </threeds>
                </payment_response>";


            return new EntityMock<CardTransactionSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<CardTransactionSuccessResponse> Create3dV2FrictionlessWith3dSecureSuccessResponse()
        {
            var successResponse = new CardTransactionSuccessResponse()
            {
                TransactionType = TransactionTypes.InitRecurringSale3d,
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                Descriptor = "Descriptor one",
                Status = TransactionStates.PendingAsync,
                UniqueId = "44177a21403427eb96664a6d7e5d5d48",
                TransactionId = "119643250547501c79d8295",
                ThreedsMethodUrl = "https://staging.gate.emerchantpay.net/threeds/threeds_method",
                ThreedsMethodContinueUrl = "https://staging.gate.emerchantpay.net/threeds/threeds_method/44177a21403427eb96664a6d7e5d5d48",
                Mode = "test",
                ProxyTime = "2022-05-24T17:25:08Z",
                SentToAcquirer = false,
            };

            var successResponseXml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
                <payment_response>
                  <transaction_type>init_recurring_sale3d</transaction_type>
                  <status>pending_async</status>
                  <mode>test</mode>
                  <transaction_id>119643250547501c79d8295</transaction_id>
                  <unique_id>44177a21403427eb96664a6d7e5d5d48</unique_id>
                  <threeds_method_url>https://staging.gate.emerchantpay.net/threeds/threeds_method</threeds_method_url>
                  <threeds_method_continue_url>https://staging.gate.emerchantpay.net/threeds/threeds_method/44177a21403427eb96664a6d7e5d5d48</threeds_method_continue_url>
                  <timestamp>2022-05-24T17:25:08Z</timestamp>
                  <descriptor>Descriptor one</descriptor>
                  <amount>100</amount>
                  <currency>USD</currency>
                  <sent_to_acquirer>false</sent_to_acquirer>
                </payment_response>";

            return new EntityMock<CardTransactionSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<CardTransactionSuccessResponse> Create3dV2ChallangeSuccessResponse()
        {
            var successResponse = new CardTransactionSuccessResponse()
            {
                TransactionType = TransactionTypes.Authorize3d,
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                Descriptor = "Descriptor one",
                Status = TransactionStates.PendingAsync,
                UniqueId = "44177a21403427eb96664a6d7e5d5d48",
                TransactionId = "119643250547501c79d8295",
                RedirectUrl = "https://staging.gate.emerchantpay.net/threeds/authentication/44177a21403427eb96664a6d7e5d5d48",
                RedirectUrlType = RedirectUrlTypes.ThreeDSv2Challage,
                Mode = "test",
                ProxyTime = "2022-05-24T17:25:08Z",
                SentToAcquirer = false,
            };

            var successResponseXml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
                <payment_response>
                  <transaction_type>authorize3d</transaction_type>
                  <status>pending_async</status>
                  <mode>test</mode>
                  <transaction_id>119643250547501c79d8295</transaction_id>
                  <unique_id>44177a21403427eb96664a6d7e5d5d48</unique_id>
                  <redirect_url>https://staging.gate.emerchantpay.net/threeds/authentication/44177a21403427eb96664a6d7e5d5d48</redirect_url>
                  <redirect_url_type>3ds_v2_challenge</redirect_url_type>
                  <timestamp>2022-05-24T17:25:08Z</timestamp>
                  <descriptor>Descriptor one</descriptor>
                  <amount>100</amount>
                  <currency>USD</currency>
                  <sent_to_acquirer>false</sent_to_acquirer>
                </payment_response>";

            return new EntityMock<CardTransactionSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<CardTransactionSuccessResponse> Create3dV2ChallangeWith3dSecureSuccessResponse()
        {
            var successResponse = new CardTransactionSuccessResponse()
            {
                TransactionType = TransactionTypes.Sale3d,
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                Descriptor = "Descriptor one",
                Status = TransactionStates.PendingAsync,
                UniqueId = "44177a21403427eb96664a6d7e5d5d48",
                TransactionId = "119643250547501c79d8295",
                ThreedsMethodUrl = "https://staging.gate.emerchantpay.net/threeds/threeds_method",
                ThreedsMethodContinueUrl = "https://staging.gate.emerchantpay.net/threeds/threeds_method/44177a21403427eb96664a6d7e5d5d48",
                Mode = "test",
                ProxyTime = "2022-05-24T17:25:09Z",
                SentToAcquirer = false,
            };

            var successResponseXml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
                <payment_response>
                  <transaction_type>sale3d</transaction_type>
                  <status>pending_async</status>
                  <mode>test</mode>
                  <transaction_id>119643250547501c79d8295</transaction_id>
                  <unique_id>44177a21403427eb96664a6d7e5d5d48</unique_id>
                  <threeds_method_url>https://staging.gate.emerchantpay.net/threeds/threeds_method</threeds_method_url>
                  <threeds_method_continue_url>https://staging.gate.emerchantpay.net/threeds/threeds_method/44177a21403427eb96664a6d7e5d5d48</threeds_method_continue_url>
                  <timestamp>2022-05-24T17:25:09Z</timestamp>
                  <descriptor>Descriptor one</descriptor>
                  <amount>100</amount>
                  <currency>USD</currency>
                  <sent_to_acquirer>false</sent_to_acquirer>
                </payment_response>";

            return new EntityMock<CardTransactionSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<CardTransactionSuccessResponse> Create3dV2FallbackSuccessResponse()
        {
            var successResponse = new CardTransactionSuccessResponse()
            {
                TransactionType = TransactionTypes.InitRecurringSale3d,
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                Descriptor = "Descriptor one",
                Status = TransactionStates.PendingAsync,
                UniqueId = "44177a21403427eb96664a6d7e5d5d48",
                TransactionId = "119643250547501c79d8295",
                RedirectUrl = "https://staging.gate.emerchantpay.net/threeds/authentication/44177a21403427eb96664a6d7e5d5d48",
                RedirectUrlType = RedirectUrlTypes.ThreeDSv1PayerAuthentication,
                Mode = "test",
                ProxyTime = "2022-05-24T17:25:09Z",
                SentToAcquirer = false,
            };

            var successResponseXml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
                <payment_response>
                  <transaction_type>init_recurring_sale3d</transaction_type>
                  <status>pending_async</status>
                  <mode>test</mode>
                  <transaction_id>119643250547501c79d8295</transaction_id>
                  <unique_id>44177a21403427eb96664a6d7e5d5d48</unique_id>
                  <redirect_url>https://staging.gate.emerchantpay.net/threeds/authentication/44177a21403427eb96664a6d7e5d5d48</redirect_url>
                  <redirect_url_type>3ds_v1_payer_authentication</redirect_url_type>
                  <timestamp>2022-05-24T17:25:09Z</timestamp>
                  <descriptor>Descriptor one</descriptor>
                  <amount>100</amount>
                  <currency>USD</currency>
                  <sent_to_acquirer>false</sent_to_acquirer>
                </payment_response>";

            return new EntityMock<CardTransactionSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<CardTransactionSuccessResponse> Create3dV2FallbackWith3dSecureSuccessResponse()
        {
            var successResponse = new CardTransactionSuccessResponse()
            {
                TransactionType = TransactionTypes.InitRecurringSale3d,
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                AuthorizationCode = "345678",
                Descriptor = "Descriptor one",
                Status = TransactionStates.PendingAsync,
                UniqueId = "44177a21403427eb96664a6d7e5d5d48",
                TransactionId = "119643250547501c79d8295",
                ThreedsMethodUrl = "https://staging.gate.emerchantpay.net/threeds/threeds_method",
                ThreedsMethodContinueUrl = "https://staging.gate.emerchantpay.net/threeds/threeds_method/44177a21403427eb96664a6d7e5d5d48",
                Mode = "test",
                ProxyTime = "2022-05-24T17:25:09Z",
                SentToAcquirer = false,
            };

            var successResponseXml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
                <payment_response>
                  <transaction_type>init_recurring_sale3d</transaction_type>
                  <status>pending_async</status>
                  <authorization_code>345678</authorization_code>
                  <mode>test</mode>
                  <transaction_id>119643250547501c79d8295</transaction_id>
                  <unique_id>44177a21403427eb96664a6d7e5d5d48</unique_id>
                  <threeds_method_url>https://staging.gate.emerchantpay.net/threeds/threeds_method</threeds_method_url>
                  <threeds_method_continue_url>https://staging.gate.emerchantpay.net/threeds/threeds_method/44177a21403427eb96664a6d7e5d5d48</threeds_method_continue_url>
                  <timestamp>2022-05-24T17:25:09Z</timestamp>
                  <descriptor>Descriptor one</descriptor>
                  <amount>100</amount>
                  <currency>USD</currency>
                  <sent_to_acquirer>false</sent_to_acquirer>
                </payment_response>";

            return new EntityMock<CardTransactionSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<SingleReconcileSuccessResponse> Create3dV2FrictionlessReconcileSuccessResponse()
        {
            var successResponse = new SingleReconcileSuccessResponse()
            {
                TransactionType = TransactionTypes.InitRecurringSale3d,
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                AuthorizationCode = "005645",
                Descriptor = "Descriptor one",
                Status = TransactionStates.Approved,
                UniqueId = "44177a21403427eb96664a6d7e5d5d48",
                TransactionId = "119643250547501c79d8295",
                Mode = "test",
                ProxyTime = "2022-05-24T17:25:08Z",
                SentToAcquirer = true,
                ResponseCode = "00",
                // missing field to be added later in other task
                // retrieval_reference_number = "016813015184"
                // card_brand = "visa"                                 ,
                // card_number = "401200...0085"                       ,
                // card_type = "CREDIT"                                ,
                // card_subtype = "CARD SUBTYPE"                       ,
                // card_issuing_bank = "Issuing Bank"                  ,
                // card_issuing_country = "Exact Issuing country"      ,
                // bank_account_number = "Bank Account Number"         ,
                // bank_identifier_code = "Bank Identifier Code"       ,
                // arn = "74537605259536043849425"                     ,
                // scheme_response_code = "00"                         ,
                ThreeDS = new ThreeDSElementModel()
                {
                    AuthenticationFlow = AuthenticationFlows.Frictionless,
                    Protocol = new ProtocolModel()
                    {
                        TargetVersion = 2,
                        ConcreteVersion = 2
                    },
                    Eci = "05"
                }
            };

            var successResponseXml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
                <payment_response>
                  <transaction_type>init_recurring_sale3d</transaction_type>
                  <status>approved</status>
                  <authorization_code>005645</authorization_code>
                  <retrieval_reference_number>016813015184</retrieval_reference_number>
                  <response_code>00</response_code>
                  <unique_id>44177a21403427eb96664a6d7e5d5d48</unique_id>
                  <transaction_id>119643250547501c79d8295</transaction_id>
                  <mode>test</mode>
                  <timestamp>2022-05-24T17:25:08Z</timestamp>
                  <descriptor>Descriptor one</descriptor>
                  <amount>100</amount>
                  <currency>USD</currency>
                  <card_brand>visa</card_brand>
                  <card_number>401200...0085</card_number>
                  <card_type>CREDIT</card_type>
                  <card_subtype>CARD SUBTYPE</card_subtype>
                  <card_issuing_bank>Issuing Bank</card_issuing_bank>
                  <card_issuing_country>Exact Issuing country</card_issuing_country>
                  <bank_account_number>Bank Account Number</bank_account_number>
                  <bank_identifier_code>Bank Identifier Code</bank_identifier_code>
                  <sent_to_acquirer>true</sent_to_acquirer>
                  <arn>74537605259536043849425</arn>
                  <scheme_response_code>00</scheme_response_code>
                  <threeds>
                    <authentication_flow>frictionless</authentication_flow>
                    <protocol>
                      <target_version>2</target_version>
                      <concrete_version>2</concrete_version>
                    </protocol>
                    <eci>05</eci>
                  </threeds>
                </payment_response>";

            return new EntityMock<SingleReconcileSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<SingleReconcileSuccessResponse> Create3dV2FrictionlessWith3dSecureReconcileSuccessResponse()
        {
            var successResponse = new SingleReconcileSuccessResponse()
            {
                TransactionType = TransactionTypes.InitRecurringSale3d,
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                AuthorizationCode = "005645",
                Descriptor = "Descriptor one",
                Status = TransactionStates.Approved,
                UniqueId = "44177a21403427eb96664a6d7e5d5d48",
                TransactionId = "119643250547501c79d8295",
                Mode = "test",
                ProxyTime = "2022-05-24T17:25:08Z",
                SentToAcquirer = true,
                ResponseCode = "00",
                ThreeDS = new ThreeDSElementModel()
                {
                    AuthenticationFlow = AuthenticationFlows.Frictionless,
                    ThreedsMethod = new ThreedsMethodModel()
                    {
                        Status = MethodStatus.Completed
                    },
                    Protocol = new ProtocolModel()
                    {
                        TargetVersion = 2,
                        ConcreteVersion = 2
                    },
                    Eci = "05"
                }
            };

            var successResponseXml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
                <payment_response>
                  <transaction_type>init_recurring_sale3d</transaction_type>
                  <status>approved</status>
                  <authorization_code>005645</authorization_code>
                  <retrieval_reference_number>016813015184</retrieval_reference_number>
                  <response_code>00</response_code>
                  <unique_id>44177a21403427eb96664a6d7e5d5d48</unique_id>
                  <transaction_id>119643250547501c79d8295</transaction_id>
                  <mode>test</mode>
                  <timestamp>2022-05-24T17:25:08Z</timestamp>
                  <descriptor>Descriptor one</descriptor>
                  <amount>100</amount>
                  <currency>USD</currency>
                  <card_brand>visa</card_brand>
                  <card_number>406633...0004</card_number>
                  <card_type>CREDIT</card_type>
                  <card_subtype>CARD SUBTYPE</card_subtype>
                  <card_issuing_bank>Issuing Bank</card_issuing_bank>
                  <card_issuing_country>Exact Issuing country</card_issuing_country>
                  <bank_account_number>Bank Account Number</bank_account_number>
                  <bank_identifier_code>Bank Identifier Code</bank_identifier_code>
                  <sent_to_acquirer>true</sent_to_acquirer>
                  <arn>74537605259536043849425</arn>
                  <scheme_response_code>00</scheme_response_code>
                  <threeds>
                    <authentication_flow>frictionless</authentication_flow>
                    <threeds_method>
                      <status>completed</status>
                    </threeds_method>
                    <protocol>
                      <target_version>2</target_version>
                      <concrete_version>2</concrete_version>
                    </protocol>
                    <eci>05</eci>
                  </threeds>
                </payment_response>";

            return new EntityMock<SingleReconcileSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<SingleReconcileSuccessResponse> Create3dV2ChallangeReconcileSuccessResponse()
        {
            var successResponse = new SingleReconcileSuccessResponse()
            {
                TransactionType = TransactionTypes.Authorize3d,
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                AuthorizationCode = "005645",
                Descriptor = "Descriptor one",
                Status = TransactionStates.Approved,
                UniqueId = "44177a21403427eb96664a6d7e5d5d48",
                TransactionId = "119643250547501c79d8295",
                Mode = "test",
                ProxyTime = "2022-05-24T17:25:08Z",
                SentToAcquirer = true,
                ResponseCode = "00",
                ThreeDS = new ThreeDSElementModel()
                {
                    AuthenticationFlow = AuthenticationFlows.Challenge,
                    Protocol = new ProtocolModel()
                    {
                        TargetVersion = 2,
                        ConcreteVersion = 2
                    },
                    Eci = "05"
                }
            };

            var successResponseXml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
                <payment_response>
                  <transaction_type>authorize3d</transaction_type>
                  <status>approved</status>
                  <authorization_code>005645</authorization_code>
                  <retrieval_reference_number>016813015184</retrieval_reference_number>
                  <response_code>00</response_code>
                  <unique_id>44177a21403427eb96664a6d7e5d5d48</unique_id>
                  <transaction_id>119643250547501c79d8295</transaction_id>
                  <mode>test</mode>
                  <timestamp>2022-05-24T17:25:08Z</timestamp>
                  <descriptor>Descriptor one</descriptor>
                  <amount>100</amount>
                  <currency>USD</currency>
                  <card_brand>visa</card_brand>
                  <card_number>491819...0002</card_number>
                  <card_type>CREDIT</card_type>
                  <card_subtype>CARD SUBTYPE</card_subtype>
                  <card_issuing_bank>Issuing Bank</card_issuing_bank>
                  <card_issuing_country>Exact Issuing country</card_issuing_country>
                  <bank_account_number>Bank Account Number</bank_account_number>
                  <bank_identifier_code>Bank Identifier Code</bank_identifier_code>
                  <sent_to_acquirer>true</sent_to_acquirer>
                  <arn>74537605259536043849425</arn>
                  <scheme_response_code>00</scheme_response_code>
                  <threeds>
                    <authentication_flow>challenge</authentication_flow>
                    <protocol>
                      <target_version>2</target_version>
                      <concrete_version>2</concrete_version>
                    </protocol>
                    <eci>05</eci>
                  </threeds>
                </payment_response>";

            return new EntityMock<SingleReconcileSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<SingleReconcileSuccessResponse> Create3dV2ChallangeWith3dSecureReconcileSuccessResponse()
        {
            var successResponse = new SingleReconcileSuccessResponse()
            {
                TransactionType = TransactionTypes.Sale3d,
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                AuthorizationCode = "005645",
                Descriptor = "Descriptor one",
                Status = TransactionStates.Approved,
                UniqueId = "44177a21403427eb96664a6d7e5d5d48",
                TransactionId = "119643250547501c79d8295",
                Mode = "test",
                ProxyTime = "2022-05-24T17:25:09Z",
                SentToAcquirer = true,
                ResponseCode = "00",
                ThreeDS = new ThreeDSElementModel()
                {
                    AuthenticationFlow = AuthenticationFlows.Challenge,
                    ThreedsMethod = new ThreedsMethodModel()
                    {
                        Status = MethodStatus.Completed
                    },
                    Protocol = new ProtocolModel()
                    {
                        TargetVersion = 2,
                        ConcreteVersion = 2
                    },
                    Eci = "05"
                }
            };

            var successResponseXml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
                <payment_response>
                  <transaction_type>sale3d</transaction_type>
                  <status>approved</status>
                  <authorization_code>005645</authorization_code>
                  <retrieval_reference_number>016813015184</retrieval_reference_number>
                  <response_code>00</response_code>
                  <unique_id>44177a21403427eb96664a6d7e5d5d48</unique_id>
                  <transaction_id>119643250547501c79d8295</transaction_id>
                  <mode>test</mode>
                  <timestamp>2022-05-24T17:25:09Z</timestamp>
                  <descriptor>Descriptor one</descriptor>
                  <amount>100</amount>
                  <currency>USD</currency>
                  <card_brand>visa</card_brand>
                  <card_number>493873...0001</card_number>
                  <card_type>CREDIT</card_type>
                  <card_subtype>CARD SUBTYPE</card_subtype>
                  <card_issuing_bank>Issuing Bank</card_issuing_bank>
                  <card_issuing_country>Exact Issuing country</card_issuing_country>
                  <bank_account_number>Bank Account Number</bank_account_number>
                  <bank_identifier_code>Bank Identifier Code</bank_identifier_code>
                  <sent_to_acquirer>true</sent_to_acquirer>
                  <arn>74537605259536043849425</arn>
                  <scheme_response_code>00</scheme_response_code>
                  <threeds>
                    <authentication_flow>challenge</authentication_flow>
                    <threeds_method>
                      <status>completed</status>
                    </threeds_method>
                    <protocol>
                      <target_version>2</target_version>
                      <concrete_version>2</concrete_version>
                    </protocol>
                    <eci>05</eci>
                  </threeds>
                </payment_response>";

            return new EntityMock<SingleReconcileSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<SingleReconcileSuccessResponse> Create3dV2FallbackReconcileSuccessResponse()
        {
            var successResponse = new SingleReconcileSuccessResponse()
            {
                TransactionType = TransactionTypes.InitRecurringSale3d,
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                AuthorizationCode = "005645",
                Descriptor = "Descriptor one",
                Status = TransactionStates.Approved,
                UniqueId = "44177a21403427eb96664a6d7e5d5d48",
                TransactionId = "119643250547501c79d8295",
                Mode = "test",
                ProxyTime = "2022-05-24T17:25:09Z",
                SentToAcquirer = true,
                ResponseCode = "00",
                ThreeDS = new ThreeDSElementModel()
                {
                    AuthenticationFlow = AuthenticationFlows.Fallback,
                    Protocol = new ProtocolModel()
                    {
                        TargetVersion = 2,
                        ConcreteVersion = 1
                    },
                    Eci = "05"
                }
            };

            var successResponseXml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
                <payment_response>
                  <transaction_type>init_recurring_sale3d</transaction_type>
                  <status>approved</status>
                  <authorization_code>005645</authorization_code>
                  <retrieval_reference_number>016813015184</retrieval_reference_number>
                  <response_code>00</response_code>
                  <unique_id>44177a21403427eb96664a6d7e5d5d48</unique_id>
                  <transaction_id>119643250547501c79d8295</transaction_id>
                  <mode>test</mode>
                  <timestamp>2022-05-24T17:25:09Z</timestamp>
                  <descriptor>Descriptor one</descriptor>
                  <amount>100</amount>
                  <currency>USD</currency>
                  <card_brand>visa</card_brand>
                  <card_number>490117...0003</card_number>
                  <card_type>CREDIT</card_type>
                  <card_subtype>CARD SUBTYPE</card_subtype>
                  <card_issuing_bank>Issuing Bank</card_issuing_bank>
                  <card_issuing_country>Exact Issuing country</card_issuing_country>
                  <bank_account_number>Bank Account Number</bank_account_number>
                  <bank_identifier_code>Bank Identifier Code</bank_identifier_code>
                  <sent_to_acquirer>true</sent_to_acquirer>
                  <arn>74537605259536043849425</arn>
                  <scheme_response_code>00</scheme_response_code>
                  <threeds>
                    <authentication_flow>fallback</authentication_flow>
                    <protocol>
                      <target_version>2</target_version>
                      <concrete_version>1</concrete_version>
                    </protocol>
                    <eci>05</eci>
                  </threeds>
                </payment_response>";

            return new EntityMock<SingleReconcileSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<SingleReconcileSuccessResponse> Create3dV2FallbackWith3dSecureReconcileSuccessResponse()
        {
            var successResponse = new SingleReconcileSuccessResponse()
            {
                TransactionType = TransactionTypes.InitRecurringSale3d,
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                AuthorizationCode = "005645",
                Descriptor = "Descriptor one",
                Status = TransactionStates.Approved,
                UniqueId = "44177a21403427eb96664a6d7e5d5d48",
                TransactionId = "119643250547501c79d8295",
                Mode = "test",
                ProxyTime = "2022-05-24T17:25:09Z",
                SentToAcquirer = true,
                ResponseCode = "00",
                ThreeDS = new ThreeDSElementModel()
                {
                    AuthenticationFlow = AuthenticationFlows.Fallback,
                    ThreedsMethod = new ThreedsMethodModel()
                    {
                        Status = MethodStatus.Completed
                    },
                    Protocol = new ProtocolModel()
                    {
                        TargetVersion = 2,
                        ConcreteVersion = 1
                    },
                    Eci = "05"
                }
            };

            var successResponseXml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
                <payment_response>
                  <transaction_type>init_recurring_sale3d</transaction_type>
                  <status>approved</status>
                  <authorization_code>005645</authorization_code>
                  <retrieval_reference_number>016813015184</retrieval_reference_number>
                  <response_code>00</response_code>
                  <unique_id>44177a21403427eb96664a6d7e5d5d48</unique_id>
                  <transaction_id>119643250547501c79d8295</transaction_id>
                  <mode>test</mode>
                  <timestamp>2022-05-24T17:25:09Z</timestamp>
                  <descriptor>Descriptor one</descriptor>
                  <amount>100</amount>
                  <currency>USD</currency>
                  <card_brand>visa</card_brand>
                  <card_number>490116...4345</card_number>
                  <card_type>CREDIT</card_type>
                  <card_subtype>CARD SUBTYPE</card_subtype>
                  <card_issuing_bank>Issuing Bank</card_issuing_bank>
                  <card_issuing_country>Exact Issuing country</card_issuing_country>
                  <bank_account_number>Bank Account Number</bank_account_number>
                  <bank_identifier_code>Bank Identifier Code</bank_identifier_code>
                  <sent_to_acquirer>true</sent_to_acquirer>
                  <arn>74537605259536043849425</arn>
                  <scheme_response_code>00</scheme_response_code>
                  <threeds>
                    <authentication_flow>fallback</authentication_flow>
                    <threeds_method>
                      <status>completed</status>
                    </threeds_method>
                    <protocol>
                      <target_version>2</target_version>
                      <concrete_version>1</concrete_version>
                    </protocol>
                    <eci>05</eci>
                  </threeds>
                </payment_response>";

            return new EntityMock<SingleReconcileSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<CardTransactionErrorResponse> CreateSale3dErrorResponse()
        {
            var errorResponse = new CardTransactionErrorResponse()
            {
                TransactionType = TransactionTypes.Sale3d,
                Status = TransactionStates.Error,
                ResponseCode = "57",
                UniqueId = "44177a21403427eb96664a6d7e5d5d48",
                TransactionId = "1196439228475036bc3a791",
                Code = ErrorCodes.InputDataInvalidError,
                TechnicalMessage = "’billing_address[zip_code]’ is invalid!",
                Message = "’billing_address[zip_code]’ is invalid!",
                Mode = "live",
                ProxyTime = "2007-11-30T16:13:50Z",
                Descriptor = "descriptor one",
                Amount = 10,
                Currency = Iso4217CurrencyCodes.USD,
                SentToAcquirer = false
            };

            var errorResponseXml =
                                  "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                  "<payment_response>" +
                                  "<transaction_type>sale3d</transaction_type>" +
                                  "<status>error</status>" +
                                  "<response_code>57</response_code>" +
                                  "<unique_id>44177a21403427eb96664a6d7e5d5d48</unique_id>" +
                                  "<transaction_id>1196439228475036bc3a791</transaction_id>" +
                                  "<code>340</code>" +
                                  "<technical_message>’billing_address[zip_code]’ is invalid!</technical_message>" +
                                  "<message>’billing_address[zip_code]’ is invalid!</message>" +
                                  "<mode>live</mode>" +
                                  "<timestamp>2007-11-30T16:13:50Z</timestamp>" +
                                  "<descriptor>descriptor one</descriptor>" +
                                  "<amount>1000</amount>" +
                                  "<currency>USD</currency>" +
                                  "<sent_to_acquirer>false</sent_to_acquirer>" +
                                  "</payment_response>";

            return new EntityMock<CardTransactionErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<CardTransactionSuccessResponse> CreateAuthorizeSuccessResponse(bool setCode = false)
        {
            var successResponse = new CardTransactionSuccessResponse()
            {
                TransactionType = TransactionTypes.Authorize,
                Status = TransactionStates.Approved,
                AuthorizationCode = "345678",
                ResponseCode = "00",
                UniqueId = "011e8d5cc1a56058cc50440c264f5063",
                TransactionId = "43671",
                TechnicalMessage = "Transaction successful!",
                Message = "Transaction successful!",
                Descriptor = "Descriptor One",
                Mode = "live",
                ProxyTime = "2007-08-30T17:46:11Z",
                Amount = 50,
                Currency = Iso4217CurrencyCodes.USD,
                SentToAcquirer = true,
                PartialApproval = true
            };
            if (setCode)
            {
                successResponse.Code = 0;
            }

            var successResponseXml =
                                    "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                    "<payment_response>" +
                                    "<transaction_type>authorize</transaction_type>" +
                                    "<status>approved</status>" +
                                    "<authorization_code>345678</authorization_code>" +
                                    "<response_code>00</response_code>" +
                                    "<unique_id>011e8d5cc1a56058cc50440c264f5063</unique_id>" +
                                    "<transaction_id>43671</transaction_id>";
            if (setCode)
            {
                successResponseXml += "<code>0</code>";
            }
            successResponseXml +=
                                 "<technical_message>Transaction successful!</technical_message>" +
                                 "<message>Transaction successful!</message>" +
                                 "<mode>live</mode>" +
                                 "<timestamp>2007-08-30T17:46:11Z</timestamp>" +
                                 "<descriptor>Descriptor One</descriptor>" +
                                 "<amount>5000</amount>" +
                                 "<currency>USD</currency>" +
                                 "<sent_to_acquirer>true</sent_to_acquirer>" +
                                 "<partial_approval>true</partial_approval>" +
                                 "</payment_response>";

            return new EntityMock<CardTransactionSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<CardTransactionErrorResponse> CreateAuthorizeErrorResponse()
        {
            var errorResponse = new CardTransactionErrorResponse()
            {
                TransactionType = TransactionTypes.Authorize,
                Status = TransactionStates.Error,
                ResponseCode = "57",
                UniqueId = "011e8d5cc1a56058cc50440c264f5063",
                TransactionId = "43671",
                Code = ErrorCodes.InputDataInvalidError,
                TechnicalMessage = "’expiration_year’ is invalid",
                Message = "’expiration_year’ is invalid",
                Mode = "live",
                ProxyTime = "2007-08-30T17:46:11Z",
                Descriptor = "Descriptor One",
                Amount = 50,
                Currency = Iso4217CurrencyCodes.USD,
                SentToAcquirer = false
            };

            var errorResponseXml =
                                  "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                  "<payment_response>" +
                                  "<transaction_type>authorize</transaction_type>" +
                                  "<status>error</status>" +
                                  "<response_code>57</response_code>" +
                                  "<unique_id>011e8d5cc1a56058cc50440c264f5063</unique_id>" +
                                  "<transaction_id>43671</transaction_id>" +
                                  "<code>340</code>" +
                                  "<technical_message>’expiration_year’ is invalid</technical_message>" +
                                  "<message>’expiration_year’ is invalid</message>" +
                                  "<mode>live</mode>" +
                                  "<timestamp>2007-08-30T17:46:11Z</timestamp>" +
                                  "<descriptor>Descriptor One</descriptor>" +
                                  "<amount>5000</amount>" +
                                  "<currency>USD</currency>" +
                                  "</payment_response>";

            return new EntityMock<CardTransactionErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<AvsSuccessResponse> CreateAvsSuccessResponse()
        {
            var successResponse = new AvsSuccessResponse()
            {
                TransactionType = TransactionTypes.Avs,
                AvsResponseCode = "5I",
                AvsResponseText = "Response provided by issuer processor; Address information not verified.",
                AuthorizationCode = "345678",
                Descriptor = "descriptor one",
                Status = TransactionStates.Approved,
                ResponseCode = "83",
                UniqueId = "5e2cbbad71d2b13432323153c208223a",
                TransactionId = "119643250547501c79d8295",
                Mode = "live",
                ProxyTime = "2007-11-30T14:21:48Z",
                SentToAcquirer = true
            };

            var successResponseXml =
                                    "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                    "<payment_response>" +
                                    "<transaction_type>avs</transaction_type>" +
                                    "<status>approved</status>" +
                                    "<avs_response_code>5I</avs_response_code>" +
                                    "<avs_response_text>Response provided by issuer processor; Address information not verified.</avs_response_text>" +
                                    "<authorization_code>345678</authorization_code>" +
                                    "<response_code>83</response_code>" +
                                    "<unique_id>5e2cbbad71d2b13432323153c208223a</unique_id>" +
                                    "<transaction_id>119643250547501c79d8295</transaction_id>" +
                                    "<mode>live</mode>" +
                                    "<timestamp>2007-11-30T14:21:48Z</timestamp>" +
                                    "<descriptor>descriptor one</descriptor>" +
                                    "<sent_to_acquirer>true</sent_to_acquirer>" +
                                    "</payment_response>";

            return new EntityMock<AvsSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<AvsErrorResponse> CreateAvsErrorResponse()
        {
            var errorResponse = new AvsErrorResponse()
            {
                TransactionType = TransactionTypes.Avs,
                Status = TransactionStates.Error,
                ResponseCode = "57",
                UniqueId = "44177a21403427eb96664a6d7e5d5d48",
                TransactionId = "1196439228475036bc3a791",
                Code = ErrorCodes.InputDataInvalidError,
                TechnicalMessage = "’billing_address[zip_code]’ is invalid!",
                Message = "’billing_address[zip_code]’ is invalid!",
                Mode = "live",
                ProxyTime = "2007-11-30T16:13:50Z",
                Descriptor = "descriptor one",
                SentToAcquirer = false
            };

            var errorResponseXml =
                                  "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                  "<payment_response>" +
                                  "<transaction_type>avs</transaction_type>" +
                                  "<status>error</status>" +
                                  "<response_code>57</response_code>" +
                                  "<unique_id>44177a21403427eb96664a6d7e5d5d48</unique_id>" +
                                  "<transaction_id>1196439228475036bc3a791</transaction_id>" +
                                  "<code>340</code>" +
                                  "<technical_message>’billing_address[zip_code]’ is invalid!</technical_message>" +
                                  "<message>’billing_address[zip_code]’ is invalid!</message>" +
                                  "<mode>live</mode>" +
                                  "<timestamp>2007-11-30T16:13:50Z</timestamp>" +
                                  "<descriptor>descriptor one</descriptor>" +
                                  "<sent_to_acquirer>false</sent_to_acquirer>" +
                                  "</payment_response>";

            return new EntityMock<AvsErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<GooglePaySuccessResponse> CreateGooglePaySuccessResponse()
        {
            var successResponse = new GooglePaySuccessResponse()
            {
                TransactionType = TransactionTypes.GooglePay,
                AvsResponseCode = "5I",
                AvsResponseText = "Response provided by issuer processor; Address information not verified.",
                AuthorizationCode = "345678",
                Descriptor = "descriptor one",
                Status = TransactionStates.Approved,
                ResponseCode = "83",
                UniqueId = "5e2cbbad71d2b13432323153c208223a",
                TransactionId = "119643250547501c79d8295",
                Mode = "live",
                ProxyTime = "2007-11-30T14:21:48Z",
                SentToAcquirer = true,
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                ConsumerId = "123456",
            };

            var successResponseXml =
                                    "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                    "<payment_response>" +
                                    "<transaction_type>google_pay</transaction_type>" +
                                    "<status>approved</status>" +
                                    "<avs_response_code>5I</avs_response_code>" +
                                    "<avs_response_text>Response provided by issuer processor; Address information not verified.</avs_response_text>" +
                                    "<authorization_code>345678</authorization_code>" +
                                    "<response_code>83</response_code>" +
                                    "<unique_id>5e2cbbad71d2b13432323153c208223a</unique_id>" +
                                    "<transaction_id>119643250547501c79d8295</transaction_id>" +
                                    "<mode>live</mode>" +
                                    "<timestamp>2007-11-30T14:21:48Z</timestamp>" +
                                    "<descriptor>descriptor one</descriptor>" +
                                    "<sent_to_acquirer>true</sent_to_acquirer>" +
                                    "<consumer_id>123456</consumer_id>" +
                                    "<amount>100</amount>" +
                                    "<currency>USD</currency>" +
                                    "</payment_response>";

            return new EntityMock<GooglePaySuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<GooglePayErrorResponse> CreateGooglePayErrorResponse()
        {
            var errorResponse = new GooglePayErrorResponse()
            {
                TransactionType = TransactionTypes.GooglePay,
                Status = TransactionStates.Error,
                UniqueId = "44177a21403427eb96664a6d7e5d5d48",
                TransactionId = "1196439228475036bc3a791",
                Code = ErrorCodes.InputDataInvalidError,
                TechnicalMessage = "expiration_year is invalid",
                Message = "expiration_year is invalid",
                Mode = "live",
                ProxyTime = "2007-11-30T16:13:50Z",
                Descriptor = "descriptor one",
                SentToAcquirer = false,
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
            };

            var errorResponseXml =
                                  "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                  "<payment_response>" +
                                  "<transaction_type>google_pay</transaction_type>" +
                                  "<status>error</status>" +
                                  "<response_code>57</response_code>" +
                                  "<unique_id>44177a21403427eb96664a6d7e5d5d48</unique_id>" +
                                  "<transaction_id>1196439228475036bc3a791</transaction_id>" +
                                  "<code>340</code>" +
                                  "<technical_message>expiration_year is invalid</technical_message>" +
                                  "<message>expiration_year is invalid</message>" +
                                  "<mode>live</mode>" +
                                  "<timestamp>2007-11-30T16:13:50Z</timestamp>" +
                                  "<descriptor>descriptor one</descriptor>" +
                                  "<sent_to_acquirer>false</sent_to_acquirer>" +
                                  "<amount>100</amount>" +
                                  "<currency>USD</currency>" +
                                  "</payment_response>";

            return new EntityMock<GooglePayErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<ApplePaySuccessResponse> CreateApplePaySuccessResponse()
        {
            var successResponse = new ApplePaySuccessResponse()
            {
                TransactionType = TransactionTypes.ApplePay,
                AvsResponseCode = "5I",
                AvsResponseText = "Response provided by issuer processor; Address information not verified.",
                AuthorizationCode = "345678",
                Descriptor = "descriptor one",
                Status = TransactionStates.Approved,
                ResponseCode = "83",
                UniqueId = "5e2cbbad71d2b13432323153c208223a",
                TransactionId = "119643250547501c79d8295",
                Mode = "live",
                ProxyTime = "2007-11-30T14:21:48Z",
                SentToAcquirer = true,
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                ConsumerId = "123456",
            };

            var successResponseXml =
                                    "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                    "<payment_response>" +
                                    "<transaction_type>apple_pay</transaction_type>" +
                                    "<status>approved</status>" +
                                    "<avs_response_code>5I</avs_response_code>" +
                                    "<avs_response_text>Response provided by issuer processor; Address information not verified.</avs_response_text>" +
                                    "<authorization_code>345678</authorization_code>" +
                                    "<response_code>83</response_code>" +
                                    "<unique_id>5e2cbbad71d2b13432323153c208223a</unique_id>" +
                                    "<transaction_id>119643250547501c79d8295</transaction_id>" +
                                    "<mode>live</mode>" +
                                    "<timestamp>2007-11-30T14:21:48Z</timestamp>" +
                                    "<descriptor>descriptor one</descriptor>" +
                                    "<sent_to_acquirer>true</sent_to_acquirer>" +
                                    "<consumer_id>123456</consumer_id>" +
                                    "<amount>100</amount>" +
                                    "<currency>USD</currency>" +
                                    "</payment_response>";

            return new EntityMock<ApplePaySuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<ApplePayErrorResponse> CreateApplePayErrorResponse()
        {
            var errorResponse = new ApplePayErrorResponse()
            {
                TransactionType = TransactionTypes.ApplePay,
                Status = TransactionStates.Error,
                UniqueId = "44177a21403427eb96664a6d7e5d5d48",
                TransactionId = "1196439228475036bc3a791",
                Code = ErrorCodes.InputDataInvalidError,
                TechnicalMessage = "expiration_year is invalid",
                Message = "expiration_year is invalid",
                Mode = "live",
                ProxyTime = "2007-11-30T16:13:50Z",
                Descriptor = "descriptor one",
                SentToAcquirer = false,
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
            };

            var errorResponseXml =
                                  "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                  "<payment_response>" +
                                  "<transaction_type>apple_pay</transaction_type>" +
                                  "<status>error</status>" +
                                  "<response_code>57</response_code>" +
                                  "<unique_id>44177a21403427eb96664a6d7e5d5d48</unique_id>" +
                                  "<transaction_id>1196439228475036bc3a791</transaction_id>" +
                                  "<code>340</code>" +
                                  "<technical_message>expiration_year is invalid</technical_message>" +
                                  "<message>expiration_year is invalid</message>" +
                                  "<mode>live</mode>" +
                                  "<timestamp>2007-11-30T16:13:50Z</timestamp>" +
                                  "<descriptor>descriptor one</descriptor>" +
                                  "<sent_to_acquirer>false</sent_to_acquirer>" +
                                  "<amount>100</amount>" +
                                  "<currency>USD</currency>" +
                                  "</payment_response>";

            return new EntityMock<ApplePayErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<CardTransactionSuccessResponse> CreateInitRecurringSaleSuccessResponse()
        {
            var successResponse = new CardTransactionSuccessResponse()
            {
                TransactionType = TransactionTypes.InitRecurringSale,
                Status = TransactionStates.Approved,
                AuthorizationCode = "345678",
                ResponseCode = "00",
                RecurringAdviceCode = "WW",
                RecurringAdviceText = "Fake code",
                UniqueId = "5e2cbbad71d2b13432323153c208223a",
                TransactionId = "119643250547501c79d8295",
                Amount = 90,
                Currency = Iso4217CurrencyCodes.USD,
                Descriptor = "descriptor one",
                Mode = "live",
                ProxyTime = "2007-11-30T14:21:48Z",
                SentToAcquirer = true,
                PartialApproval = true,
            };

            var successResponseXml =
                                    "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                    "<payment_response>" +
                                    "<transaction_type>init_recurring_sale</transaction_type>" +
                                    "<status>approved</status>" +
                                    "<authorization_code>345678</authorization_code>" +
                                    "<response_code>00</response_code>" +
                                    "<unique_id>5e2cbbad71d2b13432323153c208223a</unique_id>" +
                                    "<transaction_id>119643250547501c79d8295</transaction_id>" +
                                    "<recurring_advice_code>WW</recurring_advice_code>" +
                                    "<recurring_advice_text>Fake code</recurring_advice_text>" +
                                    "<mode>live</mode>" +
                                    "<timestamp>2007-11-30T14:21:48Z</timestamp>" +
                                    "<descriptor>descriptor one</descriptor>" +
                                    "<amount>9000</amount>" +
                                    "<currency>USD</currency>" +
                                    "<sent_to_acquirer>true</sent_to_acquirer>" +
                                    "<partial_approval>true</partial_approval>" +
                                    "</payment_response>";

            return new EntityMock<CardTransactionSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<CardTransactionErrorResponse> CreateInitRecurringSaleErrorResponse()
        {
            var errorResponse = new CardTransactionErrorResponse()
            {
                TransactionType = TransactionTypes.InitRecurringSale,
                Status = TransactionStates.Error,
                UniqueId = "d0231d21e0e50afbba1909eadc2f2d6b",
                TransactionId = "345345",
                Code = ErrorCodes.InputDataInvalidError,
                TechnicalMessage = "'billing_address[country]' is invalid!",
                Message = "Please check input data for errors!",
                Mode = "test",
                ProxyTime = "2014-11-18T16:18:39Z",
                Descriptor = "Testing MID",
                Amount = 100,
                Currency = Iso4217CurrencyCodes.USD,
                SentToAcquirer = false
            };

            var errorResponseXml =
                                  "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                  "<payment_response>" +
                                  "<transaction_type>init_recurring_sale</transaction_type>" +
                                  "<status>error</status>" +
                                  "<unique_id>d0231d21e0e50afbba1909eadc2f2d6b</unique_id>" +
                                  "<transaction_id>345345</transaction_id>" +
                                  "<code>340</code>" +
                                  "<technical_message>'billing_address[country]' is invalid!</technical_message>" +
                                  "<message>Please check input data for errors!</message>" +
                                  "<mode>test</mode>" +
                                  "<timestamp>2014-11-18T16:18:39Z</timestamp>" +
                                  "<descriptor>Testing MID</descriptor>" +
                                  "<amount>10000</amount>" +
                                  "<currency>USD</currency>" +
                                  "<sent_to_acquirer>false</sent_to_acquirer>" +
                                  "</payment_response>";

            return new EntityMock<CardTransactionErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<PayoutSuccessResponse> CreatePayoutSuccessResponse()
        {
            var successResponse = new PayoutSuccessResponse()
            {
                TransactionType = TransactionTypes.Credit,
                Status = TransactionStates.Approved,
                AuthorizationCode = "345678",
                ResponseCode = "00",
                UniqueId = "5e2cbbad71d2b13432323153c208223a",
                TransactionId = "119643250547501c79d8295",
                Mode = "live",
                ProxyTime = "2007-11-30T14:21:48Z",
                Descriptor = "descriptor one",
                Amount = 90,
                Currency = Common.Iso4217CurrencyCodes.USD,
                SentToAcquirer = true
            };

            var successResponseXml =
                                    "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                    "<payment_response>" +
                                    "<transaction_type>credit</transaction_type>" +
                                    "<status>approved</status>" +
                                    "<authorization_code>345678</authorization_code>" +
                                    "<response_code>00</response_code>" +
                                    "<unique_id>5e2cbbad71d2b13432323153c208223a</unique_id>" +
                                    "<transaction_id>119643250547501c79d8295</transaction_id>" +
                                    "<mode>live</mode>" +
                                    "<timestamp>2007-11-30T14:21:48Z</timestamp>" +
                                    "<descriptor>descriptor one</descriptor>" +
                                    "<amount>9000</amount>" +
                                    "<currency>USD</currency>" +
                                    "<sent_to_acquirer>true</sent_to_acquirer>" +
                                    "</payment_response>";

            return new EntityMock<PayoutSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<PayoutErrorResponse> CreatePayoutErrorResponse()
        {
            var errorResponse = new PayoutErrorResponse()
            {
                TransactionType = TransactionTypes.Credit,
                Status = TransactionStates.Error,
                ResponseCode = "57",
                UniqueId = "44177a21403427eb96664a6d7e5d5d48",
                TransactionId = "1196439228475036bc3a791",
                Code = ErrorCodes.InputDataInvalidError,
                TechnicalMessage = "’billing_address[zip_code]’ is invalid!",
                Message = "’billing_address[zip_code]’ is invalid!",
                Mode = "live",
                ProxyTime = "2007-11-30T16:13:50Z",
                Descriptor = "descriptor one",
                Amount = 90,
                Currency = Iso4217CurrencyCodes.USD,
                SentToAcquirer = false
            };

            var errorResponseXml =
                                  "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                  "<payment_response>" +
                                  "<transaction_type>credit</transaction_type>" +
                                  "<status>error</status>" +
                                  "<response_code>57</response_code>" +
                                  "<unique_id>44177a21403427eb96664a6d7e5d5d48</unique_id>" +
                                  "<transaction_id>1196439228475036bc3a791</transaction_id>" +
                                  "<code>340</code>" +
                                  "<technical_message>’billing_address[zip_code]’ is invalid!</technical_message>" +
                                  "<message>’billing_address[zip_code]’ is invalid!</message>" +
                                  "<mode>live</mode>" +
                                  "<timestamp>2007-11-30T16:13:50Z</timestamp>" +
                                  "<descriptor>descriptor one</descriptor>" +
                                  "<amount>9000</amount>" +
                                  "<currency>USD</currency>" +
                                  "<sent_to_acquirer>false</sent_to_acquirer>" +
                                  "</payment_response>";

            return new EntityMock<PayoutErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<CardTransactionSuccessResponse> CreateSaleSuccessResponse()
        {
            var successResponse = new CardTransactionSuccessResponse()
            {
                TransactionType = TransactionTypes.Sale,
                Amount = 90,
                Currency = Common.Iso4217CurrencyCodes.USD,
                AuthorizationCode = "345678",
                Descriptor = "descriptor one",
                Status = TransactionStates.Approved,
                ResponseCode = "00",
                UniqueId = "5e2cbbad71d2b13432323153c208223a",
                TransactionId = "119643250547501c79d8295",
                Mode = "live",
                ProxyTime = "2007-11-30T14:21:48Z",
                SentToAcquirer = true,
                PartialApproval = true
            };

            var successResponseXml =
                                    "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                    "<payment_response>" +
                                    "<transaction_type>sale</transaction_type>" +
                                    "<status>approved</status>" +
                                    "<authorization_code>345678</authorization_code>" +
                                    "<response_code>00</response_code>" +
                                    "<unique_id>5e2cbbad71d2b13432323153c208223a</unique_id>" +
                                    "<transaction_id>119643250547501c79d8295</transaction_id>" +
                                    "<mode>live</mode>" +
                                    "<timestamp>2007-11-30T14:21:48Z</timestamp>" +
                                    "<descriptor>descriptor one</descriptor>" +
                                    "<amount>9000</amount>" +
                                    "<currency>USD</currency>" +
                                    "<sent_to_acquirer>true</sent_to_acquirer>" +
                                    "<partial_approval>true</partial_approval>" +
                                    "</payment_response>";

            return new EntityMock<CardTransactionSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<CardTransactionErrorResponse> CreateSaleErrorResponse()
        {
            var errorResponse = new CardTransactionErrorResponse()
            {
                TransactionType = TransactionTypes.Sale,
                Status = TransactionStates.Error,
                UniqueId = "84b6f1c7b89b847ad0ce9035475868da",
                TransactionId = "10",
                Code = ErrorCodes.InputDataFormatError,
                TechnicalMessage = "'card_holder' has invalid format",
                Message = "Please check input data for errors!",
                Mode = "test",
                ProxyTime = "2014-11-11T12:35:47Z",
                Descriptor = "Testing MID",
                Amount = 10,
                Currency = Iso4217CurrencyCodes.USD,
                SentToAcquirer = false
            };

            var errorResponseXml =
                                  "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                  "<payment_response>" +
                                  "<transaction_type>sale</transaction_type>" +
                                  "<status>error</status>" +
                                  "<unique_id>84b6f1c7b89b847ad0ce9035475868da</unique_id>" +
                                  "<transaction_id>10</transaction_id>" +
                                  "<code>330</code>" +
                                  "<technical_message>'card_holder' has invalid format</technical_message>" +
                                  "<message>Please check input data for errors!</message>" +
                                  "<mode>test</mode>" +
                                  "<timestamp>2014-11-11T12:35:47Z</timestamp>" +
                                  "<descriptor>Testing MID</descriptor>" +
                                  "<amount>1000</amount>" +
                                  "<currency>USD</currency>" +
                                  "<sent_to_acquirer>false</sent_to_acquirer>" +
                                  "</payment_response>";

            return new EntityMock<CardTransactionErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<WpfCreateSuccessResponse> CreateWpfCreateSuccessResponse()
        {
            var successResponse = new WpfCreateSuccessResponse()
            {
                Status = TransactionStates.Approved,
                UniqueId = "eabcb7a41044e764746b0c7e32c1e9d1",
                TransactionId = "wev238f328nc",
                TechnicalMessage = "TESTMODE: No real money will be transferred!",
                Message = "TESTMODE: No real money will be transferred!",
                Mode = "test",
                ProxyTime = "2011-04-19T15:00:11Z",
                Amount = 50,
                Currency = Iso4217CurrencyCodes.USD,
                RedirectUrl = "https://gateway/payment/step1/eabcb7a41044e764746b0c7e32c1e9d1"
            };

            var successResponseXml =
                                    "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                    "<wpf_payment>" +
                                    "<status>approved</status>" +
                                    "<unique_id>eabcb7a41044e764746b0c7e32c1e9d1</unique_id>" +
                                    "<transaction_id>wev238f328nc</transaction_id>" +
                                    "<technical_message>TESTMODE: No real money will be transferred!</technical_message>" +
                                    "<message>TESTMODE: No real money will be transferred!</message>" +
                                    "<mode>test</mode>" +
                                    "<timestamp>2011-04-19T15:00:11Z</timestamp>" +
                                    "<amount>5000</amount>" +
                                    "<currency>USD</currency>" +
                                    "<redirect_url>https://gateway/payment/step1/eabcb7a41044e764746b0c7e32c1e9d1</redirect_url>" +
                                    "</wpf_payment>";

            return new EntityMock<WpfCreateSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<WpfCreateErrorResponse> CreateWpfCreateErrorResponse()
        {
            var errorResponse = new WpfCreateErrorResponse()
            {
                Status = TransactionStates.Error,
                Code = ErrorCodes.SystemError,
                TechnicalMessage = "Unknown system error. Please contact support.",
                Message = "Transaction failed, please contact support!"
            };

            var errorResponseXml =
                                  "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                  "<wpf_payment>" +
                                  "<status>error</status>" +
                                  "<code>100</code>" +
                                  "<technical_message>Unknown system error. Please contact support.</technical_message>" +
                                  "<message>Transaction failed, please contact support!</message>" +
                                  "</wpf_payment>";

            return new EntityMock<WpfCreateErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<BlacklistSuccessResponse> CreateBlacklistSuccessResponse()
        {
            var successResponse = new BlacklistSuccessResponse()
            {
                Blacklisted = true
            };

            var successResponseXml =
                                    "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                    "<blacklist_response>" +
                                    "<blacklisted>true</blacklisted>" +
                                    "</blacklist_response>";

            return new EntityMock<BlacklistSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<BlacklistErrorResponse> CreateBlacklistErrorResponse()
        {
            var errorResponse = new BlacklistErrorResponse()
            {
                Code = ErrorCodes.InvalidXmlError,
                Message = "Invalid XML: No close tag for /blacklist_request"
            };

            var errorResponseXml =
                                  "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                  "<blacklist_response>" +
                                  "<code>350</code>" +
                                  "<message>Invalid XML: No close tag for /blacklist_request</message>" +
                                  "</blacklist_response>";

            return new EntityMock<BlacklistErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<MultiChargebackSuccessResponse> CreateMultiChargebackSuccessResponse()
        {
            var successResponse = new MultiChargebackSuccessResponse()
            {
                ItemsPerPage = 100,
                PageNumber = 2,
                TotalCount = 19,
                PagesCount = 7,
                Chargebacks = new ChargebackResponse[]
                {
                    new ChargebackResponse()
                    {
                        Type = "1st chargeback ",
                        Arn = "74537604221431003881865",
                        ProxyPostDate = "2014-01-24",
                        ReasonCode = "4855",
                        ReasonDescription = "Non-receipt of merchandise",
                        AuthorizationCode = "811714",
                        Amount = 14625.0m,
                        Currency = Iso4217CurrencyCodes.USD,
                        CardNumber = "554960******5069",
                        CardBrand = "master",
                        CustomerEmail = "emil@example.com",
                        CustomerPhone = "3598851248512",
                        TransactionType = TransactionTypes.Sale3d,
                        OriginalTransactionUniqueId = "f9634ec5e7dbe6ca3871974accb875cd"
                    },
                    new ChargebackResponse()
                    {
                        Type = "2nd chargeback ",
                        Arn = "74537604221431003881862",
                        ProxyPostDate = "2014-01-27",
                        ReasonCode = "3456",
                        ReasonDescription = "Credit not processed",
                        AuthorizationCode = "123456",
                        Amount = 34.56m,
                        Currency = Iso4217CurrencyCodes.EUR,
                        CardNumber = "454360******5008",
                        CardBrand = "visa",
                        CustomerEmail = "emil@example.com",
                        CustomerPhone = "3598851248123",
                        TransactionType = TransactionTypes.Sale,
                        OriginalTransactionUniqueId = "67fbebc172b743a164a3f3af3d010457"
                    }
                }
            };

            var successResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                     "<chargeback_responses per_page=\"100\" page=\"2\" total_count=\"19\" pages_count=\"7\">" +
                                     "<chargeback_response>" +
                                     "<type>1st chargeback </type>" +
                                     "<arn>74537604221431003881865</arn>" +
                                     "<post_date>2014-01-24</post_date>" +
                                     "<reason_code>4855</reason_code>" +
                                     "<reason_description>Non-receipt of merchandise</reason_description>" +
                                     "<authorization_code>811714</authorization_code>" +
                                     "<amount>14625.0</amount>" +
                                     "<currency>USD</currency>" +
                                     "<card_number>554960******5069</card_number>" +
                                     "<card_brand>master</card_brand>" +
                                     "<customer_email>emil@example.com</customer_email>" +
                                     "<customer_phone>3598851248512</customer_phone>" +
                                     "<transaction_type>sale3d</transaction_type>" +
                                     "<original_transaction_unique_id>f9634ec5e7dbe6ca3871974accb875cd</original_transaction_unique_id>" +
                                     "</chargeback_response>" +
                                     "<chargeback_response>" +
                                     "<type>2nd chargeback </type>" +
                                     "<arn>74537604221431003881862</arn>" +
                                     "<post_date>2014-01-27</post_date>" +
                                     "<reason_code>3456</reason_code>" +
                                     "<reason_description>Credit not processed</reason_description>" +
                                     "<authorization_code>123456</authorization_code>" +
                                     "<amount>3456</amount>" +
                                     "<currency>EUR</currency>" +
                                     "<card_number>454360******5008</card_number>" +
                                     "<card_brand>visa</card_brand>" +
                                     "<customer_email>emil@example.com</customer_email>" +
                                     "<customer_phone>3598851248123</customer_phone>" +
                                     "<transaction_type>sale</transaction_type>" +
                                     "<original_transaction_unique_id>67fbebc172b743a164a3f3af3d010457</original_transaction_unique_id>" +
                                     "</chargeback_response>" +
                                     "</chargeback_responses>";

            return new EntityMock<MultiChargebackSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<MultiChargebackErrorResponse> CreateMultiChargebackErrorResponse()
        {
            var errorResponse = new MultiChargebackErrorResponse()
            {
                TechnicalMessage = "start_date has an invalid format",
                Status = TransactionStates.Error,
                Message = "Please check input data for errors!",
                Code = ErrorCodes.InputDataInvalidError
            };

            var errorResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                   "<chargeback_response>" +
                                   "<status>error</status>" +
                                   "<message>Please check input data for errors!</message>" +
                                   "<code>340</code>" +
                                   "<technical_message>start_date has an invalid format</technical_message>" +
                                   "</chargeback_response>";

            return new EntityMock<MultiChargebackErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<MultiReconcileSuccessResponse> CreateMultiReconcileSuccessResponse()
        {
            var successResponse = new MultiReconcileSuccessResponse()
            {
                ItemsPerPage = 100,
                PageNumber = 2,
                TotalCount = 19,
                PagesCount = 7,
                Payments = new PaymentResponse[]
                {
                    new PaymentResponse()
                    {
                        TransactionType = TransactionTypes.Sale,
                        Status = TransactionStates.Approved,
                        AuthorizationCode = "005645",
                        ResponseCode = "00",
                        UniqueId = "130319cfb3bf65ff3c4a4045487b174f",
                        TransactionId = "EFBFBC7D-82CD-4375-9A69-15F19C88A134",
                        TechnicalMessage = "Transaction successful!",
                        Message = "Transaction successful!",
                        Mode = "live",
                        ProxyTime = "2014-01-05T15:04:00Z",
                        Descriptor = "descriptor one",
                        Amount = 5,
                        Currency = Iso4217CurrencyCodes.USD,
                        SentToAcquirer = true
                    },
                    new PaymentResponse()
                    {
                        TransactionType = TransactionTypes.Sale,
                        Status = TransactionStates.Approved,
                        AuthorizationCode = "638745",
                        ResponseCode = "00",
                        UniqueId = "130319cfb3bf65ff3c4a4045487b173f",
                        TransactionId = "BBD7945B-BE57-4A14-A7FB-47F7AE928D95",
                        TechnicalMessage = "Transaction successful!",
                        Message = "Transaction successful!",
                        Mode = "live",
                        ProxyTime = "2014-01-05T15:04:00Z",
                        Descriptor = "descriptor one",
                        Amount = 5,
                        Currency = Iso4217CurrencyCodes.USD,
                        SentToAcquirer = true
                    },
                    new PaymentResponse()
                    {
                        TransactionType = TransactionTypes.Sale,
                        Status = TransactionStates.Approved,
                        AuthorizationCode = "226534",
                        ResponseCode = "00",
                        UniqueId = "1e8a6f09253eb8b4f8c84c0d8803713e",
                        TransactionId = "_5041_2013041012_22_10_545",
                        TechnicalMessage = "Transaction successful!",
                        Message = "Transaction successful!",
                        Mode = "live",
                        ProxyTime = "2013-04-10T10:22:13Z",
                        Descriptor = "test_descriptor",
                        Amount = 504.22m,
                        Currency = Iso4217CurrencyCodes.EUR,
                        SentToAcquirer = true
                    }
                }
            };

            var successResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                     "<payment_responses per_page=\"100\" page=\"2\" total_count=\"19\" pages_count=\"7\">" +
                                     "<payment_response>" +
                                     "<transaction_type>sale</transaction_type>" +
                                     "<status>approved</status>" +
                                     "<authorization_code>005645</authorization_code>" +
                                     "<response_code>00</response_code>" +
                                     "<unique_id>130319cfb3bf65ff3c4a4045487b174f</unique_id>" +
                                     "<transaction_id>EFBFBC7D-82CD-4375-9A69-15F19C88A134</transaction_id>" +
                                     "<technical_message>Transaction successful!</technical_message>" +
                                     "<message>Transaction successful!</message>" +
                                     "<mode>live</mode>" +
                                     "<timestamp>2014-01-05T15:04:00Z</timestamp>" +
                                     "<descriptor>descriptor one</descriptor>" +
                                     "<amount>500</amount>" +
                                     "<currency>USD</currency>" +
                                     "<sent_to_acquirer>true</sent_to_acquirer>" +
                                     "</payment_response>" +
                                     "<payment_response>" +
                                     "<transaction_type>sale</transaction_type>" +
                                     "<status>approved</status>" +
                                     "<authorization_code>638745</authorization_code>" +
                                     "<response_code>00</response_code>" +
                                     "<unique_id>130319cfb3bf65ff3c4a4045487b173f</unique_id>" +
                                     "<transaction_id>BBD7945B-BE57-4A14-A7FB-47F7AE928D95</transaction_id>" +
                                     "<technical_message>Transaction successful!</technical_message>" +
                                     "<message>Transaction successful!</message>" +
                                     "<mode>live</mode>" +
                                     "<timestamp>2014-01-05T15:04:00Z</timestamp>" +
                                     "<descriptor>descriptor one</descriptor>" +
                                     "<amount>500</amount>" +
                                     "<currency>USD</currency>" +
                                     "<sent_to_acquirer>true</sent_to_acquirer>" +
                                     "</payment_response>" +
                                     "<payment_response>" +
                                     "<transaction_type>sale</transaction_type>" +
                                     "<status>approved</status>" +
                                     "<authorization_code>226534</authorization_code>" +
                                     "<response_code>00</response_code>" +
                                     "<unique_id>1e8a6f09253eb8b4f8c84c0d8803713e</unique_id>" +
                                     "<transaction_id>_5041_2013041012_22_10_545</transaction_id>" +
                                     "<technical_message>Transaction successful!</technical_message>" +
                                     "<message>Transaction successful!</message>" +
                                     "<mode>live</mode>" +
                                     "<timestamp>2013-04-10T10:22:13Z</timestamp>" +
                                     "<descriptor>test_descriptor</descriptor>" +
                                     "<amount>50422</amount>" +
                                     "<currency>EUR</currency>" +
                                     "<sent_to_acquirer>true</sent_to_acquirer>" +
                                     "</payment_response>" +
                                     "</payment_responses>";

            return new EntityMock<MultiReconcileSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<MultiReconcileErrorResponse> CreateMultiReconcileErrorResponse()
        {
            var errorResponse = new MultiReconcileErrorResponse()
            {
                TechnicalMessage = "start_date has an invalid format",
                Status = TransactionStates.Error,
                Message = "Please check input data for errors!",
                Code = ErrorCodes.InputDataInvalidError
            };

            var errorResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                   "<payment_response>" +
                                   "<status>error</status>" +
                                   "<message>Please check input data for errors!</message>" +
                                   "<code>340</code>" +
                                   "<technical_message>start_date has an invalid format</technical_message>" +
                                   "</payment_response>";

            return new EntityMock<MultiReconcileErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<MultiRetrievalRequestSuccessResponse> CreateMultiRetrievalRequestSuccessResponse()
        {
            var successResponse = new MultiRetrievalRequestSuccessResponse()
            {
                ItemsPerPage = 100,
                PageNumber = 2,
                TotalCount = 19,
                PagesCount = 7,
                Retrievals = new RetrievalResponse[]
                {
                    new RetrievalResponse()
                    {
                        Type = "Retrieval request",
                        Arn = "74537604221431003881865",
                        ProxyPostDate = "2014-01-24",
                        ReasonCode = "42",
                        ReasonDescription = "Potential Chargeback",
                        AuthorizationCode = "811714",
                        CardNumber = "554960******5069",
                        CardBrand = "master",
                        CustomerEmail = "emil@example.com",
                        CustomerPhone = "3598851248512",
                        TransactionType = TransactionTypes.Sale3d,
                        OriginalTransactionUniqueId = "f9634ec5e7dbe6ca3871974accb875cd"
                    },
                    new RetrievalResponse()
                    {
                        Type = "Retrieval request",
                        Arn = "74537604221431003881862",
                        ProxyPostDate = "2014-01-27",
                        ReasonCode = "42",
                        ReasonDescription = "Potential Chargeback",
                        AuthorizationCode = "123456",
                        CardNumber = "454360******5008",
                        CardBrand = "visa",
                        CustomerEmail = "emil@example.com",
                        CustomerPhone = "3598851248123",
                        TransactionType = TransactionTypes.Sale,
                        OriginalTransactionUniqueId = "67fbebc172b743a164a3f3af3d010457"
                    }
                }
            };

            var successResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                     "<retrieval_request_responses per_page=\"100\" page=\"2\" total_count=\"19\" pages_count=\"7\">" +
                                     "<retrieval_request_response>" +
                                     "<type>Retrieval request</type>" +
                                     "<arn>74537604221431003881865</arn>" +
                                     "<post_date>2014-01-24</post_date>" +
                                     "<reason_code>42</reason_code>" +
                                     "<reason_description>Potential Chargeback</reason_description>" +
                                     "<authorization_code>811714</authorization_code>" +
                                     "<card_number>554960******5069</card_number>" +
                                     "<card_brand>master</card_brand>" +
                                     "<customer_email>emil@example.com</customer_email>" +
                                     "<customer_phone>3598851248512</customer_phone>" +
                                     "<transaction_type>sale3d</transaction_type>" +
                                     "<original_transaction_unique_id>f9634ec5e7dbe6ca3871974accb875cd</original_transaction_unique_id>" +
                                     "</retrieval_request_response>" +
                                     "<retrieval_request_response>" +
                                     "<type>Retrieval request</type>" +
                                     "<arn>74537604221431003881862</arn>" +
                                     "<post_date>2014-01-27</post_date>" +
                                     "<reason_code>42</reason_code>" +
                                     "<reason_description>Potential Chargeback</reason_description>" +
                                     "<authorization_code>123456</authorization_code>" +
                                     "<card_number>454360******5008</card_number>" +
                                     "<card_brand>visa</card_brand>" +
                                     "<customer_email>emil@example.com</customer_email>" +
                                     "<customer_phone>3598851248123</customer_phone>" +
                                     "<transaction_type>sale</transaction_type>" +
                                     "<original_transaction_unique_id>67fbebc172b743a164a3f3af3d010457</original_transaction_unique_id>" +
                                     "</retrieval_request_response>" +
                                     "</retrieval_request_responses>";

            return new EntityMock<MultiRetrievalRequestSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<MultiRetrievalRequestErrorResponse> CreateMultiRetrievalRequestErrorResponse()
        {
            var errorResponse = new MultiRetrievalRequestErrorResponse()
            {
                TechnicalMessage = "start_date has an invalid format",
                Status = TransactionStates.Error,
                Message = "Please check input data for errors!",
                Code = ErrorCodes.InputDataInvalidError
            };

            var errorResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                   "<retrieval_request_response>" +
                                   "<status>error</status>" +
                                   "<message>Please check input data for errors!</message>" +
                                   "<code>340</code>" +
                                   "<technical_message>start_date has an invalid format</technical_message>" +
                                   "</retrieval_request_response>";

            return new EntityMock<MultiRetrievalRequestErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<SingleChargebackSuccessResponse> CreateSingleChargebackSuccessResponse()
        {
            var successResponse = new SingleChargebackSuccessResponse()
            {
                Type = "1st chargeback ",
                Arn = "74537604221431003881865",
                ProxyPostDate = "2014-01-24",
                ReasonCode = "4855",
                ReasonDescription = "Non-receipt of merchandise",
                AuthorizationCode = "811714",
                Amount = 14625.5m,
                Currency = Iso4217CurrencyCodes.CLF,
                CardNumber = "554960******5069",
                CardBrand = "master",
                CustomerEmail = "emil@example.com",
                CustomerPhone = "3598851248512",
                TransactionType = TransactionTypes.Sale3d,
                OriginalTransactionUniqueId = "f9634ec5e7dbe6ca3871974accb875cd"
            };

            var successResponseXml =
                                    "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                    "<chargeback_response>" +
                                    "<type>1st chargeback </type>" +
                                    "<arn>74537604221431003881865</arn>" +
                                    "<post_date>2014-01-24</post_date>" +
                                    "<reason_code>4855</reason_code>" +
                                    "<reason_description>Non-receipt of merchandise</reason_description>" +
                                    "<authorization_code>811714</authorization_code>" +
                                    "<amount>14625.5</amount>" +
                                    "<currency>CLF</currency>" +
                                    "<card_number>554960******5069</card_number>" +
                                    "<card_brand>master</card_brand>" +
                                    "<customer_email>emil@example.com</customer_email>" +
                                    "<customer_phone>3598851248512</customer_phone>" +
                                    "<transaction_type>sale3d</transaction_type>" +
                                    "<original_transaction_unique_id>f9634ec5e7dbe6ca3871974accb875cd</original_transaction_unique_id>" +
                                    "</chargeback_response>";

            return new EntityMock<SingleChargebackSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<SingleChargebackErrorResponse> CreateSingleChargebackErrorResponse()
        {
            var errorResponse = new SingleChargebackErrorResponse()
            {
                TechnicalMessage = "Chargeback by the given criteria cannot be found!",
                Status = TransactionStates.Error,
                Message = "Chargeback not found!",
                Code = ErrorCodes.ChargebackNotFoundError
            };

            var errorResponseXml =
                                  "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                  "<chargeback_response>" +
                                  "<technical_message>Chargeback by the given criteria cannot be found!</technical_message>" +
                                  "<status>error</status>" +
                                  "<message>Chargeback not found!</message>" +
                                  "<code>470</code>" +
                                  "</chargeback_response>";

            return new EntityMock<SingleChargebackErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<SingleReconcileSuccessResponse> CreateSingleReconcileSuccessResponse()
        {
            var successResponse = new SingleReconcileSuccessResponse()
            {
                TransactionType = TransactionTypes.Sale,
                Status = TransactionStates.Approved,
                AuthorizationCode = "005645",
                ResponseCode = "00",
                UniqueId = "44177a21403427eb96664a6d7e5d5d48",
                TransactionId = "119643250547501c79d8295",
                Mode = "live",
                ProxyTime = "2014-01-30T14:21:48Z",
                Descriptor = "descriptor one",
                Amount = 90,
                Currency = Iso4217CurrencyCodes.USD,
                SentToAcquirer = true
            };

            var successResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                     "<payment_response>" +
                                     "<transaction_type>sale</transaction_type>" +
                                     "<status>approved</status>" +
                                     "<authorization_code>005645</authorization_code>" +
                                     "<response_code>00</response_code>" +
                                     "<unique_id>44177a21403427eb96664a6d7e5d5d48</unique_id>" +
                                     "<transaction_id>119643250547501c79d8295</transaction_id>" +
                                     "<mode>live</mode>" +
                                     "<timestamp>2014-01-30T14:21:48Z</timestamp>" +
                                     "<descriptor>descriptor one</descriptor>" +
                                     "<amount>9000</amount>" +
                                     "<currency>USD</currency>" +
                                     "<sent_to_acquirer>true</sent_to_acquirer>" +
                                     "</payment_response>";

            return new EntityMock<SingleReconcileSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<SingleReconcileSuccessResponse> CreateSingleReconcileSuccessResponseWithUndefinedCountry()
        {
            var successResponse = new SingleReconcileSuccessResponse()
            {
                TransactionType = TransactionTypes.Sale,
                Status = TransactionStates.Approved,
                AuthorizationCode = "005645",
                ResponseCode = "00",
                UniqueId = "44177a21403427eb96664a6d7e5d5d48",
                TransactionId = "119643250547501c79d8295",
                Mode = "live",
                ProxyTime = "2014-01-30T14:21:48Z",
                Descriptor = "descriptor one",
                Amount = 90,
                Currency = Iso4217CurrencyCodes.USD,
                SentToAcquirer = true,
                BillingAddress = new Address()
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Address1 = "32, Doestreet",
                    Address2 = "",
                    ZipCode = "12345",
                    City = "New York",
                    State = "NY",
                    Country = Iso3166CountryCodes.Undefined
                }
            };

            var successResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                     "<payment_response>" +
                                     "<transaction_type>sale</transaction_type>" +
                                     "<status>approved</status>" +
                                     "<authorization_code>005645</authorization_code>" +
                                     "<response_code>00</response_code>" +
                                     "<unique_id>44177a21403427eb96664a6d7e5d5d48</unique_id>" +
                                     "<transaction_id>119643250547501c79d8295</transaction_id>" +
                                     "<mode>live</mode>" +
                                     "<timestamp>2014-01-30T14:21:48Z</timestamp>" +
                                     "<descriptor>descriptor one</descriptor>" +
                                     "<amount>9000</amount>" +
                                     "<currency>USD</currency>" +
                                     "<sent_to_acquirer>true</sent_to_acquirer>" +
                                     "<billing_address>" +
                                     "<first_name>John</first_name>" +
                                     "<last_name>Doe</last_name>" +
                                     "<address1>32, Doestreet</address1>" +
                                     "<address2></address2>" +
                                     "<zip_code>12345</zip_code>" +
                                     "<city>New York</city>" +
                                     "<state>NY</state>" +
                                     "<country></country>" +
                                     "</billing_address>" +
                                     "</payment_response>";

            return new EntityMock<SingleReconcileSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<SingleReconcileErrorResponse> CreateSingleReconcileErrorResponse()
        {
            var errorResponse = new SingleReconcileErrorResponse()
            {
                TechnicalMessage = "Transaction with the given unique ID cannot be found!",
                Status = TransactionStates.Error,
                Message = "Something went wrong, please contact support!",
                Code = ErrorCodes.TransactionNotFoundError
            };

            var errorResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                   "<payment_response>" +
                                   "<status>error</status>" +
                                   "<message>Something went wrong, please contact support!</message>" +
                                   "<code>460</code>" +
                                   "<technical_message>Transaction with the given unique ID cannot be found!</technical_message>" +
                                   "</payment_response>";

            return new EntityMock<SingleReconcileErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<SingleRetrievalRequestSuccessResponse> CreateSingleRetrievalRequestSuccessResponse()
        {
            var successResponse = new SingleRetrievalRequestSuccessResponse()
            {
                Type = "Retrieval request",
                Arn = "74537604221431003881865",
                ProxyPostDate = "2014-01-24",
                ReasonCode = "42",
                ReasonDescription = "Potential Chargeback",
                AuthorizationCode = "811714",
                CardNumber = "554960******5069",
                CardBrand = "master",
                CustomerEmail = "emil@example.com",
                CustomerPhone = "3598851248512",
                TransactionType = TransactionTypes.Sale3d,
                OriginalTransactionUniqueId = "f9634ec5e7dbe6ca3871974accb875cd"
            };

            var successResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                     "<retrieval_request_response>" +
                                     "<type>Retrieval request</type>" +
                                     "<arn>74537604221431003881865</arn>" +
                                     "<post_date>2014-01-24</post_date>" +
                                     "<reason_code>42</reason_code>" +
                                     "<reason_description>Potential Chargeback</reason_description>" +
                                     "<authorization_code>811714</authorization_code>" +
                                     "<card_number>554960******5069</card_number>" +
                                     "<card_brand>master</card_brand>" +
                                     "<customer_email>emil@example.com</customer_email>" +
                                     "<customer_phone>3598851248512</customer_phone>" +
                                     "<transaction_type>sale3d</transaction_type>" +
                                     "<original_transaction_unique_id>f9634ec5e7dbe6ca3871974accb875cd</original_transaction_unique_id>" +
                                     "</retrieval_request_response>";

            return new EntityMock<SingleRetrievalRequestSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<SingleRetrievalRequestErrorResponse> CreateSingleRetrievalRequestErrorResponse()
        {
            var errorResponse = new SingleRetrievalRequestErrorResponse()
            {
                TechnicalMessage = "Retrieval request by the given criteria cannot be found!",
                Status = TransactionStates.Error,
                Message = "Retrieval request not found!",
                Code = ErrorCodes.RetrievalRequestNotFoundError
            };

            var errorResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                   "<retrieval_request_response>" +
                                   "<technical_message>Retrieval request by the given criteria cannot be found!</technical_message>" +
                                   "<status>error</status>" +
                                   "<message>Retrieval request not found!</message>" +
                                   "<code>480</code>" +
                                   "</retrieval_request_response>";

            return new EntityMock<SingleRetrievalRequestErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<CaptureSuccessResponse> CreateCaptureSuccessResponse()
        {
            var successResponse = new CaptureSuccessResponse()
            {
                TransactionType = TransactionTypes.Capture,
                Status = TransactionStates.Approved,
                UniqueId = "91449b0b7eb34dca6b0666cbfa8d5d03",
                TransactionId = "119643223347501b69b921b",
                TechnicalMessage = "Transaction successful!",
                Message = "Transaction successful!",
                Mode = "live",
                ProxyTime = "2007-11-30T14:17:15Z",
                Descriptor = "descriptor one",
                Amount = 90,
                Currency = Iso4217CurrencyCodes.USD,
                SentToAcquirer = true
            };

            var successResponseXml =
                                    "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                    "<payment_response>" +
                                    "<transaction_type>capture</transaction_type>" +
                                    "<status>approved</status>" +
                                    "<unique_id>91449b0b7eb34dca6b0666cbfa8d5d03</unique_id>" +
                                    "<transaction_id>119643223347501b69b921b</transaction_id>" +
                                    "<technical_message>Transaction successful!</technical_message>" +
                                    "<message>Transaction successful!</message>" +
                                    "<mode>live</mode>" +
                                    "<timestamp>2007-11-30T14:17:15Z</timestamp>" +
                                    "<descriptor>descriptor one</descriptor>" +
                                    "<amount>9000</amount>" +
                                    "<currency>USD</currency>" +
                                    "<sent_to_acquirer>true</sent_to_acquirer>" +
                                    "</payment_response>";

            return new EntityMock<CaptureSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<CaptureErrorResponse> CreateCaptureErrorResponse()
        {
            var errorResponse = new CaptureErrorResponse()
            {
                TransactionType = TransactionTypes.Capture,
                Status = TransactionStates.Error,
                UniqueId = "91a9adf1cc5095e483006df34b64023f",
                TransactionId = "119643234047501bd47e6b4",
                Code = ErrorCodes.ReferenceInvalidatedError,
                TechnicalMessage = "reference transaction has already been captured, and acquirer does not support partial/multiple capture",
                Message = "transaction declined.",
                Mode = "live",
                ProxyTime = "2007-11-30T14:19:02Z",
                Descriptor = "descriptor one",
                Amount = 90,
                Currency = Iso4217CurrencyCodes.USD,
                SentToAcquirer = false
            };

            var errorResponseXml =
                                  "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                  "<payment_response>" +
                                  "<transaction_type>capture</transaction_type>" +
                                  "<status>error</status>" +
                                  "<unique_id>91a9adf1cc5095e483006df34b64023f</unique_id>" +
                                  "<transaction_id>119643234047501bd47e6b4</transaction_id>" +
                                  "<code>430</code>" +
                                  "<technical_message>reference transaction has already been captured, and acquirer does not support partial/multiple capture</technical_message>" +
                                  "<message>transaction declined.</message>" +
                                  "<mode>live</mode>" +
                                  "<timestamp>2007-11-30T14:19:02Z</timestamp>" +
                                  "<descriptor>descriptor one</descriptor>" +
                                  "<amount>9000</amount>" +
                                  "<currency>USD</currency>" +
                                  "<sent_to_acquirer>false</sent_to_acquirer>" +
                                  "</payment_response>";

            return new EntityMock<CaptureErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<CreditSuccessResponse> CreateCreditSuccessResponse()
        {
            var successResponse = new CreditSuccessResponse()
            {
                TransactionType = TransactionTypes.Credit,
                Status = TransactionStates.Approved,
                AuthorizationCode = "345678",
                ResponseCode = "00",
                UniqueId = "776cc3b95eaf9025113dc18d128e99a0",
                TransactionId = "B62D6848-78EA-4910-BFD8-920A3BF10CC5",
                Mode = "live",
                ProxyTime = "2007-11-30T16:15:44Z",
                Descriptor = "descriptor one",
                Amount = 90,
                Currency = Iso4217CurrencyCodes.USD
            };

            var successResponseXml =
                                    "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                    "<payment_response>" +
                                    "<transaction_type>credit</transaction_type>" +
                                    "<status>approved</status>" +
                                    "<authorization_code>345678</authorization_code>" +
                                    "<response_code>00</response_code>" +
                                    "<unique_id>776cc3b95eaf9025113dc18d128e99a0</unique_id>" +
                                    "<transaction_id>B62D6848-78EA-4910-BFD8-920A3BF10CC5</transaction_id>" +
                                    "<mode>live</mode>" +
                                    "<timestamp>2007-11-30T16:15:44Z</timestamp>" +
                                    "<descriptor>descriptor one</descriptor>" +
                                    "<amount>9000</amount>" +
                                    "<currency>USD</currency>" +
                                    "</payment_response>";

            return new EntityMock<CreditSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<CreditErrorResponse> CreateCreditErrorResponse()
        {
            var errorResponse = new CreditErrorResponse()
            {
                TransactionType = TransactionTypes.Credit,
                Status = TransactionStates.Error,
                ResponseCode = "57",
                UniqueId = "2515db3cf16d04fa35afb140b84b99d4",
                TransactionId = "B62D6848-78EA-4910-BFD8-920A3BF10CC5",
                Code = ErrorCodes.ReferenceNotFoundError,
                TechnicalMessage = "no approved reference transaction found",
                Message = "no approved reference transaction found",
                Mode = "live",
                ProxyTime = "2007-11-30T16:16:53Z",
                Descriptor = "",
                Amount = 90,
                Currency = Iso4217CurrencyCodes.USD,
            };

            var errorResponseXml =
                                  "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                  "<payment_response>" +
                                  "<transaction_type>credit</transaction_type>" +
                                  "<status>error</status>" +
                                  "<response_code>57</response_code>" +
                                  "<unique_id>2515db3cf16d04fa35afb140b84b99d4</unique_id>" +
                                  "<transaction_id>B62D6848-78EA-4910-BFD8-920A3BF10CC5</transaction_id>" +
                                  "<code>410</code>" +
                                  "<technical_message>no approved reference transaction found</technical_message>" +
                                  "<message>no approved reference transaction found</message>" +
                                  "<mode>live</mode>" +
                                  "<timestamp>2007-11-30T16:16:53Z</timestamp>" +
                                  "<descriptor></descriptor>" +
                                  "<amount>9000</amount>" +
                                  "<currency>USD</currency>" +
                                  "</payment_response>";

            return new EntityMock<CreditErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<RecurringSaleSuccessResponse> CreateRecurringSaleSuccessResponse()
        {
            var successResponse = new RecurringSaleSuccessResponse()
            {
                TransactionType = TransactionTypes.RecurringSale,
                Status = TransactionStates.Approved,
                AuthorizationCode = "345678",
                ResponseCode = "00",
                UniqueId = "91449b0b7eb34dca6b0666cbfa8d5d03",
                TransactionId = "119643223347501b69b921b",
                Mode = "live",
                ProxyTime = "2007-11-30T14:17:15Z",
                Descriptor = "descriptor one",
                Amount = 90,
                Currency = Iso4217CurrencyCodes.USD,
                SentToAcquirer = true
            };

            var successResponseXml =
                                    "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                    "<payment_response>" +
                                    "<transaction_type>recurring_sale</transaction_type>" +
                                    "<status>approved</status>" +
                                    "<authorization_code>345678</authorization_code>" +
                                    "<response_code>00</response_code>" +
                                    "<unique_id>91449b0b7eb34dca6b0666cbfa8d5d03</unique_id>" +
                                    "<transaction_id>119643223347501b69b921b</transaction_id>" +
                                    "<mode>live</mode>" +
                                    "<timestamp>2007-11-30T14:17:15Z</timestamp>" +
                                    "<descriptor>descriptor one</descriptor>" +
                                    "<amount>9000</amount>" +
                                    "<currency>USD</currency>" +
                                    "<sent_to_acquirer>true</sent_to_acquirer>" +
                                    "</payment_response>";

            return new EntityMock<RecurringSaleSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<RecurringSaleErrorResponse> CreateRecurringSaleErrorResponse()
        {
            var errorResponse = new RecurringSaleErrorResponse()
            {
                TransactionType = TransactionTypes.RecurringSale,
                Status = TransactionStates.Error,
                UniqueId = "ce165509205f3a70dfdd190546280b8f",
                TransactionId = "235245",
                Code = ErrorCodes.ReferenceWorkflowError,
                TechnicalMessage = "reference transaction is invalid!",
                Message = "Something went wrong, please contact support!",
                Mode = "test",
                ProxyTime = "2014-11-18T16:45:36Z",
                Descriptor = "Testing MID",
                Amount = 435345,
                Currency = Iso4217CurrencyCodes.USD,
                SentToAcquirer = false
            };

            var errorResponseXml =
                                  "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                  "<payment_response>" +
                                  "<transaction_type>recurring_sale</transaction_type>" +
                                  "<status>error</status>" +
                                  "<unique_id>ce165509205f3a70dfdd190546280b8f</unique_id>" +
                                  "<transaction_id>235245</transaction_id>" +
                                  "<code>420</code>" +
                                  "<technical_message>reference transaction is invalid!</technical_message>" +
                                  "<message>Something went wrong, please contact support!</message>" +
                                  "<mode>test</mode>" +
                                  "<timestamp>2014-11-18T16:45:36Z</timestamp>" +
                                  "<descriptor>Testing MID</descriptor>" +
                                  "<amount>43534500</amount>" +
                                  "<currency>USD</currency>" +
                                  "<sent_to_acquirer>false</sent_to_acquirer>" +
                                  "</payment_response>";

            return new EntityMock<RecurringSaleErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<RefundSuccessResponse> CreateRefundSuccessResponse()
        {
            var successResponse = new RefundSuccessResponse()
            {
                TransactionType = TransactionTypes.Refund,
                Status = TransactionStates.Approved,
                AuthorizationCode = "345678",
                ResponseCode = "00",
                UniqueId = "776cc3b95eaf9025113dc18d128e99a0",
                TransactionId = "11964393414750372dad370",
                Mode = "live",
                ProxyTime = "2007-11-30T16:15:44Z",
                Descriptor = "descriptor one",
                Amount = 90,
                Currency = Iso4217CurrencyCodes.USD
            };

            var successResponseXml =
                                    "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                    "<payment_response>" +
                                    "<transaction_type>refund</transaction_type>" +
                                    "<status>approved</status>" +
                                    "<authorization_code>345678</authorization_code>" +
                                    "<response_code>00</response_code>" +
                                    "<unique_id>776cc3b95eaf9025113dc18d128e99a0</unique_id>" +
                                    "<transaction_id>11964393414750372dad370</transaction_id>" +
                                    "<mode>live</mode>" +
                                    "<timestamp>2007-11-30T16:15:44Z</timestamp>" +
                                    "<descriptor>descriptor one</descriptor>" +
                                    "<amount>9000</amount>" +
                                    "<currency>USD</currency>" +
                                    "</payment_response>";

            return new EntityMock<RefundSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<RefundErrorResponse> CreateRefundErrorResponse()
        {
            var errorResponse = new RefundErrorResponse()
            {
                TransactionType = TransactionTypes.Refund,
                Status = TransactionStates.Error,
                ResponseCode = "57",
                UniqueId = "2515db3cf16d04fa35afb140b84b99d4",
                TransactionId = "119643941047503772d9caa",
                Code = ErrorCodes.ReferenceNotFoundError,
                TechnicalMessage = "no approved reference transaction found",
                Message = "no approved reference transaction found",
                Mode = "live",
                ProxyTime = "2007-11-30T16:16:53Z",
                Descriptor = "some desc 1",
                Amount = 90,
                Currency = Iso4217CurrencyCodes.USD,
            };

            var errorResponseXml =
                                  "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                  "<payment_response>" +
                                  "<transaction_type>refund</transaction_type>" +
                                  "<status>error</status>" +
                                  "<response_code>57</response_code>" +
                                  "<unique_id>2515db3cf16d04fa35afb140b84b99d4</unique_id>" +
                                  "<transaction_id>119643941047503772d9caa</transaction_id>" +
                                  "<code>410</code>" +
                                  "<technical_message>no approved reference transaction found</technical_message>" +
                                  "<message>no approved reference transaction found</message>" +
                                  "<mode>live</mode>" +
                                  "<timestamp>2007-11-30T16:16:53Z</timestamp>" +
                                  "<descriptor>some desc 1</descriptor>" +
                                  "<amount>9000</amount>" +
                                  "<currency>USD</currency>" +
                                  "</payment_response>";

            return new EntityMock<RefundErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<VoidSuccessResponse> CreateVoidSuccessResponse()
        {
            var successResponse = new VoidSuccessResponse()
            {
                TransactionType = TransactionTypes.Void,
                Status = TransactionStates.Approved,
                AuthorizationCode = "345678",
                ResponseCode = "00",
                UniqueId = "4b9e30b641d256d9283be7ef37ea4a0e",
                TransactionId = "119643944447503794c8bb2",
                Mode = "live",
                ProxyTime = "2007-11-30T16:17:26Z",
                Descriptor = "descriptor one",
                SentToAcquirer = true
            };

            var successResponseXml =
                                    "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                    "<payment_response>" +
                                    "<transaction_type>void</transaction_type>" +
                                    "<status>approved</status>" +
                                    "<authorization_code>345678</authorization_code>" +
                                    "<response_code>00</response_code>" +
                                    "<unique_id>4b9e30b641d256d9283be7ef37ea4a0e</unique_id>" +
                                    "<transaction_id>119643944447503794c8bb2</transaction_id>" +
                                    "<mode>live</mode>" +
                                    "<timestamp>2007-11-30T16:17:26Z</timestamp>" +
                                    "<descriptor>descriptor one</descriptor>" +
                                    "<sent_to_acquirer>true</sent_to_acquirer>" +
                                    "</payment_response>";

            return new EntityMock<VoidSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<VoidErrorResponse> CreateVoidErrorResponse()
        {
            var errorResponse = new VoidErrorResponse()
            {
                TransactionType = TransactionTypes.Void,
                Status = TransactionStates.Error,
                ResponseCode = "57",
                UniqueId = "5b85106ae3b3789f7242edd5f92c218b",
                TransactionId = "1196439500475037ccabd94",
                Code = ErrorCodes.ReferenceWorkflowError,
                TechnicalMessage = "can not do void on void reference",
                Message = "can not do void on void reference",
                Mode = "live",
                ProxyTime = "2007-11-30T16:18:22Z",
                Descriptor = "descriptor one",
                SentToAcquirer = false
            };

            var errorResponseXml =
                                  "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                  "<payment_response>" +
                                  "<transaction_type>void</transaction_type>" +
                                  "<status>error</status>" +
                                  "<response_code>57</response_code>" +
                                  "<unique_id>5b85106ae3b3789f7242edd5f92c218b</unique_id>" +
                                  "<transaction_id>1196439500475037ccabd94</transaction_id>" +
                                  "<code>420</code>" +
                                  "<technical_message>can not do void on void reference</technical_message>" +
                                  "<message>can not do void on void reference</message>" +
                                  "<mode>live</mode>" +
                                  "<timestamp>2007-11-30T16:18:22Z</timestamp>" +
                                  "<descriptor>descriptor one</descriptor>" +
                                  "<sent_to_acquirer>false</sent_to_acquirer>" +
                                  "</payment_response>";

            return new EntityMock<VoidErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<WpfReconcileSuccessResponse> CreateWpfReconcileSuccessResponseForSuccessfulPayment()
        {
            var successResponse = new WpfReconcileSuccessResponse()
            {
                Status = TransactionStates.Approved,
                UniqueId = "26aa150ee68b1b2d6758a0e6c44fce4c",
                TransactionId = "mtid201104081447161135536962",
                TechnicalMessage = "TESTMODE: No real money will be transferred!",
                Message = "TESTMODE: No real money will be transferred!",
                Mode = "test",
                ProxyTime = "2011-04-08T14:46:27Z",
                Amount = 50,
                Currency = Iso4217CurrencyCodes.USD,
                Payments = new PaymentResponse[]
                {
                    new PaymentResponse()
                    {
                        Status = TransactionStates.Approved,
                        AuthorizationCode = "345678",
                        ResponseCode = "00",
                        TransactionType = TransactionTypes.Sale,
                        UniqueId = "bad08183a9ec545daf0f24c48361aa10",
                        TransactionId = "mtid201104081447161135536962",
                        TerminalToken = "e9fd7a957845450fb7ab9dccb498b6e1f6e1e3aa",
                        Mode = "test",
                        ProxyTime = "2011-04-08T14:46:40Z",
                        Descriptor = "descriptor one",
                        Amount = 50,
                        Currency = Iso4217CurrencyCodes.USD,
                        CustomerEmail = "john.doe@example.com",
                        CustomerPhone = "+11234567890",
                        TechnicalMessage = "TESTMODE: No real money will be transferred!",
                        Message = "TESTMODE: No real money will be transferred!",
                        BillingAddress = new Address()
                        {
                            FirstName = "John",
                            LastName = "Doe",
                            Address1 = "32, Doestreet",
                            Address2 = "",
                            ZipCode = "12345",
                            City = "New York",
                            State = "NY",
                            Country = Iso3166CountryCodes.US
                        }
                    }
                }
            };

            var successResponseXml =
                                    "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                    "<wpf_payment>" +
                                    "<status>approved</status>" +
                                    "<unique_id>26aa150ee68b1b2d6758a0e6c44fce4c</unique_id>" +
                                    "<transaction_id>mtid201104081447161135536962</transaction_id>" +
                                    "<technical_message>TESTMODE: No real money will be transferred!</technical_message>" +
                                    "<message>TESTMODE: No real money will be transferred!</message>" +
                                    "<mode>test</mode>" +
                                    "<timestamp>2011-04-08T14:46:27Z</timestamp>" +
                                    "<amount>5000</amount>" +
                                    "<currency>USD</currency>" +
                                    "<payment_transaction>" +
                                    "<status>approved</status>" +
                                    "<authorization_code>345678</authorization_code>" +
                                    "<response_code>00</response_code>" +
                                    "<transaction_type>sale</transaction_type>" +
                                    "<unique_id>bad08183a9ec545daf0f24c48361aa10</unique_id>" +
                                    "<transaction_id>mtid201104081447161135536962</transaction_id>" +
                                    "<terminal_token>e9fd7a957845450fb7ab9dccb498b6e1f6e1e3aa</terminal_token>" +
                                    "<mode>test</mode>" +
                                    "<timestamp>2011-04-08T14:46:40Z</timestamp>" +
                                    "<descriptor>descriptor one</descriptor>" +
                                    "<amount>5000</amount>" +
                                    "<currency>USD</currency>" +
                                    "<customer_email>john.doe@example.com</customer_email>" +
                                    "<customer_phone>+11234567890</customer_phone>" +
                                    "<technical_message>TESTMODE: No real money will be transferred!</technical_message>" +
                                    "<message>TESTMODE: No real money will be transferred!</message>" +
                                    "<billing_address>" +
                                    "<first_name>John</first_name>" +
                                    "<last_name>Doe</last_name>" +
                                    "<address1>32, Doestreet</address1>" +
                                    "<address2></address2>" +
                                    "<zip_code>12345</zip_code>" +
                                    "<city>New York</city>" +
                                    "<state>NY</state>" +
                                    "<country>US</country>" +
                                    "</billing_address>" +
                                    "</payment_transaction>" +
                                    "</wpf_payment>";

            return new EntityMock<WpfReconcileSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<WpfReconcileSuccessResponse> CreateWpfReconcileSuccessResponseForVoidedPayment()
        {
            var successResponse = new WpfReconcileSuccessResponse()
            {
                Status = TransactionStates.Voided,
                UniqueId = "26aa150ee68b1b2d6758a0e6c44fce4c",
                TransactionId = "mtid201104081447161135536962",
                TechnicalMessage = "TESTMODE: No real money will be transferred!",
                Message = "TESTMODE: No real money will be transferred!",
                Mode = "test",
                ProxyTime = "2011-04-08T14:46:27Z",
                Amount = 50,
                Currency = Iso4217CurrencyCodes.USD,
                Payments = new PaymentResponse[]
                {
                    new PaymentResponse()
                    {
                        Status = TransactionStates.Voided,
                        AuthorizationCode = "345678",
                        ResponseCode = "00",
                        TransactionType = TransactionTypes.Sale,
                        UniqueId = "bad08183a9ec545daf0f24c48361aa10",
                        TransactionId = "mtid201104081447161135536962",
                        TerminalToken = "e9fd7a957845450fb7ab9dccb498b6e1f6e1e3aa",
                        Mode = "test",
                        ProxyTime = "2011-04-08T14:46:40Z",
                        Descriptor = "descriptor one",
                        Amount = 50,
                        Currency = Iso4217CurrencyCodes.USD,
                        CustomerEmail = "john.doe@example.com",
                        CustomerPhone = "+11234567890",
                        TechnicalMessage = "TESTMODE: No real money will be transferred!",
                        Message = "TESTMODE: No real money will be transferred!",
                        BillingAddress = new Address()
                        {
                            FirstName = "John",
                            LastName = "Doe",
                            Address1 = "32, Doestreet",
                            Address2 = "",
                            ZipCode = "12345",
                            City = "New York",
                            State = "NY",
                            Country = Iso3166CountryCodes.US
                        }
                    },
                    new PaymentResponse()
                    {
                        Status = TransactionStates.Approved,
                        AuthorizationCode = "345678",
                        ResponseCode = "00",
                        TransactionType = TransactionTypes.Void,
                        UniqueId = "bad08183a9ec545daf0f24c48361aa10",
                        TransactionId = "mtid201104081447161135536962",
                        TerminalToken = "e9fd7a957845450fb7ab9dccb498b6e1f6e1e3aa",
                        Mode = "test",
                        ProxyTime = "2011-04-08T14:46:40Z",
                        Descriptor = "descriptor one",
                        Amount = 50,
                        Currency = Iso4217CurrencyCodes.USD
                    }
                }
            };

            var successResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                     "<wpf_payment>" +
                                     "<status>voided</status>" +
                                     "<unique_id>26aa150ee68b1b2d6758a0e6c44fce4c</unique_id>" +
                                     "<transaction_id>mtid201104081447161135536962</transaction_id>" +
                                     "<technical_message>TESTMODE: No real money will be transferred!</technical_message>" +
                                     "<message>TESTMODE: No real money will be transferred!</message>" +
                                     "<mode>test</mode>" +
                                     "<timestamp>2011-04-08T14:46:27Z</timestamp>" +
                                     "<amount>5000</amount>" +
                                     "<currency>USD</currency>" +
                                     "<payment_transaction>" +
                                     "<status>voided</status>" +
                                     "<authorization_code>345678</authorization_code>" +
                                     "<response_code>00</response_code>" +
                                     "<transaction_type>sale</transaction_type>" +
                                     "<unique_id>bad08183a9ec545daf0f24c48361aa10</unique_id>" +
                                     "<transaction_id>mtid201104081447161135536962</transaction_id>" +
                                     "<terminal_token>e9fd7a957845450fb7ab9dccb498b6e1f6e1e3aa</terminal_token>" +
                                     "<mode>test</mode>" +
                                     "<timestamp>2011-04-08T14:46:40Z</timestamp>" +
                                     "<descriptor>descriptor one</descriptor>" +
                                     "<amount>5000</amount>" +
                                     "<currency>USD</currency>" +
                                     "<customer_email>john.doe@example.com</customer_email>" +
                                     "<customer_phone>+11234567890</customer_phone>" +
                                     "<technical_message>TESTMODE: No real money will be transferred!</technical_message>" +
                                     "<message>TESTMODE: No real money will be transferred!</message>" +
                                     "<billing_address>" +
                                     "<first_name>John</first_name>" +
                                     "<last_name>Doe</last_name>" +
                                     "<address1>32, Doestreet</address1>" +
                                     "<address2></address2>" +
                                     "<zip_code>12345</zip_code>" +
                                     "<city>New York</city>" +
                                     "<state>NY</state>" +
                                     "<country>US</country>" +
                                     "</billing_address>" +
                                     "</payment_transaction>" +
                                     "<payment_transaction>" +
                                     "<status>approved</status>" +
                                     "<authorization_code>345678</authorization_code>" +
                                     "<response_code>00</response_code>" +
                                     "<transaction_type>void</transaction_type>" +
                                     "<unique_id>bad08183a9ec545daf0f24c48361aa10</unique_id>" +
                                     "<transaction_id>mtid201104081447161135536962</transaction_id>" +
                                     "<terminal_token>e9fd7a957845450fb7ab9dccb498b6e1f6e1e3aa</terminal_token>" +
                                     "<mode>test</mode>" +
                                     "<timestamp>2011-04-08T14:46:40Z</timestamp>" +
                                     "<descriptor>descriptor one</descriptor>" +
                                     "<amount>5000</amount>" +
                                     "<currency>USD</currency>" +
                                     "</payment_transaction>" +
                                     "</wpf_payment>";

            return new EntityMock<WpfReconcileSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<WpfReconcileErrorResponse> CreateWpfReconcileErrorResponse()
        {
            var errorResponse = new WpfReconcileErrorResponse()
            {
                Status = TransactionStates.Error,
                Code = ErrorCodes.SystemError,
                TechnicalMessage = "Unknown system error. Please contact support.",
                Message = "Transaction failed, please contact support!"
            };

            var errorResponseXml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<wpf_payment>" +
                "<status>error</status>" +
                "<code>100</code>" +
                "<technical_message>Unknown system error. Please contact support.</technical_message>" +
                "<message>Transaction failed, please contact support!</message>" +
                "</wpf_payment>";

            return new EntityMock<WpfReconcileErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<EzeeWalletSuccessResponse> CreateEzeeWalletSuccessResponse()
        {
            var successResponse = new EzeeWalletSuccessResponse()
            {
                TransactionType = TransactionTypes.EzeeWallet,
                Status = TransactionStates.PendingAsync,
                UniqueId = "12345",
                TransactionId = "asqf12e81eb23d0e00ffb85b1db7db915",
                TechnicalMessage = "Transaction successful!",
                Message = "Transaction successful!",
                RedirectUrl = "https://staging.ezeewallet.com/api/top-up/12345",
                Mode = "live",
                ProxyTime = "2015-02-16T17:56:53Z",
                Descriptor = "descriptor one",
                ProxyAmount = "50000",
                Currency = Iso4217CurrencyCodes.EUR,
                SentToAcquirer = true
            };

            var successResponseXml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<payment_response>" +
                "<transaction_type>ezeewallet</transaction_type>" +
                "<status>pending_async</status>" +
                "<unique_id>12345</unique_id>" +
                "<transaction_id>asqf12e81eb23d0e00ffb85b1db7db915</transaction_id>" +
                "<technical_message>Transaction successful!</technical_message>" +
                "<message>Transaction successful!</message>" +
                "<redirect_url>https://staging.ezeewallet.com/api/top-up/12345</redirect_url>" +
                "<mode>live</mode>" +
                "<timestamp>2015-02-16T17:56:53Z</timestamp>" +
                "<descriptor>descriptor one</descriptor>" +
                "<amount>50000</amount>" +
                "<currency>EUR</currency>" +
                "<sent_to_acquirer>true</sent_to_acquirer>" +
                "</payment_response>";

            return new EntityMock<EzeeWalletSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<EzeeWalletErrorResponse> CreateEzeeWalletErrorResponse()
        {
            var errorResponse = new EzeeWalletErrorResponse()
            {
                TransactionType = TransactionTypes.EzeeWallet,
                Status = TransactionStates.Error,
                UniqueId = "1a0e27d34a6c3c6012f53f4b54bf92a4",
                TransactionId = "asqf12e81eb23d0e00ffb85b1db7db9f8",
                Code = ErrorCodes.RemoteDataError,
                TechnicalMessage = "Target wallet account not found",
                Message = "Something went wrong, please contact support!",
                Mode = "test",
                ProxyTime = "2015-02-06T09:55:18Z",
                Descriptor = "Descriptior",
                ProxyAmount = "50000",
                Currency = Iso4217CurrencyCodes.USD,
                SentToAcquirer = true
            };

            var errorResponseXml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<payment_response>" +
                "<transaction_type>ezeewallet</transaction_type>" +
                "<status>error</status>" +
                "<unique_id>1a0e27d34a6c3c6012f53f4b54bf92a4</unique_id>" +
                "<transaction_id>asqf12e81eb23d0e00ffb85b1db7db9f8</transaction_id>" +
                "<code>930</code>" +
                "<technical_message>Target wallet account not found</technical_message>" +
                "<message>Something went wrong, please contact support!</message>" +
                "<mode>test</mode>" +
                "<timestamp>2015-02-06T09:55:18Z</timestamp>" +
                "<descriptor>Descriptior</descriptor>" +
                "<amount>50000</amount>" +
                "<currency>USD</currency>" +
                "<sent_to_acquirer>true</sent_to_acquirer>" +
                "</payment_response>";

            return new EntityMock<EzeeWalletErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<PayByVoucherSuccessResponse> CreatePayByVoucherSuccessResponse()
        {
            var successResponse = new PayByVoucherSuccessResponse()
            {
                TransactionType = TransactionTypes.PayByVoucher,
                Status = TransactionStates.PendingAsync,
                UniqueId = "abcdef",
                TransactionId = "43671",
                TechnicalMessage = "TESTMODE: No real money will be transferred!",
                Message = "TESTMODE: No real money will be transferred!",
                RedirectUrl = "https://gateway/process/xyz",
                Mode = "test",
                ProxyTime = "2015-02-17T14:21:51Z",
                Descriptor = "Descriptor",
                ProxyAmount = "50000",
                Currency = Iso4217CurrencyCodes.USD,
                SentToAcquirer = true
            };

            var successResponseXml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<payment_response>" +
                "<transaction_type>paybyvoucher</transaction_type>" +
                "<status>pending_async</status>" +
                "<unique_id>abcdef</unique_id>" +
                "<transaction_id>43671</transaction_id>" +
                "<technical_message>TESTMODE: No real money will be transferred!</technical_message>" +
                "<message>TESTMODE: No real money will be transferred!</message>" +
                "<redirect_url>https://gateway/process/xyz</redirect_url>" +
                "<mode>test</mode>" +
                "<timestamp>2015-02-17T14:21:51Z</timestamp>" +
                "<descriptor>Descriptor</descriptor>" +
                "<amount>50000</amount>" +
                "<currency>USD</currency>" +
                "<sent_to_acquirer>true</sent_to_acquirer>" +
                "</payment_response>";

            return new EntityMock<PayByVoucherSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<PayByVoucherErrorResponse> CreatePayByVoucherErrorResponse()
        {
            var errorResponse = new PayByVoucherErrorResponse()
            {
                TransactionType = TransactionTypes.PayByVoucher,
                Status = TransactionStates.Error,
                UniqueId = "dfba78a08350d3702d9a33e8bc53a5e1",
                TransactionId = "43671",
                Code = (ErrorCodes)320,
                TechnicalMessage = "’product_name’ is missing",
                Message = "Please check input data for errors!",
                Mode = "test",
                ProxyTime = "2015-02-17T14:42:12Z",
                Descriptor = "Descriptor",
                ProxyAmount = "50000",
                Currency = Iso4217CurrencyCodes.USD,
                SentToAcquirer = false
            };

            var errorResponseXml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<payment_response>" +
                "<transaction_type>paybyvoucher</transaction_type>" +
                "<status>error</status>" +
                "<unique_id>dfba78a08350d3702d9a33e8bc53a5e1</unique_id>" +
                "<transaction_id>43671</transaction_id>" +
                "<code>320</code>" +
                "<technical_message>’product_name’ is missing</technical_message>" +
                "<message>Please check input data for errors!</message>" +
                "<mode>test</mode>" +
                "<timestamp>2015-02-17T14:42:12Z</timestamp>" +
                "<descriptor>Descriptor</descriptor>" +
                "<amount>50000</amount>" +
                "<currency>USD</currency>" +
                "<sent_to_acquirer>false</sent_to_acquirer>" +
                "</payment_response>";

            return new EntityMock<PayByVoucherErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<CashUSuccessResponse> CreateCashUSuccessResponse()
        {
            var successResponse = new CashUSuccessResponse()
            {
                TransactionType = TransactionTypes.CashU,
                Status = TransactionStates.PendingAsync,
                UniqueId = "bf85ad9ed27dee80b0649e1ff35c61d0",
                TransactionId = "asqf12e81eb23d0e00ffb85b1db7db915",
                TechnicalMessage = "Transaction successful!",
                Message = "Transaction successful!",
                RedirectUrl = "https://gateway/redirect/to_acquirer/bf85ad9ed27dee80b0649e1ff35c61d0",
                Mode = "live",
                ProxyTime = "2015-02-16T17:56:53Z",
                Descriptor = "descriptor one",
                ProxyAmount = "50000",
                Currency = Iso4217CurrencyCodes.EUR,
                SentToAcquirer = true
            };

            var successResponseXml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<payment_response>" +
                "<transaction_type>cashu</transaction_type>" +
                "<status>pending_async</status>" +
                "<unique_id>bf85ad9ed27dee80b0649e1ff35c61d0</unique_id>" +
                "<transaction_id>asqf12e81eb23d0e00ffb85b1db7db915</transaction_id>" +
                "<technical_message>Transaction successful!</technical_message>" +
                "<message>Transaction successful!</message>" +
                "<redirect_url>https://gateway/redirect/to_acquirer/bf85ad9ed27dee80b0649e1ff35c61d0</redirect_url>" +
                "<mode>live</mode>" +
                "<timestamp>2015-02-16T17:56:53Z</timestamp>" +
                "<descriptor>descriptor one</descriptor>" +
                "<amount>50000</amount>" +
                "<currency>EUR</currency>" +
                "<sent_to_acquirer>true</sent_to_acquirer>" +
                "</payment_response>";

            return new EntityMock<CashUSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<CashUErrorResponse> CreateCashUErrorResponse()
        {
            var errorResponse = new CashUErrorResponse()
            {
                TransactionType = TransactionTypes.CashU,
                Status = TransactionStates.Error,
                UniqueId = "bf85ad9ed27dee80b0649e1ff35c61d0",
                TransactionId = "asqf12e81eb23d0e00ffb85b1db7db915",
                Code = (ErrorCodes)110,
                Message = "Something went wrong, please contact support!",
                Mode = "live",
                ProxyTime = "2015-02-16T17:56:53Z",
                Descriptor = "descriptor one",
                ProxyAmount = "50000",
                Currency = Iso4217CurrencyCodes.EUR,
                SentToAcquirer = true
            };

            var errorResponseXml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<payment_response>" +
                "<transaction_type>cashu</transaction_type>" +
                "<status>error</status>" +
                "<unique_id>bf85ad9ed27dee80b0649e1ff35c61d0</unique_id>" +
                "<transaction_id>asqf12e81eb23d0e00ffb85b1db7db915</transaction_id>" +
                "<code>110</code>" +
                "<message>Something went wrong, please contact support!</message>" +
                "<mode>live</mode>" +
                "<timestamp>2015-02-16T17:56:53Z</timestamp>" +
                "<descriptor>descriptor one</descriptor>" +
                "<amount>50000</amount>" +
                "<currency>EUR</currency>" +
                "<sent_to_acquirer>true</sent_to_acquirer>" +
                "</payment_response>";

            return new EntityMock<CashUErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<PaySafeCardSuccessResponse> CreatePaySafeCardSuccessResponse()
        {
            var successResponse = new PaySafeCardSuccessResponse()
            {
                TransactionType = TransactionTypes.PaySafeCard,
                Status = TransactionStates.PendingAsync,
                UniqueId = "bf85ad9ed27dee80b0649e1ff35c61d0",
                TransactionId = "asqf12e81eb23d0e00ffb85b1db7db915",
                TechnicalMessage = "Transaction successful!",
                Message = "Transaction successful!",
                RedirectUrl = "https://gateway/redirect/to_acquirer/bf85ad9ed27dee80b0649e1ff35c61d0",
                Mode = "live",
                ProxyTime = "2015-02-16T17:56:53Z",
                Descriptor = "descriptor one",
                ProxyAmount = "50000",
                Currency = Iso4217CurrencyCodes.EUR,
                SentToAcquirer = true
            };

            var successResponseXml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<payment_response>" +
                "<transaction_type>paysafecard</transaction_type>" +
                "<status>pending_async</status>" +
                "<unique_id>bf85ad9ed27dee80b0649e1ff35c61d0</unique_id>" +
                "<transaction_id>asqf12e81eb23d0e00ffb85b1db7db915</transaction_id>" +
                "<technical_message>Transaction successful!</technical_message>" +
                "<message>Transaction successful!</message>" +
                "<redirect_url>https://gateway/redirect/to_acquirer/bf85ad9ed27dee80b0649e1ff35c61d0</redirect_url>" +
                "<mode>live</mode>" +
                "<timestamp>2015-02-16T17:56:53Z</timestamp>" +
                "<descriptor>descriptor one</descriptor>" +
                "<amount>50000</amount>" +
                "<currency>EUR</currency>" +
                "<sent_to_acquirer>true</sent_to_acquirer>" +
                "</payment_response>";

            return new EntityMock<PaySafeCardSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<PaySafeCardErrorResponse> CreatePaySafeCardErrorResponse()
        {
            var errorResponse = new PaySafeCardErrorResponse()
            {
                TransactionType = TransactionTypes.PaySafeCard,
                Status = TransactionStates.Error,
                UniqueId = "bf85ad9ed27dee80b0649e1ff35c61d0",
                TransactionId = "asqf12e81eb23d0e00ffb85b1db7db915",
                Code = (ErrorCodes)110,
                Message = "Something went wrong, please contact support!",
                Mode = "live",
                ProxyTime = "2015-02-16T17:56:53Z",
                Descriptor = "descriptor one",
                ProxyAmount = "50000",
                Currency = Iso4217CurrencyCodes.EUR,
                SentToAcquirer = true
            };

            var errorResponseXml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<payment_response>" +
                "<transaction_type>paysafecard</transaction_type>" +
                "<status>error</status>" +
                "<unique_id>bf85ad9ed27dee80b0649e1ff35c61d0</unique_id>" +
                "<transaction_id>asqf12e81eb23d0e00ffb85b1db7db915</transaction_id>" +
                "<code>110</code>" +
                "<message>Something went wrong, please contact support!</message>" +
                "<mode>live</mode>" +
                "<timestamp>2015-02-16T17:56:53Z</timestamp>" +
                "<descriptor>descriptor one</descriptor>" +
                "<amount>50000</amount>" +
                "<currency>EUR</currency>" +
                "<sent_to_acquirer>true</sent_to_acquirer>" +
                "</payment_response>";

            return new EntityMock<PaySafeCardErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<SofortSuccessResponse> CreateSofortSuccessResponse()
        {
            var successResponse = new SofortSuccessResponse()
            {
                TransactionType = TransactionTypes.Sofort,
                Status = TransactionStates.PendingAsync,
                UniqueId = "9876543210",
                TransactionId = "1234567890",
                TechnicalMessage = "Transaction successful!",
                Message = "Transaction successful!",
                RedirectUrl = "https://gateway/redirect/to_acquirer/bf85ad9ed27dee80b0649e1ff35c61d0",
                Mode = "live",
                ProxyTime = "2015-03-13T08:35:58Z",
                Descriptor = "Descriptor",
                ProxyAmount = "50000",
                Currency = Iso4217CurrencyCodes.EUR,
                SentToAcquirer = true
            };

            var successResponseXml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<payment_response>" +
                "<transaction_type>sofort</transaction_type>" +
                "<status>pending_async</status>" +
                "<unique_id>9876543210</unique_id>" +
                "<transaction_id>1234567890</transaction_id>" +
                "<technical_message>Transaction successful!</technical_message>" +
                "<message>Transaction successful!</message>" +
                "<redirect_url>https://gateway/redirect/to_acquirer/bf85ad9ed27dee80b0649e1ff35c61d0</redirect_url>" +
                "<mode>live</mode>" +
                "<timestamp>2015-03-13T08:35:58Z</timestamp>" +
                "<descriptor>Descriptor</descriptor>" +
                "<amount>50000</amount>" +
                "<currency>EUR</currency>" +
                "<sent_to_acquirer>true</sent_to_acquirer>" +
                "</payment_response>";

            return new EntityMock<SofortSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<SofortErrorResponse> CreateSofortErrorResponse()
        {
            var errorResponse = new SofortErrorResponse()
            {
                TransactionType = TransactionTypes.Sofort,
                Status = TransactionStates.Error,
                UniqueId = "9876543210",
                TransactionId = "1234567890",
                Code = (ErrorCodes)110,
                Message = "Something went wrong, please contact support!",
                Mode = "live",
                ProxyTime = "2015-02-16T17:56:53Z",
                Descriptor = "descriptor one",
                ProxyAmount = "50000",
                Currency = Iso4217CurrencyCodes.EUR,
                SentToAcquirer = true
            };

            var errorResponseXml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<payment_response>" +
                "<transaction_type>sofort</transaction_type>" +
                "<status>error</status>" +
                "<unique_id>9876543210</unique_id>" +
                "<transaction_id>1234567890</transaction_id>" +
                "<code>110</code>" +
                "<message>Something went wrong, please contact support!</message>" +
                "<mode>live</mode>" +
                "<timestamp>2015-02-16T17:56:53Z</timestamp>" +
                "<descriptor>descriptor one</descriptor>" +
                "<amount>50000</amount>" +
                "<currency>EUR</currency>" +
                "<sent_to_acquirer>true</sent_to_acquirer>" +
                "</payment_response>";

            return new EntityMock<SofortErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<SofortiDealSuccessResponse> CreateSofortiDealSuccessResponse()
        {
            var successResponse = new SofortiDealSuccessResponse()
            {
                TransactionType = TransactionTypes.SofortIdeal,
                Status = TransactionStates.PendingAsync,
                UniqueId = "9876543210",
                TransactionId = "1234567890",
                TechnicalMessage = "Transaction successful!",
                Message = "Transaction successful!",
                RedirectUrl = "https://gateway/redirect/to_acquirer/9876543210",
                Mode = "live",
                ProxyTime = "2015-03-13T08:35:58Z",
                Descriptor = "Descriptor",
                ProxyAmount = "50000",
                Currency = Iso4217CurrencyCodes.EUR,
                SentToAcquirer = true
            };

            var successResponseXml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<payment_response>" +
                "<transaction_type>sofort_ideal</transaction_type>" +
                "<status>pending_async</status>" +
                "<unique_id>9876543210</unique_id>" +
                "<transaction_id>1234567890</transaction_id>" +
                "<technical_message>Transaction successful!</technical_message>" +
                "<message>Transaction successful!</message>" +
                "<redirect_url>https://gateway/redirect/to_acquirer/9876543210</redirect_url>" +
                "<mode>live</mode>" +
                "<timestamp>2015-03-13T08:35:58Z</timestamp>" +
                "<descriptor>Descriptor</descriptor>" +
                "<amount>50000</amount>" +
                "<currency>EUR</currency>" +
                "<sent_to_acquirer>true</sent_to_acquirer>" +
                "</payment_response>";

            return new EntityMock<SofortiDealSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<SofortiDealErrorResponse> CreateSofortiDealErrorResponse()
        {
            var errorResponse = new SofortiDealErrorResponse()
            {
                TransactionType = TransactionTypes.SofortIdeal,
                Status = TransactionStates.Error,
                UniqueId = "9876543210",
                TransactionId = "1234567890",
                Code = (ErrorCodes)110,
                Message = "Something went wrong, please contact support!",
                Mode = "live",
                ProxyTime = "2015-02-16T17:56:53Z",
                Descriptor = "descriptor one",
                ProxyAmount = "50000",
                Currency = Iso4217CurrencyCodes.EUR,
                SentToAcquirer = true
            };

            var errorResponseXml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<payment_response>" +
                "<transaction_type>sofort_ideal</transaction_type>" +
                "<status>error</status>" +
                "<unique_id>9876543210</unique_id>" +
                "<transaction_id>1234567890</transaction_id>" +
                "<code>110</code>" +
                "<message>Something went wrong, please contact support!</message>" +
                "<mode>live</mode>" +
                "<timestamp>2015-02-16T17:56:53Z</timestamp>" +
                "<descriptor>descriptor one</descriptor>" +
                "<amount>50000</amount>" +
                "<currency>EUR</currency>" +
                "<sent_to_acquirer>true</sent_to_acquirer>" +
                "</payment_response>";

            return new EntityMock<SofortiDealErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<PproSuccessResponse> CreatePproSuccessResponse()
        {
            var successResponse = new PproSuccessResponse()
            {
                TransactionType = TransactionTypes.Ppro,
                Status = TransactionStates.PendingAsync,
                UniqueId = "bf85ad9ed27dee80b0649e1ff35c61d0",
                TransactionId = "asqf12e81eb23d0e00ffb85b1db7db915",
                TechnicalMessage = "Transaction successful!",
                Message = "Transaction successful!",
                RedirectUrl = "https://gateway/redirect/to_acquirer/bf85ad9ed27dee80b0649e1ff35c61d0",
                Mode = "live",
                ProxyTime = "2015-02-16T17:56:53Z",
                Descriptor = "descriptor one",
                ProxyAmount = "50000",
                Currency = Iso4217CurrencyCodes.EUR,
                SentToAcquirer = true
            };

            var successResponseXml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<payment_response>" +
                "<transaction_type>ppro</transaction_type>" +
                "<status>pending_async</status>" +
                "<unique_id>bf85ad9ed27dee80b0649e1ff35c61d0</unique_id>" +
                "<transaction_id>asqf12e81eb23d0e00ffb85b1db7db915</transaction_id>" +
                "<technical_message>Transaction successful!</technical_message>" +
                "<message>Transaction successful!</message>" +
                "<redirect_url>https://gateway/redirect/to_acquirer/bf85ad9ed27dee80b0649e1ff35c61d0</redirect_url>" +
                "<mode>live</mode>" +
                "<timestamp>2015-02-16T17:56:53Z</timestamp>" +
                "<descriptor>descriptor one</descriptor>" +
                "<amount>50000</amount>" +
                "<currency>EUR</currency>" +
                "<sent_to_acquirer>true</sent_to_acquirer>" +
                "</payment_response>";

            return new EntityMock<PproSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<PproErrorResponse> CreatePproErrorResponse()
        {
            var errorResponse = new PproErrorResponse()
            {
                TransactionType = TransactionTypes.Ppro,
                Status = TransactionStates.Error,
                UniqueId = "bf85ad9ed27dee80b0649e1ff35c61d0",
                TransactionId = "asqf12e81eb23d0e00ffb85b1db7db915",
                Code = (ErrorCodes)110,
                Message = "Something went wrong, please contact support!",
                Mode = "live",
                ProxyTime = "2015-02-16T17:56:53Z",
                Descriptor = "descriptor one",
                ProxyAmount = "50000",
                Currency = Iso4217CurrencyCodes.EUR,
                SentToAcquirer = true
            };

            var errorResponseXml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<payment_response>" +
                "<transaction_type>ppro</transaction_type>" +
                "<status>error</status>" +
                "<unique_id>bf85ad9ed27dee80b0649e1ff35c61d0</unique_id>" +
                "<transaction_id>asqf12e81eb23d0e00ffb85b1db7db915</transaction_id>" +
                "<code>110</code>" +
                "<message>Something went wrong, please contact support!</message>" +
                "<mode>live</mode>" +
                "<timestamp>2015-02-16T17:56:53Z</timestamp>" +
                "<descriptor>descriptor one</descriptor>" +
                "<amount>50000</amount>" +
                "<currency>EUR</currency>" +
                "<sent_to_acquirer>true</sent_to_acquirer>" +
                "</payment_response>";

            return new EntityMock<PproErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<OnlineBankingSuccessResponse> CreateOnlineBankingSuccessResponse1()
        {
            var successResponse = new OnlineBankingSuccessResponse()
            {
                TransactionType = TransactionTypes.OnlineBanking,
                Status = TransactionStates.PendingAsync,
                UniqueId = "44177a21403427eb96664a6d7e5d5d48",
                TransactionId = "119643250547501c79d8295",
                TechnicalMessage = "Transaction successful!",
                Message = "Transaction successful!",
                RedirectUrl = "https://staging.gate.emerchantpay.net/redirect/to_acquirer/649e1ff35c61",
                Mode = "live",
                ProxyTime = "2024-11-18T13:05:56Z",
                Descriptor = "Descriptor one",
                ProxyAmount = "50000",
                Currency = Iso4217CurrencyCodes.CNY,
                SentToAcquirer = true,
                BankCode = "CITIC",
                PaymentType = OnlineBankingPaymentType.AlipayQr
            };

            var successResponseXml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<payment_response>" +
                "<transaction_type>online_banking</transaction_type>" +
                "<status>pending_async</status>" +
                "<mode>live</mode>" +
                "<transaction_id>119643250547501c79d8295</transaction_id>" +
                "<unique_id>44177a21403427eb96664a6d7e5d5d48</unique_id>" +
                "<technical_message>Transaction successful!</technical_message>" +
                "<message>Transaction successful!</message>" +
                "<redirect_url>https://staging.gate.emerchantpay.net/redirect/to_acquirer/649e1ff35c61</redirect_url>" +
                "<timestamp>2024-11-18T13:05:56Z</timestamp>" +
                "<descriptor>Descriptor one</descriptor>" +
                "<amount>50000</amount>" +
                "<currency>CNY</currency>" +
                "<sent_to_acquirer>true</sent_to_acquirer>" +
                "<bank_code>CITIC</bank_code>" +
                "<payment_type>alipay_qr</payment_type>" +
                "</payment_response>";

            return new EntityMock<OnlineBankingSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<OnlineBankingSuccessResponse> CreateOnlineBankingSuccessResponse2()
        {
            var successResponse = new OnlineBankingSuccessResponse()
            {
                TransactionType = TransactionTypes.OnlineBanking,
                Status = TransactionStates.PendingAsync,
                UniqueId = "44177a21403427eb96664a6d7e5d5d48",
                TransactionId = "119643250547501c79d8295",
                TechnicalMessage = "Transaction successful!",
                Message = "Transaction successful!",
                RedirectUrl = "https://staging.gate.emerchantpay.net/redirect/to_acquirer/649e1ff35c61",
                Mode = "live",
                ProxyTime = "2024-11-18T13:05:56Z",
                Descriptor = "Descriptor one",
                ProxyAmount = "50000",
                Currency = Iso4217CurrencyCodes.MXN,
                SentToAcquirer = true,
                BankCode = "SE",
                PaymentType = OnlineBankingPaymentType.OnlineBanking,
                AccountDetails = new AccountDetailsModel()
                {
                    ReferenceNumber = "1000210",
                    AccountNumber = "646180320000000006"
                }
            };
            var successResponseXml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<payment_response>" +
                "<transaction_type>online_banking</transaction_type>" +
                "<status>pending_async</status>" +
                "<mode>live</mode>" +
                "<transaction_id>119643250547501c79d8295</transaction_id>" +
                "<unique_id>44177a21403427eb96664a6d7e5d5d48</unique_id>" +
                "<technical_message>Transaction successful!</technical_message>" +
                "<message>Transaction successful!</message>" +
                "<timestamp>2024-11-18T13:05:56Z</timestamp>" +
                "<descriptor>Descriptor one</descriptor>" +
                "<amount>50000</amount>" +
                "<currency>MXN</currency>" +
                "<sent_to_acquirer>true</sent_to_acquirer>" +
                "<bank_code>SE</bank_code>" +
                "<payment_type>online_banking</payment_type>" +
                "<account_details>" +
                    "<reference_number>1000210</reference_number>" +
                    "<account_number>646180320000000006</account_number>" +
                "</account_details>" +
                "</payment_response>";

            return new EntityMock<OnlineBankingSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<OnlineBankingErrorResponse> CreateOnlineBankingErrorResponse()
        {
            var errorResponse = new OnlineBankingErrorResponse()
            {
                TransactionType = TransactionTypes.OnlineBanking,
                Status = TransactionStates.Error,
                UniqueId = "44177a21403427eb96664a6d7e5d5d48",
                TransactionId = "119643250547501c79d8295",
                Code = (ErrorCodes)110,
                TechnicalMessage = "amount is missing",
                Message = "Please check input data for errors!",
                Mode = "live",
                ProxyTime = "2024-11-18T13:05:56Z",
                Descriptor = "Descriptor one",
                ProxyAmount = "50000",
                Currency = Iso4217CurrencyCodes.CNY,
                SentToAcquirer = true
            };

            var errorResponseXml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<payment_response>" +
                "<transaction_type>online_banking</transaction_type>" +
                "<status>error</status>" +
                "<mode>live</mode>" +
                "<transaction_id>119643250547501c79d8295</transaction_id>" +
                "<unique_id>44177a21403427eb96664a6d7e5d5d48</unique_id>" +
                "<code>110</code>" +
                "<technical_message>amount is missing</technical_message>" +
                "<message>Please check input data for errors!</message>" +
                "<timestamp>2024-11-18T13:05:56Z</timestamp>" +
                "<descriptor>Descriptor one</descriptor>" +
                "<amount>50000</amount>" +
                "<currency>CNY</currency>" +
                "<sent_to_acquirer>true</sent_to_acquirer>" +
                "<bank_code>CITIC</bank_code>" +
                "<payment_type>online_banking</payment_type>" +
                "</payment_response>";

            return new EntityMock<OnlineBankingErrorResponse>(errorResponse, errorResponseXml);
        }

        public static EntityMock<BankPayoutSuccessResponse> CreateBankPayoutSuccessResponse()
        {
            var successResponse = new BankPayoutSuccessResponse()
            {
                TransactionType = TransactionTypes.BankPayout,
                Status = TransactionStates.PendingAsync,
                UniqueId = "44177a21403427eb96664a6d7e5d5d48",
                TransactionId = "119643250547501c79d8295",
                TechnicalMessage = "Transaction successful!",
                Message = "Transaction successful!",
                Mode = "live",
                ProxyTime = "2024-11-18T13:06:00Z",
                Descriptor = "Descriptor one",
                ProxyAmount = "50000",
                Currency = Iso4217CurrencyCodes.INR,
                SentToAcquirer = true
            };
            var successResponseXml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<payment_response>" +
                    "<transaction_type>bank_payout</transaction_type>" +
                    "<status>pending_async</status>" +
                    "<mode>live</mode>" +
                    "<transaction_id>119643250547501c79d8295</transaction_id>" +
                    "<unique_id>44177a21403427eb96664a6d7e5d5d48</unique_id>" +
                    "<technical_message>Transaction successful!</technical_message>" +
                    "<message>Transaction successful!</message>" +
                    "<timestamp>2024-11-18T13:06:00Z</timestamp>" +
                    "<descriptor>Descriptor one</descriptor>" +
                    "<amount>50000</amount>" +
                    "<currency>INR</currency>" +
                    "<sent_to_acquirer>true</sent_to_acquirer>" +
                "</payment_response>";

            return new EntityMock<BankPayoutSuccessResponse>(successResponse, successResponseXml);
        }

        public static EntityMock<BankPayoutErrorResponse> CreateBankPayoutErrorResponse()
        {
            var errorResponse = new BankPayoutErrorResponse()
            {
                TransactionType = TransactionTypes.OnlineBanking,
                Status = TransactionStates.Error,
                UniqueId = "44177a21403427eb96664a6d7e5d5d48",
                TransactionId = "119643250547501c79d8295",
                Code = (ErrorCodes)110,
                TechnicalMessage = "amount is missing",
                Message = "Please check input data for errors!",
                Mode = "live",
                ProxyTime = "2024-11-18T13:05:56Z",
                Descriptor = "Descriptor one",
                ProxyAmount = "50000",
                Currency = Iso4217CurrencyCodes.CNY,
                SentToAcquirer = true
            };

            var errorResponseXml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<payment_response>" +
                "<transaction_type>online_banking</transaction_type>" +
                "<status>error</status>" +
                "<mode>live</mode>" +
                "<transaction_id>119643250547501c79d8295</transaction_id>" +
                "<unique_id>44177a21403427eb96664a6d7e5d5d48</unique_id>" +
                "<code>110</code>" +
                "<technical_message>amount is missing</technical_message>" +
                "<message>Please check input data for errors!</message>" +
                "<timestamp>2024-11-18T13:05:56Z</timestamp>" +
                "<descriptor>Descriptor one</descriptor>" +
                "<amount>50000</amount>" +
                "<currency>CNY</currency>" +
                "<sent_to_acquirer>true</sent_to_acquirer>" +
                "<bank_code>CITIC</bank_code>" +
                "<payment_type>online_banking</payment_type>" +
                "</payment_response>";

            return new EntityMock<BankPayoutErrorResponse>(errorResponse, errorResponseXml);
        }



    }
}
