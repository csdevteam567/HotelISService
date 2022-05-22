using System;
using System.Collections.Generic;
using HotelClientPresentation.RelationsServiceReference;

namespace HotelClientPresentation
{
    public class RelationsService
    {
        private static readonly RelationsDataServiceClient client = new RelationsDataServiceClient("BasicHttpBinding_IRelationsDataService");
        private static readonly RelationsService instance = new RelationsService();
        public static RelationsDataServiceClient Client { get { return client; } }

        static RelationsService()
        {

        }

        private RelationsService()
        {

        }

        public static RelationsService Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
