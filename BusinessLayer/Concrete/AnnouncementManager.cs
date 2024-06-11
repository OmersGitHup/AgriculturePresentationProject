using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncmentDal _announcmentDal;

        public AnnouncementManager(IAnnouncmentDal announcmentDal)
        {
            _announcmentDal = announcmentDal;
        }

        public void AnnouncementStatusToFalse(int id)
        {
            _announcmentDal.AnnouncementStatusToFalse(id);
        }

        public void AnnouncementStatusToTrue(int id)
        {
            _announcmentDal.AnnouncementStatusToTrue(id);
        }

        public void Delete(Announcement t)
        {
            _announcmentDal.Delete(t);
        }

        public Announcement GetById(int id)
        {
            return _announcmentDal.GetById(id);
        }

        public List<Announcement> GetListAll()
        {
            return _announcmentDal.GetListAll();
        }

        public void Insert(Announcement t)
        {
            _announcmentDal.Insert(t);
        }

        public void Update(Announcement t)
        {
            _announcmentDal.Update(t);
        }
    }
}
