using System;
using System.ComponentModel.DataAnnotations;

namespace HotelClientModel
{
    public class Restaurant
    {
        [Display(AutoGenerateField = false)]
        public int RestaurantId { get; set; }

        [Display(AutoGenerateField = false)]
        public int HotelId { get; set; }

        public string Name { get; set; }

        [Editable(false)]
        public string HotelName { get; set; }
    }
}
