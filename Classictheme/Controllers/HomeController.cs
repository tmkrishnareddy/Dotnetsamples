using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Collections.Generic;
using System.Xml.Serialization;
using Classictheme.Models;
using System.IO;

namespace Classictheme.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult CarInfo()
        {
            List<CarDetails> cars = new List<CarDetails>();

            XmlDocument doc = new XmlDocument();
            doc.Load(Server.MapPath(@"~\App_Data\Cars.xml"));

            foreach (XmlNode node in doc.SelectNodes("/Cars/Car"))
            {
                cars.Add(new CarDetails
                {
                    StockNumber = node["StockNumber"].InnerText,
                    Make=node["Make"].InnerText,
                    Model=node["Model"].InnerText
                });
            }
            return View(cars);
        }
        //
        // GET: /Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Home/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home/Create
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

        //
        // GET: /Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Home/Edit/5
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

        //
        // GET: /Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Home/Delete/5
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
