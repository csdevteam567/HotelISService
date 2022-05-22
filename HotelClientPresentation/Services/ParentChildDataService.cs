using System;
using System.Collections.Generic;
using HotelClientPresentation.HotelServiceReference;
using HotelClientModel;
using System.Data;

namespace HotelClientPresentation
{
    public class ParentChildDataService : IParentChildDataService
    {
        public List<ParentChild> GetParentChildRelations(ParentChild relation)
        {
            List<ParentChild> result = new List<ParentChild>();

            try
            {
                var toDtoConverter = new DtoConverver<ParentChild, ParentChildDto>();
                var fromDtoConverter = new DtoConverver<ParentChildDto, ParentChild>();
                var filter = toDtoConverter.ConvertType(relation);
                var dtoResult = HotelService.Client.GetParentChildRelations(filter);
                foreach (var dto in dtoResult)
                {
                    result.Add(fromDtoConverter.ConvertType(dto));
                }
            }
            catch (Exception ex)
            {
                Logger.Log.Error(ex);
            }

            return result;
        }

        public ServiceResponce InsertParentChildRelation(ParentChild relation)
        {
            ServiceResponce result = new ServiceResponce()
            {
                IsOperationSuccessful = true
            };
            try
            {
                var toDtoConverter = new DtoConverver<ParentChild, ParentChildDto>();
                var fromDtoConverter = new DtoConverver<ServiceResponceDto, ServiceResponce>();

                var filter = toDtoConverter.ConvertType(relation);
                var dtoResult = HotelService.Client.AddParentChildRelation(filter);
                result = fromDtoConverter.ConvertType(dtoResult);
            }
            catch (Exception ex)
            {
                Logger.Log.Error(ex);
                result.IsOperationSuccessful = false;
                result.Message = "Error during accessing service";
            }
            return result;
        }

        public ServiceResponce DeleteParentChildRelation(ParentChild relation)
        {
            ServiceResponce result = new ServiceResponce()
            {
                IsOperationSuccessful = true
            };
            try
            {
                var toDtoConverter = new DtoConverver<ParentChild, ParentChildDto>();
                var fromDtoConverter = new DtoConverver<ServiceResponceDto, ServiceResponce>();

                var filter = toDtoConverter.ConvertType(relation);
                var dtoResult = HotelService.Client.DeleteParentChildRelation(filter);
                result = fromDtoConverter.ConvertType(dtoResult);
            }
            catch (Exception ex)
            {
                Logger.Log.Error(ex);
                result.IsOperationSuccessful = false;
                result.Message = "Error during accessing service";
            }
            return result;
        }
    }
}
