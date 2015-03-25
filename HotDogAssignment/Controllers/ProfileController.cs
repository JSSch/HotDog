using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotDogAssignment.Models;

namespace HotDogAssignment.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {
            return View(Profiles.Profile);
        }

        public ActionResult AddDog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDog(AddHotDogViewModel model)
        {
            string HotDogTitle = model.DogTitle;
            string HotDogDate = model.DateOfDog;
            string FullDog = HotDogTitle + " (" + HotDogDate + ")";
            Profiles.Profile.HotDogs.Add(FullDog);
            return RedirectToAction("Index");
        }

        // GET: Profile/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Profile/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Profile/Create
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

        // GET: Profile/Edit/5
        public ActionResult Edit()
        {
            EditorViewModel model = new EditorViewModel()
            {
                Bio = Profiles.Profile.Bio,
                Date = Profiles.Profile.Date,
                FavoriteDog = Profiles.Profile.FavoriteDog,
                LastDog = Profiles.Profile.LastDog,
                Name = Profiles.Profile.Name,
                ProfilePic = Profiles.Profile.ProfilePic
            };
            return View(model);
        }

        // POST: Profile/Edit/5
        [HttpPost]
        public ActionResult Edit(EditorViewModel model)
        {
            try
            {
                Profiles.Profile.Bio = model.Bio;
                Profiles.Profile.Date = model.Date;
                Profiles.Profile.FavoriteDog = model.FavoriteDog;
                Profiles.Profile.LastDog = model.LastDog;
                Profiles.Profile.Name = model.Name;
                Profiles.Profile.ProfilePic = model.ProfilePic;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Profile/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Profile/Delete/5
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
