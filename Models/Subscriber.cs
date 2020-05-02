using System;
using System.Collections.Generic;
using System.Linq;

namespace WebAPI.Models
{
    public class Subscriber
    {
        public IEnumerable<tbl_Subscribers> GetSubcribers(SibeeshPassionEntities sb)
        {
            try
            {
                if (sb != null)
                {
                    return sb.tbl_Subscribers.ToList();
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}