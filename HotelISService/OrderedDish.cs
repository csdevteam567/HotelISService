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
    
    public partial class OrderedDish
    {
        public int MenuId { get; set; }
        public int OrderId { get; set; }
    
        public virtual Menu Menu { get; set; }
        public virtual Order Order { get; set; }
    }
}
