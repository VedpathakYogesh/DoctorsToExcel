using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DptsData.Models;
using System.IO;
using System.Net;

namespace DptsData.Controllers
{
    public class FileProcessController : Controller
    {
        // GET: FileProcess
        //public ActionResult Index()
        //{
        //    return View();
        //}
        DownloadFiles obj;
        public FileProcessController()
        {
            obj = new DownloadFiles();
        }

        public ActionResult Index()
        {
            var filesCollection = obj.GetFiles();
            return View(filesCollection);
        }

        public FileResult Download(string FileID)
        {
            int CurrentFileID = Convert.ToInt32(FileID);
            var filesCol = obj.GetFiles();
            string CurrentFileName = (from fls in filesCol
                                      where fls.FileId == CurrentFileID
                                      select fls.FilePath).First();
            //FileID.Delete(FileID);


            string contentType = string.Empty;

            if (CurrentFileName.Contains(".csv"))
            {
                contentType = "application/pdf";
            }

            else if (CurrentFileName.Contains(".docx"))
            {
                contentType = "application/docx";
            }
            return File(CurrentFileName, contentType, CurrentFileName);
        }
       
        
        

    }
   
}
