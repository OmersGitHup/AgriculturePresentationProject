using DataAccsessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
    public class _DashboardOverviewPartial:ViewComponent
    {
        AgricultureContext c=new AgricultureContext();
        public IViewComponentResult Invoke() 
        {
            ViewBag.teamCount = c.Teams.Count();
            ViewBag.serviceCount = c.Services.Count();
            ViewBag.messageCount=c.Contacts.Count();
            ViewBag.currentMonthMessage = c.Contacts.Where(x => x.Date.Month == DateTime.Now.Month).Count();

            ViewBag.announcementTrue=c.Announcements.Where(x=>x.Status==true).Count();
            ViewBag.announcementFalse = c.Announcements.Where(x => x.Status == false).Count();

            ViewBag.zym=c.Teams.Where(x=>x.Title== "Ziraat Yüksek Mühendisi").Select(y=>y.PersonName).FirstOrDefault();
            ViewBag.bb = c.Teams.Where(x => x.Title == "Botanik Bilimci").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.py = c.Teams.Where(x => x.Title == "Pazarlama Yöneticisi").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.zm = c.Teams.Where(x => x.Title == "Ziraat Mühendisi").Select(y => y.PersonName).FirstOrDefault();
            return View(); 
        
        }
    }
}
