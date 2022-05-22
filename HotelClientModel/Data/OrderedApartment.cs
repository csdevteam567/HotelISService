using System;
using System.ComponentModel.DataAnnotations;

namespace HotelClientModel
{
    public class OrderedApartment
    {
        [Display(AutoGenerateField = false)]
        public int OrderId { get; set; }

        [Display(AutoGenerateField = false)]
        public int ApartmentId { get; set; }

        public string GuestPassportNumber { get; set; }

        public string GuestFirstName { get; set; }

        public string GuestLastName { get; set; }

        public string CountryName { get; set; }

        public string CityName { get; set; }

        public string HotelName { get; set; }

        public int FloorNumber { get; set; }

        public int ApartmentNumber { get; set; }

        public DateTime ActualDepartureDate { get; set; }
    }
}
