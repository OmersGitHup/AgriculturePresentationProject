using BusinessLayer.Concrete;
using DataAccsessLayer.Concrete.EntityFreamework;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class DefaultController : Controller
    {
       
        public IActionResult Index()
        {
           
            return View();
        }
    }
}
