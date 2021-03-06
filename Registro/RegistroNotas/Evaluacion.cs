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
    
    public partial class Evaluacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Evaluacion()
        {
            this.EvaluacionEstudiante = new HashSet<EvaluacionEstudiante>();
        }
    
        public int IdEvaluacion { get; set; }
        public int IdRubrica { get; set; }
        public Nullable<System.DateTime> FechaAplicacion { get; set; }
        public string Descripcion { get; set; }
        public Nullable<double> PorcentajeAsig { get; set; }
        public Nullable<int> Activo { get; set; }
    
        public virtual Rubrica Rubrica { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EvaluacionEstudiante> EvaluacionEstudiante { get; set; }
    }
}
