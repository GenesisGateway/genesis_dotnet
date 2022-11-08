using Genesis.Net.Common;
using Genesis.Net.Entities;
using Genesis.Net.Entities.Attributes.Request.Financial.Business;
using Genesis.Net.Entities.Attributes.Request.Financial.Cards.ThreedsV2;
using Genesis.Net.Entities.Attributes.Request.Financial.Cards.ThreedsV2.Enums;
using Genesis.Net.Entities.Requests.Initial;
using Genesis.Net.Entities.Requests.Query;
using Genesis.Net.Entities.Requests.Referential;
using System;
using System.Collections.Generic;

namespace Genesis.Net.Specs.Mocks
{
    static class RequestMocksFactory
    {
        const string _digitNumber = "123456789";
        const string _contractorName = "Martin Fowler";
        const string _paymentType = "deposit";

        public static EntityMock<Authorize> CreateValidAuthorize()
        {
            var _startDate = DateTime.Now.AddMonths(-1);
            var _endDate = DateTime.Now.AddMonths(1);

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
                CustomerPhone = "3598888888888",
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
                    Phone = "3598888888888",
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
                BusinessAttributes = new BusinessAttributes()
                {
                    FlightArrivalDate = _startDate.ToShortDateString(),
                    FlightDepartureDate = _endDate.ToShortDateString(),
                    AirlineFlightNumber = _digitNumber,
                    FlightTicketNumber = "WS1234TS",

                    EventId = _digitNumber,
                    EventStartDate = _startDate.ToShortDateString(),
                    EventEndDate = _endDate.ToShortDateString(),

                    DateOfOrder = _startDate.ToShortDateString(),
                    DeliveryDate = _endDate.ToShortDateString(),
                    NameOfTheSupplier = _contractorName,
                    CheckInDate = _startDate.ToShortDateString(),
                    CheckOutDate = _endDate.ToShortDateString(),
                    TravelAgencyName = "Test Agency Name",

                    VehiclePickUpDate = _startDate.ToShortDateString(),
                    VehicleReturnDate = _endDate.ToShortDateString(),
                    SupplierName = _contractorName,

                    CruiseStartDate = _startDate.ToShortDateString(),
                    CruiseEndDate = _endDate.ToShortDateString(),

                    ArrivalDate = _startDate.AddMonths(1).ToShortDateString(),
                    DepartureDate = _endDate.ToShortDateString(),

                    TicketNumber = _digitNumber,
                    OriginCity = "Sofia",
                    ContractorName = _contractorName,

                    PickUpDate = _startDate.ToShortDateString(),
                    ReturnDate = _endDate.AddMonths(1).ToShortDateString(),

                    PaymentType = _paymentType
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
                      "<customer_phone>3598888888888</customer_phone>" +
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
                      "<phone>3598888888888</phone>" +
                      "<remote_ip>255.10.100.10</remote_ip>" +
                      "<serial_number>serial number</serial_number>" +
                      "</risk_params>" +
                      "<dynamic_descriptor_params>" +
                      "<merchant_name>Test Merchant</merchant_name>" +
                      "<merchant_city>Testing Town</merchant_city>" +
                      "</dynamic_descriptor_params>" +
                      "<business_attributes>" +
                      "<flight_arrival_date>" + _startDate.ToShortDateString() + "</flight_arrival_date>" +
                      "<flight_departure_date>" + _endDate.ToShortDateString() + "</flight_departure_date>" +
                      "<airline_flight_number>" + _digitNumber + "</airline_flight_number>" +
                      "<flight_ticket_number>WS1234TS</flight_ticket_number>" +
                      "<event_id>" + _digitNumber + "</event_id>" +
                      "<event_start_date>" + _startDate.ToShortDateString() + "</event_start_date>" +
                      "<event_end_date>" + _endDate.ToShortDateString() + "</event_end_date>" +
                      "<date_of_order>" + _startDate.ToShortDateString() + "</date_of_order>" +
                      "<delivery_date>" + _endDate.ToShortDateString() + "</delivery_date>" +
                      "<name_of_the_supplier>" + _contractorName + "</name_of_the_supplier>" +
                      "<check_in_date>" + _startDate.ToShortDateString() + "</check_in_date>" +
                      "<check_out_date>" + _endDate.ToShortDateString() + "</check_out_date>" +
                      "<travel_agency_name>Test Agency Name</travel_agency_name>" +
                      "<vehicle_pick_up_date>" + _startDate.ToShortDateString() + "</vehicle_pick_up_date>" +
                      "<vehicle_return_date>" + _endDate.ToShortDateString() + "</vehicle_return_date>" +
                      "<supplier_name>" + _contractorName + "</supplier_name>" +
                      "<cruise_start_date>" + _startDate.ToShortDateString() + "</cruise_start_date>" +
                      "<cruise_end_date>" + _endDate.ToShortDateString() + "</cruise_end_date>" +
                      "<arrival_date>" + _startDate.AddMonths(1).ToShortDateString() + "</arrival_date>" +
                      "<departure_date>" + _endDate.ToShortDateString() + "</departure_date>" +
                      "<ticket_number>" + _digitNumber + "</ticket_number>" +
                      "<origin_city>Sofia</origin_city>" +
                      "<contractor_name>" + _contractorName + "</contractor_name>" +
                      "<pick_up_date>" + _startDate.ToShortDateString() + "</pick_up_date>" +
                      "<return_date>" + _endDate.AddMonths(1).ToShortDateString() + "</return_date>" +
                      "<payment_type>" + _paymentType + "</payment_type>" +
                      "</business_attributes>" +
                      "</payment_transaction>";

            return new EntityMock<Authorize>(authorize, xml);
        }

        public static EntityMock<Authorize3d> CreateValidAuthorize3dAsync()
        {
            var _startDate = DateTime.Now.AddMonths(-1);
            var _endDate = DateTime.Now.AddMonths(1);

            var authorize3dAsync = new Authorize3d()
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
                CustomerPhone = "3598888888888",
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
                    Phone = "3598888888888",
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
                BusinessAttributes = new BusinessAttributes()
                {
                    FlightArrivalDate = _startDate.ToShortDateString(),
                    FlightDepartureDate = _endDate.ToShortDateString(),
                    AirlineFlightNumber = _digitNumber,
                    FlightTicketNumber = "WS1234TS",

                    EventId = _digitNumber,
                    EventStartDate = _startDate.ToShortDateString(),
                    EventEndDate = _endDate.ToShortDateString(),

                    DateOfOrder = _startDate.ToShortDateString(),
                    DeliveryDate = _endDate.ToShortDateString(),
                    NameOfTheSupplier = _contractorName,
                    CheckInDate = _startDate.ToShortDateString(),
                    CheckOutDate = _endDate.ToShortDateString(),
                    TravelAgencyName = "Test Agency Name",

                    VehiclePickUpDate = _startDate.ToShortDateString(),
                    VehicleReturnDate = _endDate.ToShortDateString(),
                    SupplierName = _contractorName,

                    CruiseStartDate = _startDate.ToShortDateString(),
                    CruiseEndDate = _endDate.ToShortDateString(),

                    ArrivalDate = _startDate.AddMonths(1).ToShortDateString(),
                    DepartureDate = _endDate.ToShortDateString(),

                    TicketNumber = _digitNumber,
                    OriginCity = "Sofia",
                    ContractorName = _contractorName,

                    PickUpDate = _startDate.ToShortDateString(),
                    ReturnDate = _endDate.AddMonths(1).ToShortDateString(),

                    PaymentType = _paymentType
                }

            };

            var xml =
                    "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                    "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"Authorize3d\">" +
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
                    "<customer_phone>3598888888888</customer_phone>" +
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
                    "<phone>3598888888888</phone>" +
                    "<remote_ip>255.10.100.10</remote_ip>" +
                    "<serial_number>serial number</serial_number>" +
                    "</risk_params>" +
                    "<dynamic_descriptor_params>" +
                    "<merchant_name>Test Merchant</merchant_name>" +
                    "<merchant_city>Testing Town</merchant_city>" +
                    "</dynamic_descriptor_params>" +
                    "<business_attributes>" +
                    "<flight_arrival_date>" + _startDate.ToShortDateString() + "</flight_arrival_date>" +
                    "<flight_departure_date>" + _endDate.ToShortDateString() + "</flight_departure_date>" +
                    "<airline_flight_number>" + _digitNumber + "</airline_flight_number>" +
                    "<flight_ticket_number>WS1234TS</flight_ticket_number>" +
                    "<event_id>" + _digitNumber + "</event_id>" +
                    "<event_start_date>" + _startDate.ToShortDateString() + "</event_start_date>" +
                    "<event_end_date>" + _endDate.ToShortDateString() + "</event_end_date>" +
                    "<date_of_order>" + _startDate.ToShortDateString() + "</date_of_order>" +
                    "<delivery_date>" + _endDate.ToShortDateString() + "</delivery_date>" +
                    "<name_of_the_supplier>" + _contractorName + "</name_of_the_supplier>" +
                    "<check_in_date>" + _startDate.ToShortDateString() + "</check_in_date>" +
                    "<check_out_date>" + _endDate.ToShortDateString() + "</check_out_date>" +
                    "<travel_agency_name>Test Agency Name</travel_agency_name>" +
                    "<vehicle_pick_up_date>" + _startDate.ToShortDateString() + "</vehicle_pick_up_date>" +
                    "<vehicle_return_date>" + _endDate.ToShortDateString() + "</vehicle_return_date>" +
                    "<supplier_name>" + _contractorName + "</supplier_name>" +
                    "<cruise_start_date>" + _startDate.ToShortDateString() + "</cruise_start_date>" +
                    "<cruise_end_date>" + _endDate.ToShortDateString() + "</cruise_end_date>" +
                    "<arrival_date>" + _startDate.AddMonths(1).ToShortDateString() + "</arrival_date>" +
                    "<departure_date>" + _endDate.ToShortDateString() + "</departure_date>" +
                    "<ticket_number>" + _digitNumber + "</ticket_number>" +
                    "<origin_city>Sofia</origin_city>" +
                    "<contractor_name>" + _contractorName + "</contractor_name>" +
                    "<pick_up_date>" + _startDate.ToShortDateString() + "</pick_up_date>" +
                    "<return_date>" + _endDate.AddMonths(1).ToShortDateString() + "</return_date>" +
                    "<payment_type>" + _paymentType + "</payment_type>" +
                    "</business_attributes>" +
                    "<notification_url>https://example.com/notify</notification_url>" +
                    "<return_success_url>http://test.com/success</return_success_url>" +
                    "<return_failure_url>http://test.com/fail</return_failure_url>" +
                    "</payment_transaction>";

            return new EntityMock<Authorize3d>(authorize3dAsync, xml);
        }

        public static EntityMock<Authorize3d> CreateValidAuthorize3dSync()
        {
            var authorize3dSync = new Authorize3d()
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
                CustomerPhone = "3598888888888",
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
                    Phone = "3598888888888",
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
                    "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"Authorize3d\">" +
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
                    "<customer_phone>3598888888888</customer_phone>" +
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
                    "<phone>3598888888888</phone>" +
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

            return new EntityMock<Authorize3d>(authorize3dSync, xml);
        }

        public static EntityMock<InitRecurringSale3d> CreateValidInitRecurringSale3dAsync()
        {
            var _startDate = DateTime.Now.AddMonths(-1);
            var _endDate = DateTime.Now.AddMonths(1);

            var initRecurringSale3dAsync = new InitRecurringSale3d()
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
                CustomerPhone = "3598888888888",
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
                    Phone = "3598888888888",
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
                BusinessAttributes = new BusinessAttributes()
                {
                    FlightArrivalDate = _startDate.ToShortDateString(),
                    FlightDepartureDate = _endDate.ToShortDateString(),
                    AirlineFlightNumber = _digitNumber,
                    FlightTicketNumber = "WS1234TS",

                    EventId = _digitNumber,
                    EventStartDate = _startDate.ToShortDateString(),
                    EventEndDate = _endDate.ToShortDateString(),

                    DateOfOrder = _startDate.ToShortDateString(),
                    DeliveryDate = _endDate.ToShortDateString(),
                    NameOfTheSupplier = _contractorName,
                    CheckInDate = _startDate.ToShortDateString(),
                    CheckOutDate = _endDate.ToShortDateString(),
                    TravelAgencyName = "Test Agency Name",

                    VehiclePickUpDate = _startDate.ToShortDateString(),
                    VehicleReturnDate = _endDate.ToShortDateString(),
                    SupplierName = _contractorName,

                    CruiseStartDate = _startDate.ToShortDateString(),
                    CruiseEndDate = _endDate.ToShortDateString(),

                    ArrivalDate = _startDate.AddMonths(1).ToShortDateString(),
                    DepartureDate = _endDate.ToShortDateString(),

                    TicketNumber = _digitNumber,
                    OriginCity = "Sofia",
                    ContractorName = _contractorName,

                    PickUpDate = _startDate.ToShortDateString(),
                    ReturnDate = _endDate.AddMonths(1).ToShortDateString(),

                    PaymentType = _paymentType
                }
            };

            var xml =
                     "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                     "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"InitRecurringSale3d\">" +
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
                     "<customer_phone>3598888888888</customer_phone>" +
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
                     "<phone>3598888888888</phone>" +
                     "<remote_ip>255.10.100.10</remote_ip>" +
                     "<serial_number>serial number</serial_number>" +
                     "</risk_params>" +
                     "<dynamic_descriptor_params>" +
                     "<merchant_name>Test Merchant</merchant_name>" +
                     "<merchant_city>Testing Town</merchant_city>" +
                     "</dynamic_descriptor_params>" +
                     "<business_attributes>" +
                     "<flight_arrival_date>" + _startDate.ToShortDateString() + "</flight_arrival_date>" +
                     "<flight_departure_date>" + _endDate.ToShortDateString() + "</flight_departure_date>" +
                     "<airline_flight_number>" + _digitNumber + "</airline_flight_number>" +
                     "<flight_ticket_number>WS1234TS</flight_ticket_number>" +
                     "<event_id>" + _digitNumber + "</event_id>" +
                     "<event_start_date>" + _startDate.ToShortDateString() + "</event_start_date>" +
                     "<event_end_date>" + _endDate.ToShortDateString() + "</event_end_date>" +
                     "<date_of_order>" + _startDate.ToShortDateString() + "</date_of_order>" +
                     "<delivery_date>" + _endDate.ToShortDateString() + "</delivery_date>" +
                     "<name_of_the_supplier>" + _contractorName + "</name_of_the_supplier>" +
                     "<check_in_date>" + _startDate.ToShortDateString() + "</check_in_date>" +
                     "<check_out_date>" + _endDate.ToShortDateString() + "</check_out_date>" +
                     "<travel_agency_name>Test Agency Name</travel_agency_name>" +
                     "<vehicle_pick_up_date>" + _startDate.ToShortDateString() + "</vehicle_pick_up_date>" +
                     "<vehicle_return_date>" + _endDate.ToShortDateString() + "</vehicle_return_date>" +
                     "<supplier_name>" + _contractorName + "</supplier_name>" +
                     "<cruise_start_date>" + _startDate.ToShortDateString() + "</cruise_start_date>" +
                     "<cruise_end_date>" + _endDate.ToShortDateString() + "</cruise_end_date>" +
                     "<arrival_date>" + _startDate.AddMonths(1).ToShortDateString() + "</arrival_date>" +
                     "<departure_date>" + _endDate.ToShortDateString() + "</departure_date>" +
                     "<ticket_number>" + _digitNumber + "</ticket_number>" +
                     "<origin_city>Sofia</origin_city>" +
                     "<contractor_name>" + _contractorName + "</contractor_name>" +
                     "<pick_up_date>" + _startDate.ToShortDateString() + "</pick_up_date>" +
                     "<return_date>" + _endDate.AddMonths(1).ToShortDateString() + "</return_date>" +
                     "<payment_type>" + _paymentType + "</payment_type>" +
                     "</business_attributes>" +
                     "<notification_url>https://example.com/notify</notification_url>" +
                     "<return_success_url>http://test.com/success</return_success_url>" +
                     "<return_failure_url>http://test.com/fail</return_failure_url>" +
                     "</payment_transaction>";

            return new EntityMock<InitRecurringSale3d>(initRecurringSale3dAsync, xml);
        }

        public static EntityMock<InitRecurringSale3d> CreateValidInitRecurringSale3dSync()
        {
            var initRecurringSale3dSync = new InitRecurringSale3d()
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
                CustomerPhone = "3598888888888",
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
                    Phone = "3598888888888",
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
                     "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"InitRecurringSale3d\">" +
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
                     "<customer_phone>3598888888888</customer_phone>" +
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
                     "<phone>3598888888888</phone>" +
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

            return new EntityMock<InitRecurringSale3d>(initRecurringSale3dSync, xml);
        }

        public static EntityMock<Sale3d> CreateValidSale3dAsync()
        {
            var _startDate = DateTime.Now.AddMonths(-1);
            var _endDate = DateTime.Now.AddMonths(1);

            var sale3dAsync = new Sale3d()
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
                CustomerPhone = "3598888888888",
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
                    Phone = "3598888888888",
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
                BusinessAttributes = new BusinessAttributes()
                {
                    FlightArrivalDate = _startDate.ToShortDateString(),
                    FlightDepartureDate = _endDate.ToShortDateString(),
                    AirlineFlightNumber = _digitNumber,
                    FlightTicketNumber = "WS1234TS",

                    EventId = _digitNumber,
                    EventStartDate = _startDate.ToShortDateString(),
                    EventEndDate = _endDate.ToShortDateString(),

                    DateOfOrder = _startDate.ToShortDateString(),
                    DeliveryDate = _endDate.ToShortDateString(),
                    NameOfTheSupplier = _contractorName,
                    CheckInDate = _startDate.ToShortDateString(),
                    CheckOutDate = _endDate.ToShortDateString(),
                    TravelAgencyName = "Test Agency Name",

                    VehiclePickUpDate = _startDate.ToShortDateString(),
                    VehicleReturnDate = _endDate.ToShortDateString(),
                    SupplierName = _contractorName,

                    CruiseStartDate = _startDate.ToShortDateString(),
                    CruiseEndDate = _endDate.ToShortDateString(),

                    ArrivalDate = _startDate.AddMonths(1).ToShortDateString(),
                    DepartureDate = _endDate.ToShortDateString(),

                    TicketNumber = _digitNumber,
                    OriginCity = "Sofia",
                    ContractorName = _contractorName,

                    PickUpDate = _startDate.ToShortDateString(),
                    ReturnDate = _endDate.AddMonths(1).ToShortDateString(),

                    PaymentType = _paymentType
                }
            };

            var xml =
                     "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                     "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"Sale3d\">" +
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
                     "<customer_phone>3598888888888</customer_phone>" +
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
                     "<phone>3598888888888</phone>" +
                     "<remote_ip>255.10.100.10</remote_ip>" +
                     "<serial_number>serial number</serial_number>" +
                     "</risk_params>" +
                     "<dynamic_descriptor_params>" +
                     "<merchant_name>Test Merchant</merchant_name>" +
                     "<merchant_city>Testing Town</merchant_city>" +
                     "</dynamic_descriptor_params>" +
                     "<business_attributes>" +
                     "<flight_arrival_date>" + _startDate.ToShortDateString() + "</flight_arrival_date>" +
                     "<flight_departure_date>" + _endDate.ToShortDateString() + "</flight_departure_date>" +
                     "<airline_flight_number>" + _digitNumber + "</airline_flight_number>" +
                     "<flight_ticket_number>WS1234TS</flight_ticket_number>" +
                     "<event_id>" + _digitNumber + "</event_id>" +
                     "<event_start_date>" + _startDate.ToShortDateString() + "</event_start_date>" +
                     "<event_end_date>" + _endDate.ToShortDateString() + "</event_end_date>" +
                     "<date_of_order>" + _startDate.ToShortDateString() + "</date_of_order>" +
                     "<delivery_date>" + _endDate.ToShortDateString() + "</delivery_date>" +
                     "<name_of_the_supplier>" + _contractorName + "</name_of_the_supplier>" +
                     "<check_in_date>" + _startDate.ToShortDateString() + "</check_in_date>" +
                     "<check_out_date>" + _endDate.ToShortDateString() + "</check_out_date>" +
                     "<travel_agency_name>Test Agency Name</travel_agency_name>" +
                     "<vehicle_pick_up_date>" + _startDate.ToShortDateString() + "</vehicle_pick_up_date>" +
                     "<vehicle_return_date>" + _endDate.ToShortDateString() + "</vehicle_return_date>" +
                     "<supplier_name>" + _contractorName + "</supplier_name>" +
                     "<cruise_start_date>" + _startDate.ToShortDateString() + "</cruise_start_date>" +
                     "<cruise_end_date>" + _endDate.ToShortDateString() + "</cruise_end_date>" +
                     "<arrival_date>" + _startDate.AddMonths(1).ToShortDateString() + "</arrival_date>" +
                     "<departure_date>" + _endDate.ToShortDateString() + "</departure_date>" +
                     "<ticket_number>" + _digitNumber + "</ticket_number>" +
                     "<origin_city>Sofia</origin_city>" +
                     "<contractor_name>" + _contractorName + "</contractor_name>" +
                     "<pick_up_date>" + _startDate.ToShortDateString() + "</pick_up_date>" +
                     "<return_date>" + _endDate.AddMonths(1).ToShortDateString() + "</return_date>" +
                     "<payment_type>" + _paymentType + "</payment_type>" +
                     "</business_attributes>" +
                     "<notification_url>https://example.com/notify</notification_url>" +
                     "<return_success_url>http://test.com/success</return_success_url>" +
                     "<return_failure_url>http://test.com/fail</return_failure_url>" +
                     "</payment_transaction>";

            return new EntityMock<Sale3d>(sale3dAsync, xml);
        }

        public static EntityMock<Sale3d> CreateValidSale3dSync()
        {
            var sale3dSync = new Sale3d()
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
                CustomerPhone = "3598888888888",
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
                    Phone = "3598888888888",
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
                },
            };

            var xml =
                     "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                     "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"Sale3d\">" +
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
                     "<customer_phone>3598888888888</customer_phone>" +
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
                     "<phone>3598888888888</phone>" +
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

            return new EntityMock<Sale3d>(sale3dSync, xml);
        }

        public static EntityMock<InitRecurringSale3d> CreateValidFrictionless3dv2()
        {
            var sale3dv2 = new InitRecurringSale3d()
            {
                Id = "119643250547501c79d8295",
                Usage = "40208 concert tickets",
                RemoteIp = "245.253.2.12",
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                CardHolder = "Travis Pastrana",
                CardNumber = CardsNumbers.Visa3dsv2FrictionlessAuthenticated,
                ExpirationMonth = 12,
                ExpirationYear = 2023,
                CustomerEmail = "travis@example.com",
                CustomerPhone = "+1987987987987",
                Cvv = "834",
                BillingAddress = new Address()
                {
                    Address1 = "Muster Str. 12",
                    City = "Los Angeles",
                    Country = Iso3166CountryCodes.US,
                    FirstName = "Travis",
                    LastName = "Pastrana",
                    State = "CA",
                    ZipCode = "10178"
                },
                NotificationUrl = "https://www.example.com/notification",
                ReturnSuccessUrl = "http://www.example.com/success",
                ReturnFailureUrl = "http://www.example.com/failure",
                ThreeDSv2 = new ThreeDSv2
                {
                    ThreedsMethod = new ThreedsMethod()
                    {
                        CallbackUrl = "https://www.example.com/threeds/threeds_method/callback",
                    },
                    Control = new Control()
                    {
                        DeviceType = DeviceTypes.Browser,
                        ChallengeWindowSize = ChallengeWindowSizes.FullScreen,
                        ChallengeIndicator = ChallengeIndicators.Preference
                    },
                    Purchase = new Purchase()
                    {
                        Category = PurchaseCategories.Service
                    },
                    MerchantRisk = new MerchantRisk()
                    {
                        ShippingIndicator = ShippingIndicators.VerifiedAddress,
                        DeliveryTimeframe = DeliveryTimeframes.Electronic,
                        ReorderItemsIndicator = ReorderItemsIndicators.Reordered,
                        PreOrderPurchaseIndicator = PreOrderPurchaseIndicators.MerchandiseAvailable,
                        PreOrderDate = new DateTime(2022, 06, 25).Date,
                        GiftCard = true,
                        GiftCardCount = 2
                    },
                    CardHolderAccount = new CardHolderAccount()
                    {
                        CreationDate = new DateTime(2021, 05, 25).Date,
                        UpdateIndicator = UpdateIndicators.MoreThan60Days,
                        LastChangeDate = new DateTime(2022, 02, 25).Date,
                        PasswordChangeIndicator = PasswordChangeIndicators.NoChange,
                        PasswordChangeDate = new DateTime(2022, 05, 10).Date,
                        ShippingAddressUsageIndicator = ShippingAddressUsageIndicators.CurrentTransaction,
                        ShippingAddressDateFirstUsed = new DateTime(2022, 05, 20).Date,
                        TransactionsActivityLast24Hours = 2,
                        TransactionsActivityPreviousYear = 10,
                        ProvisionAttemptsLast24Hours = 1,
                        PurchasesCountLast6Months = 5,
                        SuspiciousActivityIndicator = SuspiciousActivityIndicators.NoSuspiciousObserved,
                        RegistrationIndicator = RegistrationIndicators.From30To60Days,
                        RegistrationDate = new DateTime(2020, 05, 25).Date,
                    },
                    Browser = new Browser()
                    {
                        AcceptHeader = "*/*",
                        JavaEnabled = false,
                        Language = "en-GB",
                        ColorDepth = 24,
                        ScreenHeight = 900,
                        ScreenWidth = 1440,
                        TimeZoneOffset = -120,
                        UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36",
                    },
                    Sdk = new Sdk()
                    {
                        Interface = Interfaces.Native,
                        UiTypes = new List<UiTypes>
                        {
                            UiTypes.MultiSelect
                        },
                        ApplicationId = Guid.Parse("fc1650c0-5778-0138-8205-2cbc32a32d65"),
                        EncryptedData = "encrypted-data-here",
                        EphemeralPublicKeyPair = "public-key-pair",
                        MaxTimeout = 10,
                        ReferenceNumber = "sdk-reference-number-here"
                    },
                    Recurring = new Recurring()
                    {
                        ExpirationDate = new DateTime(2022, 11, 25).Date,
                        Frequency = 30,
                    }
                },
                Sca = new Sca()
                {
                    Exemption = ScaExemptions.LowRisk
                }
            };

            var xml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
                <payment_transaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns=""InitRecurringSale3d"">
                  <transaction_type>init_recurring_sale3d</transaction_type>
                  <transaction_id>119643250547501c79d8295</transaction_id>
                  <usage>40208 concert tickets</usage>
                  <amount>100</amount>
                  <currency>USD</currency>
                  <remote_ip>245.253.2.12</remote_ip>
                  <card_holder>Travis Pastrana</card_holder>
                  <expiration_month>12</expiration_month>
                  <expiration_year>2023</expiration_year>
                  <customer_email>travis@example.com</customer_email>
                  <customer_phone>+1987987987987</customer_phone>
                  <card_number>4012000000060085</card_number>
                  <cvv>834</cvv>
                  <billing_address>
                    <first_name>Travis</first_name>
                    <last_name>Pastrana</last_name>
                    <address1>Muster Str. 12</address1>
                    <zip_code>10178</zip_code>
                    <city>Los Angeles</city>
                    <state>CA</state>
                    <country>US</country>
                  </billing_address>
                  <notification_url>https://www.example.com/notification</notification_url>
                  <return_success_url>http://www.example.com/success</return_success_url>
                  <return_failure_url>http://www.example.com/failure</return_failure_url>
                  <threeds_v2_params>
                    <threeds_method>
                      <callback_url>https://www.example.com/threeds/threeds_method/callback</callback_url>
                    </threeds_method>
                    <control>
                      <device_type>browser</device_type>
                      <challenge_window_size>full_screen</challenge_window_size>
                      <challenge_indicator>preference</challenge_indicator>
                    </control>
                    <purchase>
                      <category>service</category>
                    </purchase>
                    <merchant_risk>
                      <shipping_indicator>verified_address</shipping_indicator>
                      <delivery_timeframe>electronic</delivery_timeframe>
                      <reorder_items_indicator>reordered</reorder_items_indicator>
                      <pre_order_purchase_indicator>merchandise_available</pre_order_purchase_indicator>
                      <pre_order_date>25-06-2022</pre_order_date>
                      <gift_card>true</gift_card>
                      <gift_card_count>2</gift_card_count>
                    </merchant_risk>
                    <card_holder_account>
                      <creation_date>25-05-2021</creation_date>
                      <update_indicator>more_than_60days</update_indicator>
                      <last_change_date>25-02-2022</last_change_date>
                      <password_change_indicator>no_change</password_change_indicator>
                      <password_change_date>10-05-2022</password_change_date>
                      <shipping_address_usage_indicator>current_transaction</shipping_address_usage_indicator>
                      <shipping_address_date_first_used>20-05-2022</shipping_address_date_first_used>
                      <transactions_activity_last_24_hours>2</transactions_activity_last_24_hours>
                      <transactions_activity_previous_year>10</transactions_activity_previous_year>
                      <provision_attempts_last_24_hours>1</provision_attempts_last_24_hours>
                      <purchases_count_last_6_months>5</purchases_count_last_6_months>
                      <suspicious_activity_indicator>no_suspicious_observed</suspicious_activity_indicator>
                      <registration_indicator>30_to_60_days</registration_indicator>
                      <registration_date>25-05-2020</registration_date>
                    </card_holder_account>
                    <browser>
                      <accept_header>*/*</accept_header>
                      <java_enabled>false</java_enabled>
                      <language>en-GB</language>
                      <color_depth>24</color_depth>
                      <screen_height>900</screen_height>
                      <screen_width>1440</screen_width>
                      <time_zone_offset>-120</time_zone_offset>
                      <user_agent>Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36</user_agent>
                    </browser>
                    <sdk>
                      <interface>native</interface>
                      <ui_types>
                        <ui_type>multi_select</ui_type>
                      </ui_types>
                      <application_id>fc1650c0-5778-0138-8205-2cbc32a32d65</application_id>
                      <encrypted_data>encrypted-data-here</encrypted_data>
                      <ephemeral_public_key_pair>public-key-pair</ephemeral_public_key_pair>
                      <max_timeout>10</max_timeout>
                      <reference_number>sdk-reference-number-here</reference_number>
                    </sdk>
                    <recurring>
                      <expiration_date>25-11-2022</expiration_date>
                      <frequency>30</frequency>
                    </recurring>
                  </threeds_v2_params>
                  <sca_params>
                    <exemption>low_risk</exemption>
                  </sca_params>
                </payment_transaction>";

            return new EntityMock<InitRecurringSale3d>(sale3dv2, xml);
        }

        public static EntityMock<InitRecurringSale3d> CreateValidFrictionless3dv2With3dSecure()
        {
            var sale3dv2With3dSecure = new InitRecurringSale3d()
            {
                Id = "119643250547501c79d8295",
                Usage = "40208 concert tickets",
                RemoteIp = "245.253.2.12",
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                CardHolder = "Travis Pastrana",
                CardNumber = CardsNumbers.Visa3dsv2FrictionlessWith3dsMethodAuthenticated,
                ExpirationMonth = 12,
                ExpirationYear = 2023,
                CustomerEmail = "travis@example.com",
                CustomerPhone = "+1987987987987",
                Cvv = "834",
                BillingAddress = new Address()
                {
                    Address1 = "Muster Str. 12",
                    City = "Los Angeles",
                    Country = Iso3166CountryCodes.US,
                    FirstName = "Travis",
                    LastName = "Pastrana",
                    State = "CA",
                    ZipCode = "10178"
                },
                NotificationUrl = "https://www.example.com/notification",
                ReturnSuccessUrl = "http://www.example.com/success",
                ReturnFailureUrl = "http://www.example.com/failure",
                ThreeDSv2 = new ThreeDSv2
                {
                    ThreedsMethod = new ThreedsMethod()
                    {
                        CallbackUrl = "https://www.example.com/threeds/threeds_method/callback",
                    },
                    Control = new Control()
                    {
                        DeviceType = DeviceTypes.Browser,
                        ChallengeWindowSize = ChallengeWindowSizes.FullScreen,
                        ChallengeIndicator = ChallengeIndicators.Preference
                    },
                    Purchase = new Purchase()
                    {
                        Category = PurchaseCategories.Service
                    },
                    MerchantRisk = new MerchantRisk()
                    {
                        ShippingIndicator = ShippingIndicators.VerifiedAddress,
                        DeliveryTimeframe = DeliveryTimeframes.Electronic,
                        ReorderItemsIndicator = ReorderItemsIndicators.Reordered,
                        PreOrderPurchaseIndicator = PreOrderPurchaseIndicators.MerchandiseAvailable,
                        PreOrderDate = new DateTime(2022, 06, 25).Date,
                        GiftCard = true,
                        GiftCardCount = 2
                    },
                    CardHolderAccount = new CardHolderAccount()
                    {
                        CreationDate = new DateTime(2021, 05, 25).Date,
                        UpdateIndicator = UpdateIndicators.MoreThan60Days,
                        LastChangeDate = new DateTime(2022, 02, 25).Date,
                        PasswordChangeIndicator = PasswordChangeIndicators.NoChange,
                        PasswordChangeDate = new DateTime(2022, 05, 10).Date,
                        ShippingAddressUsageIndicator = ShippingAddressUsageIndicators.CurrentTransaction,
                        ShippingAddressDateFirstUsed = new DateTime(2022, 05, 20).Date,
                        TransactionsActivityLast24Hours = 2,
                        TransactionsActivityPreviousYear = 10,
                        ProvisionAttemptsLast24Hours = 1,
                        PurchasesCountLast6Months = 5,
                        SuspiciousActivityIndicator = SuspiciousActivityIndicators.NoSuspiciousObserved,
                        RegistrationIndicator = RegistrationIndicators.From30To60Days,
                        RegistrationDate = new DateTime(2020, 05, 25).Date,
                    },
                    Browser = new Browser()
                    {
                        AcceptHeader = "*/*",
                        JavaEnabled = false,
                        Language = "en-GB",
                        ColorDepth = 24,
                        ScreenHeight = 900,
                        ScreenWidth = 1440,
                        TimeZoneOffset = -120,
                        UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36",
                    },
                    Sdk = new Sdk()
                    {
                        Interface = Interfaces.Native,
                        UiTypes = new List<UiTypes>
                        {
                            UiTypes.MultiSelect
                        },
                        ApplicationId = Guid.Parse("fc1650c0-5778-0138-8205-2cbc32a32d65"),
                        EncryptedData = "encrypted-data-here",
                        EphemeralPublicKeyPair = "public-key-pair",
                        MaxTimeout = 10,
                        ReferenceNumber = "sdk-reference-number-here"
                    },
                    Recurring = new Recurring()
                    {
                        ExpirationDate = new DateTime(2022, 11, 25).Date,
                        Frequency = 30,
                    }
                },
                Sca = new Sca()
                {
                    Exemption = ScaExemptions.LowRisk
                }
            };

            var xml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
  <payment_transaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns=""InitRecurringSale3d"">
    <transaction_type>init_recurring_sale3d</transaction_type>
    <transaction_id>119643250547501c79d8295</transaction_id>
    <usage>40208 concert tickets</usage>
    <amount>100</amount>
    <currency>USD</currency>
    <remote_ip>245.253.2.12</remote_ip>
    <card_holder>Travis Pastrana</card_holder>
    <expiration_month>12</expiration_month>
    <expiration_year>2023</expiration_year>
    <customer_email>travis@example.com</customer_email>
    <customer_phone>+1987987987987</customer_phone>
    <card_number>4066330000000004</card_number>
    <cvv>834</cvv>
    <billing_address>
      <first_name>Travis</first_name>
      <last_name>Pastrana</last_name>
      <address1>Muster Str. 12</address1>
      <zip_code>10178</zip_code>
      <city>Los Angeles</city>
      <state>CA</state>
      <country>US</country>
    </billing_address>
    <notification_url>https://www.example.com/notification</notification_url>
    <return_success_url>http://www.example.com/success</return_success_url>
    <return_failure_url>http://www.example.com/failure</return_failure_url>
    <threeds_v2_params>
      <threeds_method>
        <callback_url>https://www.example.com/threeds/threeds_method/callback</callback_url>
      </threeds_method>
      <control>
        <device_type>browser</device_type>
        <challenge_window_size>full_screen</challenge_window_size>
        <challenge_indicator>preference</challenge_indicator>
      </control>
      <purchase>
        <category>service</category>
      </purchase>
      <merchant_risk>
        <shipping_indicator>verified_address</shipping_indicator>
        <delivery_timeframe>electronic</delivery_timeframe>
        <reorder_items_indicator>reordered</reorder_items_indicator>
        <pre_order_purchase_indicator>merchandise_available</pre_order_purchase_indicator>
        <pre_order_date>25-06-2022</pre_order_date>
        <gift_card>true</gift_card>
        <gift_card_count>2</gift_card_count>
      </merchant_risk>
      <card_holder_account>
        <creation_date>25-05-2021</creation_date>
        <update_indicator>more_than_60days</update_indicator>
        <last_change_date>25-02-2022</last_change_date>
        <password_change_indicator>no_change</password_change_indicator>
        <password_change_date>10-05-2022</password_change_date>
        <shipping_address_usage_indicator>current_transaction</shipping_address_usage_indicator>
        <shipping_address_date_first_used>20-05-2022</shipping_address_date_first_used>
        <transactions_activity_last_24_hours>2</transactions_activity_last_24_hours>
        <transactions_activity_previous_year>10</transactions_activity_previous_year>
        <provision_attempts_last_24_hours>1</provision_attempts_last_24_hours>
        <purchases_count_last_6_months>5</purchases_count_last_6_months>
        <suspicious_activity_indicator>no_suspicious_observed</suspicious_activity_indicator>
        <registration_indicator>30_to_60_days</registration_indicator>
        <registration_date>25-05-2020</registration_date>
      </card_holder_account>
      <browser>
        <accept_header>*/*</accept_header>
        <java_enabled>false</java_enabled>
        <language>en-GB</language>
        <color_depth>24</color_depth>
        <screen_height>900</screen_height>
        <screen_width>1440</screen_width>
        <time_zone_offset>-120</time_zone_offset>
        <user_agent>Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36</user_agent>
      </browser>
      <sdk>
        <interface>native</interface>
        <ui_types>
          <ui_type>multi_select</ui_type>
        </ui_types>
        <application_id>fc1650c0-5778-0138-8205-2cbc32a32d65</application_id>
        <encrypted_data>encrypted-data-here</encrypted_data>
        <ephemeral_public_key_pair>public-key-pair</ephemeral_public_key_pair>
        <max_timeout>10</max_timeout>
        <reference_number>sdk-reference-number-here</reference_number>
      </sdk>
      <recurring>
        <expiration_date>25-11-2022</expiration_date>
        <frequency>30</frequency>
      </recurring>
    </threeds_v2_params>
    <sca_params>
      <exemption>low_risk</exemption>
    </sca_params>
  </payment_transaction>";
            return new EntityMock<InitRecurringSale3d>(sale3dv2With3dSecure, xml);
        }

        public static EntityMock<Authorize3d> CreateValidChallenge3dv2()
        {
            var challenge3dv2With3dSecure = new Authorize3d()
            {
                Type = TransactionTypes.Authorize3d,
                Id = "119643250547501c79d8295",
                Usage = "40208 concert tickets",
                RemoteIp = "245.253.2.12",
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                CardHolder = "Travis Pastrana",
                CardNumber = CardsNumbers.Visa3dsv2Challenge,
                ExpirationMonth = 12,
                ExpirationYear = 2023,
                CustomerEmail = "travis@example.com",
                CustomerPhone = "+1987987987987",
                Cvv = "834",
                BillingAddress = new Address()
                {
                    Address1 = "Muster Str. 12",
                    City = "Los Angeles",
                    Country = Iso3166CountryCodes.US,
                    FirstName = "Travis",
                    LastName = "Pastrana",
                    State = "CA",
                    ZipCode = "10178"
                },
                NotificationUrl = "https://www.example.com/notification",
                ReturnSuccessUrl = "http://www.example.com/success",
                ReturnFailureUrl = "http://www.example.com/failure",
                ThreeDSv2 = new ThreeDSv2
                {
                    ThreedsMethod = new ThreedsMethod()
                    {
                        CallbackUrl = "https://www.example.com/threeds/threeds_method/callback",
                    },
                    Control = new Control()
                    {
                        DeviceType = DeviceTypes.Browser,
                        ChallengeWindowSize = ChallengeWindowSizes.FullScreen,
                        ChallengeIndicator = ChallengeIndicators.Preference
                    },
                    Purchase = new Purchase()
                    {
                        Category = PurchaseCategories.Service
                    },
                    MerchantRisk = new MerchantRisk()
                    {
                        ShippingIndicator = ShippingIndicators.VerifiedAddress,
                        DeliveryTimeframe = DeliveryTimeframes.Electronic,
                        ReorderItemsIndicator = ReorderItemsIndicators.Reordered,
                        PreOrderPurchaseIndicator = PreOrderPurchaseIndicators.MerchandiseAvailable,
                        PreOrderDate = new DateTime(2022, 06, 25).Date,
                        GiftCard = true,
                        GiftCardCount = 2
                    },
                    CardHolderAccount = new CardHolderAccount()
                    {
                        CreationDate = new DateTime(2021, 05, 25).Date,
                        UpdateIndicator = UpdateIndicators.MoreThan60Days,
                        LastChangeDate = new DateTime(2022, 02, 25).Date,
                        PasswordChangeIndicator = PasswordChangeIndicators.NoChange,
                        PasswordChangeDate = new DateTime(2022, 05, 10).Date,
                        ShippingAddressUsageIndicator = ShippingAddressUsageIndicators.CurrentTransaction,
                        ShippingAddressDateFirstUsed = new DateTime(2022, 05, 20).Date,
                        TransactionsActivityLast24Hours = 2,
                        TransactionsActivityPreviousYear = 10,
                        ProvisionAttemptsLast24Hours = 1,
                        PurchasesCountLast6Months = 5,
                        SuspiciousActivityIndicator = SuspiciousActivityIndicators.NoSuspiciousObserved,
                        RegistrationIndicator = RegistrationIndicators.From30To60Days,
                        RegistrationDate = new DateTime(2020, 05, 25).Date,
                    },
                    Browser = new Browser()
                    {
                        AcceptHeader = "*/*",
                        JavaEnabled = false,
                        Language = "en-GB",
                        ColorDepth = 24,
                        ScreenHeight = 900,
                        ScreenWidth = 1440,
                        TimeZoneOffset = -120,
                        UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36",
                    },
                    Sdk = new Sdk()
                    {
                        Interface = Interfaces.Native,
                        UiTypes = new List<UiTypes>
                        {
                            UiTypes.MultiSelect
                        },
                        ApplicationId = Guid.Parse("fc1650c0-5778-0138-8205-2cbc32a32d65"),
                        EncryptedData = "encrypted-data-here",
                        EphemeralPublicKeyPair = "public-key-pair",
                        MaxTimeout = 10,
                        ReferenceNumber = "sdk-reference-number-here"
                    }
                },
                Sca = new Sca()
                {
                    Exemption = ScaExemptions.LowRisk
                }
            };

            var xml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
  <payment_transaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns=""Authorize3d"">
    <transaction_type>authorize3d</transaction_type>
    <transaction_id>119643250547501c79d8295</transaction_id>
    <usage>40208 concert tickets</usage>
    <amount>100</amount>
    <currency>USD</currency>
    <remote_ip>245.253.2.12</remote_ip>
    <card_holder>Travis Pastrana</card_holder>
    <expiration_month>12</expiration_month>
    <expiration_year>2023</expiration_year>
    <customer_email>travis@example.com</customer_email>
    <customer_phone>+1987987987987</customer_phone>
    <card_number>4918190000000002</card_number>
    <cvv>834</cvv>
    <billing_address>
      <first_name>Travis</first_name>
      <last_name>Pastrana</last_name>
      <address1>Muster Str. 12</address1>
      <zip_code>10178</zip_code>
      <city>Los Angeles</city>
      <state>CA</state>
      <country>US</country>
    </billing_address>
    <notification_url>https://www.example.com/notification</notification_url>
    <return_success_url>http://www.example.com/success</return_success_url>
    <return_failure_url>http://www.example.com/failure</return_failure_url>
    <threeds_v2_params>
      <threeds_method>
        <callback_url>https://www.example.com/threeds/threeds_method/callback</callback_url>
      </threeds_method>
      <control>
        <device_type>browser</device_type>
        <challenge_window_size>full_screen</challenge_window_size>
        <challenge_indicator>preference</challenge_indicator>
      </control>
      <purchase>
        <category>service</category>
      </purchase>
      <merchant_risk>
        <shipping_indicator>verified_address</shipping_indicator>
        <delivery_timeframe>electronic</delivery_timeframe>
        <reorder_items_indicator>reordered</reorder_items_indicator>
        <pre_order_purchase_indicator>merchandise_available</pre_order_purchase_indicator>
        <pre_order_date>25-06-2022</pre_order_date>
        <gift_card>true</gift_card>
        <gift_card_count>2</gift_card_count>
      </merchant_risk>
      <card_holder_account>
        <creation_date>25-05-2021</creation_date>
        <update_indicator>more_than_60days</update_indicator>
        <last_change_date>25-02-2022</last_change_date>
        <password_change_indicator>no_change</password_change_indicator>
        <password_change_date>10-05-2022</password_change_date>
        <shipping_address_usage_indicator>current_transaction</shipping_address_usage_indicator>
        <shipping_address_date_first_used>20-05-2022</shipping_address_date_first_used>
        <transactions_activity_last_24_hours>2</transactions_activity_last_24_hours>
        <transactions_activity_previous_year>10</transactions_activity_previous_year>
        <provision_attempts_last_24_hours>1</provision_attempts_last_24_hours>
        <purchases_count_last_6_months>5</purchases_count_last_6_months>
        <suspicious_activity_indicator>no_suspicious_observed</suspicious_activity_indicator>
        <registration_indicator>30_to_60_days</registration_indicator>
        <registration_date>25-05-2020</registration_date>
      </card_holder_account>
      <browser>
        <accept_header>*/*</accept_header>
        <java_enabled>false</java_enabled>
        <language>en-GB</language>
        <color_depth>24</color_depth>
        <screen_height>900</screen_height>
        <screen_width>1440</screen_width>
        <time_zone_offset>-120</time_zone_offset>
        <user_agent>Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36</user_agent>
      </browser>
      <sdk>
        <interface>native</interface>
        <ui_types>
          <ui_type>multi_select</ui_type>
        </ui_types>
        <application_id>fc1650c0-5778-0138-8205-2cbc32a32d65</application_id>
        <encrypted_data>encrypted-data-here</encrypted_data>
        <ephemeral_public_key_pair>public-key-pair</ephemeral_public_key_pair>
        <max_timeout>10</max_timeout>
        <reference_number>sdk-reference-number-here</reference_number>
      </sdk>
    </threeds_v2_params>
    <sca_params>
      <exemption>low_risk</exemption>
    </sca_params>
  </payment_transaction>";
            return new EntityMock<Authorize3d>(challenge3dv2With3dSecure, xml);
        }

        public static EntityMock<Sale3d> CreateValidChallenge3dv2With3dSecure()
        {
            var challenge3dv2With3dSecure = new Sale3d()
            {
                Type = TransactionTypes.Sale3d,
                Id = "119643250547501c79d8295",
                Usage = "40208 concert tickets",
                RemoteIp = "245.253.2.12",
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                CardHolder = "Travis Pastrana",
                CardNumber = CardsNumbers.Visa3dsv2ChallengeWith3dsMethod,
                ExpirationMonth = 12,
                ExpirationYear = 2023,
                CustomerEmail = "travis@example.com",
                CustomerPhone = "+1987987987987",
                Cvv = "834",
                BillingAddress = new Address()
                {
                    Address1 = "Muster Str. 12",
                    City = "Los Angeles",
                    Country = Iso3166CountryCodes.US,
                    FirstName = "Travis",
                    LastName = "Pastrana",
                    State = "CA",
                    ZipCode = "10178"
                },
                NotificationUrl = "https://www.example.com/notification",
                ReturnSuccessUrl = "http://www.example.com/success",
                ReturnFailureUrl = "http://www.example.com/failure",
                ThreeDSv2 = new ThreeDSv2
                {
                    ThreedsMethod = new ThreedsMethod()
                    {
                        CallbackUrl = "https://www.example.com/threeds/threeds_method/callback",
                    },
                    Control = new Control()
                    {
                        DeviceType = DeviceTypes.Browser,
                        ChallengeWindowSize = ChallengeWindowSizes.FullScreen,
                        ChallengeIndicator = ChallengeIndicators.Preference
                    },
                    Purchase = new Purchase()
                    {
                        Category = PurchaseCategories.Service
                    },
                    MerchantRisk = new MerchantRisk()
                    {
                        ShippingIndicator = ShippingIndicators.VerifiedAddress,
                        DeliveryTimeframe = DeliveryTimeframes.Electronic,
                        ReorderItemsIndicator = ReorderItemsIndicators.Reordered,
                        PreOrderPurchaseIndicator = PreOrderPurchaseIndicators.MerchandiseAvailable,
                        PreOrderDate = new DateTime(2022, 06, 25).Date,
                        GiftCard = true,
                        GiftCardCount = 2
                    },
                    CardHolderAccount = new CardHolderAccount()
                    {
                        CreationDate = new DateTime(2021, 05, 25).Date,
                        UpdateIndicator = UpdateIndicators.MoreThan60Days,
                        LastChangeDate = new DateTime(2022, 02, 25).Date,
                        PasswordChangeIndicator = PasswordChangeIndicators.NoChange,
                        PasswordChangeDate = new DateTime(2022, 05, 10).Date,
                        ShippingAddressUsageIndicator = ShippingAddressUsageIndicators.CurrentTransaction,
                        ShippingAddressDateFirstUsed = new DateTime(2022, 05, 20).Date,
                        TransactionsActivityLast24Hours = 2,
                        TransactionsActivityPreviousYear = 10,
                        ProvisionAttemptsLast24Hours = 1,
                        PurchasesCountLast6Months = 5,
                        SuspiciousActivityIndicator = SuspiciousActivityIndicators.NoSuspiciousObserved,
                        RegistrationIndicator = RegistrationIndicators.From30To60Days,
                        RegistrationDate = new DateTime(2020, 05, 25).Date,
                    },
                    Browser = new Browser()
                    {
                        AcceptHeader = "*/*",
                        JavaEnabled = false,
                        Language = "en-GB",
                        ColorDepth = 24,
                        ScreenHeight = 900,
                        ScreenWidth = 1440,
                        TimeZoneOffset = -120,
                        UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36",
                    },
                    Sdk = new Sdk()
                    {
                        Interface = Interfaces.Native,
                        UiTypes = new List<UiTypes>
                        {
                            UiTypes.MultiSelect
                        },
                        ApplicationId = Guid.Parse("fc1650c0-5778-0138-8205-2cbc32a32d65"),
                        EncryptedData = "encrypted-data-here",
                        EphemeralPublicKeyPair = "public-key-pair",
                        MaxTimeout = 10,
                        ReferenceNumber = "sdk-reference-number-here"
                    }
                },
                Sca = new Sca()
                {
                    Exemption = ScaExemptions.LowRisk
                }
            };

            var xml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
  <payment_transaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns=""Sale3d"">
    <transaction_type>sale3d</transaction_type>
    <transaction_id>119643250547501c79d8295</transaction_id>
    <usage>40208 concert tickets</usage>
    <amount>100</amount>
    <currency>USD</currency>
    <remote_ip>245.253.2.12</remote_ip>
    <card_holder>Travis Pastrana</card_holder>
    <expiration_month>12</expiration_month>
    <expiration_year>2023</expiration_year>
    <customer_email>travis@example.com</customer_email>
    <customer_phone>+1987987987987</customer_phone>
    <card_number>4938730000000001</card_number>
    <cvv>834</cvv>
    <billing_address>
      <first_name>Travis</first_name>
      <last_name>Pastrana</last_name>
      <address1>Muster Str. 12</address1>
      <zip_code>10178</zip_code>
      <city>Los Angeles</city>
      <state>CA</state>
      <country>US</country>
    </billing_address>
    <notification_url>https://www.example.com/notification</notification_url>
    <return_success_url>http://www.example.com/success</return_success_url>
    <return_failure_url>http://www.example.com/failure</return_failure_url>
    <threeds_v2_params>
      <threeds_method>
        <callback_url>https://www.example.com/threeds/threeds_method/callback</callback_url>
      </threeds_method>
      <control>
        <device_type>browser</device_type>
        <challenge_window_size>full_screen</challenge_window_size>
        <challenge_indicator>preference</challenge_indicator>
      </control>
      <purchase>
        <category>service</category>
      </purchase>
      <merchant_risk>
        <shipping_indicator>verified_address</shipping_indicator>
        <delivery_timeframe>electronic</delivery_timeframe>
        <reorder_items_indicator>reordered</reorder_items_indicator>
        <pre_order_purchase_indicator>merchandise_available</pre_order_purchase_indicator>
        <pre_order_date>25-06-2022</pre_order_date>
        <gift_card>true</gift_card>
        <gift_card_count>2</gift_card_count>
      </merchant_risk>
      <card_holder_account>
        <creation_date>25-05-2021</creation_date>
        <update_indicator>more_than_60days</update_indicator>
        <last_change_date>25-02-2022</last_change_date>
        <password_change_indicator>no_change</password_change_indicator>
        <password_change_date>10-05-2022</password_change_date>
        <shipping_address_usage_indicator>current_transaction</shipping_address_usage_indicator>
        <shipping_address_date_first_used>20-05-2022</shipping_address_date_first_used>
        <transactions_activity_last_24_hours>2</transactions_activity_last_24_hours>
        <transactions_activity_previous_year>10</transactions_activity_previous_year>
        <provision_attempts_last_24_hours>1</provision_attempts_last_24_hours>
        <purchases_count_last_6_months>5</purchases_count_last_6_months>
        <suspicious_activity_indicator>no_suspicious_observed</suspicious_activity_indicator>
        <registration_indicator>30_to_60_days</registration_indicator>
        <registration_date>25-05-2020</registration_date>
      </card_holder_account>
      <browser>
        <accept_header>*/*</accept_header>
        <java_enabled>false</java_enabled>
        <language>en-GB</language>
        <color_depth>24</color_depth>
        <screen_height>900</screen_height>
        <screen_width>1440</screen_width>
        <time_zone_offset>-120</time_zone_offset>
        <user_agent>Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36</user_agent>
      </browser>
      <sdk>
        <interface>native</interface>
        <ui_types>
          <ui_type>multi_select</ui_type>
        </ui_types>
        <application_id>fc1650c0-5778-0138-8205-2cbc32a32d65</application_id>
        <encrypted_data>encrypted-data-here</encrypted_data>
        <ephemeral_public_key_pair>public-key-pair</ephemeral_public_key_pair>
        <max_timeout>10</max_timeout>
        <reference_number>sdk-reference-number-here</reference_number>
      </sdk>
    </threeds_v2_params>
    <sca_params>
      <exemption>low_risk</exemption>
    </sca_params>
  </payment_transaction>";
            return new EntityMock<Sale3d>(challenge3dv2With3dSecure, xml);
        }

        public static EntityMock<InitRecurringSale3d> CreateValidFallback3dv2()
        {
            var fallback3dv2 = new InitRecurringSale3d()
            {
                Type = TransactionTypes.InitRecurringSale3d,
                Id = "119643250547501c79d8295",
                Usage = "40208 concert tickets",
                RemoteIp = "245.253.2.12",
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                CardHolder = "Travis Pastrana",
                CardNumber = CardsNumbers.Visa3dsv2FallbackTo3dv1,
                ExpirationMonth = 12,
                ExpirationYear = 2023,
                CustomerEmail = "travis@example.com",
                CustomerPhone = "+1987987987987",
                Cvv = "834",
                BillingAddress = new Address()
                {
                    Address1 = "Muster Str. 12",
                    City = "Los Angeles",
                    Country = Iso3166CountryCodes.US,
                    FirstName = "Travis",
                    LastName = "Pastrana",
                    State = "CA",
                    ZipCode = "10178"
                },
                NotificationUrl = "https://www.example.com/notification",
                ReturnSuccessUrl = "http://www.example.com/success",
                ReturnFailureUrl = "http://www.example.com/failure",
                ThreeDSv2 = new ThreeDSv2
                {
                    ThreedsMethod = new ThreedsMethod()
                    {
                        CallbackUrl = "https://www.example.com/threeds/threeds_method/callback",
                    },
                    Control = new Control()
                    {
                        DeviceType = DeviceTypes.Browser,
                        ChallengeWindowSize = ChallengeWindowSizes.FullScreen,
                        ChallengeIndicator = ChallengeIndicators.Preference
                    },
                    Purchase = new Purchase()
                    {
                        Category = PurchaseCategories.Service
                    },
                    MerchantRisk = new MerchantRisk()
                    {
                        ShippingIndicator = ShippingIndicators.VerifiedAddress,
                        DeliveryTimeframe = DeliveryTimeframes.Electronic,
                        ReorderItemsIndicator = ReorderItemsIndicators.Reordered,
                        PreOrderPurchaseIndicator = PreOrderPurchaseIndicators.MerchandiseAvailable,
                        PreOrderDate = new DateTime(2022, 06, 25).Date,
                        GiftCard = true,
                        GiftCardCount = 2
                    },
                    CardHolderAccount = new CardHolderAccount()
                    {
                        CreationDate = new DateTime(2021, 05, 25).Date,
                        UpdateIndicator = UpdateIndicators.MoreThan60Days,
                        LastChangeDate = new DateTime(2022, 02, 25).Date,
                        PasswordChangeIndicator = PasswordChangeIndicators.NoChange,
                        PasswordChangeDate = new DateTime(2022, 05, 10).Date,
                        ShippingAddressUsageIndicator = ShippingAddressUsageIndicators.CurrentTransaction,
                        ShippingAddressDateFirstUsed = new DateTime(2022, 05, 20).Date,
                        TransactionsActivityLast24Hours = 2,
                        TransactionsActivityPreviousYear = 10,
                        ProvisionAttemptsLast24Hours = 1,
                        PurchasesCountLast6Months = 5,
                        SuspiciousActivityIndicator = SuspiciousActivityIndicators.NoSuspiciousObserved,
                        RegistrationIndicator = RegistrationIndicators.From30To60Days,
                        RegistrationDate = new DateTime(2020, 05, 25).Date,
                    },
                    Browser = new Browser()
                    {
                        AcceptHeader = "*/*",
                        JavaEnabled = false,
                        Language = "en-GB",
                        ColorDepth = 24,
                        ScreenHeight = 900,
                        ScreenWidth = 1440,
                        TimeZoneOffset = -120,
                        UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36",
                    },
                    Sdk = new Sdk()
                    {
                        Interface = Interfaces.Native,
                        UiTypes = new List<UiTypes>
                        {
                            UiTypes.MultiSelect
                        },
                        ApplicationId = Guid.Parse("fc1650c0-5778-0138-8205-2cbc32a32d65"),
                        EncryptedData = "encrypted-data-here",
                        EphemeralPublicKeyPair = "public-key-pair",
                        MaxTimeout = 10,
                        ReferenceNumber = "sdk-reference-number-here"
                    },
                    Recurring = new Recurring()
                    {
                        ExpirationDate = new DateTime(2022, 11, 25).Date,
                        Frequency = 30,
                    }
                }
            };

            var xml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
  <payment_transaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns=""InitRecurringSale3d"">
    <transaction_type>init_recurring_sale3d</transaction_type>
    <transaction_id>119643250547501c79d8295</transaction_id>
    <usage>40208 concert tickets</usage>
    <amount>100</amount>
    <currency>USD</currency>
    <remote_ip>245.253.2.12</remote_ip>
    <card_holder>Travis Pastrana</card_holder>
    <expiration_month>12</expiration_month>
    <expiration_year>2023</expiration_year>
    <customer_email>travis@example.com</customer_email>
    <customer_phone>+1987987987987</customer_phone>
    <card_number>4901170000000003</card_number>
    <cvv>834</cvv>
    <billing_address>
      <first_name>Travis</first_name>
      <last_name>Pastrana</last_name>
      <address1>Muster Str. 12</address1>
      <zip_code>10178</zip_code>
      <city>Los Angeles</city>
      <state>CA</state>
      <country>US</country>
    </billing_address>
    <notification_url>https://www.example.com/notification</notification_url>
    <return_success_url>http://www.example.com/success</return_success_url>
    <return_failure_url>http://www.example.com/failure</return_failure_url>
    <threeds_v2_params>
      <threeds_method>
        <callback_url>https://www.example.com/threeds/threeds_method/callback</callback_url>
      </threeds_method>
      <control>
        <device_type>browser</device_type>
        <challenge_window_size>full_screen</challenge_window_size>
        <challenge_indicator>preference</challenge_indicator>
      </control>
      <purchase>
        <category>service</category>
      </purchase>
      <merchant_risk>
        <shipping_indicator>verified_address</shipping_indicator>
        <delivery_timeframe>electronic</delivery_timeframe>
        <reorder_items_indicator>reordered</reorder_items_indicator>
        <pre_order_purchase_indicator>merchandise_available</pre_order_purchase_indicator>
        <pre_order_date>25-06-2022</pre_order_date>
        <gift_card>true</gift_card>
        <gift_card_count>2</gift_card_count>
      </merchant_risk>
      <card_holder_account>
        <creation_date>25-05-2021</creation_date>
        <update_indicator>more_than_60days</update_indicator>
        <last_change_date>25-02-2022</last_change_date>
        <password_change_indicator>no_change</password_change_indicator>
        <password_change_date>10-05-2022</password_change_date>
        <shipping_address_usage_indicator>current_transaction</shipping_address_usage_indicator>
        <shipping_address_date_first_used>20-05-2022</shipping_address_date_first_used>
        <transactions_activity_last_24_hours>2</transactions_activity_last_24_hours>
        <transactions_activity_previous_year>10</transactions_activity_previous_year>
        <provision_attempts_last_24_hours>1</provision_attempts_last_24_hours>
        <purchases_count_last_6_months>5</purchases_count_last_6_months>
        <suspicious_activity_indicator>no_suspicious_observed</suspicious_activity_indicator>
        <registration_indicator>30_to_60_days</registration_indicator>
        <registration_date>25-05-2020</registration_date>
      </card_holder_account>
      <browser>
        <accept_header>*/*</accept_header>
        <java_enabled>false</java_enabled>
        <language>en-GB</language>
        <color_depth>24</color_depth>
        <screen_height>900</screen_height>
        <screen_width>1440</screen_width>
        <time_zone_offset>-120</time_zone_offset>
        <user_agent>Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36</user_agent>
      </browser>
      <sdk>
        <interface>native</interface>
        <ui_types>
          <ui_type>multi_select</ui_type>
        </ui_types>
        <application_id>fc1650c0-5778-0138-8205-2cbc32a32d65</application_id>
        <encrypted_data>encrypted-data-here</encrypted_data>
        <ephemeral_public_key_pair>public-key-pair</ephemeral_public_key_pair>
        <max_timeout>10</max_timeout>
        <reference_number>sdk-reference-number-here</reference_number>
      </sdk>
      <recurring>
        <expiration_date>25-11-2022</expiration_date>
        <frequency>30</frequency>
      </recurring>
    </threeds_v2_params>
  </payment_transaction>";

            return new EntityMock<InitRecurringSale3d>(fallback3dv2, xml);
        }

        public static EntityMock<InitRecurringSale3d> CreateValidFallback3dv2With3dSecure()
        {
            var fallback3dv2 = new InitRecurringSale3d()
            {
                Type = TransactionTypes.InitRecurringSale3d,
                Id = "119643250547501c79d8295",
                Usage = "40208 concert tickets",
                RemoteIp = "245.253.2.12",
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                CardHolder = "Travis Pastrana",
                CardNumber = CardsNumbers.Visa3dsv2FallbackTo3dv1With3dsMethod,
                ExpirationMonth = 12,
                ExpirationYear = 2023,
                CustomerEmail = "travis@example.com",
                CustomerPhone = "+1987987987987",
                Cvv = "834",
                BillingAddress = new Address()
                {
                    Address1 = "Muster Str. 12",
                    City = "Los Angeles",
                    Country = Iso3166CountryCodes.US,
                    FirstName = "Travis",
                    LastName = "Pastrana",
                    State = "CA",
                    ZipCode = "10178"
                },
                NotificationUrl = "https://www.example.com/notification",
                ReturnSuccessUrl = "http://www.example.com/success",
                ReturnFailureUrl = "http://www.example.com/failure",
                ThreeDSv2 = new ThreeDSv2
                {
                    ThreedsMethod = new ThreedsMethod()
                    {
                        CallbackUrl = "https://www.example.com/threeds/threeds_method/callback",
                    },
                    Control = new Control()
                    {
                        DeviceType = DeviceTypes.Browser,
                        ChallengeWindowSize = ChallengeWindowSizes.FullScreen,
                        ChallengeIndicator = ChallengeIndicators.Preference
                    },
                    Purchase = new Purchase()
                    {
                        Category = PurchaseCategories.Service
                    },
                    MerchantRisk = new MerchantRisk()
                    {
                        ShippingIndicator = ShippingIndicators.VerifiedAddress,
                        DeliveryTimeframe = DeliveryTimeframes.Electronic,
                        ReorderItemsIndicator = ReorderItemsIndicators.Reordered,
                        PreOrderPurchaseIndicator = PreOrderPurchaseIndicators.MerchandiseAvailable,
                        PreOrderDate = new DateTime(2022, 06, 25).Date,
                        GiftCard = true,
                        GiftCardCount = 2
                    },
                    CardHolderAccount = new CardHolderAccount()
                    {
                        CreationDate = new DateTime(2021, 05, 25).Date,
                        UpdateIndicator = UpdateIndicators.MoreThan60Days,
                        LastChangeDate = new DateTime(2022, 02, 25).Date,
                        PasswordChangeIndicator = PasswordChangeIndicators.NoChange,
                        PasswordChangeDate = new DateTime(2022, 05, 10).Date,
                        ShippingAddressUsageIndicator = ShippingAddressUsageIndicators.CurrentTransaction,
                        ShippingAddressDateFirstUsed = new DateTime(2022, 05, 20).Date,
                        TransactionsActivityLast24Hours = 2,
                        TransactionsActivityPreviousYear = 10,
                        ProvisionAttemptsLast24Hours = 1,
                        PurchasesCountLast6Months = 5,
                        SuspiciousActivityIndicator = SuspiciousActivityIndicators.NoSuspiciousObserved,
                        RegistrationIndicator = RegistrationIndicators.From30To60Days,
                        RegistrationDate = new DateTime(2020, 05, 25).Date,
                    },
                    Browser = new Browser()
                    {
                        AcceptHeader = "*/*",
                        JavaEnabled = false,
                        Language = "en-GB",
                        ColorDepth = 24,
                        ScreenHeight = 900,
                        ScreenWidth = 1440,
                        TimeZoneOffset = -120,
                        UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36",
                    },
                    Sdk = new Sdk()
                    {
                        Interface = Interfaces.Native,
                        UiTypes = new List<UiTypes>
                        {
                            UiTypes.MultiSelect
                        },
                        ApplicationId = Guid.Parse("fc1650c0-5778-0138-8205-2cbc32a32d65"),
                        EncryptedData = "encrypted-data-here",
                        EphemeralPublicKeyPair = "public-key-pair",
                        MaxTimeout = 10,
                        ReferenceNumber = "sdk-reference-number-here"
                    },
                    Recurring = new Recurring()
                    {
                        ExpirationDate = new DateTime(2022, 11, 25).Date,
                        Frequency = 30,
                    }
                }
            };

            var xml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
  <payment_transaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns=""InitRecurringSale3d"">
    <transaction_type>init_recurring_sale3d</transaction_type>
    <transaction_id>119643250547501c79d8295</transaction_id>
    <usage>40208 concert tickets</usage>
    <amount>100</amount>
    <currency>USD</currency>
    <remote_ip>245.253.2.12</remote_ip>
    <card_holder>Travis Pastrana</card_holder>
    <expiration_month>12</expiration_month>
    <expiration_year>2023</expiration_year>
    <customer_email>travis@example.com</customer_email>
    <customer_phone>+1987987987987</customer_phone>
    <card_number>4901164281364345</card_number>
    <cvv>834</cvv>
    <billing_address>
      <first_name>Travis</first_name>
      <last_name>Pastrana</last_name>
      <address1>Muster Str. 12</address1>
      <zip_code>10178</zip_code>
      <city>Los Angeles</city>
      <state>CA</state>
      <country>US</country>
    </billing_address>
    <notification_url>https://www.example.com/notification</notification_url>
    <return_success_url>http://www.example.com/success</return_success_url>
    <return_failure_url>http://www.example.com/failure</return_failure_url>
    <threeds_v2_params>
      <threeds_method>
        <callback_url>https://www.example.com/threeds/threeds_method/callback</callback_url>
      </threeds_method>
      <control>
        <device_type>browser</device_type>
        <challenge_window_size>full_screen</challenge_window_size>
        <challenge_indicator>preference</challenge_indicator>
      </control>
      <purchase>
        <category>service</category>
      </purchase>
      <merchant_risk>
        <shipping_indicator>verified_address</shipping_indicator>
        <delivery_timeframe>electronic</delivery_timeframe>
        <reorder_items_indicator>reordered</reorder_items_indicator>
        <pre_order_purchase_indicator>merchandise_available</pre_order_purchase_indicator>
        <pre_order_date>25-06-2022</pre_order_date>
        <gift_card>true</gift_card>
        <gift_card_count>2</gift_card_count>
      </merchant_risk>
      <card_holder_account>
        <creation_date>25-05-2021</creation_date>
        <update_indicator>more_than_60days</update_indicator>
        <last_change_date>25-02-2022</last_change_date>
        <password_change_indicator>no_change</password_change_indicator>
        <password_change_date>10-05-2022</password_change_date>
        <shipping_address_usage_indicator>current_transaction</shipping_address_usage_indicator>
        <shipping_address_date_first_used>20-05-2022</shipping_address_date_first_used>
        <transactions_activity_last_24_hours>2</transactions_activity_last_24_hours>
        <transactions_activity_previous_year>10</transactions_activity_previous_year>
        <provision_attempts_last_24_hours>1</provision_attempts_last_24_hours>
        <purchases_count_last_6_months>5</purchases_count_last_6_months>
        <suspicious_activity_indicator>no_suspicious_observed</suspicious_activity_indicator>
        <registration_indicator>30_to_60_days</registration_indicator>
        <registration_date>25-05-2020</registration_date>
      </card_holder_account>
      <browser>
        <accept_header>*/*</accept_header>
        <java_enabled>false</java_enabled>
        <language>en-GB</language>
        <color_depth>24</color_depth>
        <screen_height>900</screen_height>
        <screen_width>1440</screen_width>
        <time_zone_offset>-120</time_zone_offset>
        <user_agent>Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36</user_agent>
      </browser>
      <sdk>
        <interface>native</interface>
        <ui_types>
          <ui_type>multi_select</ui_type>
        </ui_types>
        <application_id>fc1650c0-5778-0138-8205-2cbc32a32d65</application_id>
        <encrypted_data>encrypted-data-here</encrypted_data>
        <ephemeral_public_key_pair>public-key-pair</ephemeral_public_key_pair>
        <max_timeout>10</max_timeout>
        <reference_number>sdk-reference-number-here</reference_number>
      </sdk>
      <recurring>
        <expiration_date>25-11-2022</expiration_date>
        <frequency>30</frequency>
      </recurring>
    </threeds_v2_params>
  </payment_transaction>";

            return new EntityMock<InitRecurringSale3d>(fallback3dv2, xml);
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
                CustomerPhone = "3598888888888",
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
                    Phone = "3598888888888",
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
                     "<customer_phone>3598888888888</customer_phone>" +
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
                     "<phone>3598888888888</phone>" +
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
                CustomerPhone = "3598888888888",
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
                    Phone = "3598888888888",
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
                      "<customer_phone>3598888888888</customer_phone>" +
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
                      "<phone>3598888888888</phone>" +
                      "<remote_ip>255.10.100.10</remote_ip>" +
                      "<serial_number>serial number</serial_number>" +
                      "</risk_params>" +
                      "</payment_transaction>";

            return new EntityMock<Avs>(avs, xml);
        }

        public static EntityMock<InitRecurringSale> CreateValidInitRecurringSale()
        {
            var _startDate = DateTime.Now.AddMonths(-1);
            var _endDate = DateTime.Now.AddMonths(1);

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
                CustomerPhone = "3598888888888",
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
                    Phone = "3598888888888",
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
                BusinessAttributes = new BusinessAttributes()
                {
                    FlightArrivalDate = _startDate.ToShortDateString(),
                    FlightDepartureDate = _endDate.ToShortDateString(),
                    AirlineFlightNumber = _digitNumber,
                    FlightTicketNumber = "WS1234TS",

                    EventId = _digitNumber,
                    EventStartDate = _startDate.ToShortDateString(),
                    EventEndDate = _endDate.ToShortDateString(),

                    DateOfOrder = _startDate.ToShortDateString(),
                    DeliveryDate = _endDate.ToShortDateString(),
                    NameOfTheSupplier = _contractorName,
                    CheckInDate = _startDate.ToShortDateString(),
                    CheckOutDate = _endDate.ToShortDateString(),
                    TravelAgencyName = "Test Agency Name",

                    VehiclePickUpDate = _startDate.ToShortDateString(),
                    VehicleReturnDate = _endDate.ToShortDateString(),
                    SupplierName = _contractorName,

                    CruiseStartDate = _startDate.ToShortDateString(),
                    CruiseEndDate = _endDate.ToShortDateString(),

                    ArrivalDate = _startDate.AddMonths(1).ToShortDateString(),
                    DepartureDate = _endDate.ToShortDateString(),

                    TicketNumber = _digitNumber,
                    OriginCity = "Sofia",
                    ContractorName = _contractorName,

                    PickUpDate = _startDate.ToShortDateString(),
                    ReturnDate = _endDate.AddMonths(1).ToShortDateString(),

                    PaymentType = _paymentType
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
                    "<customer_phone>3598888888888</customer_phone>" +
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
                    "<phone>3598888888888</phone>" +
                    "<remote_ip>255.10.100.10</remote_ip>" +
                    "<serial_number>serial number</serial_number>" +
                    "</risk_params>" +
                    "<dynamic_descriptor_params>" +
                    "<merchant_name>Test Merchant</merchant_name>" +
                    "<merchant_city>Testing Town</merchant_city>" +
                    "</dynamic_descriptor_params>" +
                    "<business_attributes>" +
                    "<flight_arrival_date>" + _startDate.ToShortDateString() + "</flight_arrival_date>" +
                    "<flight_departure_date>" + _endDate.ToShortDateString() + "</flight_departure_date>" +
                    "<airline_flight_number>" + _digitNumber + "</airline_flight_number>" +
                    "<flight_ticket_number>WS1234TS</flight_ticket_number>" +
                    "<event_id>" + _digitNumber + "</event_id>" +
                    "<event_start_date>" + _startDate.ToShortDateString() + "</event_start_date>" +
                    "<event_end_date>" + _endDate.ToShortDateString() + "</event_end_date>" +
                    "<date_of_order>" + _startDate.ToShortDateString() + "</date_of_order>" +
                    "<delivery_date>" + _endDate.ToShortDateString() + "</delivery_date>" +
                    "<name_of_the_supplier>" + _contractorName + "</name_of_the_supplier>" +
                    "<check_in_date>" + _startDate.ToShortDateString() + "</check_in_date>" +
                    "<check_out_date>" + _endDate.ToShortDateString() + "</check_out_date>" +
                    "<travel_agency_name>Test Agency Name</travel_agency_name>" +
                    "<vehicle_pick_up_date>" + _startDate.ToShortDateString() + "</vehicle_pick_up_date>" +
                    "<vehicle_return_date>" + _endDate.ToShortDateString() + "</vehicle_return_date>" +
                    "<supplier_name>" + _contractorName + "</supplier_name>" +
                    "<cruise_start_date>" + _startDate.ToShortDateString() + "</cruise_start_date>" +
                    "<cruise_end_date>" + _endDate.ToShortDateString() + "</cruise_end_date>" +
                    "<arrival_date>" + _startDate.AddMonths(1).ToShortDateString() + "</arrival_date>" +
                    "<departure_date>" + _endDate.ToShortDateString() + "</departure_date>" +
                    "<ticket_number>" + _digitNumber + "</ticket_number>" +
                    "<origin_city>Sofia</origin_city>" +
                    "<contractor_name>" + _contractorName + "</contractor_name>" +
                    "<pick_up_date>" + _startDate.ToShortDateString() + "</pick_up_date>" +
                    "<return_date>" + _endDate.AddMonths(1).ToShortDateString() + "</return_date>" +
                    "<payment_type>" + _paymentType + "</payment_type>" +
                    "</business_attributes>" +
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
                CustomerPhone = "3598888888888",
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
                     "<customer_phone>3598888888888</customer_phone>" +
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
            var _startDate = DateTime.Now.AddMonths(-1);
            var _endDate = DateTime.Now.AddMonths(1);

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
                CustomerPhone = "3598888888888",
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
                    Phone = "3598888888888",
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
                BusinessAttributes = new BusinessAttributes()
                {
                    FlightArrivalDate = _startDate.ToShortDateString(),
                    FlightDepartureDate = _endDate.ToShortDateString(),
                    AirlineFlightNumber = _digitNumber,
                    FlightTicketNumber = "WS1234TS",

                    EventId = _digitNumber,
                    EventStartDate = _startDate.ToShortDateString(),
                    EventEndDate = _endDate.ToShortDateString(),

                    DateOfOrder = _startDate.ToShortDateString(),
                    DeliveryDate = _endDate.ToShortDateString(),
                    NameOfTheSupplier = _contractorName,
                    CheckInDate = _startDate.ToShortDateString(),
                    CheckOutDate = _endDate.ToShortDateString(),
                    TravelAgencyName = "Test Agency Name",

                    VehiclePickUpDate = _startDate.ToShortDateString(),
                    VehicleReturnDate = _endDate.ToShortDateString(),
                    SupplierName = _contractorName,

                    CruiseStartDate = _startDate.ToShortDateString(),
                    CruiseEndDate = _endDate.ToShortDateString(),

                    ArrivalDate = _startDate.AddMonths(1).ToShortDateString(),
                    DepartureDate = _endDate.ToShortDateString(),

                    TicketNumber = _digitNumber,
                    OriginCity = "Sofia",
                    ContractorName = _contractorName,

                    PickUpDate = _startDate.ToShortDateString(),
                    ReturnDate = _endDate.AddMonths(1).ToShortDateString(),

                    PaymentType = _paymentType
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
                      "<customer_phone>3598888888888</customer_phone>" +
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
                      "<phone>3598888888888</phone>" +
                      "<remote_ip>255.10.100.10</remote_ip>" +
                      "<serial_number>serial number</serial_number>" +
                      "</risk_params>" +
                      "<dynamic_descriptor_params>" +
                      "<merchant_name>Test Merchant</merchant_name>" +
                      "<merchant_city>Testing Town</merchant_city>" +
                      "</dynamic_descriptor_params>" +
                      "<business_attributes>" +
                      "<flight_arrival_date>" + _startDate.ToShortDateString() + "</flight_arrival_date>" +
                      "<flight_departure_date>" + _endDate.ToShortDateString() + "</flight_departure_date>" +
                      "<airline_flight_number>" + _digitNumber + "</airline_flight_number>" +
                      "<flight_ticket_number>WS1234TS</flight_ticket_number>" +
                      "<event_id>" + _digitNumber + "</event_id>" +
                      "<event_start_date>" + _startDate.ToShortDateString() + "</event_start_date>" +
                      "<event_end_date>" + _endDate.ToShortDateString() + "</event_end_date>" +
                      "<date_of_order>" + _startDate.ToShortDateString() + "</date_of_order>" +
                      "<delivery_date>" + _endDate.ToShortDateString() + "</delivery_date>" +
                      "<name_of_the_supplier>" + _contractorName + "</name_of_the_supplier>" +
                      "<check_in_date>" + _startDate.ToShortDateString() + "</check_in_date>" +
                      "<check_out_date>" + _endDate.ToShortDateString() + "</check_out_date>" +
                      "<travel_agency_name>Test Agency Name</travel_agency_name>" +
                      "<vehicle_pick_up_date>" + _startDate.ToShortDateString() + "</vehicle_pick_up_date>" +
                      "<vehicle_return_date>" + _endDate.ToShortDateString() + "</vehicle_return_date>" +
                      "<supplier_name>" + _contractorName + "</supplier_name>" +
                      "<cruise_start_date>" + _startDate.ToShortDateString() + "</cruise_start_date>" +
                      "<cruise_end_date>" + _endDate.ToShortDateString() + "</cruise_end_date>" +
                      "<arrival_date>" + _startDate.AddMonths(1).ToShortDateString() + "</arrival_date>" +
                      "<departure_date>" + _endDate.ToShortDateString() + "</departure_date>" +
                      "<ticket_number>" + _digitNumber + "</ticket_number>" +
                      "<origin_city>Sofia</origin_city>" +
                      "<contractor_name>" + _contractorName + "</contractor_name>" +
                      "<pick_up_date>" + _startDate.ToShortDateString() + "</pick_up_date>" +
                      "<return_date>" + _endDate.AddMonths(1).ToShortDateString() + "</return_date>" +
                      "<payment_type>" + _paymentType + "</payment_type>" +
                      "</business_attributes>" +
                      "</payment_transaction>";

            return new EntityMock<Sale>(sale, xml);
        }

        public static EntityMock<WpfCreate> CreateValidWpfCreate()
        {
            var _startDate = DateTime.Now.AddMonths(-1);
            var _endDate = DateTime.Now.AddMonths(1);

            var wpfCreate = new WpfCreate()
            {
                TransactionId = "id",
                Usage = "usage",
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                ConsumerId = "123456",
                CustomerEmail = "hello@world.com",
                CustomerPhone = "3598888888888",
                RememberCard = "true",
                Description = "description",
                CardHolder = "Hodler Name",
                TransactionTypes = new Composite[] {
                    new Composite() { { "name", "sale" } }, new Composite() { { "name", "sale3d" } },
                    new Composite() { { "name", "ezeewallet" }, { "source_wallet_id", "emil@example.com" } },
                    new Composite() { { "name", "apple_pay" }, { "payment_subtype", "authorize" } },
                    new Composite() { { "name", "google_pay" }, { "payment_subtype", "authorize" } }
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
                    Phone = "3598888888888",
                    RemoteIp = "255.10.100.10",
                    SerialNumber = "serial number",
                    SessionId = "session id",
                    Ssn = "ssn",
                    UserId = "user id",
                    UserLevel = "user level"
                },
                DynamicDescriptorParams = new DynamicDescriptor
                {
                    MerchantName = "Test",
                    MerchantCity = "12345"
                },
                BusinessAttributes = new BusinessAttributes()
                {
                    FlightArrivalDate = _startDate.ToShortDateString(),
                    FlightDepartureDate = _endDate.ToShortDateString(),
                    AirlineFlightNumber = _digitNumber,
                    FlightTicketNumber = "WS1234TS",

                    EventId = _digitNumber,
                    EventStartDate = _startDate.ToShortDateString(),
                    EventEndDate = _endDate.ToShortDateString(),

                    DateOfOrder = _startDate.ToShortDateString(),
                    DeliveryDate = _endDate.ToShortDateString(),
                    NameOfTheSupplier = _contractorName,
                    CheckInDate = _startDate.ToShortDateString(),
                    CheckOutDate = _endDate.ToShortDateString(),
                    TravelAgencyName = "Test Agency Name",

                    VehiclePickUpDate = _startDate.ToShortDateString(),
                    VehicleReturnDate = _endDate.ToShortDateString(),
                    SupplierName = _contractorName,

                    CruiseStartDate = _startDate.ToShortDateString(),
                    CruiseEndDate = _endDate.ToShortDateString(),

                    ArrivalDate = _startDate.AddMonths(1).ToShortDateString(),
                    DepartureDate = _endDate.ToShortDateString(),

                    TicketNumber = _digitNumber,
                    OriginCity = "Sofia",
                    ContractorName = _contractorName,

                    PickUpDate = _startDate.ToShortDateString(),
                    ReturnDate = _endDate.AddMonths(1).ToShortDateString(),

                    PaymentType = _paymentType
                },
                PayLater = "true",
                ReminderLanguage = WpfLocales.EN,
                Reminders = new List<Reminder>
                {
                    new Reminder
                    {
                        After = 40,
                        Channel = "email"
                    },
                    new Reminder
                    {
                        After = 10,
                        Channel = "sms"
                    }
                },
                Sca = new Sca
                {
                    Exemption = ScaExemptions.LowValue
                },
                WebPaymentFormId = "1"
            };

            var xml =
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                "<wpf_payment xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"WpfCreate\">" +
                    "<transaction_id>id</transaction_id>" +
                    "<amount>100</amount>" +
                    "<currency>USD</currency>" +
                    "<consumer_id>123456</consumer_id>" +
                    "<usage>usage</usage>" +
                    "<description>description</description>" +
                    "<card_holder>Hodler Name</card_holder>" +
                    "<customer_email>hello@world.com</customer_email>" +
                    "<customer_phone>3598888888888</customer_phone>" +                   
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
                        "<transaction_type>" +
                            "<name>apple_pay</name>" +
                            "<payment_subtype>authorize</payment_subtype>" +
                        "</transaction_type>" +
                        "<transaction_type>" +
                            "<name>google_pay</name>" +
                            "<payment_subtype>authorize</payment_subtype>" +
                        "</transaction_type>" +
                    "</transaction_types>" +
                    "<remember_card>true</remember_card>" +
                    "<lifetime xsi:nil=\"true\"/>" +
                    "<risk_params>" +
                        "<ssn>ssn</ssn>" +
                        "<mac_address>mac address</mac_address>" +
                        "<session_id>session id</session_id>" +
                        "<user_id>user id</user_id>" +
                        "<user_level>user level</user_level>" +
                        "<email>hello@world.com</email>" +
                        "<phone>3598888888888</phone>" +
                        "<remote_ip>255.10.100.10</remote_ip>" +
                        "<serial_number>serial number</serial_number>" +
                    "</risk_params>" +
                    "<dynamic_descriptor_params>" +
                        "<merchant_name>Test</merchant_name>" +
                        "<merchant_city>12345</merchant_city>" +
                    "</dynamic_descriptor_params>" +
                    "<business_attributes>" +
                        "<flight_arrival_date>" + _startDate.ToShortDateString() + "</flight_arrival_date>" +
                        "<flight_departure_date>" + _endDate.ToShortDateString() + "</flight_departure_date>" +
                        "<airline_flight_number>" + _digitNumber + "</airline_flight_number>" +
                        "<flight_ticket_number>WS1234TS</flight_ticket_number>" +
                        "<event_id>" + _digitNumber + "</event_id>" +
                        "<event_start_date>" + _startDate.ToShortDateString() + "</event_start_date>" +
                        "<event_end_date>" + _endDate.ToShortDateString() + "</event_end_date>" +
                        "<date_of_order>" + _startDate.ToShortDateString() + "</date_of_order>" +
                        "<delivery_date>" + _endDate.ToShortDateString() + "</delivery_date>" +
                        "<name_of_the_supplier>" + _contractorName + "</name_of_the_supplier>" +
                        "<check_in_date>" + _startDate.ToShortDateString() + "</check_in_date>" +
                        "<check_out_date>" + _endDate.ToShortDateString() + "</check_out_date>" +
                        "<travel_agency_name>Test Agency Name</travel_agency_name>" +
                        "<vehicle_pick_up_date>" + _startDate.ToShortDateString() + "</vehicle_pick_up_date>" +
                        "<vehicle_return_date>" + _endDate.ToShortDateString() + "</vehicle_return_date>" +
                        "<supplier_name>" + _contractorName + "</supplier_name>" +
                        "<cruise_start_date>" + _startDate.ToShortDateString() + "</cruise_start_date>" +
                        "<cruise_end_date>" + _endDate.ToShortDateString() + "</cruise_end_date>" +
                        "<arrival_date>" + _startDate.AddMonths(1).ToShortDateString() + "</arrival_date>" +
                        "<departure_date>" + _endDate.ToShortDateString() + "</departure_date>" +
                        "<ticket_number>" + _digitNumber + "</ticket_number>" +
                        "<origin_city>Sofia</origin_city>" +
                        "<contractor_name>" + _contractorName + "</contractor_name>" +
                        "<pick_up_date>" + _startDate.ToShortDateString() + "</pick_up_date>" +
                        "<return_date>" + _endDate.AddMonths(1).ToShortDateString() + "</return_date>" +
                        "<payment_type>" + _paymentType + "</payment_type>" +
                    "</business_attributes>" +
                    "<pay_later>true</pay_later>" +
                    "<reminder_language>en</reminder_language>" +
                    "<reminders>" +
                      "<reminder>" +
                        "<channel>email</channel>" +
                        "<after>40</after>" +
                      "</reminder>" +
                      "<reminder>" +
                        "<channel>sms</channel>" +
                        "<after>10</after>" +
                      "</reminder>" +
                    "</reminders>" +
                    "<sca_params>" +
                      "<exemption>low_value</exemption>" +
                    "</sca_params>" +
                    "<web_payment_form_id>1</web_payment_form_id>" +
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
            var _startDate = DateTime.Now.AddMonths(-1);
            var _endDate = DateTime.Now.AddMonths(1);

            var capture = new Capture()
            {
                Amount = 50,
                Currency = Iso4217CurrencyCodes.USD,
                Id = "43671",
                ReferenceId = "2ee4287e67971380ef7f97d5743bb523",
                RemoteIp = "127.0.0.1",
                Usage = "40208 concert tickets",
                BusinessAttributes = new BusinessAttributes()
                {
                    FlightArrivalDate = _startDate.ToShortDateString(),
                    FlightDepartureDate = _endDate.ToShortDateString(),
                    AirlineFlightNumber = _digitNumber,
                    FlightTicketNumber = "WS1234TS",

                    EventId = _digitNumber,
                    EventStartDate = _startDate.ToShortDateString(),
                    EventEndDate = _endDate.ToShortDateString(),

                    DateOfOrder = _startDate.ToShortDateString(),
                    DeliveryDate = _endDate.ToShortDateString(),
                    NameOfTheSupplier = _contractorName,
                    CheckInDate = _startDate.ToShortDateString(),
                    CheckOutDate = _endDate.ToShortDateString(),
                    TravelAgencyName = "Test Agency Name",

                    VehiclePickUpDate = _startDate.ToShortDateString(),
                    VehicleReturnDate = _endDate.ToShortDateString(),
                    SupplierName = _contractorName,

                    CruiseStartDate = _startDate.ToShortDateString(),
                    CruiseEndDate = _endDate.ToShortDateString(),

                    ArrivalDate = _startDate.AddMonths(1).ToShortDateString(),
                    DepartureDate = _endDate.ToShortDateString(),

                    TicketNumber = _digitNumber,
                    OriginCity = "Sofia",
                    ContractorName = _contractorName,

                    PickUpDate = _startDate.ToShortDateString(),
                    ReturnDate = _endDate.AddMonths(1).ToShortDateString(),

                    PaymentType = _paymentType
                }
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
                    "<business_attributes>" +
                    "<flight_arrival_date>" + _startDate.ToShortDateString() + "</flight_arrival_date>" +
                    "<flight_departure_date>" + _endDate.ToShortDateString() + "</flight_departure_date>" +
                    "<airline_flight_number>" + _digitNumber + "</airline_flight_number>" +
                    "<flight_ticket_number>WS1234TS</flight_ticket_number>" +
                    "<event_id>" + _digitNumber + "</event_id>" +
                    "<event_start_date>" + _startDate.ToShortDateString() + "</event_start_date>" +
                    "<event_end_date>" + _endDate.ToShortDateString() + "</event_end_date>" +
                    "<date_of_order>" + _startDate.ToShortDateString() + "</date_of_order>" +
                    "<delivery_date>" + _endDate.ToShortDateString() + "</delivery_date>" +
                    "<name_of_the_supplier>" + _contractorName + "</name_of_the_supplier>" +
                    "<check_in_date>" + _startDate.ToShortDateString() + "</check_in_date>" +
                    "<check_out_date>" + _endDate.ToShortDateString() + "</check_out_date>" +
                    "<travel_agency_name>Test Agency Name</travel_agency_name>" +
                    "<vehicle_pick_up_date>" + _startDate.ToShortDateString() + "</vehicle_pick_up_date>" +
                    "<vehicle_return_date>" + _endDate.ToShortDateString() + "</vehicle_return_date>" +
                    "<supplier_name>" + _contractorName + "</supplier_name>" +
                    "<cruise_start_date>" + _startDate.ToShortDateString() + "</cruise_start_date>" +
                    "<cruise_end_date>" + _endDate.ToShortDateString() + "</cruise_end_date>" +
                    "<arrival_date>" + _startDate.AddMonths(1).ToShortDateString() + "</arrival_date>" +
                    "<departure_date>" + _endDate.ToShortDateString() + "</departure_date>" +
                    "<ticket_number>" + _digitNumber + "</ticket_number>" +
                    "<origin_city>Sofia</origin_city>" +
                    "<contractor_name>" + _contractorName + "</contractor_name>" +
                    "<pick_up_date>" + _startDate.ToShortDateString() + "</pick_up_date>" +
                    "<return_date>" + _endDate.AddMonths(1).ToShortDateString() + "</return_date>" +
                    "<payment_type>" + _paymentType + "</payment_type>" +
                    "</business_attributes>" +
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

        public static EntityMock<ApplePay> CreateValidApplePay()
               {
            DateTime _startDate = DateTime.Now.AddMonths(-1);
            DateTime _endDate = DateTime.Now.AddMonths(1);
            DateTime _birthDate = new DateTime(1980, 10, 10);

            var applePay = new ApplePay()
            {
                Id = "43671",
                Type = TransactionTypes.ApplePay,
                Subtype = TransactionSubTypes.Authorize,
                PaymentToken = "...",
                Usage = "40208 concert tickets",
                RemoteIp = "245.253.2.12",
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                CustomerEmail = "travis@example.com",
                CustomerPhone = "15002268663",
                BirthDate = _birthDate.ToShortDateString(),
                DocumentId = "123456789",
                BusinessAttributes = new BusinessAttributes()
                {
                    EventId = "1912",
                    EventOrganizerId = "20192375",
                    EventStartDate = _startDate.ToShortDateString(),
                    EventEndDate = _endDate.ToShortDateString(),
                },
                BillingAddress = new Address()
                {
                    FirstName = "Travis",
                    LastName = "Pastrana",
                    Address1 = "Muster Str. 12",
                    ZipCode = "10178",
                    City = "Los Angeles",
                    State = "CA",
                    Country = Iso3166CountryCodes.US
                },
                ShippingAddress = new Address()
                {
                    FirstName = "Travis",
                    LastName = "Pastrana",
                    Address1 = "Muster Str. 12",
                    ZipCode = "10178",
                    City = "Los Angeles",
                    State = "CA",
                    Country = Iso3166CountryCodes.US
                }
            };

            var xml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"ApplePay\">" +
                "<transaction_type>apple_pay</transaction_type>" +
                "<transaction_id>43671</transaction_id>" +
                "<usage>40208 concert tickets</usage>" +
                "<amount>100</amount>" +
                "<currency>USD</currency>" +
                "<remote_ip>245.253.2.12</remote_ip>" +
                "<payment_token>...</payment_token>" +
                "<payment_subtype>authorize</payment_subtype>" +
                "<birth_date>" + _birthDate.ToShortDateString() + "</birth_date>" +
                "<document_id>123456789</document_id>" +
                "<billing_address>" +
                "<first_name>Travis</first_name>" +
                "<last_name>Pastrana</last_name>" +
                "<address1>Muster Str. 12</address1>" +
                "<zip_code>10178</zip_code>" +
                "<city>Los Angeles</city>" +
                "<state>CA</state>" +
                "<country>US</country>" +
                "</billing_address>" +
                "<shipping_address>" +
                "<first_name>Travis</first_name>" +
                "<last_name>Pastrana</last_name>" +
                "<address1>Muster Str. 12</address1>" +
                "<zip_code>10178</zip_code>" +
                "<city>Los Angeles</city>" +
                "<state>CA</state>" +
                "<country>US</country>" +
                "</shipping_address>" +
                "<business_attributes>" +
                "<event_id>1912</event_id>" +
                "<event_start_date>" + _startDate.ToShortDateString() + "</event_start_date>" +
                "<event_end_date>" + _endDate.ToShortDateString() + "</event_end_date>" +
                "<event_organizer_id>20192375</event_organizer_id>" +
                "</business_attributes>" +
                "<customer_email>travis@example.com</customer_email>" +
                "<customer_phone>15002268663</customer_phone>" +
                "</payment_transaction>";

            return new EntityMock<ApplePay>(applePay, xml);
        }

        public static EntityMock<GooglePay> CreateValidGooglePay()
        {
            DateTime _startDate = DateTime.Now.AddMonths(-1);
            DateTime _endDate = DateTime.Now.AddMonths(1);
            DateTime _birthDate = new DateTime(1980, 10, 10);

            var googlePay = new GooglePay()
            {
                Id = "43671",
                Type = TransactionTypes.GooglePay,
                Subtype = TransactionSubTypes.Authorize,
                PaymentToken = "...",
                Usage = "40208 concert tickets",
                RemoteIp = "245.253.2.12",
                Amount = 1,
                Currency = Iso4217CurrencyCodes.USD,
                CustomerEmail = "travis@example.com",
                CustomerPhone = "15002268663",
                BirthDate = _birthDate.ToShortDateString(),
                DocumentId = "123456789",
                BusinessAttributes = new BusinessAttributes()
                {
                    EventId = "1912",
                    EventOrganizerId = "20192375",
                    EventStartDate = _startDate.ToShortDateString(),
                    EventEndDate = _endDate.ToShortDateString(),
                },
                BillingAddress = new Address()
                {
                    FirstName = "Travis",
                    LastName = "Pastrana",
                    Address1 = "Muster Str. 12",
                    ZipCode = "10178",
                    City = "Los Angeles",
                    State = "CA",
                    Country = Iso3166CountryCodes.US
                },
                ShippingAddress = new Address()
                {
                    FirstName = "Travis",
                    LastName = "Pastrana",
                    Address1 = "Muster Str. 12",
                    ZipCode = "10178",
                    City = "Los Angeles",
                    State = "CA",
                    Country = Iso3166CountryCodes.US
                }
            };

            var xml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<payment_transaction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"GooglePay\">" +
                "<transaction_type>google_pay</transaction_type>" +
                "<transaction_id>43671</transaction_id>" +
                "<usage>40208 concert tickets</usage>" +
                "<amount>100</amount>" +
                "<currency>USD</currency>" +
                "<remote_ip>245.253.2.12</remote_ip>" +
                "<payment_token>...</payment_token>" +
                "<payment_subtype>authorize</payment_subtype>" +                
                "<document_id>123456789</document_id>" +
                "<birth_date>" + _birthDate.ToShortDateString() + "</birth_date>" +
                "<billing_address>" +
                "<first_name>Travis</first_name>" +
                "<last_name>Pastrana</last_name>" +
                "<address1>Muster Str. 12</address1>" +
                "<zip_code>10178</zip_code>" +
                "<city>Los Angeles</city>" +
                "<state>CA</state>" +
                "<country>US</country>" +
                "</billing_address>" +
                "<shipping_address>" +
                "<first_name>Travis</first_name>" +
                "<last_name>Pastrana</last_name>" +
                "<address1>Muster Str. 12</address1>" +
                "<zip_code>10178</zip_code>" +
                "<city>Los Angeles</city>" +
                "<state>CA</state>" +
                "<country>US</country>" +
                "</shipping_address>" +
                "<business_attributes>" +
                "<event_id>1912</event_id>" +
                "<event_start_date>" + _startDate.ToShortDateString() + "</event_start_date>" +
                "<event_end_date>" + _endDate.ToShortDateString() + "</event_end_date>" +
                "<event_organizer_id>20192375</event_organizer_id>" +
                "</business_attributes>" +
                "<customer_email>travis@example.com</customer_email>" +
                "<customer_phone>15002268663</customer_phone>" +
                "</payment_transaction>";

            return new EntityMock<GooglePay>(googlePay, xml);
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
