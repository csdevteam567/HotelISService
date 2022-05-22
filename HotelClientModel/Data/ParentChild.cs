using System;
using System.ComponentModel.DataAnnotations;

namespace HotelClientModel
{
    public class ParentChild
    {
        [Display(AutoGenerateField = false)]
        public int ChildId { get; set; }

        [Display(AutoGenerateField = false)]
        public int ParentId { get; set; }

        [Editable(false)]
        public string ChildFirstname { get; set; }

        [Editable(false)]
        public string ChildLastname { get; set; }

        [Editable(false)]
        public string ChildPassport { get; set; }

        [Editable(false)]
        public string ParentFirstname { get; set; }

        [Editable(false)]
        public string ParentLastname { get; set; }

        [Editable(false)]
        public string ParentPassport { get; set; }
    }
}
