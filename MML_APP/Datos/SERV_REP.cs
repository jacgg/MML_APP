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
    
    public partial class SERV_REP
    {
        public string CODSERV { get; set; }
        public string SECSERV { get; set; }
        public string CODGEN { get; set; }
        public string CODESP { get; set; }
        public string CODART { get; set; }
        public string TIPBIE { get; set; }
        public string NUMSEC { get; set; }
        public string DESCRIP { get; set; }
        public Nullable<decimal> COSTO { get; set; }
    
        public virtual DATACT DATACT { get; set; }
    }
}
