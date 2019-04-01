using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OData.Client;
using NAVWebAppNetCore.Models;

namespace NAVWebAppNetCore.Controllers
{
    public class NAVContentController : Controller
    {
        NAV.NAV nvv = new NAV.NAV(new Uri("http://localhost:7048/DynamicsNAV130/ODataV4/Company('CRONUS%20CZ%20s.r.o.')"));        

        // GET: NAVContent
        public ActionResult Index()
        {            
            nvv.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
            var queryCustomers = nvv.Customer;
            //var query = (DataServiceQuery<NAV.Customer>)queryCustomers;
            var taskFactory = new TaskFactory<IEnumerable<NAV.Customer>>();
            IEnumerable<NAV.Customer> result = taskFactory.FromAsync(queryCustomers.BeginExecute(null, null), iar => queryCustomers.EndExecute(iar)).Result;
            List<NAVContentClass> custData = result.Select(c => new NAVContentClass(c.No, c.Name)).ToList();

            

            ViewData["Message"] = custData.Count().ToString();
            return View(custData);
            
        }

        // GET: NAVContent/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NAVContent/Create
        public ActionResult Create()
        {
            nvv.AddToCustomer(new NAV.Customer()
            {
                Name = "New cust name"
            });

            try
            {
                nvv.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
            

            return RedirectToAction(nameof(Index));
            //return View(nameof(Index));
        }

        // POST: NAVContent/Create
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

        // GET: NAVContent/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NAVContent/Edit/5
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

        // GET: NAVContent/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NAVContent/Delete/5
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