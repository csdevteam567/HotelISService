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
    
    public partial class Hotel
    {
        public Hotel()
        {
            this.Restaurants = new HashSet<Restaurant>();
            this.Floors = new HashSet<Floor>();
            this.Orders = new HashSet<Order>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public bool HasRestaurant { get; set; }
        public int MaxFloorsCount { get; set; }
        public int CityId { get; set; }
    
        public virtual ICollection<Restaurant> Restaurants { get; set; }
        public virtual ICollection<Floor> Floors { get; set; }
        public virtual City City { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}