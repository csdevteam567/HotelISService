using System;
using System.ComponentModel.DataAnnotations;

namespace HotelClientModel
{
    public class Guest
    {
        [Display(AutoGenerateField = false)]
        public int GuestId { get; set; }

        [Editable(false)]
        public string PassportNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string FamilyName { get; set; }

        [Editable(false)]
        public System.DateTime DateOfBirth { get; set; }

        [Editable(false)]
        public string Sex { get; set; }

        [Editable(false)]
        public bool StatusVip { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        [Editable(false)]
        public double Discount { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
