using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reciclaap.Api
{
    public class LocalController : Controller
    {
        // GET: LocalController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LocalController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LocalController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LocalController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LocalController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LocalController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LocalController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LocalController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
