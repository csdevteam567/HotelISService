using System;
using System.ComponentModel.DataAnnotations;

namespace HotelClientModel
{
    public class User
    {
        [Display(AutoGenerateField = false)]
        public int Id { get; set; }

        [Editable(false)]
        public string UserLogin { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Display(AutoGenerateField = false)]
        public int Role { get; set; }

        [Display(AutoGenerateField = false)]
        public string Password { get; set; }

        public bool IsAdmin { get; set; }

        public override string ToString()
        {
            return UserLogin;
        }
    }
}
