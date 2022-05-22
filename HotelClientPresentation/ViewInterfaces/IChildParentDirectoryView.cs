using System;
using System.Collections.Generic;
using HotelClientModel;
using System.Data;

namespace HotelClientPresentation
{
    public interface IChildParentDirectoryView: IView
    {
        List<Guest> ParentsDataSource { get; set; }
        List<Guest> ChildsDataSource { get; set; }

        List<ParentChild> ChildParentRelationDataSource { get; set; }

        Guest CurrentChild { get; set; }
        Guest CurrentParent { get; set; }
        ParentChild CurrentRelation { get; }

        string CustomerLastname { get; }
        string CustomerFirstname { get; }
        string CustomerPassportNumber { get; }
        string CustomerFamily { get; }

        event Action AddRelation;
        event Action DeleteRelation;
        event Action LoadParents;
        event Action LoadChilds;
        event Action LoadRelations;

        event Action ViewUpdated;

        void ShowError(string errorMessage);
    }
}
