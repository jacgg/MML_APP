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
    
    public partial class PUESTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PUESTO()
        {
            this.AYUDANTE_PUESTO = new HashSet<AYUDANTE_PUESTO>();
            this.CONDUCTOR_PUESTO = new HashSet<CONDUCTOR_PUESTO>();
            this.CTACTE = new HashSet<CTACTE>();
        }
    
        public string COD_PUESTO { get; set; }
        public string COD_LETRA { get; set; }
        public string COD_MERCADO { get; set; }
        public string COD_PASAJE { get; set; }
        public string COD_CODCON { get; set; }
        public Nullable<decimal> NRO_AREA { get; set; }
        public string COD_GIRO { get; set; }
        public string COD_ACTIVI { get; set; }
        public string COD_CATEGO { get; set; }
        public string COD_NUMRES { get; set; }
        public string CUSUARIO { get; set; }
        public Nullable<System.DateTime> FCONTROL { get; set; }
        public string XGIR { get; set; }
        public string XACT { get; set; }
        public string ESTADO { get; set; }
        public string COD_GIROACT { get; set; }
        public string COD_ACTIVIACT { get; set; }
        public string COD_CONDICION { get; set; }
        public string FLGHAB { get; set; }
        public string CODCAT { get; set; }
        public string USUBLOQ { get; set; }
        public Nullable<System.DateTime> FECBLOQ { get; set; }
        public string OBSBLOQ { get; set; }
        public string USUHAB { get; set; }
        public Nullable<System.DateTime> FECHAB { get; set; }
    
        public virtual ACTIVIDAD ACTIVIDAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AYUDANTE_PUESTO> AYUDANTE_PUESTO { get; set; }
        public virtual CONDICION CONDICION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONDUCTOR_PUESTO> CONDUCTOR_PUESTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTACTE> CTACTE { get; set; }
        public virtual MERCADO MERCADO { get; set; }
        public virtual PUESTO_EMP2004 PUESTO_EMP2004 { get; set; }
        public virtual PUESTO_EMP PUESTO_EMP { get; set; }
    }
}
