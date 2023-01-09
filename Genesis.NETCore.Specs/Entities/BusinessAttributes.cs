using System;
using Genesis.NetCore.Entities.Attributes.Request.Financial.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities
{
    [TestClass]
    public class Describe_BusinessAttributes
    {
        private BusinessAttributes businessAttributes;

        private readonly string _digitNumber = "123456789";
        private readonly string _contractorName = "Martin Fowler";
        private readonly string _paymentType = "deposit";

        [TestInitialize]
        public void before_each()
        {
            DateTime _startDate = DateTime.Now.AddMonths(-1);
            DateTime _endDate = DateTime.Now.AddMonths(1);
            DateTime _backDate = DateTime.Now.AddMonths(2);

            businessAttributes = new BusinessAttributes()
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
            };
        }

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            businessAttributes.should_serialize_and_deserialize();
        }
    }
}