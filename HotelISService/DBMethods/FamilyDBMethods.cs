using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HotelISDTO;

namespace HotelISService
{
    public class FamilyDBMethods
    {
        private HotelISService.HotelISDBContainer dbContainer;

        public FamilyDBMethods()
        {
            dbContainer = new HotelISDBContainer();
        }

        public List<FamilyRelation> getFamilyRelations(int guestId)
        {
            List<FamilyRelation> result = new List<FamilyRelation>();
            try
            {
                var query = from fr in dbContainer.FamilyRelations
                            where fr.GuestId == guestId ||
                            fr.RelativeId == guestId
                            select fr;
                result = query.ToList();
            }
            catch (Exception ex)
            {
                Logger.Log.Error("DB Error:" + ex.Message);
            }
            return result;
        }

        public List<Guest> getFamilyMembers(int guestId)
        {
            List<Guest> result = new List<Guest>();
            try
            {
                var query = from fr in dbContainer.FamilyRelations
                            from guest in dbContainer.Guests
                            where (fr.GuestId == guest.Id ||
                            fr.RelativeId == guest.Id) &&
                            (fr.GuestId == guestId ||
                            fr.RelativeId == guestId)
                            select guest;
                result = query.ToList();
            }
            catch(Exception ex)
            {
                Logger.Log.Error("DB Error:" + ex.Message);
            }
            return result;
        }

        public double getFamilyMaxDiscount(int guestId)
        {
            double result = 0;
            try
            {
                var query = (from fr in dbContainer.FamilyRelations
                            from guest in dbContainer.Guests
                            where (fr.GuestId == guest.Id ||
                            fr.RelativeId == guest.Id) &&
                            (fr.GuestId == guestId ||
                            fr.RelativeId == guestId)
                            select guest.Discount).Max();
                result = query;
            }
            catch (Exception ex)
            {
                Logger.Log.Error("DB Error:" + ex.Message);
            }
            return result;
        }

        public bool InsertFamilyRelation(FamilyRelation relation)
        {
            bool result = true;
            try
            {
                dbContainer.FamilyRelations.Add(relation);
                dbContainer.SaveChanges();
            }
            catch (Exception ex)
            {
                Logger.Log.Error("DB error" + ex.Message);
                result = false;
            }
            return result;
        }

        public bool DeleteFamilyRelation(FamilyRelation relation)
        {
            bool result = true;
            try
            {
                dbContainer.FamilyRelations.Remove(relation);
                dbContainer.SaveChanges();
            }
            catch (Exception ex)
            {
                Logger.Log.Error("DB error" + ex.Message);
                result = false;
            }
            return result;
        }
    }
}