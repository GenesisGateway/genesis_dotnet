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

More information about each one of the request types can be found in the Genesis API Documentation

License
-------------

This software is licensed under the MIT license, quoted <a href="LICENSE" target="_blank">here</a>.


[build.cmd]: build.cmd
