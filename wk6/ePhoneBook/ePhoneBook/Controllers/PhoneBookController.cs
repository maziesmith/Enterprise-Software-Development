using ePhoneBook.Models;
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
                        LastName = "Seo",
                        Email = "neaven_seo@nyp.edu.sg",
                        MobileNumber = "6550 1623"
                    }
                    );
                }
                return phoneBookModels;
            }
        }
        
        // GET: PhoneBook
        public ActionResult Index()
        {
            return View(PhoneBooks);
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
        public ActionResult Create(PhoneBookModel phoneBookModel)
        {
            try
            {
                // TODO: Add insert logic here
                PhoneBooks.Add(phoneBookModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PhoneBook/Edit/5
        public ActionResult Edit(String mobileNumber)
        {
            return View(PhoneBooks.FirstOrDefault(pbm => String.Compare(pbm.MobileNumber,mobileNumber) == 0));
        }

        // POST: PhoneBook/Edit/5
        [HttpPost]
        public ActionResult Edit(String mobileNumber, PhoneBookModel phoneBookModel)
        {
            try
            {
                // TODO: Add update logic here
                PhoneBooks.Where(pbm => String.Compare(pbm.MobileNumber, mobileNumber) == 0)
                    .ToList().ForEach(pbm => { pbm = phoneBookModel; });
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PhoneBook/Delete/5
        public ActionResult Delete(String mobileNumber)
        {
            PhoneBooks.RemoveAll(pbm => String.Compare(pbm.MobileNumber, mobileNumber) == 0);
            return RedirectToAction("Index");
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
