using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HotelISDTO;

namespace HotelISService
{
    public class ParentChildDBMethods
    {
        private HotelISService.HotelISDBContainer dbContainer;

        public ParentChildDBMethods()
        {
            dbContainer = new HotelISDBContainer();
        }

        public List<ChildParent> getParentChilds(ParentChildDto filter)
        {
            List<ChildParent> result = new List<ChildParent>();
            try
            {
                IQueryable<ChildParent> query = dbContainer.ChildParents;

                if (filter.ParentId > 0 && filter.ChildId > 0)
                {
                    query = from pc in query
                            where pc.ParentId == filter.ParentId &&
                            pc.ChildId == filter.ChildId
                            select pc;
                    result = query.ToList();
                }
                else if (!string.IsNullOrEmpty(filter.ParentPassport) && !string.IsNullOrEmpty(filter.ChildPassport))
                {
                    query = from pc in query
                            join child in dbContainer.Guests on pc.ChildId equals child.Id into childs
                            join parent in dbContainer.Guests on pc.ChildId equals parent.Id into parents
                            from ch in childs
                            from pa in parents
                            where ch.PassportNumber == filter.ChildPassport &&
                            pa.PassportNumber == filter.ParentPassport
                            select pc;
                    result = query.ToList();
                }
                else
                {
                    if (filter.ParentId > 0)
                    {
                        query = from pc in query
                                where pc.ParentId == filter.ParentId
                                select pc;
                    } else if (!string.IsNullOrEmpty(filter.ParentPassport))
                    {
                        query = from pc in query
                                join g in dbContainer.Guests on pc.ChildId equals g.Id
                                where g.PassportNumber == filter.ParentPassport
                                select pc;
                    }

                    if (filter.ChildId > 0)
                    {
                        query = from pc in query
                                where pc.ChildId == filter.ChildId
                                select pc;

                    } if (!string.IsNullOrEmpty(filter.ChildPassport))
                    {
                        query = from pc in query
                                join g in dbContainer.Guests on pc.ChildId equals g.Id
                                where g.PassportNumber == filter.ChildPassport
                                select pc;
                    }
                    
                    result = query.ToList();
                }
            }
            catch(Exception ex)
            {
                Logger.Log.Error("DB Error:" + ex.Message);
            }

            return result;
        }

        public List<Guest> GetParents(int childId)
        {
            List<Guest> result = new List<Guest>();
            try
            {
                var query = from pc in dbContainer.ChildParents
                            join g in dbContainer.Guests on pc.ParentId equals g.Id
                            where pc.ChildId == childId
                            select g;
                result = query.ToList();
            }
            catch (Exception ex)
            {
                Logger.Log.Error("DB error" + ex.Message);
            }
            return result;
        }

        public List<Guest> GetChilds(int parentId)
        {
            List<Guest> result = new List<Guest>();
            try
            {
                var query = from pc in dbContainer.ChildParents
                            join g in dbContainer.Guests on pc.ChildId equals g.Id
                            where pc.ParentId == parentId
                            select g;
                result = query.ToList();
            }
            catch (Exception ex)
            {
                Logger.Log.Error("DB error" + ex.Message);
            }
            return result;
        }

        public bool InsertParentChild(ChildParent parentChild)
        {
            bool result = true;
            try
            {
                dbContainer.ChildParents.Add(parentChild);
                dbContainer.SaveChanges();
            }
            catch(Exception ex)
            {
                Logger.Log.Error("DB error" + ex.Message);
                result = false;
            }
            return result;
        }

        public bool DeleteParentChild(ChildParent parentChild)
        {
            bool result = true;
            try
            {
                dbContainer.ChildParents.Remove(parentChild);
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