//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class EvaluacionEstudiante
    {
        public int IdEvalEst { get; set; }
        public int IdEstudiante { get; set; }
        public int IdEvaluacion { get; set; }
        public Nullable<double> NotaObtenida { get; set; }
        public Nullable<int> Activo { get; set; }
    
        public virtual Estudiante Estudiante { get; set; }
        public virtual Evaluacion Evaluacion { get; set; }
    }
}