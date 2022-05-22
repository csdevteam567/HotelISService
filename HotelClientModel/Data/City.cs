using System;
using System.ComponentModel.DataAnnotations;

namespace HotelClientModel
{
    public class City
    {
        [Display(AutoGenerateField = false)]
        public int CityId { get; set; }

        [Display(AutoGenerateField = false)]
        public int CountryId { get; set; }

        [Editable(false)]
        public string CountryName { get; set; }

        public string CityName { get; set; }

        public override string ToString()
        {
            return CityName;
        }

    }
}
