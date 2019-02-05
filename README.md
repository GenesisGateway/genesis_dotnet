Genesis .net
============

[![Software License](https://img.shields.io/badge/license-MIT-green.svg?style=flat)](LICENSE)

Overview
--------

Client Library for processing payments through Genesis Payment Processing Gateway. Its highly recommended to checkout "Genesis Payment Gateway API Documentation" first, in order to get an overview of Genesis's Payment Gateway API and functionality.

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
Genesis.Net.Entities.Requests.Initial:
* AccountVerification
* Authorize
* Avs
* InitRecurringSale
* Payout
* Sale
* WpfCreate

Genesis.Net.Entities.Requests.Initial.ThreeD:
* Authorize3dSync
* Authorize3dAsync
* InitRecurringSale3dSync
* InitRecurringSale3dAsync
* Sale3dSync
* Sale3dAsync

Genesis.Net.Entities.Requests.Query:
* Blacklist
* SingleChargeback
* MultiChargeback
* SingleReconcile
* MultiReconcile
* SingleRetrievalRequest
* MultiRetrievalRequest

Genesis.Net.Entities.Requests.Referential:
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
using Genesis.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Reflection;

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

            // Set merchant credentials
            string username = "YOUR_USERNAME";
            string password = "YOUR_PASSWORD";
            string token    = "YOUR_TOKEN";

            // Setup certificate
            // (copy from ./Genesis.NET.Specs/Certificates/genesis_sandbox_comodo_ca.pem)
            X509Certificate cert = X509Certificate.CreateFromCertFile(Path.Combine(
                Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath),
                "Certificates",
                "genesis_sandbox_comodo_ca.pem"
            ));

            // Initialize configuration - endpoint and env
            Configuration conf = new Configuration(
                Environments.Staging,
                token,
                username,
                password,
                cert,
                Endpoints.eMerchantPay
            );

            // Initialize Genesis Client
            IGenesisClient gen = Genesis.Net.GenesisClientFactory.Create(conf);

            // Create Authorize request
            Genesis.Net.Entities.Requests.Initial.Authorize req = new Genesis.Net.Entities.Requests.Initial.Authorize();

            // Set request info
            Random r = new Random();
            req.Id = r.Next(1000000, 9000000).ToString();
            req.Usage = "Test Genesis.NET SDK";
            req.RemoteIp = "192.168.0.11";

            // Set amount & currency
            req.Amount = 3.14M;
            req.Currency = Genesis.Net.Common.Iso4217CurrencyCodes.EUR;

            // Set card info
            req.CardHolder = "John Smith";
            req.CardNumber = "4200000000000000";
            req.ExpirationMonth = 6;
            req.ExpirationYear = 2020;
            req.Cvv = "888";
            req.Moto = false;

            // Set customer info
            req.CustomerEmail = "john.smith@example.com";
            req.CustomerPhone = "888888888";

            // Set Billing Address
            req.BillingAddress = new Genesis.Net.Entities.Address();
            req.BillingAddress.Country = Genesis.Net.Common.Iso3166CountryCodes.BG;
            req.BillingAddress.City = "Sofia";
            req.BillingAddress.State = "Sofia";
            req.BillingAddress.Address1 = "Street 1";
            req.BillingAddress.ZipCode = "1407";
            req.BillingAddress.FirstName = "John";
            req.BillingAddress.LastName = "Smith";

            // Set Shipping Address
            req.ShippingAddress = new Genesis.Net.Entities.Address();
            req.ShippingAddress.Country = Genesis.Net.Common.Iso3166CountryCodes.BG;
            req.ShippingAddress.City = "Sofia";
            req.ShippingAddress.State = "Sofia";
            req.ShippingAddress.Address1 = "Street 1";
            req.ShippingAddress.ZipCode = "1407";
            req.ShippingAddress.FirstName = "John";
            req.ShippingAddress.LastName = "Smith";

            Genesis.Net.Result<
                Genesis.Net.Entities.Responses.Successful.AuthorizeSuccessResponse,
                Genesis.Net.Entities.Responses.Error.AuthorizeErrorResponse
            > res = gen.Execute(req);
        }
    }
}
```

Example WPF request

```c#
Random r = new Random();
Genesis.Net.Entities.Requests.Initial.WpfCreate req = new Genesis.Net.Entities.Requests.Initial.WpfCreate()
{
    TransactionId = r.Next(1000000, 9000000).ToString(),
    Usage = "Genesis.NET test",
    Amount = 1,
    Currency = Iso4217CurrencyCodes.EUR,
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
    }
};

Genesis.Net.Result<
    Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse,
    Genesis.Net.Entities.Responses.Error.WpfCreateErrorResponse
> res = gen.Execute(req);
```

More example requests can be found in the library's specs class [`Genesis.Net.Specs.Mocks.RequestMocksFactory`](Genesis.NET.Specs/Mocks/RequestMocksFactory.cs).

More information about each one of the request types can be found in the Genesis API Documentation

License
-------------

This software is licensed under the MIT license, quoted <a href="LICENSE" target="_blank">here</a>.


[build.cmd]: build.cmd
