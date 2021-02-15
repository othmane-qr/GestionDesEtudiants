using GestionDesEtudiants.Models;
using GestionDesEtudiants.Models.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionDesEtudiants.Controllers
{
    public class EtudiantController : Controller
    {
        private readonly IEtudiantRepository<Etudiant> etudiantRepository;

        public EtudiantController(IEtudiantRepository<Etudiant> etudiantRepository)
        {
            this.etudiantRepository = etudiantRepository;
        }
        // GET: EtudiantController
        public ActionResult Index()
        {
            var etudiants = etudiantRepository.List();
            return View(etudiants);
        }

        // GET: EtudiantController/Details/5
        public ActionResult Details(int id)
        {
            var etudiants = etudiantRepository.Find(id);
            return View(etudiants);
        }

        // GET: EtudiantController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EtudiantController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Etudiant etudiant)
        {
            try
            {
                etudiantRepository.Add(etudiant);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EtudiantController/Edit/5
        public ActionResult Edit(int id)
        {
            var etudiant = etudiantRepository.Find(id);
            return View(etudiant);
        }

        // POST: EtudiantController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Etudiant etudiant)
        {
            try
            {
                etudiantRepository.Update(id, etudiant);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EtudiantController/Delete/5
        public ActionResult Delete(int id)
        {
            var etudiant = etudiantRepository.Find(id);
            return View(etudiant);
        }

        // POST: EtudiantController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Etudiant etudiant)
        {
            try
            {
                etudiantRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
