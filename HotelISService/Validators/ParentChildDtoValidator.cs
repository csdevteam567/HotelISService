using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using HotelISDTO;

namespace HotelISService
{
    public class ParentChildDtoValidator
    {
        private ServiceResponceDto validationResult;

        public ServiceResponceDto ValidationResult 
        {
            get
            {
                return validationResult;
            }
            private set
            {
                validationResult = value;
            }
        }

        public ParentChildDtoValidator()
        {
            validationResult = new ServiceResponceDto()
            {
                IsOperationSuccessful = true
            };
        }

        public ChildParent Validate(ParentChildDto relation)
        {
            ChildParent result = null;

            if (relation.ChildId < 1)
            {
                ValidationResult.IsOperationSuccessful = false;
                ValidationResult.Message = "Child is missing";
            }

            if (relation.ParentId < 1)
            {
                ValidationResult.IsOperationSuccessful = false;
                ValidationResult.Message = "Parent is missing";
            }

            if(validationResult.IsOperationSuccessful)
            {
                var guestDB = new GuestDBMethods();

                var parent = guestDB.getGuestById(relation.ParentId);
                var child = guestDB.getGuestById(relation.ChildId);

                if (parent == null || child == null)
                {
                    ValidationResult.IsOperationSuccessful = false;
                    ValidationResult.Message = "No such guest record";
                }
                else
                {
                    var parentChildDB = new ParentChildDBMethods();
                    var duplicate = parentChildDB.getParentChilds(relation);
                    if (duplicate.Count < 1)
                    {
                        result = new ChildParent()
                        {
                            ChildId = child.Id,
                            ParentId = parent.Id
                        };
                    }
                    else
                    {
                        ValidationResult.IsOperationSuccessful = false;
                        ValidationResult.Message = "Such relation already exist";
                    }
                }
            };
            return result;
        }
    }
}