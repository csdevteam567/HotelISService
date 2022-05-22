using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace HotelClientModel
{
    public class Paycheck
    {
        public int OrderId { get; set; }

        public string HotelName { get; set; }

        public string CityName { get; set; }

        public string CountryName { get; set; }

        public DateTime OrderDate { get; set; }

        public List<DishInfo> OrderedDishes { get; set; }

        public List<ApartmentPaycheck> OrderedApartments { get; set; }

        public double TotalPrice { get; set; }
    }
}
