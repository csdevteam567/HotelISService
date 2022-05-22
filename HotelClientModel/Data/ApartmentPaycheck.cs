using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelClientModel
{
    public class ApartmentPaycheck
    {
        [Display(AutoGenerateField = false)]
        public int OrderId { get; set; }

        public int FloorNumber { get; set; }

        public int ApartmentNumber { get; set; }

        public DateTime ActualDepartureDate { get; set; }

        public double ApartmentPrice { get; set; }

        public int TotalDays { get; set; }
    }
}
