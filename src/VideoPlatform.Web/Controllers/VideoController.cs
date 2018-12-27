using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

namespace VideoPlatform.Web.Controllers
{
    public class VideoController : Controller
    {
        // GET: Video
        public ActionResult Index()
        {
            return View();
        }

        // GET: Video/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Video/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetVideoContent()
        {

            var fs = System.IO.File.OpenRead("13971005001073_360P.mp4");
            return new FileStreamResult(fs, "video/mp4");
            
            
        }

        // POST: Video/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Video/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Video/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Video/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Video/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}