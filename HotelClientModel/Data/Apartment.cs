using System;
using System.ComponentModel.DataAnnotations;
namespace HotelClientModel
{
    public class Apartment
    {
        [Display(AutoGenerateField = false)]
        public int ApartmentId { get; set; }

        [Display(AutoGenerateField = false)]
        public int FloorId { get; set; }

        [Display(AutoGenerateField = false)]
        public int HotelId { get; set; }

        public int Number { get; set; }

        [Display(Name = "VIP")]
        public bool HasStatusVip { get; set; }

        public int MaxCapacity { get; set; }

        public int RoomsNumber { get; set; }

        public double Price { get; set; }

        [Editable(false)]
        public int FloorNumber { get; set; }

        [Editable(false)]
        public string HotelName { get; set; }

        [Editable(false)]
        public string CityName { get; set; }

        [Editable(false)]
        public string CountryName { get; set; }

        [Display(AutoGenerateField = false)]
        public bool OnlyAvailable { get; set; }

        public override string ToString()
        {
            return string.Format("No: {0} Floor No: {1}", Number, FloorNumber);
        }
    }
}
