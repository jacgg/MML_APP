//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MML_APP.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class ACTIVIDAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACTIVIDAD()
        {
            this.PUESTO = new HashSet<PUESTO>();
        }
    
        public string COD_ACTIVI { get; set; }
        public string COD_GIRO { get; set; }
        public string NOM_ACTIVIDAD { get; set; }
        public string CUSUARIO { get; set; }
        public Nullable<System.DateTime> FCONTROL { get; set; }
    
        public virtual GIRO GIRO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PUESTO> PUESTO { get; set; }
    }
}
