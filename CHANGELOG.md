2.1.2
-----
**Fixes**:

* Fixed Accept HTTP header config for the web request with the Smart Router API

2.1.1
-----
**Features**:

* Extended Funding parameters with VISA parameters support
* Extended Dynamic Descriptor parameters support
* Added mobile recurring payments support to the following transaction requests:
  * Google Pay
  * Apple Pay

2.1.0
-----
**Features**:

* Added neighborhood attribute support to the Address
* Added allowed Genesis.NetCore.Entities.Enums.PproPaymentType for PPRO Payment Types
* Added Online Banking transaction request
* Added Bank Payout transaction request
* Added Smart Router API support
* Removed Account Verification transaction request. You can use Sale/3D, Authorize/3D with zero amount (Account Verification V2)

2.0.4
-----
**Features**:

* Added Funding parameters support
* Added Address State validation in the Web Payment Form

2.0.3
-----
**Features**:

* Improved documentation
* Added support for the following Web Payment Form locales:
  * `NL`, Dutch
  * `IS`, Icelandic
  * `ID`, Indonesian
  * `MS`, Malay
  * `TH`, Thai
  * `CS`, Czech
  * `HR`, Croatian
  * `SL`, Slovenian
  * `FI`, Finnish
  * `NO`, Norwegian
  * `DA`, Danish
  * `SV`, Swedish

2.0.2
-----
**Features**:

* Added Recurring Type attribute support to the following transaction requests: Authorize, Authorize 3D, Sale, Sale 3D, Web Payment Form
* Added Managed Recurring attributes support to the following transaction requests: Authorize, Authorize 3D, Sale, Sale 3D, Init Recurring Sale, Init Recurring Sale 3D
* Added Manager Recurring attributes support to the Web Payment Form Transaction Types Composite object
* Added Reference Id attributes support to the following transaction requests: Authorize, Sale

2.0.1
-----
**Features**:

* Updated project README by adding a reference to the official Gateway API Documentation
* Added Release Notes to the NuGet Package configuration

2.0.0
-----
**Features**:

* Updated the library to `.Net Standard 2.0`  in order to support .NET Core, 5, 6 and 7.  The older compatibility remains. .Net 4.5 and 4.6 are supported with the same codebase and realized by "multi-targeting".
* Replaced the `Genesis.NET` namespace with `Genesis.NETCore`
* Added **Client-Side Encryption** support by adding a boolean parameter `ClientSideEncryption` to the following transaction requests:
  * Authorize
  * Authorize 3D
  * Sale
  * Sale 3D
  * Init Recurring Sale
  * Init Recurring Sale 3D
  * Payout
  * Account Verification
* Removed obsolete `Sale3dAsync`, `Authorize3dAsync`, `InitiRecurringSale3dAsync` transaction requests

1.2.1
-----
**Features**:

* Updated Web Payment Form attributes by extending support with:
  * **Reminder Language**
  * **Reminders**
  * **Pay Later**
  * **Tokenization**
    * **Consumer Id**
    * **Remember Card**
  * **Web Payment Form Id**

1.2.0
-----
**Features**:

* Added 3DSv2 parameters support to the following transaction requests:
    * **Sale 3D**
    * **Authorize 3D**
    * **Initi Recurring Sale 3D**
    * **Web Payment Form**
* Added new Sale 3D, Authorize 3D and Init Recurring Sale 3D classes under `Genesis.Net.Entities.Requests.Initial` namespace. The old Async classes are still available and will be removed in future versions.
* Updated `remote_ip` attribute by marking it as optional.
* Added **SCA** parameters support.
* Updated response parameters - 3DSv2 and more.

**Fixes**:

* Fixed notification response generation

1.1.9
-----
**Features**:

* Added Apple Pay support
* Added Google Pay support

**Fixes**:

* Fixed error upon empty Billing/Shipping Country inside the response

1.1.8
-----
**Features**:

* Added Business Attributes support to the following transaction request:
  * **Authorize**
  * **Authorize 3D**
  * **Sale**
  * **Sale 3D**
  * **Init Recurring Sale**
  * **Init Recurring Sale 3D**
  * **Capture**
  * **Recurring Sale**
  * **Web Payment Form**

1.1.7
-----
**Features**:

* Removed requirement for Certificate usage

1.1.6
-----
**Fixes:**

* Fixed bug with the building of requests' URLs

1.1.5
-----
**Fixes:**

* Updated conditionally required fields in requests
* Removed leftover files after updating filenames

1.1.3
-----
**Features:**

* Added new fields to WPF Create request
  * Card Holder
  * Lifetime
  * Dynamic Descriptor Params
* Added example code to README

**Fixes:**

* Fixed WPF Reconcile request's API URL

1.1.2
-----

**Features:**

* Extended library’s tests to include checking connectivity to the gateways

**Fixes:**

* Fixed issue with SSL certificate’s path in library tests
* Fixed issues with library’s tests - filenames and configs

1.1.1
----

**Fixes**:

* Fixed issue with the conversion from major to minor units based on regional settings
* Fixed syntax error in specs
