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
    public class GrupoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult MostrarGrupos(int idProfe,int idPeriodo)
        {
            var listaGrupos = db.Database.SqlQuery<Grupos>("sp_ListarGrupo @Activo,@IdProfesor,@IdPeriodo",
                new SqlParameter("@Activo", 1),
                new SqlParameter("@IdProfesor", idProfe),
                new SqlParameter("@IdPeriodo", idPeriodo)
                ).ToList();
            return View(listaGrupos);
        }

        // GET: Grupo
        public ActionResult Index()
        {
            var grupo = db.Grupo.Include(g => g.Curso).Include(g => g.EstadoGrupo1).Include(g => g.PeriodoLectivo).Include(g => g.Profesor);
            return View(grupo.ToList());
        }

        // GET: Grupo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grupo grupo = db.Grupo.Find(id);
            if (grupo == null)
            {
                return HttpNotFound();
            }
            return View(grupo);
        }

        // GET: Grupo/Create
        public ActionResult Create()
        {
            ViewBag.IdCurso = new SelectList(db.Curso, "IdCurso", "NombreCurso");
            ViewBag.EstadoGrupo = new SelectList(db.EstadoGrupo, "IdEstadoGrupo", "Descripcion");
            ViewBag.IdPeriodo = new SelectList(db.PeriodoLectivo, "IdPeriodo", "NombrePeriodo");
            ViewBag.IdProfesor = new SelectList(db.Profesor, "IdProfesor", "Cedula");
            return View();
        }

        // POST: Grupo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdGrupo,Hora,Aula,EstadoGrupo,IdCurso,IdProfesor,IdPeriodo,Activo")] Grupo grupo)
        {
            if (ModelState.IsValid)
            {
                db.Grupo.Add(grupo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdCurso = new SelectList(db.Curso, "IdCurso", "NombreCurso", grupo.IdCurso);
            ViewBag.EstadoGrupo = new SelectList(db.EstadoGrupo, "IdEstadoGrupo", "Descripcion", grupo.EstadoGrupo);
            ViewBag.IdPeriodo = new SelectList(db.PeriodoLectivo, "IdPeriodo", "NombrePeriodo", grupo.IdPeriodo);
            ViewBag.IdProfesor = new SelectList(db.Profesor, "IdProfesor", "Cedula", grupo.IdProfesor);
            return View(grupo);
        }

        // GET: Grupo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grupo grupo = db.Grupo.Find(id);
            if (grupo == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdCurso = new SelectList(db.Curso, "IdCurso", "NombreCurso", grupo.IdCurso);
            ViewBag.EstadoGrupo = new SelectList(db.EstadoGrupo, "IdEstadoGrupo", "Descripcion", grupo.EstadoGrupo);
            ViewBag.IdPeriodo = new SelectList(db.PeriodoLectivo, "IdPeriodo", "NombrePeriodo", grupo.IdPeriodo);
            ViewBag.IdProfesor = new SelectList(db.Profesor, "IdProfesor", "Cedula", grupo.IdProfesor);
            return View(grupo);
        }

        // POST: Grupo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdGrupo,Hora,Aula,EstadoGrupo,IdCurso,IdProfesor,IdPeriodo,Activo")] Grupo grupo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(grupo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCurso = new SelectList(db.Curso, "IdCurso", "NombreCurso", grupo.IdCurso);
            ViewBag.EstadoGrupo = new SelectList(db.EstadoGrupo, "IdEstadoGrupo", "Descripcion", grupo.EstadoGrupo);
            ViewBag.IdPeriodo = new SelectList(db.PeriodoLectivo, "IdPeriodo", "NombrePeriodo", grupo.IdPeriodo);
            ViewBag.IdProfesor = new SelectList(db.Profesor, "IdProfesor", "Cedula", grupo.IdProfesor);
            return View(grupo);
        }

        // GET: Grupo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grupo grupo = db.Grupo.Find(id);
            if (grupo == null)
            {
                return HttpNotFound();
            }
            return View(grupo);
        }

        // POST: Grupo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Grupo grupo = db.Grupo.Find(id);
            db.Grupo.Remove(grupo);
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
