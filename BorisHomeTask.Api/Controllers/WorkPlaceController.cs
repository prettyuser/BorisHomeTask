using BorisHomeTask.Domain.Entities.Application;
using BorisHomeTask.Manager.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BorisHomeTask.Api.Controllers
{
    public class WorkPlaceController : Controller
    {
        IWorkPlaceService _workPlaceService;
        IUserService _userService;
        public WorkPlaceController(IWorkPlaceService workPlaceService, IUserService userService)
        {
            _workPlaceService = workPlaceService;
            _userService = userService;
        }

        // GET: /WorkPlace/ 
        public ActionResult Index()
        {
            return View(_workPlaceService.GetAll());
        }

        // GET: /WorkPlace/Details/5 
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkPlace workPlace = _workPlaceService.GetById(id.Value);
            if (workPlace == null)
            {
                return HttpNotFound();
            }
            return View(workPlace);
        }

        // GET: /WorkPlace/Create 
        public ActionResult Create()
        {
            ViewBag.UserId = new SelectList(_userService.GetAll(), "Id", "Name");
            return View();
        }

        // POST: /WorkPlace/Create 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CompanyName,StartDate,EndDate,UserId")] WorkPlace workPlace)
        {
            if (ModelState.IsValid)
            {
                _workPlaceService.Create(workPlace);
                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(_userService.GetAll(), "Id", "Name", workPlace.UserId);
            return View(workPlace);
        }

        // GET: /WorkPlace/Edit/5 
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkPlace workPlace = _workPlaceService.GetById(id.Value);
            if (workPlace == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserId = new SelectList(_userService.GetAll(), "Id", "Name", workPlace.UserId);
            return View(workPlace);
        }

        // POST: /WorkPlace/Edit/5  
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CompanyName,StartDate,EndDate,UserId")] WorkPlace workPlace)
        {
            if (ModelState.IsValid)
            {
                _workPlaceService.Update(workPlace);
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(_userService.GetAll(), "Id", "Name", workPlace.UserId);
            return View(workPlace);
        }

        // GET: /WorkPlace/Delete/5 
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkPlace workPlace = _workPlaceService.GetById(id.Value);
            if (workPlace == null)
            {
                return HttpNotFound();
            }
            return View(workPlace);
        }

        // POST: /WorkPlace/Delete/5 
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WorkPlace workPlace = _workPlaceService.GetById(id);
            _workPlaceService.Delete(workPlace);
            return RedirectToAction("Index");
        }
    }
}