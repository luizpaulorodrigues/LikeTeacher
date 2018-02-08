using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LP.LikeTeacher.Application;
using LP.LikeTeacher.Application.Interfaces;
using LP.LikeTeacher.Application.ViewModel;
using LP.LikeTeacher.UI.Site.Models;

namespace LP.LikeTeacher.UI.Site.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly ProfessorAppService _professorAppService;

        public ProfessorController()
        {
            _professorAppService = new ProfessorAppService();
        }
        // GET: Professor
        public ActionResult Index()
        {
            return View(_professorAppService.ObterTodos());
        }

        // GET: Professor/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var professorViewModel = _professorAppService.ObterPorId(id.Value);

            if (professorViewModel == null)
            {
                return HttpNotFound();
            }
            return View(professorViewModel);
        }

        // GET: Professor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Professor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProfessorEnderecoViewModel professorEnderecoViewModel)
        {
            if (ModelState.IsValid)
            {
                _professorAppService.Adicionar(professorEnderecoViewModel);
                return RedirectToAction("Index");
            }
            return View(professorEnderecoViewModel);
        }

        // GET: Professor/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var professorViewModel = _professorAppService.ObterPorId(id.Value);

            if (professorViewModel == null)
            {
                return HttpNotFound();
            }
            return View(professorViewModel);
        }

        // POST: Professor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProfessorViewModel professorViewModel)
        {
            if (ModelState.IsValid)
            {
                _professorAppService.Atualizar(professorViewModel);
                return RedirectToAction("Index");
            }
            return View(professorViewModel);
        }

        // GET: Professor/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var professorViewModel = _professorAppService.ObterPorId(id.Value);
            if (professorViewModel == null)
            {
                return HttpNotFound();
            }
            return View(professorViewModel);
        }

        // POST: Professor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
           _professorAppService.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _professorAppService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
