Overview
===========

C# Client Library for communication with E-ComProcessing's Payment Processing Gateway - Genesis. You can use this library to integrate your current system with Genesis Payment Gateway. Its highly recommended to checkout "Genesis Payment Gateway API Documentation" first, to get an overview of Genesis's Payment Gateway API and functionality.

Requirements
------------

* .NET framework 4.5 or later

Installation
------------

* clone this repo / download the archive
````bash
git clone https://github.com/E-ComProcessing/genesis_dotnet.git genesis_dotnet && cd genesis_dotnet
````

* run [build.cmd] to build the library

API Examples
------------

You can explore a collection of examples demonstrating the different transaction types of Genesis Payment Gateway at [Genesis Client Integration]

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

More information about each one of the request types can be found in the Genesis API Documentation

License
-------------

This software is licensed under the MIT license, quoted <a href="LICENSE" target="_blank">here</a>.


[build.cmd]: build.cmd
[Genesis Client Integration]: https://github.com/E-ComProcessing/genesis_api_examples
