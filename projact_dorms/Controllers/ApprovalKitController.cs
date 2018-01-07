using projact_dorms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Bson;
using MongoDB.Driver.Builders;

namespace projact_dorms.Controllers
{
    public class ApprovalKitController : Controller
    {


        private readonly DBmanger Context = new DBmanger();

        // GET: User
        public ActionResult Index()
        {
            var Approv = Context.ApprovalKit.FindAll().SetSortOrder(SortBy<ApprovalKit>.Ascending(u => u.Last_name));
            return View(Approv);
        }

        // GET: User/Details/5
        public ActionResult Details(String Id)
        {
            var Approv = Context.ApprovalKit.FindOneById(new ObjectId(Id));
            return View(Approv);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(ApprovalKit Approv)
        {
            if (ModelState.IsValid)
            {
                Context.ApprovalKit.Save(Approv);
                return RedirectToAction("index");
            }
            return View();
        }

        // GET: User/Edit/5
        public ActionResult Edit(String Id)
        {
            var Approv = Context.ApprovalKit.FindOneById(new ObjectId(Id));
            return View(Approv);
        }


        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(ApprovalKit Approv)
        {
            if (ModelState.IsValid)
            {
                Context.ApprovalKit.Save(Approv);
                return RedirectToAction("index");
            }
            return View();

        }

        // GET: User/Delete/5
        public ActionResult Delete(String Id)
        {
            var rental = Context.ApprovalKit.FindOneById(new ObjectId(Id));
            return View(rental);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(String Id)
        {
            var rental = Context.ApprovalKit.Remove(Query.EQ("_id", new ObjectId(Id)));
            return RedirectToAction("Index");

        }
    }
}
