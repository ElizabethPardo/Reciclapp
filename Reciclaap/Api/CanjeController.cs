using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reciclaap.Api
{
    public class CanjeController : Controller
    {
        // GET: CanjeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CanjeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CanjeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CanjeController/Create
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

        // GET: CanjeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CanjeController/Edit/5
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

        // GET: CanjeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CanjeController/Delete/5
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
