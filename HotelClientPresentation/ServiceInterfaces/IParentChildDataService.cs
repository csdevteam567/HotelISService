using System;
using System.Collections.Generic;
using HotelClientModel;
using HotelClientPresentation.RelationsServiceReference;
using System.Data;

namespace HotelClientPresentation
{
    public interface IParentChildDataService
    {
        List<ParentChild> GetParentChildRelations(ParentChild relation);
        ServiceResponce InsertParentChildRelation(ParentChild relation);
        ServiceResponce DeleteParentChildRelation(ParentChild relation);
    }
}
