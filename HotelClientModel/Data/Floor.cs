using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelClientModel
{
    public class Floor
    {
        [Display(AutoGenerateField = false)]
        public int FloorId { get; set; }

        [Display(AutoGenerateField = false)]
        public int HotelId { get; set; }
 
        public int FloorNum { get; set; }

        [Editable(false)]
        public int MaxApartments { get; set; }

        [Editable(false)]
        public string HotelName { get; set; }

        public override string ToString()
        {
            return FloorNum.ToString();
        }
    }
}
