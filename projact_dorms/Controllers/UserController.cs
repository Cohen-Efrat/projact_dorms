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
    public class UserController : Controller
    {
        private readonly DBmanger Context = new DBmanger();
        // GET: User
        public ActionResult Index()
        {
            var Users = Context.Users.FindAll().SetSortOrder(SortBy<User>.Ascending(u => u.Email));
            return View(Users);
        }

        // GET: User/Details/5
        public ActionResult Details(String Id)
        {
            var User = Context.Users.FindOneById(new ObjectId(Id));
            return View(User);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(User _user)
        {
            if (ModelState.IsValid)
            {
                Context.Users.Save(_user);
                return RedirectToAction("index");
            }
            return View();
        }

        // GET: User/Edit/5
        public ActionResult Edit(String Id)
        {
            var User = Context.Users.FindOneById(new ObjectId(Id));
            return View(User);
        }


        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(User _user)
        {
            if (ModelState.IsValid)
            {
                Context.Users.Save(_user);
                return RedirectToAction("index");
            }
            return View();

        }

        // GET: User/Delete/5
        public ActionResult Delete(String Id)
        {
            var rental = Context.Users.FindOneById(new ObjectId(Id));
            return View(rental);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(String Id)
        {
            var rental = Context.Users.Remove(Query.EQ("_id", new ObjectId(Id)));
            return RedirectToAction("Index");

        }
    }
}

