//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelISService
{
    using System;
    using System.Collections.Generic;
    
    public partial class Floor
    {
        public Floor()
        {
            this.Apartments = new HashSet<Apartment>();
        }
    
        public int Id { get; set; }
        public int MaxApartments { get; set; }
        public int FloorNum { get; set; }
        public int HotelId { get; set; }
    
        public virtual ICollection<Apartment> Apartments { get; set; }
        public virtual Hotel Hotel { get; set; }
    }
}