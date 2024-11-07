using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using NHPhuc_QuanLyBanHang.Models;

namespace NHPhuc_QuanLyBanHang.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        // GET: Admin/Account
        public ActionResult Index()
        {
            return View();
        }
        // POST: /Account/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
              

                TempData["SuccessMessage"] = "Registration successful!";
                return RedirectToAction("RegisterSuccess");
            }

            return View(model);
        }

        // GET: /Account/RegisterSuccess
        public ActionResult RegisterSuccess()
        {
            return View();
        }
    }
}