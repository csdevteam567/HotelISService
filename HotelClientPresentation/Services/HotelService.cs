using System;
using System.Collections.Generic;
using HotelClientPresentation.HotelServiceReference;

namespace HotelClientPresentation
{
    public class HotelService
    {
        private static readonly HotelServiceClient client = new HotelServiceClient("BasicHttpBinding_IHotelService");
        private static readonly HotelService instance = new HotelService();
        public static HotelServiceClient Client { get { return client; } }

        static HotelService()
        {

        }

        private HotelService()
        {

        }

        public static HotelService Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
