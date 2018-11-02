using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RegistroNotas;
using RegistroNotas.Models;

namespace RegistroNotas.Controllers
{
    public class PeriodoLectivoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        public ActionResult MostrarPeriodo()
        {
            var listaPeriodos = db.Database.SqlQuery<Periodo>("sp_ListarPeriodoLectivo @Activo",new SqlParameter("@Activo",1)).ToList();
            return View(listaPeriodos);
        }

        public ActionResult MostrarGrupos(int idProfe, int idPeriodo)
        {
            var listaGrupos = db.Database.SqlQuery<Grupos>("sp_ListarGrupo @Activo,@IdProfesor,@IdPeriodo",
                new SqlParameter("@Activo", 1),
                new SqlParameter("@IdProfesor", idProfe),
                new SqlParameter("@IdPeriodo", idPeriodo)
                ).ToList();
            return View(listaGrupos);
        }
        // GET: PeriodoLectivo
        public ActionResult Index()
        {
            var periodoLectivo = db.PeriodoLectivo.Include(p => p.Modalidad);
            return View(periodoLectivo.ToList());
        }
        // GET: PeriodoLectivo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PeriodoLectivo periodoLectivo = db.PeriodoLectivo.Find(id);
            if (periodoLectivo == null)
            {
                return HttpNotFound();
            }
            return View(periodoLectivo);
        }

        // GET: PeriodoLectivo/Create
        public ActionResult Create()
        {
            ViewBag.IdModalidad = new SelectList(db.Modalidad, "IdModalidad", "NombreModalidad");
            return View();
        }

        // POST: PeriodoLectivo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdPeriodo,IdModalidad,FechaInicio,FechaFin,NombrePeriodo,Activo")] PeriodoLectivo periodoLectivo)
        {
            if (ModelState.IsValid)
            {
                db.PeriodoLectivo.Add(periodoLectivo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdModalidad = new SelectList(db.Modalidad, "IdModalidad", "NombreModalidad", periodoLectivo.IdModalidad);
            return View(periodoLectivo);
        }

        // GET: PeriodoLectivo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PeriodoLectivo periodoLectivo = db.PeriodoLectivo.Find(id);
            if (periodoLectivo == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdModalidad = new SelectList(db.Modalidad, "IdModalidad", "NombreModalidad", periodoLectivo.IdModalidad);
            return View(periodoLectivo);
        }

        // POST: PeriodoLectivo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdPeriodo,IdModalidad,FechaInicio,FechaFin,NombrePeriodo,Activo")] PeriodoLectivo periodoLectivo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(periodoLectivo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdModalidad = new SelectList(db.Modalidad, "IdModalidad", "NombreModalidad", periodoLectivo.IdModalidad);
            return View(periodoLectivo);
        }

        // GET: PeriodoLectivo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PeriodoLectivo periodoLectivo = db.PeriodoLectivo.Find(id);
            if (periodoLectivo == null)
            {
                return HttpNotFound();
            }
            return View(periodoLectivo);
        }

        // POST: PeriodoLectivo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PeriodoLectivo periodoLectivo = db.PeriodoLectivo.Find(id);
            db.PeriodoLectivo.Remove(periodoLectivo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
