using System;
using System.Collections.Generic;
using HotelClientModel;
using HotelClientPresentation.HotelServiceReference;

namespace HotelClientPresentation
{
    public class ChildParentDirectoryPresenter : BasePresener<IChildParentDirectoryView, Guest>
    {
        private readonly IParentChildDataService _service;
        private readonly IGuestDataService _guestService;
        private Guest currentGuest;
        private ParentChildRelationsModel parentChildModel;

        public ChildParentDirectoryPresenter(IApplicationController controller, IChildParentDirectoryView view, IParentChildDataService service,
            IGuestDataService guestService)
            : base(controller, view)
        {
            _service = service;
            _guestService = guestService;
            parentChildModel = new ParentChildRelationsModel();
            View.AddRelation += () => AddRelation();
            View.DeleteRelation += () => DeleteRelation();
            View.LoadRelations += () => LoadRelations();
            View.LoadParents += () => LoadGuests();
            View.LoadChilds += () => LoadGuests();
            View.ViewUpdated += () => UpdateModelFromView();
        }

        private void UpdateModelFromView()
        {
            parentChildModel.CurrentChild = View.CurrentChild;
            parentChildModel.CurrentParent = View.CurrentParent;
            parentChildModel.CustomerFamily = View.CustomerFamily;
            parentChildModel.CustomerFirstname = View.CustomerFirstname;
            parentChildModel.CustomerLastname = View.CustomerLastname;
            parentChildModel.CustomerPassportNumber = View.CustomerPassportNumber;
            parentChildModel.CurrentRelation = View.CurrentRelation;
        }

        public override void Run(Guest argument)
        {
            currentGuest = argument;

            List<Guest> guests = new List<Guest>();
            guests.Add(currentGuest);

            if (((DateTime.Today - currentGuest.DateOfBirth).Days / 365) < 18)
            {
                parentChildModel.Childs = guests;
                parentChildModel.CurrentChild = currentGuest;
                View.Show();
                View.ChildsDataSource = parentChildModel.Childs;
                View.CurrentChild = parentChildModel.CurrentChild;
            }
            else
            {
                parentChildModel.Parents = guests;
                parentChildModel.CurrentParent = currentGuest;
                View.Show();
                View.ParentsDataSource = parentChildModel.Parents;
                View.CurrentParent = parentChildModel.CurrentParent;
            }
        }

        /// <summary> 
        /// Sends request to delete country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to delete.</param> 
        private void AddRelation()
        {
            if (parentChildModel.CurrentChild != null && parentChildModel.CurrentParent != null)
            {
                _service.InsertParentChildRelation(new ParentChild()
                {
                    ChildId = parentChildModel.CurrentChild.GuestId,
                    ParentId = parentChildModel.CurrentParent.GuestId
                });
            }
            else
            {
                View.ShowError("First you need to select record");
            }
        }

        /// <summary> 
        /// Sends request to delete country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to delete.</param> 
        private void DeleteRelation()
        {
            if (parentChildModel.CurrentRelation != null)
            {
                ServiceResponce result = _service.DeleteParentChildRelation(parentChildModel.CurrentRelation);
                if (!result.IsOperationSuccessful)
                {
                    View.ShowError(result.Message);
                }
                else
                {
                    LoadRelations();
                }
            }
            else
            {
                View.ShowError("First you need to select record");
            }
        }

        /// <summary> 
        /// Sends request to create country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to insert.</param> 
        private void LoadRelations()
        {
            ParentChild filter = new ParentChild();
            if (parentChildModel.CurrentChild != null)
            {
                filter.ChildId = parentChildModel.CurrentChild.GuestId;
            }

            if (parentChildModel.CurrentParent != null)
            {
                filter.ParentId = parentChildModel.CurrentParent.GuestId;
            }

            parentChildModel.ParentChildRelationsTable = _service.GetParentChildRelations(filter);
            View.ChildParentRelationDataSource = parentChildModel.ParentChildRelationsTable;
            //RelationsService.Client.GetParentChildRelations();
        }

        /// <summary> 
        /// Sends request to create country record to the server 
        /// </summary> 
        /// <param name="countryName">Country name to insert.</param> 
        private void LoadGuests()
        {
            if (!string.IsNullOrEmpty(View.CustomerLastname) || !string.IsNullOrEmpty(View.CustomerPassportNumber))
            {
                GuestSearchCriteriaDto guest = new GuestSearchCriteriaDto()
                {
                    FirstName = View.CustomerFirstname,
                    LastName = View.CustomerLastname,
                    PassportNumber = View.CustomerPassportNumber
                };

                if (parentChildModel.CurrentParent == null)
                {
                    guest.IsAdult = true;
                    parentChildModel.Parents = _guestService.GetGuests(guest);
                    View.ParentsDataSource = parentChildModel.Parents;
                }
                else if (parentChildModel.CurrentChild == null)
                {
                    guest.IsChild = true;
                    parentChildModel.Childs = _guestService.GetGuests(guest);
                    View.ChildsDataSource = parentChildModel.Childs;
                }
            }
            else
            {
                View.ShowError("Lastname or Passport number required");
            }
        }
    }
}
