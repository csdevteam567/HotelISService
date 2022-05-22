using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using HotelISDTO;
using System.Data;

namespace HotelISService
{
    [ServiceContract]
    public interface IRelationsDataService
    {
        [OperationContract]
        ServiceResponceDto AddParentChildRelation(ParentChildDto relation);

        [OperationContract]
        ServiceResponceDto DeleteParentChildRelation(ParentChildDto relation);

        [OperationContract]
        DataTable GetParentChildRelations(ParentChildDto relation);
    }
}
