using System;
using System.Linq;
using Genesis.Net.Common;
using Genesis.Net.Entities;
using Genesis.Net.Entities.Requests.Initial;
using Genesis.Net.Entities.Requests.Initial.ThreeD;
using Genesis.Net.Entities.Requests.Query;
using Genesis.Net.Entities.Requests.Referential;
using System.Collections.Generic;

namespace Genesis.Net.Specs.Mocks
{
    static class RequestMocksFactory
    {
        public static EntityMock<Authorize> CreateValidAuthorize()
        {
            var authorize = new Authorize()
            {
                Id = "id",
                Usage = "usage",
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                RemoteIp = "255.10.100.10",
                CardHolder = "card holder",
                ExpirationMonth = 1,
                ExpirationYear = 2025,
                CustomerEmail = "hello@world.com",
                CustomerPhone = "phone number",
                CardNumber = CardsNumbers.Visa3dSecureEnrolled,
                Cvv = "123",
                BillingAddress = new Address()
                {
                    Address1 = "billing address1",
                    Address2 = "billing address2",
                    City = "billing city",
                    Country = Iso3166CountryCodes.BG,
                    FirstName = "billing first name",
                    LastName = "billing last name",
                    State = "BS",
                    ZipCode = "1000"
                },
                ShippingAddress = new Address()
                {
                    Address1 = "shipping address1",
                    Address2 = "shipping address2",
                    City = "shipping city",
                    Country = Iso3166CountryCodes.BG,
                    FirstName = "shipping first name",
                    LastName = "shipping last name",
                    State = "BS",
                    ZipCode = "1000"
                },
                RiskParams = new RiskParams()
                {
                    Email = "hello@world.com",
                    MacAddress = "mac address",
                    Phone = "phone",
                    RemoteIp = "255.10.100.10",
                    SerialNumber = "serial number",
                    SessionId = "session id",
                    Ssn = "ssn",
                    UserId = "user id",
                    UserLevel = "user level"
                },
                DynamicDescriptorParams = new DynamicDescriptor()
                {
                    MerchantName = "Test Merchant",
                    MerchantCity = "Testing Town"
                }
            };

            var xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                      "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"Authorize\">" +
                      "<transaction_type>authorize</transaction_type>" +
                      "<transaction_id>id</transaction_id>" +
                      "<usage>usage</usage>" +
                      "<amount>100</amount>" +
                      "<currency>USD</currency>" +
                      "<remote_ip>255.10.100.10</remote_ip>" +
                      "<card_holder>card holder</card_holder>" +
                      "<expiration_month>01</expiration_month>" +
                      "<expiration_year>2025</expiration_year>" +
                      "<customer_email>hello@world.com</customer_email>" +
                      "<customer_phone>phone number</customer_phone>" +
                      "<card_number>4711100000000000</card_number>" +
                      "<cvv>123</cvv>" +
                      "<billing_address>" +
                      "<first_name>billing first name</first_name>" +
                      "<last_name>billing last name</last_name>" +
                      "<address1>billing address1</address1>" +
                      "<address2>billing address2</address2>" +
                      "<zip_code>1000</zip_code>" +
                      "<city>billing city</city>" +
                      "<state>BS</state>" +
                      "<country>BG</country>" +
                      "</billing_address>" +
                      "<shipping_address>" +
                      "<first_name>shipping first name</first_name>" +
                      "<last_name>shipping last name</last_name>" +
                      "<address1>shipping address1</address1>" +
                      "<address2>shipping address2</address2>" +
                      "<zip_code>1000</zip_code>" +
                      "<city>shipping city</city>" +
                      "<state>BS</state>" +
                      "<country>BG</country>" +
                      "</shipping_address>" +
                      "<risk_params>" +
                      "<ssn>ssn</ssn>" +
                      "<mac_address>mac address</mac_address>" +
                      "<session_id>session id</session_id>" +
                      "<user_id>user id</user_id>" +
                      "<user_level>user level</user_level>" +
                      "<email>hello@world.com</email>" +
                      "<phone>phone</phone>" +
                      "<remote_ip>255.10.100.10</remote_ip>" +
                      "<serial_number>serial number</serial_number>" +
                      "</risk_params>" +
                      "<dynamic_descriptor_params>" +
                      "<merchant_name>Test Merchant</merchant_name>" +
                      "<merchant_city>Testing Town</merchant_city>" +
                      "</dynamic_descriptor_params>" +
                      "</payment_transaction>";

            return new EntityMock<Authorize>(authorize, xml);
        }

        public static EntityMock<Authorize3dAsync> CreateValidAuthorize3dAsync()
        {
            var authorize3dAsync = new Authorize3dAsync()
            {
                Id = "id",
                Usage = "usage",
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                RemoteIp = "255.10.100.10",
                CardHolder = "card holder",
                ExpirationMonth = 1,
                ExpirationYear = 2025,
                CustomerEmail = "hello@world.com",
                CustomerPhone = "phone number",
                CardNumber = CardsNumbers.Visa3dSecureEnrolled,
                Cvv = "123",
                NotificationUrl = "https://example.com/notify",
                ReturnSuccessUrl = "http://test.com/success",
                ReturnFailureUrl = "http://test.com/fail",
                BillingAddress = new Address()
                {
                    Address1 = "billing address1",
                    Address2 = "billing address2",
                    City = "billing city",
                    Country = Iso3166CountryCodes.BG,
                    FirstName = "billing first name",
                    LastName = "billing last name",
                    State = "BS",
                    ZipCode = "1000"
                },
                ShippingAddress = new Address()
                {
                    Address1 = "shipping address1",
                    Address2 = "shipping address2",
                    City = "shipping city",
                    Country = Iso3166CountryCodes.BG,
                    FirstName = "shipping first name",
                    LastName = "shipping last name",
                    State = "BS",
                    ZipCode = "1000"
                },
                RiskParams = new RiskParams()
                {
                    Email = "hello@world.com",
                    MacAddress = "mac address",
                    Phone = "phone",
                    RemoteIp = "255.10.100.10",
                    SerialNumber = "serial number",
                    SessionId = "session id",
                    Ssn = "ssn",
                    UserId = "user id",
                    UserLevel = "user level"
                },
                DynamicDescriptorParams = new DynamicDescriptor()
                {
                    MerchantName = "Test Merchant",
                    MerchantCity = "Testing Town"
                },
            };

            var xml =
                     "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                     "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"Authorize3DAsync\">" +
                     "<transaction_type>authorize3d</transaction_type>" +
                     "<transaction_id>id</transaction_id>" +
                     "<usage>usage</usage>" +
                     "<amount>100</amount>" +
                     "<currency>USD</currency>" +
                     "<remote_ip>255.10.100.10</remote_ip>" +
                     "<card_holder>card holder</card_holder>" +
                     "<expiration_month>01</expiration_month>" +
                     "<expiration_year>2025</expiration_year>" +
                     "<customer_email>hello@world.com</customer_email>" +
                     "<customer_phone>phone number</customer_phone>" +
                     "<card_number>4711100000000000</card_number>" +
                     "<cvv>123</cvv>" +
                     "<billing_address>" +
                     "<first_name>billing first name</first_name>" +
                     "<last_name>billing last name</last_name>" +
                     "<address1>billing address1</address1>" +
                     "<address2>billing address2</address2>" +
                     "<zip_code>1000</zip_code>" +
                     "<city>billing city</city>" +
                     "<state>BS</state>" +
                     "<country>BG</country>" +
                     "</billing_address>" +
                     "<shipping_address>" +
                     "<first_name>shipping first name</first_name>" +
                     "<last_name>shipping last name</last_name>" +
                     "<address1>shipping address1</address1>" +
                     "<address2>shipping address2</address2>" +
                     "<zip_code>1000</zip_code>" +
                     "<city>shipping city</city>" +
                     "<state>BS</state>" +
                     "<country>BG</country>" +
                     "</shipping_address>" +
                     "<risk_params>" +
                     "<ssn>ssn</ssn>" +
                     "<mac_address>mac address</mac_address>" +
                     "<session_id>session id</session_id>" +
                     "<user_id>user id</user_id>" +
                     "<user_level>user level</user_level>" +
                     "<email>hello@world.com</email>" +
                     "<phone>phone</phone>" +
                     "<remote_ip>255.10.100.10</remote_ip>" +
                     "<serial_number>serial number</serial_number>" +
                     "</risk_params>" +
                     "<dynamic_descriptor_params>" +
                     "<merchant_name>Test Merchant</merchant_name>" +
                     "<merchant_city>Testing Town</merchant_city>" +
                     "</dynamic_descriptor_params>" +
                     "<notification_url>https://example.com/notify</notification_url>" +
                     "<return_success_url>http://test.com/success</return_success_url>" +
                     "<return_failure_url>http://test.com/fail</return_failure_url>" +
                     "</payment_transaction>";

            return new EntityMock<Authorize3dAsync>(authorize3dAsync, xml);
        }

        public static EntityMock<Authorize3dSync> CreateValidAuthorize3dSync()
        {
            var authorize3dSync = new Authorize3dSync()
            {
                Id = "id",
                Usage = "usage",
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                RemoteIp = "255.10.100.10",
                CardHolder = "card holder",
                ExpirationMonth = 1,
                ExpirationYear = 2025,
                CustomerEmail = "hello@world.com",
                CustomerPhone = "phone number",
                CardNumber = CardsNumbers.Visa3dSecureEnrolled,
                Cvv = "123",
                BillingAddress = new Address()
                {
                    Address1 = "billing address1",
                    Address2 = "billing address2",
                    City = "billing city",
                    Country = Iso3166CountryCodes.BG,
                    FirstName = "billing first name",
                    LastName = "billing last name",
                    State = "BS",
                    ZipCode = "1000"
                },
                ShippingAddress = new Address()
                {
                    Address1 = "shipping address1",
                    Address2 = "shipping address2",
                    City = "shipping city",
                    Country = Iso3166CountryCodes.BG,
                    FirstName = "shipping first name",
                    LastName = "shipping last name",
                    State = "BS",
                    ZipCode = "1000"
                },
                RiskParams = new RiskParams()
                {
                    Email = "hello@world.com",
                    MacAddress = "mac address",
                    Phone = "phone",
                    RemoteIp = "255.10.100.10",
                    SerialNumber = "serial number",
                    SessionId = "session id",
                    Ssn = "ssn",
                    UserId = "user id",
                    UserLevel = "user level"
                },
                DynamicDescriptorParams = new DynamicDescriptor()
                {
                    MerchantName = "Test Merchant",
                    MerchantCity = "Testing Town"
                },
                MpiParams = new MpiParams()
                {
                    Cavv = "Testing Cavv",
                    Eci = "Testing Eci",
                    Xid = "Testing Xid"
                }
            };

            var xml =
                     "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                     "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"Authorize3DSync\">" +
                     "<transaction_type>authorize3d</transaction_type>" +
                     "<transaction_id>id</transaction_id>" +
                     "<usage>usage</usage>" +
                     "<amount>100</amount>" +
                     "<currency>USD</currency>" +
                     "<remote_ip>255.10.100.10</remote_ip>" +
                     "<card_holder>card holder</card_holder>" +
                     "<expiration_month>01</expiration_month>" +
                     "<expiration_year>2025</expiration_year>" +
                     "<customer_email>hello@world.com</customer_email>" +
                     "<customer_phone>phone number</customer_phone>" +
                     "<card_number>4711100000000000</card_number>" +
                     "<cvv>123</cvv>" +
                     "<billing_address>" +
                     "<first_name>billing first name</first_name>" +
                     "<last_name>billing last name</last_name>" +
                     "<address1>billing address1</address1>" +
                     "<address2>billing address2</address2>" +
                     "<zip_code>1000</zip_code>" +
                     "<city>billing city</city>" +
                     "<state>BS</state>" +
                     "<country>BG</country>" +
                     "</billing_address>" +
                     "<shipping_address>" +
                     "<first_name>shipping first name</first_name>" +
                     "<last_name>shipping last name</last_name>" +
                     "<address1>shipping address1</address1>" +
                     "<address2>shipping address2</address2>" +
                     "<zip_code>1000</zip_code>" +
                     "<city>shipping city</city>" +
                     "<state>BS</state>" +
                     "<country>BG</country>" +
                     "</shipping_address>" +
                     "<risk_params>" +
                     "<ssn>ssn</ssn>" +
                     "<mac_address>mac address</mac_address>" +
                     "<session_id>session id</session_id>" +
                     "<user_id>user id</user_id>" +
                     "<user_level>user level</user_level>" +
                     "<email>hello@world.com</email>" +
                     "<phone>phone</phone>" +
                     "<remote_ip>255.10.100.10</remote_ip>" +
                     "<serial_number>serial number</serial_number>" +
                     "</risk_params>" +
                     "<dynamic_descriptor_params>" +
                     "<merchant_name>Test Merchant</merchant_name>" +
                     "<merchant_city>Testing Town</merchant_city>" +
                     "</dynamic_descriptor_params>" +
                     "<mpi_params>" +
                     "<cavv>Testing Cavv</cavv>" +
                     "<eci>Testing Eci</eci>" +
                     "<xid>Testing Xid</xid>" +
                     "</mpi_params>" +
                     "</payment_transaction>";

            return new EntityMock<Authorize3dSync>(authorize3dSync, xml);
        }

        public static EntityMock<InitRecurringSale3dAsync> CreateValidInitRecurringSale3dAsync()
        {
            var initRecurringSale3dAsync = new InitRecurringSale3dAsync()
            {
                Id = "id",
                Usage = "usage",
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                RemoteIp = "255.10.100.10",
                CardHolder = "card holder",
                ExpirationMonth = 1,
                ExpirationYear = 2025,
                CustomerEmail = "hello@world.com",
                CustomerPhone = "phone number",
                CardNumber = CardsNumbers.Visa3dSecureEnrolled,
                Cvv = "123",
                NotificationUrl = "https://example.com/notify",
                ReturnSuccessUrl = "http://test.com/success",
                ReturnFailureUrl = "http://test.com/fail",
                BillingAddress = new Address()
                {
                    Address1 = "billing address1",
                    Address2 = "billing address2",
                    City = "billing city",
                    Country = Iso3166CountryCodes.BG,
                    FirstName = "billing first name",
                    LastName = "billing last name",
                    State = "BS",
                    ZipCode = "1000"
                },
                ShippingAddress = new Address()
                {
                    Address1 = "shipping address1",
                    Address2 = "shipping address2",
                    City = "shipping city",
                    Country = Iso3166CountryCodes.BG,
                    FirstName = "shipping first name",
                    LastName = "shipping last name",
                    State = "BS",
                    ZipCode = "1000"
                },
                RiskParams = new RiskParams()
                {
                    Email = "hello@world.com",
                    MacAddress = "mac address",
                    Phone = "phone",
                    RemoteIp = "255.10.100.10",
                    SerialNumber = "serial number",
                    SessionId = "session id",
                    Ssn = "ssn",
                    UserId = "user id",
                    UserLevel = "user level"
                },
                DynamicDescriptorParams = new DynamicDescriptor()
                {
                    MerchantName = "Test Merchant",
                    MerchantCity = "Testing Town"
                },
            };

            var xml =
                     "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                     "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"InitRecurringSale3DAsync\">" +
                     "<transaction_type>init_recurring_sale3d</transaction_type>" +
                     "<transaction_id>id</transaction_id>" +
                     "<usage>usage</usage>" +
                     "<amount>100</amount>" +
                     "<currency>USD</currency>" +
                     "<remote_ip>255.10.100.10</remote_ip>" +
                     "<card_holder>card holder</card_holder>" +
                     "<expiration_month>01</expiration_month>" +
                     "<expiration_year>2025</expiration_year>" +
                     "<customer_email>hello@world.com</customer_email>" +
                     "<customer_phone>phone number</customer_phone>" +
                     "<card_number>4711100000000000</card_number>" +
                     "<cvv>123</cvv>" +
                     "<billing_address>" +
                     "<first_name>billing first name</first_name>" +
                     "<last_name>billing last name</last_name>" +
                     "<address1>billing address1</address1>" +
                     "<address2>billing address2</address2>" +
                     "<zip_code>1000</zip_code>" +
                     "<city>billing city</city>" +
                     "<state>BS</state>" +
                     "<country>BG</country>" +
                     "</billing_address>" +
                     "<shipping_address>" +
                     "<first_name>shipping first name</first_name>" +
                     "<last_name>shipping last name</last_name>" +
                     "<address1>shipping address1</address1>" +
                     "<address2>shipping address2</address2>" +
                     "<zip_code>1000</zip_code>" +
                     "<city>shipping city</city>" +
                     "<state>BS</state>" +
                     "<country>BG</country>" +
                     "</shipping_address>" +
                     "<risk_params>" +
                     "<ssn>ssn</ssn>" +
                     "<mac_address>mac address</mac_address>" +
                     "<session_id>session id</session_id>" +
                     "<user_id>user id</user_id>" +
                     "<user_level>user level</user_level>" +
                     "<email>hello@world.com</email>" +
                     "<phone>phone</phone>" +
                     "<remote_ip>255.10.100.10</remote_ip>" +
                     "<serial_number>serial number</serial_number>" +
                     "</risk_params>" +
                     "<dynamic_descriptor_params>" +
                     "<merchant_name>Test Merchant</merchant_name>" +
                     "<merchant_city>Testing Town</merchant_city>" +
                     "</dynamic_descriptor_params>" +
                     "<notification_url>https://example.com/notify</notification_url>" +
                     "<return_success_url>http://test.com/success</return_success_url>" +
                     "<return_failure_url>http://test.com/fail</return_failure_url>" +
                     "</payment_transaction>";

            return new EntityMock<InitRecurringSale3dAsync>(initRecurringSale3dAsync, xml);
        }

        public static EntityMock<InitRecurringSale3dSync> CreateValidInitRecurringSale3dSync()
        {
            var initRecurringSale3dSync = new InitRecurringSale3dSync()
            {
                Id = "id",
                Usage = "usage",
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                RemoteIp = "255.10.100.10",
                CardHolder = "card holder",
                ExpirationMonth = 1,
                ExpirationYear = 2025,
                CustomerEmail = "hello@world.com",
                CustomerPhone = "phone number",
                CardNumber = CardsNumbers.Visa3dSecureEnrolled,
                Cvv = "123",
                BillingAddress = new Address()
                {
                    Address1 = "billing address1",
                    Address2 = "billing address2",
                    City = "billing city",
                    Country = Iso3166CountryCodes.BG,
                    FirstName = "billing first name",
                    LastName = "billing last name",
                    State = "BS",
                    ZipCode = "1000"
                },
                ShippingAddress = new Address()
                {
                    Address1 = "shipping address1",
                    Address2 = "shipping address2",
                    City = "shipping city",
                    Country = Iso3166CountryCodes.BG,
                    FirstName = "shipping first name",
                    LastName = "shipping last name",
                    State = "BS",
                    ZipCode = "1000"
                },
                RiskParams = new RiskParams()
                {
                    Email = "hello@world.com",
                    MacAddress = "mac address",
                    Phone = "phone",
                    RemoteIp = "255.10.100.10",
                    SerialNumber = "serial number",
                    SessionId = "session id",
                    Ssn = "ssn",
                    UserId = "user id",
                    UserLevel = "user level"
                },
                DynamicDescriptorParams = new DynamicDescriptor()
                {
                    MerchantName = "Test Merchant",
                    MerchantCity = "Testing Town"
                },
                MpiParams = new MpiParams()
                {
                    Cavv = "Testing Cavv",
                    Eci = "Testing Eci",
                    Xid = "Testing Xid"
                }
            };

            var xml =
                     "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                     "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"InitRecurringSale3DSync\">" +
                     "<transaction_type>init_recurring_sale3d</transaction_type>" +
                     "<transaction_id>id</transaction_id>" +
                     "<usage>usage</usage>" +
                     "<amount>100</amount>" +
                     "<currency>USD</currency>" +
                     "<remote_ip>255.10.100.10</remote_ip>" +
                     "<card_holder>card holder</card_holder>" +
                     "<expiration_month>01</expiration_month>" +
                     "<expiration_year>2025</expiration_year>" +
                     "<customer_email>hello@world.com</customer_email>" +
                     "<customer_phone>phone number</customer_phone>" +
                     "<card_number>4711100000000000</card_number>" +
                     "<cvv>123</cvv>" +
                     "<billing_address>" +
                     "<first_name>billing first name</first_name>" +
                     "<last_name>billing last name</last_name>" +
                     "<address1>billing address1</address1>" +
                     "<address2>billing address2</address2>" +
                     "<zip_code>1000</zip_code>" +
                     "<city>billing city</city>" +
                     "<state>BS</state>" +
                     "<country>BG</country>" +
                     "</billing_address>" +
                     "<shipping_address>" +
                     "<first_name>shipping first name</first_name>" +
                     "<last_name>shipping last name</last_name>" +
                     "<address1>shipping address1</address1>" +
                     "<address2>shipping address2</address2>" +
                     "<zip_code>1000</zip_code>" +
                     "<city>shipping city</city>" +
                     "<state>BS</state>" +
                     "<country>BG</country>" +
                     "</shipping_address>" +
                     "<risk_params>" +
                     "<ssn>ssn</ssn>" +
                     "<mac_address>mac address</mac_address>" +
                     "<session_id>session id</session_id>" +
                     "<user_id>user id</user_id>" +
                     "<user_level>user level</user_level>" +
                     "<email>hello@world.com</email>" +
                     "<phone>phone</phone>" +
                     "<remote_ip>255.10.100.10</remote_ip>" +
                     "<serial_number>serial number</serial_number>" +
                     "</risk_params>" +
                     "<dynamic_descriptor_params>" +
                     "<merchant_name>Test Merchant</merchant_name>" +
                     "<merchant_city>Testing Town</merchant_city>" +
                     "</dynamic_descriptor_params>" +
                     "<mpi_params>" +
                     "<cavv>Testing Cavv</cavv>" +
                     "<eci>Testing Eci</eci>" +
                     "<xid>Testing Xid</xid>" +
                     "</mpi_params>" +
                     "</payment_transaction>";

            return new EntityMock<InitRecurringSale3dSync>(initRecurringSale3dSync, xml);
        }

        public static EntityMock<Sale3dAsync> CreateValidSale3dAsync()
        {
            var sale3dAsync = new Sale3dAsync()
            {
                Id = "id",
                Usage = "usage",
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                RemoteIp = "255.10.100.10",
                CardHolder = "card holder",
                ExpirationMonth = 1,
                ExpirationYear = 2025,
                CustomerEmail = "hello@world.com",
                CustomerPhone = "phone number",
                CardNumber = CardsNumbers.Visa3dSecureEnrolled,
                Cvv = "123",
                NotificationUrl = "https://example.com/notify",
                ReturnSuccessUrl = "http://test.com/success",
                ReturnFailureUrl = "http://test.com/fail",
                BillingAddress = new Address()
                {
                    Address1 = "billing address1",
                    Address2 = "billing address2",
                    City = "billing city",
                    Country = Iso3166CountryCodes.BG,
                    FirstName = "billing first name",
                    LastName = "billing last name",
                    State = "BS",
                    ZipCode = "1000"
                },
                ShippingAddress = new Address()
                {
                    Address1 = "shipping address1",
                    Address2 = "shipping address2",
                    City = "shipping city",
                    Country = Iso3166CountryCodes.BG,
                    FirstName = "shipping first name",
                    LastName = "shipping last name",
                    State = "BS",
                    ZipCode = "1000"
                },
                RiskParams = new RiskParams()
                {
                    Email = "hello@world.com",
                    MacAddress = "mac address",
                    Phone = "phone",
                    RemoteIp = "255.10.100.10",
                    SerialNumber = "serial number",
                    SessionId = "session id",
                    Ssn = "ssn",
                    UserId = "user id",
                    UserLevel = "user level"
                },
                DynamicDescriptorParams = new DynamicDescriptor()
                {
                    MerchantName = "Test Merchant",
                    MerchantCity = "Testing Town"
                },
            };

            var xml =
                     "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                     "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"Sale3DAsync\">" +
                     "<transaction_type>sale3d</transaction_type>" +
                     "<transaction_id>id</transaction_id>" +
                     "<usage>usage</usage>" +
                     "<amount>100</amount>" +
                     "<currency>USD</currency>" +
                     "<remote_ip>255.10.100.10</remote_ip>" +
                     "<card_holder>card holder</card_holder>" +
                     "<expiration_month>01</expiration_month>" +
                     "<expiration_year>2025</expiration_year>" +
                     "<customer_email>hello@world.com</customer_email>" +
                     "<customer_phone>phone number</customer_phone>" +
                     "<card_number>4711100000000000</card_number>" +
                     "<cvv>123</cvv>" +
                     "<billing_address>" +
                     "<first_name>billing first name</first_name>" +
                     "<last_name>billing last name</last_name>" +
                     "<address1>billing address1</address1>" +
                     "<address2>billing address2</address2>" +
                     "<zip_code>1000</zip_code>" +
                     "<city>billing city</city>" +
                     "<state>BS</state>" +
                     "<country>BG</country>" +
                     "</billing_address>" +
                     "<shipping_address>" +
                     "<first_name>shipping first name</first_name>" +
                     "<last_name>shipping last name</last_name>" +
                     "<address1>shipping address1</address1>" +
                     "<address2>shipping address2</address2>" +
                     "<zip_code>1000</zip_code>" +
                     "<city>shipping city</city>" +
                     "<state>BS</state>" +
                     "<country>BG</country>" +
                     "</shipping_address>" +
                     "<risk_params>" +
                     "<ssn>ssn</ssn>" +
                     "<mac_address>mac address</mac_address>" +
                     "<session_id>session id</session_id>" +
                     "<user_id>user id</user_id>" +
                     "<user_level>user level</user_level>" +
                     "<email>hello@world.com</email>" +
                     "<phone>phone</phone>" +
                     "<remote_ip>255.10.100.10</remote_ip>" +
                     "<serial_number>serial number</serial_number>" +
                     "</risk_params>" +
                     "<dynamic_descriptor_params>" +
                     "<merchant_name>Test Merchant</merchant_name>" +
                     "<merchant_city>Testing Town</merchant_city>" +
                     "</dynamic_descriptor_params>" +
                     "<notification_url>https://example.com/notify</notification_url>" +
                     "<return_success_url>http://test.com/success</return_success_url>" +
                     "<return_failure_url>http://test.com/fail</return_failure_url>" +
                     "</payment_transaction>";

            return new EntityMock<Sale3dAsync>(sale3dAsync, xml);
        }

        public static EntityMock<Sale3dSync> CreateValidSale3dSync()
        {
            var sale3dSync = new Sale3dSync()
            {
                Id = "id",
                Usage = "usage",
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                RemoteIp = "255.10.100.10",
                CardHolder = "card holder",
                ExpirationMonth = 1,
                ExpirationYear = 2025,
                CustomerEmail = "hello@world.com",
                CustomerPhone = "phone number",
                CardNumber = CardsNumbers.Visa3dSecureEnrolled,
                Cvv = "123",
                BillingAddress = new Address()
                {
                    Address1 = "billing address1",
                    Address2 = "billing address2",
                    City = "billing city",
                    Country = Iso3166CountryCodes.BG,
                    FirstName = "billing first name",
                    LastName = "billing last name",
                    State = "BS",
                    ZipCode = "1000"
                },
                ShippingAddress = new Address()
                {
                    Address1 = "shipping address1",
                    Address2 = "shipping address2",
                    City = "shipping city",
                    Country = Iso3166CountryCodes.BG,
                    FirstName = "shipping first name",
                    LastName = "shipping last name",
                    State = "BS",
                    ZipCode = "1000"
                },
                RiskParams = new RiskParams()
                {
                    Email = "hello@world.com",
                    MacAddress = "mac address",
                    Phone = "phone",
                    RemoteIp = "255.10.100.10",
                    SerialNumber = "serial number",
                    SessionId = "session id",
                    Ssn = "ssn",
                    UserId = "user id",
                    UserLevel = "user level"
                },
                DynamicDescriptorParams = new DynamicDescriptor()
                {
                    MerchantName = "Test Merchant",
                    MerchantCity = "Testing Town"
                },
                MpiParams = new MpiParams()
                {
                    Cavv = "Testing Cavv",
                    Eci = "Testing Eci",
                    Xid = "Testing Xid"
                }
            };

            var xml =
                     "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                     "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"Sale3DSync\">" +
                     "<transaction_type>sale3d</transaction_type>" +
                     "<transaction_id>id</transaction_id>" +
                     "<usage>usage</usage>" +
                     "<amount>100</amount>" +
                     "<currency>USD</currency>" +
                     "<remote_ip>255.10.100.10</remote_ip>" +
                     "<card_holder>card holder</card_holder>" +
                     "<expiration_month>01</expiration_month>" +
                     "<expiration_year>2025</expiration_year>" +
                     "<customer_email>hello@world.com</customer_email>" +
                     "<customer_phone>phone number</customer_phone>" +
                     "<card_number>4711100000000000</card_number>" +
                     "<cvv>123</cvv>" +
                     "<billing_address>" +
                     "<first_name>billing first name</first_name>" +
                     "<last_name>billing last name</last_name>" +
                     "<address1>billing address1</address1>" +
                     "<address2>billing address2</address2>" +
                     "<zip_code>1000</zip_code>" +
                     "<city>billing city</city>" +
                     "<state>BS</state>" +
                     "<country>BG</country>" +
                     "</billing_address>" +
                     "<shipping_address>" +
                     "<first_name>shipping first name</first_name>" +
                     "<last_name>shipping last name</last_name>" +
                     "<address1>shipping address1</address1>" +
                     "<address2>shipping address2</address2>" +
                     "<zip_code>1000</zip_code>" +
                     "<city>shipping city</city>" +
                     "<state>BS</state>" +
                     "<country>BG</country>" +
                     "</shipping_address>" +
                     "<risk_params>" +
                     "<ssn>ssn</ssn>" +
                     "<mac_address>mac address</mac_address>" +
                     "<session_id>session id</session_id>" +
                     "<user_id>user id</user_id>" +
                     "<user_level>user level</user_level>" +
                     "<email>hello@world.com</email>" +
                     "<phone>phone</phone>" +
                     "<remote_ip>255.10.100.10</remote_ip>" +
                     "<serial_number>serial number</serial_number>" +
                     "</risk_params>" +
                     "<dynamic_descriptor_params>" +
                     "<merchant_name>Test Merchant</merchant_name>" +
                     "<merchant_city>Testing Town</merchant_city>" +
                     "</dynamic_descriptor_params>" +
                     "<mpi_params>" +
                     "<cavv>Testing Cavv</cavv>" +
                     "<eci>Testing Eci</eci>" +
                     "<xid>Testing Xid</xid>" +
                     "</mpi_params>" +
                     "</payment_transaction>";

            return new EntityMock<Sale3dSync>(sale3dSync, xml);
        }

        public static EntityMock<AccountVerification> CreateValidAccountVerification()
        {
            var accountVerification = new AccountVerification()
            {
                Id = "id",
                Usage = "usage",
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                RemoteIp = "255.10.100.10",
                CardHolder = "card holder",
                ExpirationMonth = 1,
                ExpirationYear = 2025,
                CustomerEmail = "hello@world.com",
                CustomerPhone = "phone number",
                CardNumber = CardsNumbers.Visa3dSecureEnrolled,
                Cvv = "123",
                BillingAddress = new Address()
                {
                    Address1 = "billing address1",
                    Address2 = "billing address2",
                    City = "billing city",
                    Country = Iso3166CountryCodes.BG,
                    FirstName = "billing first name",
                    LastName = "billing last name",
                    State = "BS",
                    ZipCode = "1000"
                },
                ShippingAddress = new Address()
                {
                    Address1 = "shipping address1",
                    Address2 = "shipping address2",
                    City = "shipping city",
                    Country = Iso3166CountryCodes.BG,
                    FirstName = "shipping first name",
                    LastName = "shipping last name",
                    State = "BS",
                    ZipCode = "1000"
                },
                RiskParams = new RiskParams()
                {
                    Email = "hello@world.com",
                    MacAddress = "mac address",
                    Phone = "phone",
                    RemoteIp = "255.10.100.10",
                    SerialNumber = "serial number",
                    SessionId = "session id",
                    Ssn = "ssn",
                    UserId = "user id",
                    UserLevel = "user level"
                }
            };

            var xml =
                     "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                     "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"AccountVerification\">" +
                     "<transaction_type>account_verification</transaction_type>" +
                     "<transaction_id>id</transaction_id>" +
                     "<usage>usage</usage>" +
                     "<amount>100</amount>" +
                     "<currency>USD</currency>" +
                     "<remote_ip>255.10.100.10</remote_ip>" +
                     "<card_holder>card holder</card_holder>" +
                     "<expiration_month>01</expiration_month>" +
                     "<expiration_year>2025</expiration_year>" +
                     "<customer_email>hello@world.com</customer_email>" +
                     "<customer_phone>phone number</customer_phone>" +
                     "<card_number>4711100000000000</card_number>" +
                     "<cvv>123</cvv>" +
                     "<billing_address>" +
                     "<first_name>billing first name</first_name>" +
                     "<last_name>billing last name</last_name>" +
                     "<address1>billing address1</address1>" +
                     "<address2>billing address2</address2>" +
                     "<zip_code>1000</zip_code>" +
                     "<city>billing city</city>" +
                     "<state>BS</state>" +
                     "<country>BG</country>" +
                     "</billing_address>" +
                     "<shipping_address>" +
                     "<first_name>shipping first name</first_name>" +
                     "<last_name>shipping last name</last_name>" +
                     "<address1>shipping address1</address1>" +
                     "<address2>shipping address2</address2>" +
                     "<zip_code>1000</zip_code>" +
                     "<city>shipping city</city>" +
                     "<state>BS</state>" +
                     "<country>BG</country>" +
                     "</shipping_address>" +
                     "<risk_params>" +
                     "<ssn>ssn</ssn>" +
                     "<mac_address>mac address</mac_address>" +
                     "<session_id>session id</session_id>" +
                     "<user_id>user id</user_id>" +
                     "<user_level>user level</user_level>" +
                     "<email>hello@world.com</email>" +
                     "<phone>phone</phone>" +
                     "<remote_ip>255.10.100.10</remote_ip>" +
                     "<serial_number>serial number</serial_number>" +
                     "</risk_params>" +
                     "</payment_transaction>";

            return new EntityMock<AccountVerification>(accountVerification, xml);
        }

        public static EntityMock<Avs> CreateValidAvs()
        {
            var avs = new Avs()
            {
                Id = "id",
                Usage = "usage",
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                RemoteIp = "255.10.100.10",
                CardHolder = "card holder",
                ExpirationMonth = 1,
                ExpirationYear = 2025,
                CustomerEmail = "hello@world.com",
                CustomerPhone = "phone number",
                CardNumber = CardsNumbers.Visa3dSecureEnrolled,
                Cvv = "123",
                BillingAddress = new Address()
                {
                    Address1 = "billing address1",
                    Address2 = "billing address2",
                    City = "billing city",
                    Country = Iso3166CountryCodes.BG,
                    FirstName = "billing first name",
                    LastName = "billing last name",
                    State = "BS",
                    ZipCode = "1000"
                },
                ShippingAddress = new Address()
                {
                    Address1 = "shipping address1",
                    Address2 = "shipping address2",
                    City = "shipping city",
                    Country = Iso3166CountryCodes.BG,
                    FirstName = "shipping first name",
                    LastName = "shipping last name",
                    State = "BS",
                    ZipCode = "1000"
                },
                RiskParams = new RiskParams()
                {
                    Email = "hello@world.com",
                    MacAddress = "mac address",
                    Phone = "phone",
                    RemoteIp = "255.10.100.10",
                    SerialNumber = "serial number",
                    SessionId = "session id",
                    Ssn = "ssn",
                    UserId = "user id",
                    UserLevel = "user level"
                }
            };

            var xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                      "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"Avs\">" +
                      "<transaction_type>avs</transaction_type>" +
                      "<transaction_id>id</transaction_id>" +
                      "<usage>usage</usage>" +
                      "<amount>100</amount>" +
                      "<currency>USD</currency>" +
                      "<remote_ip>255.10.100.10</remote_ip>" +
                      "<card_holder>card holder</card_holder>" +
                      "<expiration_month>01</expiration_month>" +
                      "<expiration_year>2025</expiration_year>" +
                      "<customer_email>hello@world.com</customer_email>" +
                      "<customer_phone>phone number</customer_phone>" +
                      "<card_number>4711100000000000</card_number>" +
                      "<cvv>123</cvv>" +
                      "<billing_address>" +
                      "<first_name>billing first name</first_name>" +
                      "<last_name>billing last name</last_name>" +
                      "<address1>billing address1</address1>" +
                      "<address2>billing address2</address2>" +
                      "<zip_code>1000</zip_code>" +
                      "<city>billing city</city>" +
                      "<state>BS</state>" +
                      "<country>BG</country>" +
                      "</billing_address>" +
                      "<shipping_address>" +
                      "<first_name>shipping first name</first_name>" +
                      "<last_name>shipping last name</last_name>" +
                      "<address1>shipping address1</address1>" +
                      "<address2>shipping address2</address2>" +
                      "<zip_code>1000</zip_code>" +
                      "<city>shipping city</city>" +
                      "<state>BS</state>" +
                      "<country>BG</country>" +
                      "</shipping_address>" +
                      "<risk_params>" +
                      "<ssn>ssn</ssn>" +
                      "<mac_address>mac address</mac_address>" +
                      "<session_id>session id</session_id>" +
                      "<user_id>user id</user_id>" +
                      "<user_level>user level</user_level>" +
                      "<email>hello@world.com</email>" +
                      "<phone>phone</phone>" +
                      "<remote_ip>255.10.100.10</remote_ip>" +
                      "<serial_number>serial number</serial_number>" +
                      "</risk_params>" +
                      "</payment_transaction>";

            return new EntityMock<Avs>(avs, xml);
        }

        public static EntityMock<InitRecurringSale> CreateValidInitRecurringSale()
        {
            var initRecurringSale = new InitRecurringSale()
            {
                Id = "id",
                Usage = "usage",
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                RemoteIp = "255.10.100.10",
                CardHolder = "card holder",
                ExpirationMonth = 1,
                ExpirationYear = 2025,
                CustomerEmail = "hello@world.com",
                CustomerPhone = "phone number",
                CardNumber = CardsNumbers.Visa3dSecureEnrolled,
                Cvv = "123",
                BillingAddress = new Address()
                {
                    Address1 = "billing address1",
                    Address2 = "billing address2",
                    City = "billing city",
                    Country = Iso3166CountryCodes.BG,
                    FirstName = "billing first name",
                    LastName = "billing last name",
                    State = "BS",
                    ZipCode = "1000"
                },
                ShippingAddress = new Address()
                {
                    Address1 = "shipping address1",
                    Address2 = "shipping address2",
                    City = "shipping city",
                    Country = Iso3166CountryCodes.BG,
                    FirstName = "shipping first name",
                    LastName = "shipping last name",
                    State = "BS",
                    ZipCode = "1000"
                },
                RiskParams = new RiskParams()
                {
                    Email = "hello@world.com",
                    MacAddress = "mac address",
                    Phone = "phone",
                    RemoteIp = "255.10.100.10",
                    SerialNumber = "serial number",
                    SessionId = "session id",
                    Ssn = "ssn",
                    UserId = "user id",
                    UserLevel = "user level"
                },
                DynamicDescriptorParams = new DynamicDescriptor()
                {
                    MerchantName = "Test Merchant",
                    MerchantCity = "Testing Town"
                }
            };

            var xml =
                     "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                     "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"InitRecurringSale\">" +
                     "<transaction_type>init_recurring_sale</transaction_type>" +
                     "<transaction_id>id</transaction_id>" +
                     "<usage>usage</usage>" +
                     "<amount>100</amount>" +
                     "<currency>USD</currency>" +
                     "<remote_ip>255.10.100.10</remote_ip>" +
                     "<card_holder>card holder</card_holder>" +
                     "<expiration_month>01</expiration_month>" +
                     "<expiration_year>2025</expiration_year>" +
                     "<customer_email>hello@world.com</customer_email>" +
                     "<customer_phone>phone number</customer_phone>" +
                     "<card_number>4711100000000000</card_number>" +
                     "<cvv>123</cvv>" +
                     "<billing_address>" +
                     "<first_name>billing first name</first_name>" +
                     "<last_name>billing last name</last_name>" +
                     "<address1>billing address1</address1>" +
                     "<address2>billing address2</address2>" +
                     "<zip_code>1000</zip_code>" +
                     "<city>billing city</city>" +
                     "<state>BS</state>" +
                     "<country>BG</country>" +
                     "</billing_address>" +
                     "<shipping_address>" +
                     "<first_name>shipping first name</first_name>" +
                     "<last_name>shipping last name</last_name>" +
                     "<address1>shipping address1</address1>" +
                     "<address2>shipping address2</address2>" +
                     "<zip_code>1000</zip_code>" +
                     "<city>shipping city</city>" +
                     "<state>BS</state>" +
                     "<country>BG</country>" +
                     "</shipping_address>" +
                     "<risk_params>" +
                     "<ssn>ssn</ssn>" +
                     "<mac_address>mac address</mac_address>" +
                     "<session_id>session id</session_id>" +
                     "<user_id>user id</user_id>" +
                     "<user_level>user level</user_level>" +
                     "<email>hello@world.com</email>" +
                     "<phone>phone</phone>" +
                     "<remote_ip>255.10.100.10</remote_ip>" +
                     "<serial_number>serial number</serial_number>" +
                     "</risk_params>" +
                     "<dynamic_descriptor_params>" +
                     "<merchant_name>Test Merchant</merchant_name>" +
                     "<merchant_city>Testing Town</merchant_city>" +
                     "</dynamic_descriptor_params>" +
                     "</payment_transaction>";

            return new EntityMock<InitRecurringSale>(initRecurringSale, xml);
        }

        public static EntityMock<Payout> CreateValidPayout()
        {
            var payout = new Payout()
            {
                Id = "id",
                Usage = "usage",
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                RemoteIp = "255.10.100.10",
                CardHolder = "card holder",
                ExpirationMonth = 1,
                ExpirationYear = 2025,
                CustomerEmail = "hello@world.com",
                CustomerPhone = "phone number",
                CardNumber = CardsNumbers.Visa3dSecureEnrolled,
                Cvv = "123",
                BillingAddress = new Address()
                {
                    Address1 = "billing address1",
                    Address2 = "billing address2",
                    City = "billing city",
                    Country = Iso3166CountryCodes.BG,
                    FirstName = "billing first name",
                    LastName = "billing last name",
                    State = "BS",
                    ZipCode = "1000"
                },
                ShippingAddress = new Address()
                {
                    Address1 = "shipping address1",
                    Address2 = "shipping address2",
                    City = "shipping city",
                    Country = Iso3166CountryCodes.BG,
                    FirstName = "shipping first name",
                    LastName = "shipping last name",
                    State = "BS",
                    ZipCode = "1000"
                }
            };

            var xml =
                     "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                     "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"Payout\">" +
                     "<transaction_type>payout</transaction_type>" +
                     "<transaction_id>id</transaction_id>" +
                     "<usage>usage</usage>" +
                     "<amount>100</amount>" +
                     "<currency>USD</currency>" +
                     "<remote_ip>255.10.100.10</remote_ip>" +
                     "<card_holder>card holder</card_holder>" +
                     "<expiration_month>01</expiration_month>" +
                     "<expiration_year>2025</expiration_year>" +
                     "<customer_email>hello@world.com</customer_email>" +
                     "<customer_phone>phone number</customer_phone>" +
                     "<card_number>4711100000000000</card_number>" +
                     "<cvv>123</cvv>" +
                     "<billing_address>" +
                     "<first_name>billing first name</first_name>" +
                     "<last_name>billing last name</last_name>" +
                     "<address1>billing address1</address1>" +
                     "<address2>billing address2</address2>" +
                     "<zip_code>1000</zip_code>" +
                     "<city>billing city</city>" +
                     "<state>BS</state>" +
                     "<country>BG</country>" +
                     "</billing_address>" +
                     "<shipping_address>" +
                     "<first_name>shipping first name</first_name>" +
                     "<last_name>shipping last name</last_name>" +
                     "<address1>shipping address1</address1>" +
                     "<address2>shipping address2</address2>" +
                     "<zip_code>1000</zip_code>" +
                     "<city>shipping city</city>" +
                     "<state>BS</state>" +
                     "<country>BG</country>" +
                     "</shipping_address>" +
                     "</payment_transaction>";

            return new EntityMock<Payout>(payout, xml);
        }

        public static EntityMock<Sale> CreateValidSale()
        {
            var sale = new Sale()
            {
                Id = "id",
                Usage = "usage",
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                RemoteIp = "255.10.100.10",
                CardHolder = "card holder",
                ExpirationMonth = 1,
                ExpirationYear = 2025,
                CustomerEmail = "hello@world.com",
                CustomerPhone = "phone number",
                CardNumber = CardsNumbers.Visa3dSecureEnrolled,
                Cvv = "123",
                BillingAddress = new Address()
                {
                    Address1 = "billing address1",
                    Address2 = "billing address2",
                    City = "billing city",
                    Country = Iso3166CountryCodes.BG,
                    FirstName = "billing first name",
                    LastName = "billing last name",
                    State = "BS",
                    ZipCode = "1000"
                },
                ShippingAddress = new Address()
                {
                    Address1 = "shipping address1",
                    Address2 = "shipping address2",
                    City = "shipping city",
                    Country = Iso3166CountryCodes.BG,
                    FirstName = "shipping first name",
                    LastName = "shipping last name",
                    State = "BS",
                    ZipCode = "1000"
                },
                RiskParams = new RiskParams()
                {
                    Email = "hello@world.com",
                    MacAddress = "mac address",
                    Phone = "phone",
                    RemoteIp = "255.10.100.10",
                    SerialNumber = "serial number",
                    SessionId = "session id",
                    Ssn = "ssn",
                    UserId = "user id",
                    UserLevel = "user level"
                },
                DynamicDescriptorParams = new DynamicDescriptor()
                {
                    MerchantName = "Test Merchant",
                    MerchantCity = "Testing Town"
                }
            };

            var xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                      "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"Sale\">" +
                      "<transaction_type>sale</transaction_type>" +
                      "<transaction_id>id</transaction_id>" +
                      "<usage>usage</usage>" +
                      "<amount>100</amount>" +
                      "<currency>USD</currency>" +
                      "<remote_ip>255.10.100.10</remote_ip>" +
                      "<card_holder>card holder</card_holder>" +
                      "<expiration_month>01</expiration_month>" +
                      "<expiration_year>2025</expiration_year>" +
                      "<customer_email>hello@world.com</customer_email>" +
                      "<customer_phone>phone number</customer_phone>" +
                      "<card_number>4711100000000000</card_number>" +
                      "<cvv>123</cvv>" +
                      "<billing_address>" +
                      "<first_name>billing first name</first_name>" +
                      "<last_name>billing last name</last_name>" +
                      "<address1>billing address1</address1>" +
                      "<address2>billing address2</address2>" +
                      "<zip_code>1000</zip_code>" +
                      "<city>billing city</city>" +
                      "<state>BS</state>" +
                      "<country>BG</country>" +
                      "</billing_address>" +
                      "<shipping_address>" +
                      "<first_name>shipping first name</first_name>" +
                      "<last_name>shipping last name</last_name>" +
                      "<address1>shipping address1</address1>" +
                      "<address2>shipping address2</address2>" +
                      "<zip_code>1000</zip_code>" +
                      "<city>shipping city</city>" +
                      "<state>BS</state>" +
                      "<country>BG</country>" +
                      "</shipping_address>" +
                      "<risk_params>" +
                      "<ssn>ssn</ssn>" +
                      "<mac_address>mac address</mac_address>" +
                      "<session_id>session id</session_id>" +
                      "<user_id>user id</user_id>" +
                      "<user_level>user level</user_level>" +
                      "<email>hello@world.com</email>" +
                      "<phone>phone</phone>" +
                      "<remote_ip>255.10.100.10</remote_ip>" +
                      "<serial_number>serial number</serial_number>" +
                      "</risk_params>" +
                      "<dynamic_descriptor_params>" +
                      "<merchant_name>Test Merchant</merchant_name>" +
                      "<merchant_city>Testing Town</merchant_city>" +
                      "</dynamic_descriptor_params>" +
                      "</payment_transaction>";

            return new EntityMock<Sale>(sale, xml);
        }

        public static EntityMock<WpfCreate> CreateValidWpfCreate()
        {
            var wpfCreate = new WpfCreate()
            {
                TransactionId = "id",
                Usage = "usage",
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                CustomerEmail = "hello@world.com",
                CustomerPhone = "phone number",
                Description = "description",
                TransactionTypes = new Composite[] {
                    new Composite() { { "name", "sale" } }, new Composite() { { "name", "sale3d" } },
                    new Composite() { { "name", "ezeewallet" }, { "source_wallet_id", "emil@example.com" } }
                },
                ReturnCancelUrl = "http://test.com/cancel",
                ReturnFailureUrl = "http://test.com/fail",
                ReturnSuccessUrl = "http://test.com/success",
                NotificationUrl = "https://example.com/notify",
                BillingAddress = new Address()
                {
                    Address1 = "billing address1",
                    Address2 = "billing address2",
                    City = "billing city",
                    Country = Iso3166CountryCodes.BG,
                    FirstName = "billing first name",
                    LastName = "billing last name",
                    State = "BS",
                    ZipCode = "1000"
                },
                ShippingAddress = new Address()
                {
                    Address1 = "shipping address1",
                    Address2 = "shipping address2",
                    City = "shipping city",
                    Country = Iso3166CountryCodes.BG,
                    FirstName = "shipping first name",
                    LastName = "shipping last name",
                    State = "BS",
                    ZipCode = "1000"
                },
                RiskParams = new RiskParams()
                {
                    Email = "hello@world.com",
                    MacAddress = "mac address",
                    Phone = "phone",
                    RemoteIp = "255.10.100.10",
                    SerialNumber = "serial number",
                    SessionId = "session id",
                    Ssn = "ssn",
                    UserId = "user id",
                    UserLevel = "user level"
                }
            };

            var xml =
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                "<wpf_payment xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"WpfCreate\">" +
                    "<transaction_id>id</transaction_id>" +
                    "<amount>100</amount>" +
                    "<currency>USD</currency>" +
                    "<usage>usage</usage>" +
                    "<description>description</description>" +
                    "<customer_email>hello@world.com</customer_email>" +
                    "<customer_phone>phone number</customer_phone>" +
                    "<notification_url>https://example.com/notify</notification_url>" +
                    "<return_success_url>http://test.com/success</return_success_url>" +
                    "<return_failure_url>http://test.com/fail</return_failure_url>" +
                    "<return_cancel_url>http://test.com/cancel</return_cancel_url>" +
                    "<billing_address>" +
                        "<first_name>billing first name</first_name>" +
                        "<last_name>billing last name</last_name>" +
                        "<address1>billing address1</address1>" +
                        "<address2>billing address2</address2>" +
                        "<zip_code>1000</zip_code>" +
                        "<city>billing city</city>" +
                        "<state>BS</state>" +
                        "<country>BG</country>" +
                    "</billing_address>" +
                    "<shipping_address>" +
                        "<first_name>shipping first name</first_name>" +
                        "<last_name>shipping last name</last_name>" +
                        "<address1>shipping address1</address1>" +
                        "<address2>shipping address2</address2>" +
                        "<zip_code>1000</zip_code>" +
                        "<city>shipping city</city>" +
                        "<state>BS</state>" +
                        "<country>BG</country>" +
                    "</shipping_address>" +
                    "<transaction_types>" +
                        "<transaction_type><name>sale</name></transaction_type>" +
                        "<transaction_type><name>sale3d</name></transaction_type>" +
                        "<transaction_type>" +
                            "<name>ezeewallet</name>" +
                            "<source_wallet_id>emil@example.com</source_wallet_id>" +
                        "</transaction_type>" +
                    "</transaction_types>"+
                    "<risk_params>" +
                        "<ssn>ssn</ssn>" +
                        "<mac_address>mac address</mac_address>" +
                        "<session_id>session id</session_id>" +
                        "<user_id>user id</user_id>" +
                        "<user_level>user level</user_level>" +
                        "<email>hello@world.com</email>" +
                        "<phone>phone</phone>" +
                        "<remote_ip>255.10.100.10</remote_ip>" +
                        "<serial_number>serial number</serial_number>" +
                    "</risk_params>" +
                "</wpf_payment>";

            return new EntityMock<WpfCreate>(wpfCreate, xml);
        }

        public static EntityMock<Blacklist> CreateValidBlacklist()
        {
            var blacklist = new Blacklist()
            {
                CardNumber = "4200000000000000",
                TerminalToken = "abd30ed00f88f838c5d233cbb62b6da0b69267b4"
            };

            var xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                      "<blacklist_request xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"Blacklist\">" +
                      "<card_number>4200000000000000</card_number>" +
                      "<terminal_token>abd30ed00f88f838c5d233cbb62b6da0b69267b4</terminal_token>" +
                      "</blacklist_request>";

            return new EntityMock<Blacklist>(blacklist, xml);
        }

        public static EntityMock<MultiChargeback> CreateValidMultiChargeback()
        {
            var multiChargeback = new MultiChargeback()
            {
                ProxyStartDate = "2014-01-01",
                ProxyEndDate = "2014-01-31",
                Page = 1
            };

            var xml =
                     "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                     "<chargeback_request xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"MultiChargeback\">" +
                     "<start_date>2014-01-01</start_date>" +
                     "<end_date>2014-01-31</end_date>" +
                     "<page>1</page>" +
                     "</chargeback_request>";

            return new EntityMock<MultiChargeback>(multiChargeback, xml);
        }

        public static EntityMock<MultiReconcile> CreateValidMultiReconcile()
        {
            var multiReconcile = new MultiReconcile()
            {
                ProxyStartDate = "2014-01-01",
                ProxyEndDate = "2014-01-31",
                Page = 1
            };

            var xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                      "<reconcile xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"MultiReconcile\">" +
                      "<start_date>2014-01-01</start_date>" +
                      "<end_date>2014-01-31</end_date>" +
                      "<page>1</page>" +
                      "</reconcile>";

            return new EntityMock<MultiReconcile>(multiReconcile, xml);
        }

        public static EntityMock<MultiRetrievalRequest> CreateValidMultiRetrievalRequest()
        {
            var multiRetrievalRequest = new MultiRetrievalRequest()
            {
                ProxyStartDate = "2014-01-01",
                ProxyEndDate = "2014-01-31",
                Page = 1
            };

            var xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                      "<retrieval_request_request xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"MultiRetrievalRequest\">" +
                      "<start_date>2014-01-01</start_date>" +
                      "<end_date>2014-01-31</end_date>" +
                      "<page>1</page>" +
                      "</retrieval_request_request>";

            return new EntityMock<MultiRetrievalRequest>(multiRetrievalRequest, xml);
        }

        public static EntityMock<SingleChargeback> CreateValidSingleChargeback(string arn, string originalTransactionUniqueId = "")
        {
            var singleChargeback = new SingleChargeback();
            var xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                      "<chargeback_request xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"SingleChargeback\">";

            if (!string.IsNullOrEmpty(arn))
            {
                singleChargeback.Arn = arn;
                xml += "<arn>" + arn + "</arn>";
            }
            if (!string.IsNullOrEmpty(originalTransactionUniqueId))
            {
                singleChargeback.OriginalTransactionUniqueId = originalTransactionUniqueId;
                xml += "<original_transaction_unique_id>" + originalTransactionUniqueId + "</original_transaction_unique_id>";
            }

            xml += "</chargeback_request>";

            return new EntityMock<SingleChargeback>(singleChargeback, xml);
        }

        public static EntityMock<SingleReconcile> CreateValidSingleReconcile()
        {
            var singleReconcile = new SingleReconcile()
            {
                UniqueId = "44177a21403427eb96664a6d7e5d5d48"
            };

            var xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                      "<reconcile xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"SingleReconcile\">" +
                      "<unique_id>44177a21403427eb96664a6d7e5d5d48</unique_id>" +
                      "</reconcile>";

            return new EntityMock<SingleReconcile>(singleReconcile, xml);
        }

        public static EntityMock<SingleRetrievalRequest> CreateValidSingleRetrievalRequest(string arn, string originalTransactionUniqueId = "")
        {
            var singleRetrievalRequest = new SingleRetrievalRequest();
            var xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                      "<retrieval_request_request xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"SingleRetrievalRequest\">";

            if (!string.IsNullOrEmpty(arn))
            {
                singleRetrievalRequest.Arn = arn;
                xml += "<arn>" + arn + "</arn>";
            }
            if (!string.IsNullOrEmpty(originalTransactionUniqueId))
            {
                singleRetrievalRequest.OriginalTransactionUniqueId = originalTransactionUniqueId;
                xml += "<original_transaction_unique_id>" + originalTransactionUniqueId + "</original_transaction_unique_id>";
            }

            xml += "</retrieval_request_request>";

            return new EntityMock<SingleRetrievalRequest>(singleRetrievalRequest, xml);
        }

        public static EntityMock<Capture> CreateValidCapture()
        {
            var capture = new Capture()
            {
                Amount = 50,
                Currency = Iso4217CurrencyCodes.USD,
                Id = "43671",
                ReferenceId = "2ee4287e67971380ef7f97d5743bb523",
                RemoteIp = "127.0.0.1",
                Usage = "40208 concert tickets"
            };

            var xml =
                     "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                     "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"Capture\">" +
                     "<transaction_type>capture</transaction_type>" +
                     "<transaction_id>43671</transaction_id>" +
                     "<usage>40208 concert tickets</usage>" +
                     "<remote_ip>127.0.0.1</remote_ip>" +
                     "<reference_id>2ee4287e67971380ef7f97d5743bb523</reference_id>" +
                     "<amount>5000</amount>" +
                     "<currency>USD</currency>" +
                     "</payment_transaction>";

            return new EntityMock<Capture>(capture, xml);
        }

        public static EntityMock<Credit> CreateValidCredit()
        {
            var credit = new Credit()
            {
                Amount = 50,
                Currency = Iso4217CurrencyCodes.USD,
                Id = "43671",
                ReferenceId = "2ee4287e67971380ef7f97d5743bb523",
                RemoteIp = "127.0.0.1",
                Usage = "40208 concert tickets"
            };

            var xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                      "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"Credit\">" +
                      "<transaction_type>credit</transaction_type>" +
                      "<transaction_id>43671</transaction_id>" +
                      "<usage>40208 concert tickets</usage>" +
                      "<remote_ip>127.0.0.1</remote_ip>" +
                      "<reference_id>2ee4287e67971380ef7f97d5743bb523</reference_id>" +
                      "<amount>5000</amount>" +
                      "<currency>USD</currency>" +
                      "</payment_transaction>";

            return new EntityMock<Credit>(credit, xml);
        }

        public static EntityMock<RecurringSale> CreateValidRecurringSale()
        {
            var recurringSale = new RecurringSale()
            {
                Amount = 50,
                Currency = Iso4217CurrencyCodes.USD,
                Id = "43671",
                ReferenceId = "2ee4287e67971380ef7f97d5743bb523",
                RemoteIp = "127.0.0.1",
                Usage = "40208 concert tickets"
            };

            var xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                      "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"RecurringSale\">" +
                      "<transaction_type>recurring_sale</transaction_type>" +
                      "<transaction_id>43671</transaction_id>" +
                      "<usage>40208 concert tickets</usage>" +
                      "<remote_ip>127.0.0.1</remote_ip>" +
                      "<reference_id>2ee4287e67971380ef7f97d5743bb523</reference_id>" +
                      "<amount>5000</amount>" +
                      "<currency>USD</currency>" +
                      "</payment_transaction>";

            return new EntityMock<RecurringSale>(recurringSale, xml);
        }

        public static EntityMock<Refund> CreateValidRefund()
        {
            var refund = new Refund()
            {
                Amount = 50,
                Currency = Iso4217CurrencyCodes.USD,
                Id = "43671",
                ReferenceId = "2ee4287e67971380ef7f97d5743bb523",
                RemoteIp = "127.0.0.1",
                Usage = "40208 concert tickets"
            };

            var xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                      "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"Refund\">" +
                      "<transaction_type>refund</transaction_type>" +
                      "<transaction_id>43671</transaction_id>" +
                      "<usage>40208 concert tickets</usage>" +
                      "<remote_ip>127.0.0.1</remote_ip>" +
                      "<reference_id>2ee4287e67971380ef7f97d5743bb523</reference_id>" +
                      "<amount>5000</amount>" +
                      "<currency>USD</currency>" +
                      "</payment_transaction>";

            return new EntityMock<Refund>(refund, xml);
        }

        public static EntityMock<VoidRequest> CreateValidVoidRequest()
        {
            var voidRequest = new VoidRequest()
            {
                Id = "43671",
                ReferenceId = "2ee4287e67971380ef7f97d5743bb523",
                RemoteIp = "127.0.0.1",
                Usage = "40208 concert tickets"
            };

            var xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                      "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"VoidRequest\">" +
                      "<transaction_type>void</transaction_type>" +
                      "<transaction_id>43671</transaction_id>" +
                      "<usage>40208 concert tickets</usage>" +
                      "<remote_ip>127.0.0.1</remote_ip>" +
                      "<reference_id>2ee4287e67971380ef7f97d5743bb523</reference_id>" +
                      "</payment_transaction>";

            return new EntityMock<VoidRequest>(voidRequest, xml);
        }

        public static EntityMock<WpfReconcile> CreateValidWpfReconcile()
        {
            var wpfReconcile = new WpfReconcile()
            {
                UniqueId = "44177a21403427eb96664a6d7e5d5d48"
            };

            var xml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<wpf_reconcile xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"WpfReconcile\">" +
                "<unique_id>44177a21403427eb96664a6d7e5d5d48</unique_id>" +
                "</wpf_reconcile>";

            return new EntityMock<WpfReconcile>(wpfReconcile, xml);
        }

        public static EntityMock<EzeeWallet> CreateValidEzeeWallet()
        {
            var ezeeWallet = new EzeeWallet()
            {
                Id = "1234567890",
                Usage = "iPad",
                RemoteIp = "127.0.0.1",
                Amount = 500,
                Currency = Iso4217CurrencyCodes.USD,
                SourceWalletId = "john@example.com",
                SourceWalletPassword = "UDBydsDBrYWxAQA==",
                ReturnSuccessUrl = "https://example.com/return_success",
                ReturnFailureUrl = "https://example.com/return_failure"
            };

            var xml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"EzeeWallet\">" +
                "<transaction_type>ezeewallet</transaction_type>" +
                "<transaction_id>1234567890</transaction_id>" +
                "<usage>iPad</usage>" +
                "<amount>50000</amount>" +
                "<currency>USD</currency>" +
                "<remote_ip>127.0.0.1</remote_ip>" +
                "<source_wallet_id>john@example.com</source_wallet_id>" +
                "<source_wallet_pwd>UDBydsDBrYWxAQA==</source_wallet_pwd>" +
                "<return_success_url>https://example.com/return_success</return_success_url>" +
                "<return_failure_url>https://example.com/return_failure</return_failure_url>" +
                "</payment_transaction>";

            return new EntityMock<EzeeWallet>(ezeeWallet, xml);
        }

        public static EntityMock<PayByVoucher> CreateValidPayByVoucher()
        {
            var payByVoucher = new PayByVoucher()
            {
                Id = "43671",
                Type = TransactionTypes.PayByVoucher,
                RemoteIp = "127.0.0.1",
                ProxyAmount = "50000",
                Currency = Iso4217CurrencyCodes.USD,
                ProductName = "Interstellar",
                ProductCategory = "movie",
                CardHolder = "姓名",
                CustomerIdNumber = "120104198302030841",
                CustomerPhone = "15002268663",
                CustomerEmail = "customer@example.com",
                CustomerBankId = "ICBC",
                BankAccountNumber = "6222020302063077036"
            };

            var xml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"PayByVoucher\">" +
                "<transaction_type>paybyvoucher</transaction_type>" +
                "<transaction_id>43671</transaction_id>" +
                "<amount>50000</amount>" +
                "<currency>USD</currency>" +
                "<remote_ip>127.0.0.1</remote_ip>" +
                "<product_name>Interstellar</product_name>" +
                "<product_category>movie</product_category>" +
                "<card_holder>姓名</card_holder>" +
                "<customer_phone>15002268663</customer_phone>" +
                "<customer_email>customer@example.com</customer_email>" +
                "<customer_id_number>120104198302030841</customer_id_number>" +
                "<customer_bank_id>ICBC</customer_bank_id>" +
                "<bank_account_number>6222020302063077036</bank_account_number>" +
                "</payment_transaction>";

            return new EntityMock<PayByVoucher>(payByVoucher, xml);
        }

        public static EntityMock<CashU> CreateValidCashU()
        {
            var cashU = new CashU()
            {
                Id = "asqf12e81eb23d0e00ffb85b1db7db913",
                Usage = "New iPad",
                RemoteIp = "82.137.112.202",
                ReturnSuccessUrl = "https://example.com/return_success",
                ReturnFailureUrl = "https://example.com/return_failure",
                ProxyAmount = "50000",
                Currency = Iso4217CurrencyCodes.EUR,
                CustomerEmail = "emil@example.com",
                CustomerPhone = "+11234567890",
                BillingAddress = new Address()
                {
                    FirstName = "Barney",
                    LastName = "Rubble",
                    Address1 = "14, Nerazdelni str",
                    ZipCode = "1407",
                    City = "Sofia",
                    Country = Iso3166CountryCodes.BG
                }
            };

            var xml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"CashU\">" +
                "<transaction_type>cashu</transaction_type>" +
                "<transaction_id>asqf12e81eb23d0e00ffb85b1db7db913</transaction_id>" +
                "<usage>New iPad</usage>" +
                "<amount>50000</amount>" +
                "<currency>EUR</currency>" +
                "<remote_ip>82.137.112.202</remote_ip>" +
                "<return_success_url>https://example.com/return_success</return_success_url>" +
                "<return_failure_url>https://example.com/return_failure</return_failure_url>" +
                "<customer_email>emil@example.com</customer_email>" +
                "<customer_phone>+11234567890</customer_phone>" +
                "<billing_address>" +
                "<first_name>Barney</first_name>" +
                "<last_name>Rubble</last_name>" +
                "<address1>14, Nerazdelni str</address1>" +
                "<zip_code>1407</zip_code>" +
                "<city>Sofia</city>" +
                "<country>BG</country>" +
                "</billing_address>" +
                "</payment_transaction>";

            return new EntityMock<CashU>(cashU, xml);
        }

        public static EntityMock<PaySafeCard> CreateValidPaySafeCard()
        {
            var paySafeCard = new PaySafeCard()
            {
                Id = "asqf12e81eb23d0e00ffb85b1db7db913",
                Usage = "New iPad",
                RemoteIp = "82.137.112.202",
                ReturnSuccessUrl = "https://example.com/return_success",
                ReturnFailureUrl = "https://example.com/return_failure",
                ProxyAmount = "50000",
                Currency = Iso4217CurrencyCodes.EUR,
                CustomerEmail = "emil@example.com",
                CustomerPhone = "+11234567890",
                BillingAddress = new Address()
                {
                    FirstName = "Barney",
                    LastName = "Rubble",
                    Address1 = "14, Nerazdelni str",
                    ZipCode = "1407",
                    City = "Sofia",
                    Country = Iso3166CountryCodes.BG
                }
            };

            var xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"PaySafeCard\">" +
                "<transaction_type>paysafecard</transaction_type>" +
                "<transaction_id>asqf12e81eb23d0e00ffb85b1db7db913</transaction_id>" +
                "<usage>New iPad</usage>" +
                "<amount>50000</amount>" +
                "<currency>EUR</currency>" +
                "<remote_ip>82.137.112.202</remote_ip>" +
                "<return_success_url>https://example.com/return_success</return_success_url>" +
                "<return_failure_url>https://example.com/return_failure</return_failure_url>" +
                "<customer_email>emil@example.com</customer_email>" +
                "<customer_phone>+11234567890</customer_phone>" +
                "<billing_address>" +
                "<first_name>Barney</first_name>" +
                "<last_name>Rubble</last_name>" +
                "<address1>14, Nerazdelni str</address1>" +
                "<zip_code>1407</zip_code>" +
                "<city>Sofia</city>" +
                "<country>BG</country>" +
                "</billing_address>" +
                "</payment_transaction>";

            return new EntityMock<PaySafeCard>(paySafeCard, xml);
        }

        public static EntityMock<Sofort> CreateValidSofort()
        {
            var sofort = new Sofort()
            {
                Id = "1234567890",
                Usage = "New iPad",
                RemoteIp = "82.137.112.202",
                ReturnSuccessUrl = "https://example.com/return_success",
                ReturnFailureUrl = "https://example.com/return_failure",
                ProxyAmount = "50000",
                Currency = Iso4217CurrencyCodes.EUR,
                CustomerEmail = "emil@example.com",
                BillingAddress = new Address()
                {
                    FirstName = "Barney",
                    LastName = "Rubble",
                    Address1 = "14, Nerazdelni str",
                    ZipCode = "1407",
                    City = "Sofia",
                    Country = Iso3166CountryCodes.BG
                },
                RiskParams = new RiskParams()
                {
                    UserId = "123456"
                }
            };

            var xml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"Sofort\">" +
                "<transaction_type>sofort</transaction_type>" +
                "<transaction_id>1234567890</transaction_id>" +
                "<usage>New iPad</usage>" +
                "<amount>50000</amount>" +
                "<currency>EUR</currency>" +
                "<remote_ip>82.137.112.202</remote_ip>" +
                "<return_success_url>https://example.com/return_success</return_success_url>" +
                "<return_failure_url>https://example.com/return_failure</return_failure_url>" +
                "<customer_email>emil@example.com</customer_email>" +
                "<billing_address>" +
                "<first_name>Barney</first_name>" +
                "<last_name>Rubble</last_name>" +
                "<address1>14, Nerazdelni str</address1>" +
                "<zip_code>1407</zip_code>" +
                "<city>Sofia</city>" +
                "<country>BG</country>" +
                "</billing_address>" +
                "<risk_params>" +
                "<user_id>123456</user_id>" +
                "</risk_params>" +
                "</payment_transaction>";

            return new EntityMock<Sofort>(sofort, xml);
        }

        public static EntityMock<SofortiDeal> CreateValidSofortiDeal()
        {
            var sofortiDeal = new SofortiDeal()
            {
                Id = "1234567890",
                Usage = "New iPad",
                RemoteIp = "82.137.112.202",
                ReturnSuccessUrl = "https://example.com/return_success",
                ReturnFailureUrl = "https://example.com/return_failure",
                ProxyAmount = "50000",
                Currency = Iso4217CurrencyCodes.EUR,
                CustomerEmail = "emil@example.com",
                CustomerBankId = "751",
                BankAccountNumber = "1234567890",
                BillingAddress = new Address()
                {
                    FirstName = "Barney",
                    LastName = "Rubble",
                    Address1 = "14, Nerazdelni str",
                    ZipCode = "1407",
                    City = "Sofia",
                    Country = Iso3166CountryCodes.BG
                },
                RiskParams = new RiskParams()
                {
                    UserId = "123456"
                }
            };

            var xml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"SofortiDeal\">" +
                "<transaction_type>sofort_ideal</transaction_type>" +
                "<transaction_id>1234567890</transaction_id>" +
                "<usage>New iPad</usage>" +
                "<amount>50000</amount>" +
                "<currency>EUR</currency>" +
                "<remote_ip>82.137.112.202</remote_ip>" +
                "<return_success_url>https://example.com/return_success</return_success_url>" +
                "<return_failure_url>https://example.com/return_failure</return_failure_url>" +
                "<customer_email>emil@example.com</customer_email>" +
                "<billing_address>" +
                "<first_name>Barney</first_name>" +
                "<last_name>Rubble</last_name>" +
                "<address1>14, Nerazdelni str</address1>" +
                "<zip_code>1407</zip_code>" +
                "<city>Sofia</city>" +
                "<country>BG</country>" +
                "</billing_address>" +
                "<risk_params>" +
                "<user_id>123456</user_id>" +
                "</risk_params>" +
                "<customer_bank_id>751</customer_bank_id>" +
                "<bank_account_number>1234567890</bank_account_number>" +
                "</payment_transaction>";

            return new EntityMock<SofortiDeal>(sofortiDeal, xml);
        }

        public static EntityMock<Ppro> CreateValidPpro()
        {
            var ppro = new Ppro()
            {
                Id = "a1qf12e81eb23d0e00ffb85b1db7d152",
                Usage = "New iPad",
                RemoteIp = "82.137.112.202",
                ReturnSuccessUrl = "https://example.com/return_success",
                ReturnFailureUrl = "https://example.com/return_failure",
                ProxyAmount = "519",
                Currency = Iso4217CurrencyCodes.EUR,
                PaymentType = "giropay",
                Bic = "GENODETT488",
                Iban = "DE07444488880123456789",
                AccountNumber = "334432",
                BankCode = "12345678",
                CustomerEmail = "emil@example.com",
                AccountPhone = "71234567891",
                BillingAddress = new Address()
                {
                    FirstName = "Barney",
                    LastName = "Rubble",
                    Address1 = "14, Nerazdelni str",
                    ZipCode = "1407",
                    City = "Sofia",
                    Country = Iso3166CountryCodes.BG
                },
                RiskParams = new RiskParams()
                {
                    UserId = "123456"
                }
            };

            var xml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"Ppro\">" +
                "<transaction_type>ppro</transaction_type>" +
                "<transaction_id>a1qf12e81eb23d0e00ffb85b1db7d152</transaction_id>" +
                "<usage>New iPad</usage>" +
                "<amount>519</amount>" +
                "<currency>EUR</currency>" +
                "<remote_ip>82.137.112.202</remote_ip>" +
                "<return_success_url>https://example.com/return_success</return_success_url>" +
                "<return_failure_url>https://example.com/return_failure</return_failure_url>" +
                "<customer_email>emil@example.com</customer_email>" +
                "<billing_address>" +
                "<first_name>Barney</first_name>" +
                "<last_name>Rubble</last_name>" +
                "<address1>14, Nerazdelni str</address1>" +
                "<zip_code>1407</zip_code>" +
                "<city>Sofia</city>" +
                "<country>BG</country>" +
                "</billing_address>" +
                "<risk_params>" +
                "<user_id>123456</user_id>" +
                "</risk_params>" +
                "<payment_type>giropay</payment_type>" +
                "<account_number>334432</account_number>" +
                "<bank_code>12345678</bank_code>" +
                "<bic>GENODETT488</bic>" +
                "<iban>DE07444488880123456789</iban>" +
                "<account_phone>71234567891</account_phone>" +
                "</payment_transaction>";

            return new EntityMock<Ppro>(ppro, xml);
        }
    }
}
