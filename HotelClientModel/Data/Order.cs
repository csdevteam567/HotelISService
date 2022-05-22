using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelClientModel
{
    public class Order
    {
        [Display(AutoGenerateField = false)]
        public int Id { get; set; }

        [Display(AutoGenerateField = false)]
        public int HotelId { get; set; }

        [Display(AutoGenerateField = false)]
        public int GuestId { get; set; }

        [Display(AutoGenerateField = false)]
        public int ApartmentId { get; set; }

        [Display(Name = "Departure date")]
        public DateTime DepartureDate { get; set; }

        [Display(Name = "Guest passport number")]
        public string PassportNumber { get; set; }

        [Display(Name = "Guest firstname")]
        public string GuestFirstName { get; set; }

        [Display(Name = "Guest lastname")]
        public string GuestLastName { get; set; }

        [Display(Name = "Visit date")]
        public System.DateTime OrderDate { get; set; }

        [Display(Name = "User login")]
        public string UserLogin { get; set; }

        public double Total { get; set; }

        [Display(Name = "Hotel name")]
        public string HotelName { get; set; }

        [Display(Name = "City name")]
        public string CityName { get; set; }

        [Display(Name = "Country name")]
        public string CountryName { get; set; }
    }
}
