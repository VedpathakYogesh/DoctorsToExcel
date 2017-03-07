//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace DptsData.Controllers
//{
//    public class UploadExcelController : Controller
//    {
//        // GET: UploadExcel
//        public ActionResult Index1()
//        {
//            return View();
//        }

//        private bool isValidContentType(string contentType)
//        {
//            return contentType.Equals("Excel.csv") || contentType.Equals("Excel.xlsx"); 
//            //    ||
//            //contentType.Equals("image/png") || contentType.Equals("image.jpg");
//        }

//        private bool isValidContentLength(int contentLength)
//        {
//            return ((contentLength / 1024) / 1024) < 1; // 1MB max
//        }

//        [HttpPost]
//         public ActionResult Process1(HttpPostedFileBase PostedFile)

//        {
//            //if(!isValidContentType(PostedFile.ContentType))
//            //{
//            //    ViewBag.Error = " Only Excel Files are Allowed";
//            //    return View("Index1");

//            //}
//            //return View("Success");

//            if (!isValidContentType(PostedFile.ContentType))
//            {
//                ViewBag.Error = "Only Excel are Allowed.";
//                return View("Index");
//            }
//            else if (!isValidContentLength(PostedFile.ContentLength))
//            {
//                ViewBag.Error = " Should be 1MB Max .";
//                return View("Index1");
//            }
//            // Length Checking
//            else
//            {
//                if (PostedFile.ContentLength > 0)
//                {
//                    var fileName = Path.GetFileName(PostedFile.FileName);
//                    var path = Path.Combine(Server.MapPath("~/Contents/Images"), fileName);
//                    PostedFile.SaveAs(path);
//                    ViewBag.filName = PostedFile.FileName;
//                }
//                ViewBag.fileName = PostedFile.FileName;
//                return View("Success");
//            }

//        }
//    }
//}