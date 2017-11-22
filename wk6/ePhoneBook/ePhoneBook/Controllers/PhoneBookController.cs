using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ePhoneBook.Controllers
{
    public class PhoneBookController : Controller
    {
        private static List<PhoneBookModel> phoneBookModels;
        public static List<PhoneBookModel> PhoneBooks
        {
            get
            {
                if (phoneBookModels == null)
                {
                    phoneBookModels = new List<PhoneBookModel>();
                    phoneBookModels.Add(new PhoneBookModel
                    {
                        FirstName = "Yong Kheng Neaven", 

                    }
                    );
                }
                return phoneBookModels;
        }
        
        // GET: PhoneBook
        public ActionResult Index()
        {
            return View();
        }

        // GET: PhoneBook/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PhoneBook/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PhoneBook/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PhoneBook/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PhoneBook/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PhoneBook/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PhoneBook/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
