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
    
    public partial class TB_USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_USUARIO()
        {
            this.TB_PERFIL = new HashSet<TB_PERFIL>();
        }
    
        public string CODUSU { get; set; }
        public string NOMUSU { get; set; }
        public string APEUSU { get; set; }
        public string PASUSU { get; set; }
        public string ESTADO { get; set; }
        public string USUARI { get; set; }
        public string FECREG { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PERFIL> TB_PERFIL { get; set; }
    }
}
