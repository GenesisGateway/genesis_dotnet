Genesis .net
============

[![Software License](https://img.shields.io/badge/license-MIT-green.svg?style=flat)](LICENSE)

Overview
--------

Client Library for processing payments through Genesis Payment Processing Gateway. Its highly recommended to checkout "Genesis Payment Gateway API Documentation" first, [you can discover it here](https://emerchantpay.github.io/gateway-api-docs/#version), in order to get an overview of Genesis's Payment Gateway API and functionality.

Requirements
------------

* .NET framework 4.5 or later

Installation
------------

* clone this repo / download the archive
````sh
git clone https://github.com/GenesisGateway/genesis_dotnet.git genesis_dotnet && cd genesis_dotnet
````

* run [build.cmd] to build the library

Request types
-------------

You can use the following request types to initialize various transactions supported by Genesis.

````
Genesis.NetCore.Entities.Requests.Initial:
* AccountVerification
* Authorize
* Authorize3d
* Avs
* InitRecurringSale
* InitRecurringSale3d
* Payout
* Sale
* Sale3d
* WpfCreate
* GooglePay
* ApplePay

Genesis.NetCore.Entities.Requests.Query:
* Blacklist
* SingleChargeback
* MultiChargeback
* SingleReconcile
* MultiReconcile
* SingleRetrievalRequest
* MultiRetrievalRequest

Genesis.NetCore.Entities.Requests.Referential:
* Capture
* Credit
* RecurringSale
* Refund
* VoidRequest
* WpfReconcile

````

Example code
-------------

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using Genesis.NetCore;

namespace ExampleConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.SendRequest();
            Console.ReadKey();
        }

        public static void SendRequest()
        {
            // Set connection settings
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ServicePointManager.CheckCertificateRevocationList = true;

            // Set merchant credentials
            string username = "YOUR_USERNAME";
            string password = "YOUR_PASSWORD";
            string token    = "YOUR_TOKEN";

            // Initialize configuration - endpoint and env
            Configuration configuration = new Configuration(
                Environments.Staging,
                token,
                username,
                password,
                Endpoints.eMerchantPay
            );

            // Initialize Genesis Client
            var genesis = Genesis.NetCore.GenesisClientFactory.Create(configuration);

            // Create Authorize request
            var request = new Genesis.NetCore.Entities.Requests.Initial.Authorize();

            // Set request info
            var random = new Random();
            request.Id = random.Next(1000000, 9000000).ToString();
            request.Usage = "Test Genesis.NET SDK";
            request.RemoteIp = "192.168.0.11";

            // Set amount & currency
            request.Amount = 3.14M;
            request.Currency = Genesis.NetCore.Common.Iso4217CurrencyCodes.EUR;

            // Set card info
            request.CardHolder = "John Smith";
            request.CardNumber = "4200000000000000";
            request.ExpirationMonth = "6";
            request.ExpirationYear = "2029";
            request.Cvv = "888";
            request.Moto = false;

            // Set customer info
            request.CustomerEmail = "john.smith@example.com";
            request.CustomerPhone = "888888888";

            // Set Billing Address
            request.BillingAddress = new Genesis.NetCore.Entities.Address
            {
                Country = Genesis.NetCore.Common.Iso3166CountryCodes.BG,
                City = "Sofia",
                State = "Sofia",
                Address1 = "Street 1",
                ZipCode = "1407",
                FirstName = "John",
                LastName = "Smith"
            };

            // Set Shipping Address
            request.ShippingAddress = new Genesis.NetCore.Entities.Address
            {
                Country = Genesis.NetCore.Common.Iso3166CountryCodes.BG,
                City = "Sofia",
                State = "Sofia",
                Address1 = "Street 1",
                ZipCode = "1407",
                FirstName = "John",
                LastName = "Smith"
            };

            // Business Attributes
            request.BusinessAttributes = new Genesis.NetCore.Entities.Attributes.Request.Financial.Business.BusinessAttributes
            {
                // Business Airlines Air Carriers
                FlightArrivalDate = "23-12-2030",
                FlightDepartureDate = "23-12-2030",
                AirlineCode = "C0D3",
                AirlineFlightNumber = "FLIGHT_NUMBER",
                FlightTicketNumber = "TICKET_NUMBER",
                FlightOriginCity = "ORIGIN_CITY",
                FlightDestinationCity = "DESTINATION_CITY",
                AirlineTourOperatorName = "TOUR_OPERATOR",

                // Event Management
                EventStartDate = "23-12-2030",
                EventEndDate = "24-12-2030",
                EventOrganizerId = "ORGANIZER_ID",
                EventId = "EVENT_ID",

                // Furniture
                DateOfOrder = "23-12-2030",
                DeliveryDate = "24-12-2030",
                NameOfTheSupplier = "SUPPLIER_NAME",

                // Hotels and Real estate rentals
                CheckInDate = "23-12-2030",
                CheckOutDate = "24-12-2030",
                TravelAgencyName = "TRAVEL_AGENCY",

                // Car, Plane and Boat Rentals
                VehiclePickUpDate = "23-12-2030",
                VehicleReturnDate = "24-12-2030",
                SupplierName = "SUPPLIER_NAME",

                // Cruise Lines
                CruiseStartDate = "23-12-2030",
                CruiseEndDate = "23-12-2030",

                // Travel Agencies
                ArrivalDate = "23-12-2030",
                DepartureDate = "24-12-2030",
                CarrierCode = "CARRIER_CODE",
                FlightNumber = "FLIGHT_NUMBER",
                TicketNumber = "TICKET_NUMBER",
                OriginCity = "ORIGIN_CITY",
                DestinationCity = "DESTINATION_CITY",
                TravelAgency = "TRAVEL_AGENCY",
                ContractorName = "CONTRACTOR_NAME",
                AtolCertificate = "ATOL_CERTIFICATE",
                PickUpDate = "22-12-2030",
                ReturnDate = "25-12-2030",

                // Payment Type
                PaymentType = "deposit"
            };

            Result<
                Genesis.NetCore.Entities.Responses.Successful.CardTransactionSuccessResponse,
                Genesis.NetCore.Entities.Responses.Error.CardTransactionErrorResponse> result = genesis.Execute(request);
           
            Console.WriteLine($"{nameof(result.IsSuccessful)}: {result.IsSuccessful}");
            if (result.IsSuccessful)
            {
                Console.WriteLine($"{nameof(result.SuccessResponse.Status)}: {result.SuccessResponse.Status}");
                Console.WriteLine($"{nameof(result.SuccessResponse.TransactionId)}: {result.SuccessResponse.TransactionId}");
                Console.WriteLine($"{nameof(result.SuccessResponse.UniqueId)}: {result.SuccessResponse.UniqueId}");
            }
            else
            {
                Console.WriteLine($"{nameof(result.ErrorResponse.Status)}: {result.ErrorResponse.Status}");
                Console.WriteLine($"{nameof(result.ErrorResponse.TransactionId)}: {result.ErrorResponse.TransactionId}");
                Console.WriteLine($"{nameof(result.ErrorResponse.UniqueId)}: {result.ErrorResponse.UniqueId}");
                Console.WriteLine($"{nameof(result.ErrorResponse.Message)}: {result.ErrorResponse.Message}");
                Console.WriteLine($"{nameof(result.ErrorResponse.TechnicalMessage)}: {result.ErrorResponse.TechnicalMessage}");
            }
        }
    }
}
```

Example WPF request

```c#
Random random = new Random();
Genesis.NetCore.Entities.Requests.Initial.WpfCreate request = new Genesis.NetCore.Entities.Requests.Initial.WpfCreate()
{
    TransactionId = random.Next(1000000, 9000000).ToString(),
    Usage = "Genesis.NET test",
    Amount = 1,
    Currency = Iso4217CurrencyCodes.EUR,
    ConsumerId = "123456", // only avaialable with enabled Tokenization, contact your Account Manager
    RememberCard = "true", // only avaialable with enabled Tokenization, contact your Account Manager
    CustomerEmail = "hello@world.com",
    CustomerPhone = "3598888888888",
    Description = "description",
    TransactionTypes = new Composite[] {
        new Composite() { { "name", TransactionTypes.Sale.ToString() } },
        new Composite() { { "name", TransactionTypes.Authorize.ToString() } }
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
    BusinessAttributes = new Genesis.NetCore.Entities.Attributes.Request.Financial.Business.BusinessAttributes()
    {
        // Business Airlines Air Carriers
        FlightArrivalDate = "23-12-2030",
        FlightDepartureDate = "23-12-2030",
        AirlineCode = "C0D3",
        AirlineFlightNumber = "FLIGHT_NUMBER",
        FlightTicketNumber = "TICKET_NUMBER",
        FlightOriginCity = "ORIGIN_CITY",
        FlightDestinationCity = "DESTINATION_CITY",
        AirlineTourOperatorName = "TOUR_OPERATOR",

        // Event Management
        EventStartDate = "23-12-2030",
        EventEndDate = "24-12-2030",
        EventOrganizerId = "ORGANIZER_ID",
        EventId = "EVENT_ID",

        // Furniture
        DateOfOrder = "23-12-2030",
        DeliveryDate = "24-12-2030",
        NameOfTheSupplier = "SUPPLIER_NAME",

        // Hotels and Real estate rentals
        CheckInDate = "23-12-2030",
        CheckOutDate = "24-12-2030",
        TravelAgencyName = "TRAVEL_AGENCY",

        // Car, Plane and Boat Rentals
        VehiclePickUpDate = "23-12-2030",
        VehicleReturnDate = "24-12-2030",
        SupplierName = "SUPPLIER_NAME",

        // Cruise Lines
        CruiseStartDate = "23-12-2030",
        CruiseEndDate = "23-12-2030",

        // Travel Agencies
        ArrivalDate = "23-12-2030",
        DepartureDate = "24-12-2030",
        CarrierCode = "CARRIER_CODE",
        FlightNumber = "FLIGHT_NUMBER",
        TicketNumber = "TICKET_NUMBER",
        OriginCity = "ORIGIN_CITY",
        DestinationCity = "DESTINATION_CITY",
        TravelAgency = "TRAVEL_AGENCY",
        ContractorName = "CONTRACTOR_NAME",
        AtolCertificate = "ATOL_CERTIFICATE",
        PickUpDate = "22-12-2030",
        ReturnDate = "25-12-2030",

        // Payment Type
        PaymentType = "deposit"
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

Genesis.NetCore.Result<
    Genesis.NetCore.Entities.Responses.Successful.WpfCreateSuccessResponse,
    Genesis.NetCore.Entities.Responses.Error.WpfCreateErrorResponse
> res = genesis.Execute(request);
```


Example Sale3D v2 request with "Continue" request

```c#
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using Genesis.NetCore;
using Genesis.NetCore.Common;
using Genesis.NetCore.Entities;
using Genesis.NetCore.Entities.Attributes.Request.Financial.Cards.ThreedsV2;
using Genesis.NetCore.Entities.Attributes.Request.Financial.Cards.ThreedsV2.Enums;
using Genesis.NetCore.Entities.Enums;
using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Entities.Requests.Initial.Threedsv2;

namespace ConsoleTest3dv2Requests
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSale3d();
            Console.WriteLine("End. Press any key...");
            Console.ReadKey();
        }

		static void TestSale3d()
        {
            // Set connection settings
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ServicePointManager.CheckCertificateRevocationList = true;

            // Set merchant credentials
            string username = "YOUR_USERNAME";
            string password = "YOUR_PASSWORD";
            string token    = "YOUR_TOKEN";

            // Initialize configuration - endpoint and env
            var configuration = new Configuration(
                Environments.Staging,
                token,
                username,
                password,
                Endpoints.EComProcessing
            );

            // Initialize Genesis Client
            var client = GenesisClientFactory.Create(configuration);

            Random random = new Random();
            var request = new Sale3d()
            {
                Id = random.Next(1000000, 9000000).ToString(),
                Usage = "40208 concert tickets",
                RemoteIp = "192.168.2.12",
                Amount = 50,
                Currency = Genesis.NetCore.Common.Iso4217CurrencyCodes.USD,
                CardHolder = "FirstName LastName",
                CustomerEmail = "jhonny@example.com",
                CustomerPhone = "+1678678678678",
                CardNumber = TestCardsNumbers.Visa3dv2ChallengeWith3dSecure, //"4938730000000001"
                ExpirationMonth = "1",
                ExpirationYear = "2029",
                Cvv = "123",
                BillingAddress = new Address()
                {
                    Address1 = "Muster Str. 18",
                    City = "Los Angeles",
                    Country = Iso3166CountryCodes.US,
                    FirstName = "John",
                    LastName = "Smith",
                    State = "CA",
                    ZipCode = "10178"
                },
                ShippingAddress = new Address()
                {
                    Address1 = "Muster Str. 18",
                    City = "Los Angeles",
                    Country = Iso3166CountryCodes.US,
                    FirstName = "John",
                    LastName = "Smith",
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
                        PreOrderDate = new DateTime(2030, 12, 31).Date,
                        GiftCard = true,
                        GiftCardCount = 99
                    },
                    CardHolderAccount = new CardHolderAccount()
                    {
                        CreationDate = new DateTime(2020, 05, 25).Date,
                        UpdateIndicator = UpdateIndicators.MoreThan60Days,
                        LastChangeDate = new DateTime(2021, 02, 25).Date,
                        PasswordChangeIndicator = PasswordChangeIndicators.NoChange,
                        PasswordChangeDate = new DateTime(2021, 05, 10).Date,
                        ShippingAddressUsageIndicator = ShippingAddressUsageIndicators.CurrentTransaction,
                        ShippingAddressDateFirstUsed = new DateTime(2021, 05, 20).Date,
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
                            UiTypes.SingleSelect,
                            UiTypes.MultiSelect,
                            UiTypes.Text
                        },
                        ApplicationId = Guid.Parse("fc1650c0-5778-0138-8205-2cbc32a32d65"),
                        EncryptedData = "encrypted-data-here",
                        EphemeralPublicKeyPair = "public-key-pair",
                        MaxTimeout = 10,
                        ReferenceNumber = "sdk-reference-number-here"
                    },
                    //Recurring = new Recurring()
                    //{
                    //    ExpirationDate = new DateTime(2022, 11, 25).Date,
                    //    Frequency = 30,
                    //}
                },
                //Sca = new Sca()
                //{
                //    Exemption = ScaExemptions.LowRisk
                //}
            };

            try
            {
                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    Console.WriteLine("--- Response is successful.");
                    Console.WriteLine($"Unique id:\t\t{ response.SuccessResponse.UniqueId}");
                    if (response.SuccessResponse.Status.HasValue)
                    {
                        Console.WriteLine($"Status: \t\t{response.SuccessResponse.Status}");
                        switch (response.SuccessResponse.Status.Value)
                        {
                            case Genesis.NetCore.Entities.Enums.TransactionStates.Approved:
                                Console.WriteLine("--- --- Transaction is Approved.");
                                break;
                            case Genesis.NetCore.Entities.Enums.TransactionStates.PendingAsync:
                                Console.WriteLine("--- --- Transaction is pending - interaction between consumer and issuer is required.");
                                if (!string.IsNullOrEmpty(response.SuccessResponse.RedirectUrl))
                                {
                                    Console.WriteLine($"Redirect type:\t{response.SuccessResponse.RedirectUrlType}");
                                    Console.WriteLine($"Redirect url:\t{response.SuccessResponse.RedirectUrl}");
                                    Console.WriteLine();
                                }

                                if (!string.IsNullOrEmpty(response.SuccessResponse.ThreedsMethodUrl))
                                {
                                    Console.WriteLine($"ThreedsMethodContinueUrl:\t{response.SuccessResponse.ThreedsMethodContinueUrl}");
                                    Console.WriteLine($"ThreedsMethodUrl:\t{response.SuccessResponse.ThreedsMethodUrl}");
                                    Console.WriteLine();
                                }

                                if (!string.IsNullOrEmpty(response.SuccessResponse.ThreedsMethodUrl))
                                {
                                    Console.WriteLine($"Time: \t{response.SuccessResponse.Time.ToString("o", CultureInfo.InvariantCulture)}");
                                    Console.WriteLine($"ProxyAmount: \t{response.SuccessResponse.ProxyAmount}");
                                    var signature = response.SuccessResponse.GenerateSignature(configuration);
                                    Console.WriteLine($"Signature: \t{signature}");
                                    var continueRequest = new ThreeDSv2ContinueRequest(response.SuccessResponse, configuration);
                                    var continueResponse = client.Execute(continueRequest);
                                    if (continueResponse.IsSuccessful)
                                    {
                                        Console.WriteLine("--- Continue request successful.");
                                        Console.WriteLine($"UniqueId: \t\t{continueResponse.SuccessResponse.UniqueId}");
                                        Console.WriteLine($"TransactionId: \t\t{continueResponse.SuccessResponse.TransactionId}");
                                        Console.WriteLine($"Amount: \t\t{continueResponse.SuccessResponse.Amount}");
                                        Console.WriteLine($"Status: \t\t{continueResponse.SuccessResponse.Status}");
                                        if (continueResponse.SuccessResponse.Status == TransactionStates.PendingAsync)
                                        {
                                            Console.WriteLine("--- Status is pending async!");
                                            Console.WriteLine($"RedirectUrlType: \t{continueResponse.SuccessResponse.RedirectUrlType}");
                                            Console.WriteLine($"RedirectUrl: \t\t{continueResponse.SuccessResponse.RedirectUrl}");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("--- Continue request error.");
                                        Console.WriteLine($"Status: \t\t{continueResponse.ErrorResponse.Status}");
                                        Console.WriteLine($"UniqueId: \t\t{continueResponse.ErrorResponse.UniqueId}");
                                        Console.WriteLine($"Message: \t\t{continueResponse.ErrorResponse.Message}");
                                        Console.WriteLine($"TechnicalMessage: \t{continueResponse.ErrorResponse.TechnicalMessage}");
                                    }

                                    Console.WriteLine();
                                }

                                break;
                            case TransactionStates.Declined:
                                Console.WriteLine("--- --- Transaction is Declined.");
                                break;
                            default:
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("--- Response not successful (error).");
                    Console.WriteLine($"Unique id:\t\t{ response.ErrorResponse.UniqueId}");
                    Console.WriteLine($"Status:   \t\t{ response.ErrorResponse.Status}");
                    Console.WriteLine($"Message:   \t\t{ response.ErrorResponse.Message}");
                    Console.WriteLine($"TechnicalMessage:\t{ response.ErrorResponse.TechnicalMessage}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("--- Exception!");
                var x = ex;
                Console.WriteLine(x.Message);
                while (x.InnerException != null)
                {
                    x = x.InnerException;
                    Console.WriteLine(x.Message);
                }

                if (!string.IsNullOrEmpty(ex.StackTrace))
                {
                    Console.WriteLine("--- Stack trace:");
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }
    }
}
```

Managed Recurring
-----------------------------------------------------------------
Managed Recurring provides the option to automatically schedule recurring transactions for a specific day and time. Managed Recurring is available after additional configuration.

In order to suit the gateway requirements of sending the `amount` or `max_amount` as an integer we are providing an option of doing such minor currency conversion with the help of the library's internal tools.

You can do it in the following way:
```
ManagedRecurring = new ManagedRecurring()
                {
                    Mode = Mode.Automatic,
                    Interval = Interval.Days,
                    FirstDate = "2040-12-18",
                    TimeOfDay = 5,
                    Period = 22,
                    Amount = new Money(Iso4217CurrencyCodes.USD, 5.5M).MinorAmount,
                    MaxCount = 10
                },
```


More example requests can be found in the library's specs class [`Genesis.NetCore.Specs.Mocks.RequestMocksFactory`](Genesis.NetCore.Specs/Mocks/RequestMocksFactory.cs).

More information about each one of the request types can be found in the Genesis API Documentation

License
-------------

This software is licensed under the MIT license, quoted <a href="LICENSE" target="_blank">here</a>.


[build.cmd]: build.cmd
