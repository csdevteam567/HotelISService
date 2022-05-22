using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelClientModel
{
    public class Menu
    {
        [Display(AutoGenerateField = false)]
        public int DishId { get; set; }

        [Display(AutoGenerateField = false)]
        public int RestaurantId { get; set; }

        public string DishName { get; set; }

        public double Price { get; set; }

        [Editable(false)]
        public string RestaurantName { get; set; }

        [Editable(false)]
        public string HotelName { get; set; }
    }
}
