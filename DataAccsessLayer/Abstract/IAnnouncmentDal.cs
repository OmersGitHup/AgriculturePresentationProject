using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Abstract
{
    public interface IAnnouncmentDal:IGenericDal<Announcement>
    {

        //Activate Deactivate of using 
        void AnnouncementStatusToTrue(int id);
        void AnnouncementStatusToFalse(int id);

    }
}
