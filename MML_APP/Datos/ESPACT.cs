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
    
    public partial class ESPACT
    {
        public string NUMSEC { get; set; }
        public string CODGEN { get; set; }
        public string CODESP { get; set; }
        public string CODART { get; set; }
        public string TIPBIE { get; set; }
        public string DESTEC { get; set; }
        public string CODCOM { get; set; }
        public string CODMAR { get; set; }
        public string CODCOL { get; set; }
        public string CODMAT { get; set; }
        public string CODMOD { get; set; }
        public string ANOFAB { get; set; }
        public string NUMSER { get; set; }
        public string NUMPLA { get; set; }
        public string NUMMOT { get; set; }
        public Nullable<decimal> LONGIT { get; set; }
        public Nullable<decimal> ALTURA { get; set; }
        public Nullable<decimal> ANCHOS { get; set; }
        public Nullable<System.DateTime> FECREC { get; set; }
        public string NUMFIL { get; set; }
        public string NUMCON { get; set; }
        public Nullable<System.DateTime> FECMAR { get; set; }
    
        public virtual DATACT DATACT { get; set; }
    }
}
