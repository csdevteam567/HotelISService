using System;
using System.ComponentModel.DataAnnotations;

namespace HotelClientModel
{
    public class DishInfo
    {
        [Display(AutoGenerateField = false)]
        public int DishId { get; set; }

        public string DishName { get; set; }

        public double Price { get; set; }
    }
}
