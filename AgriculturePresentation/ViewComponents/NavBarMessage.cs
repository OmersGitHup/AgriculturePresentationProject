using BusinessLayer.Concrete;
using DataAccsessLayer.Concrete.EntityFreamework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgriculturePresentation.ViewComponents
{
    public class NavBarMessage:ViewComponent
    {

        ContactManager contactManager = new ContactManager(new EfContactDal());
        public IViewComponentResult Invoke()
        {
            var values = contactManager.GetListAll();
            return View(values);
        }
    }
}
