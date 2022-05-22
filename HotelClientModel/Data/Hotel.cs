using System;
using System.ComponentModel.DataAnnotations;

namespace HotelClientModel
{
    public class Hotel
    {
        [Display(AutoGenerateField = false)]
        public int HotelId { get; set; }

        [Display(AutoGenerateField = false)]
        public int CityId { get; set; }

        [Display(AutoGenerateField = false)]
        public int CountryId { get; set; }

        public string HotelName { get; set; }

        [Editable(false)]
        public string CityName { get; set; }

        [Editable(false)]
        public string CountryName { get; set; }

        public int Rating { get; set; }

        [Editable(false)]
        public int MaxFloorsCount { get; set; }

        public override string ToString()
        {
            return HotelName;
        }
    }
}
