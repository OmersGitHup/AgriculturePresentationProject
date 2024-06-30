using AgriculturePresentation.Models;
using ClosedXML.Excel;
using DataAccsessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;

namespace AgriculturePresentation.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StaticReport() {

            ExcelPackage excelPackage = new ExcelPackage();
            var workBook=excelPackage.Workbook.Worksheets.Add("Document1");
            workBook.Cells[1, 1].Value = "Product Name";
            workBook.Cells[1, 2].Value = "Product Category";
            workBook.Cells[1, 3].Value = "Product Stock";

            workBook.Cells[2, 1].Value = "Mercimek";
            workBook.Cells[2, 2].Value = "Bakliyat";
            workBook.Cells[2, 3].Value = "700 Kg";

            workBook.Cells[3, 1].Value = "Buğday";
            workBook.Cells[3, 2].Value = "Bakliyat";
            workBook.Cells[3, 3].Value = "1980 Kg";

            workBook.Cells[4, 1].Value = "Havuç";
            workBook.Cells[4, 2].Value = "Sebze";
            workBook.Cells[4, 3].Value = "160 Kg";

            var bytes=excelPackage.GetAsByteArray();
            return File(bytes,"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","BakliyatRaporu.xlsx");
        
        }


        //Excel verisi için ;for excel values
        public List<ContactModel> ContactList()
        {
            List<ContactModel> contactModels = new List<ContactModel>();
            using (var context = new AgricultureContext())
            {
                contactModels=context.Contacts.Select(x=>new ContactModel{
                    ContactID=x.ContactID,
                    ContactName =x.Name,
                    Contactmail =x.Mail,
                    ContactDate=x.Date,
                    ContactMessage=x.Message

                }).ToList();

            }
            return contactModels;
        }

        public IActionResult ContactReport()
        {
            using (var workBook = new XLWorkbook())
            {

                var workSheet = workBook.Worksheets.Add("Message List");
                workSheet.Cell(1, 1).Value = "Message ID";
                workSheet.Cell(1, 2).Value = "Sended By";
                workSheet.Cell(1, 3).Value = "Mail";
                workSheet.Cell(1, 4).Value = "Message Content";
                workSheet.Cell(1, 5).Value = "Message Date";

                int contactRowCount = 2;
                foreach(var item in ContactList())
                {
                    workSheet.Cell(contactRowCount,1).Value= item.ContactID;
                    workSheet.Cell(contactRowCount, 2).Value = item.ContactName;
                    workSheet.Cell(contactRowCount, 3).Value = item.Contactmail;
                    workSheet.Cell(contactRowCount, 4).Value = item.ContactMessage;
                    workSheet.Cell(contactRowCount, 5).Value = item.ContactDate;
                    contactRowCount++;
                }

                //var bytes = excelPackage.GetAsByteArray();
                //return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "BakliyatRaporu.xlsx");

                using (var stream=new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content=stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "MessageReport.xlsx");
                }
            }

         
        }

        public List<AnnouncementModel> AnnouncementList()
        {
            List<AnnouncementModel> announcementModels = new List<AnnouncementModel>();
            using (var context = new AgricultureContext())
            {
                announcementModels = context.Announcements.Select(x => new AnnouncementModel
                {
                    Id = x.AnnouncementId,
                    Status=x.Status,
                    Date = x.Date,
                    Description=x.Description,
                    Title=x.Title,
                  

                }).ToList();

            }
            return announcementModels;
        }

        public IActionResult AnnouncementReport()
        {
            using (var workBook = new XLWorkbook())
            {

                var workSheet = workBook.Worksheets.Add("Message List");
                workSheet.Cell(1, 1).Value = "Announcement Id";
                workSheet.Cell(1, 2).Value = "Title";
                workSheet.Cell(1, 3).Value = "Description";
                workSheet.Cell(1, 4).Value = "Date";
                workSheet.Cell(1, 5).Value = "Status";

                int contactRowCount = 2;
                foreach (var item in AnnouncementList())
                {
                    workSheet.Cell(contactRowCount, 1).Value = item.Id;
                    workSheet.Cell(contactRowCount, 2).Value = item.Title;
                    workSheet.Cell(contactRowCount, 3).Value = item.Description;
                    workSheet.Cell(contactRowCount, 4).Value = item.Date;
                    workSheet.Cell(contactRowCount, 5).Value = item.Status;
                    contactRowCount++;
                }

                //var bytes = excelPackage.GetAsByteArray();
                //return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "BakliyatRaporu.xlsx");

                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "AnnouncementReport.xlsx");
                }
            }


        }
    }
}
