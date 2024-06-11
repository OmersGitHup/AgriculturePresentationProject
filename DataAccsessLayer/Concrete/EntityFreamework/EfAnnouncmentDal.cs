using DataAccsessLayer.Abstract;
using DataAccsessLayer.Concrete.Repository;
using DataAccsessLayer.Contexts;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Concrete.EntityFreamework
{
    public class EfAnnouncmentDal : GenericRepository<Announcement>, IAnnouncmentDal //Activate deactivate of using
    {
        public void AnnouncementStatusToFalse(int id)
        {
            using var context = new AgricultureContext();
            Announcement p = context.Announcements.Find(id);
            p.Status = false;
            context.SaveChanges();
        }

        public void AnnouncementStatusToTrue(int id)
        {
            using var context = new AgricultureContext();
            Announcement p = context.Announcements.Find(id);
            p.Status=true;
            context.SaveChanges();
        }
    }
}
