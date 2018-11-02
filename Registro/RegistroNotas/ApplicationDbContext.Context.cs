﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistroNotas
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("name=ApplicationDbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<EstadoEstudiante> EstadoEstudiante { get; set; }
        public virtual DbSet<EstadoGrupo> EstadoGrupo { get; set; }
        public virtual DbSet<Estudiante> Estudiante { get; set; }
        public virtual DbSet<EstudianteGrupo> EstudianteGrupo { get; set; }
        public virtual DbSet<Evaluacion> Evaluacion { get; set; }
        public virtual DbSet<EvaluacionEstudiante> EvaluacionEstudiante { get; set; }
        public virtual DbSet<Grupo> Grupo { get; set; }
        public virtual DbSet<Modalidad> Modalidad { get; set; }
        public virtual DbSet<PeriodoLectivo> PeriodoLectivo { get; set; }
        public virtual DbSet<Profesor> Profesor { get; set; }
        public virtual DbSet<Rubrica> Rubrica { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TipoEvaluacion> TipoEvaluacion { get; set; }
    
        public virtual int sp_AgregarCurso(string nombreCurso, string codCurso)
        {
            var nombreCursoParameter = nombreCurso != null ?
                new ObjectParameter("NombreCurso", nombreCurso) :
                new ObjectParameter("NombreCurso", typeof(string));
    
            var codCursoParameter = codCurso != null ?
                new ObjectParameter("CodCurso", codCurso) :
                new ObjectParameter("CodCurso", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AgregarCurso", nombreCursoParameter, codCursoParameter);
        }
    
        public virtual int sp_AgregarEstadoEstudiante(string descripcion)
        {
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AgregarEstadoEstudiante", descripcionParameter);
        }
    
        public virtual int sp_AgregarEstadoGrupo(string descripcion)
        {
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AgregarEstadoGrupo", descripcionParameter);
        }
    
        public virtual int sp_AgregarEstudiantes(string carnet, string nombre, string primerApellido, string segundoApellido, string email, string telefono)
        {
            var carnetParameter = carnet != null ?
                new ObjectParameter("Carnet", carnet) :
                new ObjectParameter("Carnet", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var primerApellidoParameter = primerApellido != null ?
                new ObjectParameter("PrimerApellido", primerApellido) :
                new ObjectParameter("PrimerApellido", typeof(string));
    
            var segundoApellidoParameter = segundoApellido != null ?
                new ObjectParameter("SegundoApellido", segundoApellido) :
                new ObjectParameter("SegundoApellido", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AgregarEstudiantes", carnetParameter, nombreParameter, primerApellidoParameter, segundoApellidoParameter, emailParameter, telefonoParameter);
        }
    
        public virtual int sp_AgregarEstudiantesXGrupo(Nullable<int> idEstudiante, Nullable<int> idGrupo)
        {
            var idEstudianteParameter = idEstudiante.HasValue ?
                new ObjectParameter("IdEstudiante", idEstudiante) :
                new ObjectParameter("IdEstudiante", typeof(int));
    
            var idGrupoParameter = idGrupo.HasValue ?
                new ObjectParameter("IdGrupo", idGrupo) :
                new ObjectParameter("IdGrupo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AgregarEstudiantesXGrupo", idEstudianteParameter, idGrupoParameter);
        }
    
        public virtual int sp_AgregarEvaluaciones(Nullable<int> idRubrica, Nullable<System.DateTime> fechaAplicacion, string descripcion, Nullable<double> porcentajeAsig)
        {
            var idRubricaParameter = idRubrica.HasValue ?
                new ObjectParameter("IdRubrica", idRubrica) :
                new ObjectParameter("IdRubrica", typeof(int));
    
            var fechaAplicacionParameter = fechaAplicacion.HasValue ?
                new ObjectParameter("FechaAplicacion", fechaAplicacion) :
                new ObjectParameter("FechaAplicacion", typeof(System.DateTime));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var porcentajeAsigParameter = porcentajeAsig.HasValue ?
                new ObjectParameter("PorcentajeAsig", porcentajeAsig) :
                new ObjectParameter("PorcentajeAsig", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AgregarEvaluaciones", idRubricaParameter, fechaAplicacionParameter, descripcionParameter, porcentajeAsigParameter);
        }
    
        public virtual int sp_AgregarEvaluacionesXEstudiante(Nullable<int> idEvaluacion, Nullable<double> notaObtenida)
        {
            var idEvaluacionParameter = idEvaluacion.HasValue ?
                new ObjectParameter("IdEvaluacion", idEvaluacion) :
                new ObjectParameter("IdEvaluacion", typeof(int));
    
            var notaObtenidaParameter = notaObtenida.HasValue ?
                new ObjectParameter("NotaObtenida", notaObtenida) :
                new ObjectParameter("NotaObtenida", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AgregarEvaluacionesXEstudiante", idEvaluacionParameter, notaObtenidaParameter);
        }
    
        public virtual int sp_AgregarEvaluacionFija(Nullable<int> idRubrica, Nullable<System.DateTime> fechaAplicacion, string descripcion, Nullable<double> porcentajeAsig)
        {
            var idRubricaParameter = idRubrica.HasValue ?
                new ObjectParameter("IdRubrica", idRubrica) :
                new ObjectParameter("IdRubrica", typeof(int));
    
            var fechaAplicacionParameter = fechaAplicacion.HasValue ?
                new ObjectParameter("FechaAplicacion", fechaAplicacion) :
                new ObjectParameter("FechaAplicacion", typeof(System.DateTime));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var porcentajeAsigParameter = porcentajeAsig.HasValue ?
                new ObjectParameter("PorcentajeAsig", porcentajeAsig) :
                new ObjectParameter("PorcentajeAsig", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AgregarEvaluacionFija", idRubricaParameter, fechaAplicacionParameter, descripcionParameter, porcentajeAsigParameter);
        }
    
        public virtual int sp_AgregarEvaluacionVariada(Nullable<int> idRubrica, Nullable<System.DateTime> fechaAplicacion, string descripcion)
        {
            var idRubricaParameter = idRubrica.HasValue ?
                new ObjectParameter("IdRubrica", idRubrica) :
                new ObjectParameter("IdRubrica", typeof(int));
    
            var fechaAplicacionParameter = fechaAplicacion.HasValue ?
                new ObjectParameter("FechaAplicacion", fechaAplicacion) :
                new ObjectParameter("FechaAplicacion", typeof(System.DateTime));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AgregarEvaluacionVariada", idRubricaParameter, fechaAplicacionParameter, descripcionParameter);
        }
    
        public virtual int sp_AgregarGrupo(Nullable<System.DateTime> hora, string aula, Nullable<int> idCurso, Nullable<int> idProfesor, Nullable<int> idPeriodo)
        {
            var horaParameter = hora.HasValue ?
                new ObjectParameter("Hora", hora) :
                new ObjectParameter("Hora", typeof(System.DateTime));
    
            var aulaParameter = aula != null ?
                new ObjectParameter("Aula", aula) :
                new ObjectParameter("Aula", typeof(string));
    
            var idCursoParameter = idCurso.HasValue ?
                new ObjectParameter("IdCurso", idCurso) :
                new ObjectParameter("IdCurso", typeof(int));
    
            var idProfesorParameter = idProfesor.HasValue ?
                new ObjectParameter("IdProfesor", idProfesor) :
                new ObjectParameter("IdProfesor", typeof(int));
    
            var idPeriodoParameter = idPeriodo.HasValue ?
                new ObjectParameter("IdPeriodo", idPeriodo) :
                new ObjectParameter("IdPeriodo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AgregarGrupo", horaParameter, aulaParameter, idCursoParameter, idProfesorParameter, idPeriodoParameter);
        }
    
        public virtual int sp_AgregarModalidad(string nombreModalidad)
        {
            var nombreModalidadParameter = nombreModalidad != null ?
                new ObjectParameter("NombreModalidad", nombreModalidad) :
                new ObjectParameter("NombreModalidad", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AgregarModalidad", nombreModalidadParameter);
        }
    
        public virtual int sp_AgregarPeriodoLectivo(string modalidad, Nullable<System.DateTime> fechaInicio, Nullable<System.DateTime> fechaFin, string nombrePeriodo)
        {
            var modalidadParameter = modalidad != null ?
                new ObjectParameter("Modalidad", modalidad) :
                new ObjectParameter("Modalidad", typeof(string));
    
            var fechaInicioParameter = fechaInicio.HasValue ?
                new ObjectParameter("FechaInicio", fechaInicio) :
                new ObjectParameter("FechaInicio", typeof(System.DateTime));
    
            var fechaFinParameter = fechaFin.HasValue ?
                new ObjectParameter("FechaFin", fechaFin) :
                new ObjectParameter("FechaFin", typeof(System.DateTime));
    
            var nombrePeriodoParameter = nombrePeriodo != null ?
                new ObjectParameter("NombrePeriodo", nombrePeriodo) :
                new ObjectParameter("NombrePeriodo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AgregarPeriodoLectivo", modalidadParameter, fechaInicioParameter, fechaFinParameter, nombrePeriodoParameter);
        }
    
        public virtual int sp_AgregarProfesor(string cedula, string nombre, string primerApellido, string segundoApellido, string ppassword)
        {
            var cedulaParameter = cedula != null ?
                new ObjectParameter("Cedula", cedula) :
                new ObjectParameter("Cedula", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var primerApellidoParameter = primerApellido != null ?
                new ObjectParameter("PrimerApellido", primerApellido) :
                new ObjectParameter("PrimerApellido", typeof(string));
    
            var segundoApellidoParameter = segundoApellido != null ?
                new ObjectParameter("SegundoApellido", segundoApellido) :
                new ObjectParameter("SegundoApellido", typeof(string));
    
            var ppasswordParameter = ppassword != null ?
                new ObjectParameter("Ppassword", ppassword) :
                new ObjectParameter("Ppassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AgregarProfesor", cedulaParameter, nombreParameter, primerApellidoParameter, segundoApellidoParameter, ppasswordParameter);
        }
    
        public virtual int sp_AgregarRubrica(Nullable<int> idTipoEvaluacion, Nullable<int> idGrupo, Nullable<double> porcentaje, Nullable<int> esCalculado, Nullable<int> cantidad)
        {
            var idTipoEvaluacionParameter = idTipoEvaluacion.HasValue ?
                new ObjectParameter("IdTipoEvaluacion", idTipoEvaluacion) :
                new ObjectParameter("IdTipoEvaluacion", typeof(int));
    
            var idGrupoParameter = idGrupo.HasValue ?
                new ObjectParameter("IdGrupo", idGrupo) :
                new ObjectParameter("IdGrupo", typeof(int));
    
            var porcentajeParameter = porcentaje.HasValue ?
                new ObjectParameter("Porcentaje", porcentaje) :
                new ObjectParameter("Porcentaje", typeof(double));
    
            var esCalculadoParameter = esCalculado.HasValue ?
                new ObjectParameter("EsCalculado", esCalculado) :
                new ObjectParameter("EsCalculado", typeof(int));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("Cantidad", cantidad) :
                new ObjectParameter("Cantidad", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AgregarRubrica", idTipoEvaluacionParameter, idGrupoParameter, porcentajeParameter, esCalculadoParameter, cantidadParameter);
        }
    
        public virtual int sp_AgregarTipoEvaluaciones(string descripcion)
        {
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AgregarTipoEvaluaciones", descripcionParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual ObjectResult<sp_ConsultarEvaluacionRubrica_Result> sp_ConsultarEvaluacionRubrica(Nullable<int> idRubrica)
        {
            var idRubricaParameter = idRubrica.HasValue ?
                new ObjectParameter("IdRubrica", idRubrica) :
                new ObjectParameter("IdRubrica", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ConsultarEvaluacionRubrica_Result>("sp_ConsultarEvaluacionRubrica", idRubricaParameter);
        }
    
        public virtual ObjectResult<sp_ConsultarRubricaGrupo_Result> sp_ConsultarRubricaGrupo(Nullable<int> idGrupo)
        {
            var idGrupoParameter = idGrupo.HasValue ?
                new ObjectParameter("IdGrupo", idGrupo) :
                new ObjectParameter("IdGrupo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ConsultarRubricaGrupo_Result>("sp_ConsultarRubricaGrupo", idGrupoParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_EliminarCurso(string codCurso)
        {
            var codCursoParameter = codCurso != null ?
                new ObjectParameter("CodCurso", codCurso) :
                new ObjectParameter("CodCurso", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminarCurso", codCursoParameter);
        }
    
        public virtual int sp_EliminarEstadoEstudiante(Nullable<int> idEstadoEst)
        {
            var idEstadoEstParameter = idEstadoEst.HasValue ?
                new ObjectParameter("IdEstadoEst", idEstadoEst) :
                new ObjectParameter("IdEstadoEst", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminarEstadoEstudiante", idEstadoEstParameter);
        }
    
        public virtual int sp_EliminarEstadoGrupo(string idEstadoGrupo)
        {
            var idEstadoGrupoParameter = idEstadoGrupo != null ?
                new ObjectParameter("IdEstadoGrupo", idEstadoGrupo) :
                new ObjectParameter("IdEstadoGrupo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminarEstadoGrupo", idEstadoGrupoParameter);
        }
    
        public virtual int sp_EliminarEstudiante(string carnet)
        {
            var carnetParameter = carnet != null ?
                new ObjectParameter("Carnet", carnet) :
                new ObjectParameter("Carnet", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminarEstudiante", carnetParameter);
        }
    
        public virtual int sp_EliminarEstudiantesXGrupo(Nullable<int> idEstGrup)
        {
            var idEstGrupParameter = idEstGrup.HasValue ?
                new ObjectParameter("IdEstGrup", idEstGrup) :
                new ObjectParameter("IdEstGrup", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminarEstudiantesXGrupo", idEstGrupParameter);
        }
    
        public virtual int sp_EliminarEvaluacion(Nullable<int> idEvaluacion)
        {
            var idEvaluacionParameter = idEvaluacion.HasValue ?
                new ObjectParameter("IdEvaluacion", idEvaluacion) :
                new ObjectParameter("IdEvaluacion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminarEvaluacion", idEvaluacionParameter);
        }
    
        public virtual int sp_EliminarEvaluacionXEstudiante(Nullable<int> idEvalEst)
        {
            var idEvalEstParameter = idEvalEst.HasValue ?
                new ObjectParameter("IdEvalEst", idEvalEst) :
                new ObjectParameter("IdEvalEst", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminarEvaluacionXEstudiante", idEvalEstParameter);
        }
    
        public virtual int sp_EliminarGrupo(Nullable<int> idGrupo)
        {
            var idGrupoParameter = idGrupo.HasValue ?
                new ObjectParameter("IdGrupo", idGrupo) :
                new ObjectParameter("IdGrupo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminarGrupo", idGrupoParameter);
        }
    
        public virtual int sp_EliminarModalidad(Nullable<int> idModalidad)
        {
            var idModalidadParameter = idModalidad.HasValue ?
                new ObjectParameter("IdModalidad", idModalidad) :
                new ObjectParameter("IdModalidad", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminarModalidad", idModalidadParameter);
        }
    
        public virtual int sp_EliminarPeriodoLectivo(Nullable<int> idPeriodo)
        {
            var idPeriodoParameter = idPeriodo.HasValue ?
                new ObjectParameter("IdPeriodo", idPeriodo) :
                new ObjectParameter("IdPeriodo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminarPeriodoLectivo", idPeriodoParameter);
        }
    
        public virtual int sp_EliminarProfesor(string cedula)
        {
            var cedulaParameter = cedula != null ?
                new ObjectParameter("Cedula", cedula) :
                new ObjectParameter("Cedula", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminarProfesor", cedulaParameter);
        }
    
        public virtual int sp_EliminarRubrica(Nullable<int> idRubrica)
        {
            var idRubricaParameter = idRubrica.HasValue ?
                new ObjectParameter("IdRubrica", idRubrica) :
                new ObjectParameter("IdRubrica", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminarRubrica", idRubricaParameter);
        }
    
        public virtual int sp_EliminarTipoEvaluacion(Nullable<int> idEvaluacion)
        {
            var idEvaluacionParameter = idEvaluacion.HasValue ?
                new ObjectParameter("IdEvaluacion", idEvaluacion) :
                new ObjectParameter("IdEvaluacion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminarTipoEvaluacion", idEvaluacionParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_ListarCurso_Result> sp_ListarCurso(Nullable<int> activo)
        {
            var activoParameter = activo.HasValue ?
                new ObjectParameter("Activo", activo) :
                new ObjectParameter("Activo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ListarCurso_Result>("sp_ListarCurso", activoParameter);
        }
    
        public virtual ObjectResult<sp_ListarEstadoEstudiante_Result> sp_ListarEstadoEstudiante(Nullable<int> activo)
        {
            var activoParameter = activo.HasValue ?
                new ObjectParameter("Activo", activo) :
                new ObjectParameter("Activo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ListarEstadoEstudiante_Result>("sp_ListarEstadoEstudiante", activoParameter);
        }
    
        public virtual ObjectResult<sp_ListarEstadoGrupo_Result> sp_ListarEstadoGrupo(Nullable<int> activo)
        {
            var activoParameter = activo.HasValue ?
                new ObjectParameter("Activo", activo) :
                new ObjectParameter("Activo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ListarEstadoGrupo_Result>("sp_ListarEstadoGrupo", activoParameter);
        }
    
        public virtual ObjectResult<sp_ListarEstudiante_Result> sp_ListarEstudiante(Nullable<int> activo)
        {
            var activoParameter = activo.HasValue ?
                new ObjectParameter("Activo", activo) :
                new ObjectParameter("Activo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ListarEstudiante_Result>("sp_ListarEstudiante", activoParameter);
        }
    
        public virtual ObjectResult<sp_ListarEstudianteGrupo_Result> sp_ListarEstudianteGrupo(Nullable<int> activo)
        {
            var activoParameter = activo.HasValue ?
                new ObjectParameter("Activo", activo) :
                new ObjectParameter("Activo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ListarEstudianteGrupo_Result>("sp_ListarEstudianteGrupo", activoParameter);
        }
    
        public virtual ObjectResult<sp_ListarEvaluacion_Result> sp_ListarEvaluacion(Nullable<int> activo)
        {
            var activoParameter = activo.HasValue ?
                new ObjectParameter("Activo", activo) :
                new ObjectParameter("Activo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ListarEvaluacion_Result>("sp_ListarEvaluacion", activoParameter);
        }
    
        public virtual ObjectResult<sp_ListarEvaluacionEstudiante_Result> sp_ListarEvaluacionEstudiante(Nullable<int> activo)
        {
            var activoParameter = activo.HasValue ?
                new ObjectParameter("Activo", activo) :
                new ObjectParameter("Activo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ListarEvaluacionEstudiante_Result>("sp_ListarEvaluacionEstudiante", activoParameter);
        }
    
        public virtual ObjectResult<sp_ListarGrupo_Result> sp_ListarGrupo(Nullable<int> activo, Nullable<int> idProfesor, Nullable<int> idPeriodo)
        {
            var activoParameter = activo.HasValue ?
                new ObjectParameter("Activo", activo) :
                new ObjectParameter("Activo", typeof(int));
    
            var idProfesorParameter = idProfesor.HasValue ?
                new ObjectParameter("IdProfesor", idProfesor) :
                new ObjectParameter("IdProfesor", typeof(int));
    
            var idPeriodoParameter = idPeriodo.HasValue ?
                new ObjectParameter("IdPeriodo", idPeriodo) :
                new ObjectParameter("IdPeriodo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ListarGrupo_Result>("sp_ListarGrupo", activoParameter, idProfesorParameter, idPeriodoParameter);
        }
    
        public virtual ObjectResult<sp_ListarModalidad_Result> sp_ListarModalidad(Nullable<int> activo)
        {
            var activoParameter = activo.HasValue ?
                new ObjectParameter("Activo", activo) :
                new ObjectParameter("Activo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ListarModalidad_Result>("sp_ListarModalidad", activoParameter);
        }
    
        public virtual ObjectResult<sp_ListarPeriodoLectivo_Result> sp_ListarPeriodoLectivo(Nullable<int> activo)
        {
            var activoParameter = activo.HasValue ?
                new ObjectParameter("Activo", activo) :
                new ObjectParameter("Activo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ListarPeriodoLectivo_Result>("sp_ListarPeriodoLectivo", activoParameter);
        }
    
        public virtual ObjectResult<sp_ListarProfesor_Result> sp_ListarProfesor(Nullable<int> activo)
        {
            var activoParameter = activo.HasValue ?
                new ObjectParameter("Activo", activo) :
                new ObjectParameter("Activo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ListarProfesor_Result>("sp_ListarProfesor", activoParameter);
        }
    
        public virtual ObjectResult<sp_ListarRubrica_Result> sp_ListarRubrica(Nullable<int> activo)
        {
            var activoParameter = activo.HasValue ?
                new ObjectParameter("Activo", activo) :
                new ObjectParameter("Activo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ListarRubrica_Result>("sp_ListarRubrica", activoParameter);
        }
    
        public virtual ObjectResult<sp_ListarTipoEvaluacion_Result> sp_ListarTipoEvaluacion(Nullable<int> activo)
        {
            var activoParameter = activo.HasValue ?
                new ObjectParameter("Activo", activo) :
                new ObjectParameter("Activo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ListarTipoEvaluacion_Result>("sp_ListarTipoEvaluacion", activoParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}