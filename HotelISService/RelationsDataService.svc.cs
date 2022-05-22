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
    public class RelationsDataService : IRelationsDataService
    {
        public ServiceResponceDto AddParentChildRelation(ParentChildDto relation)
        {
            ParentChildDBMethods dbParentChild = new ParentChildDBMethods();
            ParentChildDtoValidator validator = new ParentChildDtoValidator();
            var entry = validator.Validate(relation);
            ServiceResponceDto result = validator.ValidationResult;

            if (result.IsOperationSuccessful)
            {
                if (!dbParentChild.InsertParentChild(new ChildParent()
                    {
                        ChildId = relation.ChildId,
                        ParentId = relation.ParentId
                    }))
                {
                    result.IsOperationSuccessful = false;
                    result.Message = "Error during record creation";
                }
            }
            return result;
        }

        public ServiceResponceDto DeleteParentChildRelation(ParentChildDto relation)
        {

            ServiceResponceDto result = new ServiceResponceDto()
            {
                IsOperationSuccessful = true
            };
            ParentChildDBMethods dbParentChild = new ParentChildDBMethods();
            var relations = dbParentChild.getParentChilds(relation);
            if (relations.Count() != 1)
            {
                result.IsOperationSuccessful = false;
                result.Message = "Record not found";
            }
            else
            {
                dbParentChild.DeleteParentChild(new ChildParent()
                {
                    ChildId = relation.ChildId,
                    ParentId = relation.ParentId
                });
            }

            return result;
        }

        public DataTable GetParentChildRelations(ParentChildDto relation)
        {
            ParentChildDBMethods dbParentChild = new ParentChildDBMethods();
            GuestDBMethods dbGuests = new GuestDBMethods();
            List<ChildParent> rows = dbParentChild.getParentChilds(relation);
            DataTable result = new DataTable();
            foreach (var row in rows)
            {
                var parent = dbGuests.getGuestById(row.ParentId);
                var child = dbGuests.getGuestById(row.ChildId);
                ParentChildDto pcRecord = new ParentChildDto()
                {
                    ParentId = row.ParentId,
                    ChildId = row.ChildId,
                    ChildFirstname = child.FirstName,
                    ChildLastname = child.LastName,
                    ChildPassport = child.PassportNumber,
                    ParentFirstname = parent.FirstName,
                    ParentLastname = parent.LastName,
                    ParentPassport = parent.PassportNumber
                };
                result.Rows.Add(pcRecord);
            }
            return result;
        }
    }
}
