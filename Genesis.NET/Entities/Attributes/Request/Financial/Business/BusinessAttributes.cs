using Genesis.Net.Validations;
using System;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Attributes.Request.Financial.Business
{
    public class BusinessAttributes : Entity
    {
        [XmlElement(ElementName = "flight_arrival_date")]
        public string FlightArrivalDate { get; set; }

        [XmlElement(ElementName = "flight_departure_date")]
        public string FlightDepartureDate { get; set; }

        [XmlElement(ElementName = "airline_code")]
        public string AirlineCode { get; set; }

        [XmlElement(ElementName = "airline_flight_number")]
        public string AirlineFlightNumber { get; set; }

        [XmlElement(ElementName = "flight_ticket_number")]
        public string FlightTicketNumber { get; set; }

        [XmlElement(ElementName = "flight_origin_city")]
        public string FlightOriginCity { get; set; }

        [XmlElement(ElementName = "flight_destination_city")]
        public string FlightDestinationCity { get; set; }

        [XmlElement(ElementName = "airline_tour_operator_name")]
        public string AirlineTourOperatorName { get; set; }

        [XmlElement(ElementName = "event_id")]
        public string EventId { get; set; }

        [XmlElement(ElementName = "event_start_date")]
        public string EventStartDate { get; set; }

        [XmlElement(ElementName = "event_end_date")]
        public string EventEndDate { get; set; }

        [XmlElement(ElementName = "event_organizer_id")]
        public string EventOrganizerId { get; set; }

        [XmlElement(ElementName = "date_of_order")]
        public string DateOfOrder { get; set; }

        [XmlElement(ElementName = "delivery_date")]
        public string DeliveryDate { get; set; }

        [XmlElement(ElementName = "name_of_the_supplier")]
        public string NameOfTheSupplier { get; set; }

        [XmlElement(ElementName = "check_in_date")]
        public string CheckInDate { get; set; }

        [XmlElement(ElementName = "check_out_date")]
        public string CheckOutDate { get; set; }

        [XmlElement(ElementName = "travel_agency_name")]
        public string TravelAgencyName { get; set; }

        [XmlElement(ElementName = "vehicle_pick_up_date")]
        public string VehiclePickUpDate { get; set; }

        [XmlElement(ElementName = "vehicle_return_date")]
        public string VehicleReturnDate { get; set; }

        [XmlElement(ElementName = "supplier_name")]
        public string SupplierName { get; set; }

        [XmlElement(ElementName = "cruise_start_date")]
        public string CruiseStartDate { get; set; }

        [XmlElement(ElementName = "cruise_end_date")]
        public string CruiseEndDate { get; set; }

        [XmlElement(ElementName = "arrival_date")]
        public string ArrivalDate { get; set; }

        [XmlElement(ElementName = "departure_date")]
        public string DepartureDate { get; set; }

        [XmlElement(ElementName = "carrier_code")]
        public string CarrierCode { get; set; }

        [XmlElement(ElementName = "flight_number")]
        public string FlightNumber { get; set; }

        [XmlElement(ElementName = "ticket_number")]
        public string TicketNumber { get; set; }

        [XmlElement(ElementName = "origin_city")]
        public string OriginCity { get; set; }

        [XmlElement(ElementName = "destination_city")]
        public string DestinationCity { get; set; }

        [XmlElement(ElementName = "travel_agency")]
        public string TravelAgency { get; set; }

        [XmlElement(ElementName = "contractor_name")]
        public string ContractorName { get; set; }

        [XmlElement(ElementName = "atol_certificate")]
        public string AtolCertificate { get; set; }

        [XmlElement(ElementName = "pick_up_date")]
        public string PickUpDate { get; set; }

        [XmlElement(ElementName = "return_date")]
        public string ReturnDate { get; set; }

        [XmlElement(ElementName = "payment_type")]
        public string PaymentType { get; set; }

        public BusinessAttributes()
        {
        }
    }
}