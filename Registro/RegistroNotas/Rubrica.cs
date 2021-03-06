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
    
    public partial class Rubrica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rubrica()
        {
            this.Evaluacion = new HashSet<Evaluacion>();
        }
    
        public int IdRubrica { get; set; }
        public int IdTipoEvaluacion { get; set; }
        public int IdGrupo { get; set; }
        public double Porcentaje { get; set; }
        public Nullable<int> EsCalculado { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<int> Activo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evaluacion> Evaluacion { get; set; }
        public virtual Grupo Grupo { get; set; }
        public virtual TipoEvaluacion TipoEvaluacion { get; set; }
    }
}
