﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MMLEntities : DbContext
    {
        public MMLEntities()
            : base("name=MMLEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ACCESO> ACCESO { get; set; }
        public virtual DbSet<ACTIVIDAD> ACTIVIDAD { get; set; }
        public virtual DbSet<ALMACE> ALMACE { get; set; }
        public virtual DbSet<ASIGNACION> ASIGNACION { get; set; }
        public virtual DbSet<AUTORIZA> AUTORIZA { get; set; }
        public virtual DbSet<AYUDANTE> AYUDANTE { get; set; }
        public virtual DbSet<AYUDANTE_PUESTO> AYUDANTE_PUESTO { get; set; }
        public virtual DbSet<CABEVEN> CABEVEN { get; set; }
        public virtual DbSet<CABMENU> CABMENU { get; set; }
        public virtual DbSet<CATEGORIA> CATEGORIA { get; set; }
        public virtual DbSet<COB_TESORERIA> COB_TESORERIA { get; set; }
        public virtual DbSet<CODMOV> CODMOV { get; set; }
        public virtual DbSet<COLOR> COLOR { get; set; }
        public virtual DbSet<CONCEPTO> CONCEPTO { get; set; }
        public virtual DbSet<CONDICION> CONDICION { get; set; }
        public virtual DbSet<CONDUCTOR> CONDUCTOR { get; set; }
        public virtual DbSet<CONDUCTOR_PUESTO> CONDUCTOR_PUESTO { get; set; }
        public virtual DbSet<CONSUMO> CONSUMO { get; set; }
        public virtual DbSet<CONTRI> CONTRI { get; set; }
        public virtual DbSet<CTACTE> CTACTE { get; set; }
        public virtual DbSet<DATACT> DATACT { get; set; }
        public virtual DbSet<DEPACT> DEPACT { get; set; }
        public virtual DbSet<DEPARTAMENTO> DEPARTAMENTO { get; set; }
        public virtual DbSet<DEPARTAMENTO_P> DEPARTAMENTO_P { get; set; }
        public virtual DbSet<DEPENDENCIA> DEPENDENCIA { get; set; }
        public virtual DbSet<DEPENDENCIA_P> DEPENDENCIA_P { get; set; }
        public virtual DbSet<DETALLE_PER_DEP_COPIA> DETALLE_PER_DEP_COPIA { get; set; }
        public virtual DbSet<DETEVEN> DETEVEN { get; set; }
        public virtual DbSet<DETMENU> DETMENU { get; set; }
        public virtual DbSet<DIRECC> DIRECC { get; set; }
        public virtual DbSet<DISTRITO> DISTRITO { get; set; }
        public virtual DbSet<DISTRITO_P> DISTRITO_P { get; set; }
        public virtual DbSet<DISTRITOS> DISTRITOS { get; set; }
        public virtual DbSet<ENCUESTA> ENCUESTA { get; set; }
        public virtual DbSet<ESPACT> ESPACT { get; set; }
        public virtual DbSet<ESTADO_PROCESO> ESTADO_PROCESO { get; set; }
        public virtual DbSet<FACAJUS> FACAJUS { get; set; }
        public virtual DbSet<FACTOR> FACTOR { get; set; }
        public virtual DbSet<GIRO> GIRO { get; set; }
        public virtual DbSet<GRIDIS> GRIDIS { get; set; }
        public virtual DbSet<INGGRI> INGGRI { get; set; }
        public virtual DbSet<MARCA> MARCA { get; set; }
        public virtual DbSet<MERCADO> MERCADO { get; set; }
        public virtual DbSet<MODULO> MODULO { get; set; }
        public virtual DbSet<MODULOS> MODULOS { get; set; }
        public virtual DbSet<MOVACF> MOVACF { get; set; }
        public virtual DbSet<MOVACT> MOVACT { get; set; }
        public virtual DbSet<MOVVEH> MOVVEH { get; set; }
        public virtual DbSet<MOVVEH_TEMP> MOVVEH_TEMP { get; set; }
        public virtual DbSet<NUM_COB> NUM_COB { get; set; }
        public virtual DbSet<OBJ_RESOLUCION> OBJ_RESOLUCION { get; set; }
        public virtual DbSet<PAIS> PAIS { get; set; }
        public virtual DbSet<PAIS_P> PAIS_P { get; set; }
        public virtual DbSet<PANTALLA> PANTALLA { get; set; }
        public virtual DbSet<PERSONAL> PERSONAL { get; set; }
        public virtual DbSet<PERSONAL_DEPENDENCIA_P> PERSONAL_DEPENDENCIA_P { get; set; }
        public virtual DbSet<PERSONAL_P> PERSONAL_P { get; set; }
        public virtual DbSet<PILOTO> PILOTO { get; set; }
        public virtual DbSet<PILVEH> PILVEH { get; set; }
        public virtual DbSet<PROFESION> PROFESION { get; set; }
        public virtual DbSet<PROVINCIA> PROVINCIA { get; set; }
        public virtual DbSet<PROVINCIA_P> PROVINCIA_P { get; set; }
        public virtual DbSet<PUESTO> PUESTO { get; set; }
        public virtual DbSet<PUESTO_EMP> PUESTO_EMP { get; set; }
        public virtual DbSet<PUESTO_EMP2004> PUESTO_EMP2004 { get; set; }
        public virtual DbSet<SALGRI> SALGRI { get; set; }
        public virtual DbSet<SERV_REP> SERV_REP { get; set; }
        public virtual DbSet<TB_OPCION> TB_OPCION { get; set; }
        public virtual DbSet<TB_PERFIL> TB_PERFIL { get; set; }
        public virtual DbSet<TB_TIPO_DOCUMENTO> TB_TIPO_DOCUMENTO { get; set; }
        public virtual DbSet<TB_TIPO_OPCION> TB_TIPO_OPCION { get; set; }
        public virtual DbSet<TB_USUARIO> TB_USUARIO { get; set; }
        public virtual DbSet<TBLFIN> TBLFIN { get; set; }
        public virtual DbSet<TBLRES> TBLRES { get; set; }
        public virtual DbSet<TDOALM> TDOALM { get; set; }
        public virtual DbSet<TIP_RESOLUCION> TIP_RESOLUCION { get; set; }
        public virtual DbSet<TIPCOMB> TIPCOMB { get; set; }
        public virtual DbSet<TIPMOT> TIPMOT { get; set; }
        public virtual DbSet<TIPVEH> TIPVEH { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
        public virtual DbSet<USUARIOS> USUARIOS { get; set; }
        public virtual DbSet<VEHICULO> VEHICULO { get; set; }
        public virtual DbSet<VIA> VIA { get; set; }
        public virtual DbSet<AGRARIA> AGRARIA { get; set; }
        public virtual DbSet<ALCALDESPROV> ALCALDESPROV { get; set; }
        public virtual DbSet<ALCDIS> ALCDIS { get; set; }
        public virtual DbSet<AMNISTIA> AMNISTIA { get; set; }
        public virtual DbSet<BACK_PERSONAL> BACK_PERSONAL { get; set; }
        public virtual DbSet<BANCO> BANCO { get; set; }
        public virtual DbSet<CABECERA> CABECERA { get; set; }
        public virtual DbSet<CABECOB> CABECOB { get; set; }
        public virtual DbSet<CABECOBDANTE> CABECOBDANTE { get; set; }
        public virtual DbSet<CABERECIBO> CABERECIBO { get; set; }
        public virtual DbSet<COMITE> COMITE { get; set; }
        public virtual DbSet<CONDUCTOR_PUESTO_LOG> CONDUCTOR_PUESTO_LOG { get; set; }
        public virtual DbSet<COORDCER> COORDCER { get; set; }
        public virtual DbSet<CORREC> CORREC { get; set; }
        public virtual DbSet<CORREC01> CORREC01 { get; set; }
        public virtual DbSet<CORRELAT> CORRELAT { get; set; }
        public virtual DbSet<CTACTE_ABR> CTACTE_ABR { get; set; }
        public virtual DbSet<CTACTE_ABR2006> CTACTE_ABR2006 { get; set; }
        public virtual DbSet<CTACTE_ABRIL> CTACTE_ABRIL { get; set; }
        public virtual DbSet<CTACTE_AGO> CTACTE_AGO { get; set; }
        public virtual DbSet<CTACTE_AGO2006> CTACTE_AGO2006 { get; set; }
        public virtual DbSet<CTACTE_AGO2007> CTACTE_AGO2007 { get; set; }
        public virtual DbSet<CTACTE_AGOSTO> CTACTE_AGOSTO { get; set; }
        public virtual DbSet<CTACTE_AGOSTO2005> CTACTE_AGOSTO2005 { get; set; }
        public virtual DbSet<CTACTE_AMINISTIA> CTACTE_AMINISTIA { get; set; }
        public virtual DbSet<CTACTE_ANGEL> CTACTE_ANGEL { get; set; }
        public virtual DbSet<CTACTE_BORRAR> CTACTE_BORRAR { get; set; }
        public virtual DbSet<CTACTE_DIC> CTACTE_DIC { get; set; }
        public virtual DbSet<CTACTE_DIC2005> CTACTE_DIC2005 { get; set; }
        public virtual DbSet<CTACTE_ENE> CTACTE_ENE { get; set; }
        public virtual DbSet<CTACTE_FECHAS> CTACTE_FECHAS { get; set; }
        public virtual DbSet<CTACTE_INCENDIO_SIN_PAGO> CTACTE_INCENDIO_SIN_PAGO { get; set; }
        public virtual DbSet<CTACTE_JUL> CTACTE_JUL { get; set; }
        public virtual DbSet<CTACTE_JULIO> CTACTE_JULIO { get; set; }
        public virtual DbSet<CTACTE_JULIO2005> CTACTE_JULIO2005 { get; set; }
        public virtual DbSet<CTACTE_JUN> CTACTE_JUN { get; set; }
        public virtual DbSet<CTACTE_JUN2006> CTACTE_JUN2006 { get; set; }
        public virtual DbSet<CTACTE_JUNIO> CTACTE_JUNIO { get; set; }
        public virtual DbSet<CTACTE_MAR> CTACTE_MAR { get; set; }
        public virtual DbSet<CTACTE_MAR2011> CTACTE_MAR2011 { get; set; }
        public virtual DbSet<CTACTE_MARZO> CTACTE_MARZO { get; set; }
        public virtual DbSet<CTACTE_MAY> CTACTE_MAY { get; set; }
        public virtual DbSet<CTACTE_MIGRA> CTACTE_MIGRA { get; set; }
        public virtual DbSet<CTACTE_NOV> CTACTE_NOV { get; set; }
        public virtual DbSet<CTACTE_NOV2005> CTACTE_NOV2005 { get; set; }
        public virtual DbSet<CTACTE_REP> CTACTE_REP { get; set; }
        public virtual DbSet<CTACTE_REPA> CTACTE_REPA { get; set; }
        public virtual DbSet<CTACTE_REPF> CTACTE_REPF { get; set; }
        public virtual DbSet<CTACTE_SET> CTACTE_SET { get; set; }
        public virtual DbSet<CTACTE_SET2005> CTACTE_SET2005 { get; set; }
        public virtual DbSet<CTACTE_SET2006> CTACTE_SET2006 { get; set; }
        public virtual DbSet<CTACTE229> CTACTE229 { get; set; }
        public virtual DbSet<CTACTE519> CTACTE519 { get; set; }
        public virtual DbSet<CTACTE519A> CTACTE519A { get; set; }
        public virtual DbSet<CTACTEFEB> CTACTEFEB { get; set; }
        public virtual DbSet<CTACTEMAY> CTACTEMAY { get; set; }
        public virtual DbSet<CTACTEPARAISO> CTACTEPARAISO { get; set; }
        public virtual DbSet<CTAFEC> CTAFEC { get; set; }
        public virtual DbSet<DEPENDENCIA_COPIA> DEPENDENCIA_COPIA { get; set; }
        public virtual DbSet<DESABILITADOS> DESABILITADOS { get; set; }
        public virtual DbSet<DETALLE> DETALLE { get; set; }
        public virtual DbSet<DETCOB> DETCOB { get; set; }
        public virtual DbSet<DETCOBDANTE> DETCOBDANTE { get; set; }
        public virtual DbSet<DETPAG> DETPAG { get; set; }
        public virtual DbSet<DETPAGDANTE> DETPAGDANTE { get; set; }
        public virtual DbSet<DETRECA> DETRECA { get; set; }
        public virtual DbSet<DISTRITOWW> DISTRITOWW { get; set; }
        public virtual DbSet<DROPPARAISO> DROPPARAISO { get; set; }
        public virtual DbSet<DROPPARAISO2> DROPPARAISO2 { get; set; }
        public virtual DbSet<ENE2005> ENE2005 { get; set; }
        public virtual DbSet<F080> F080 { get; set; }
        public virtual DbSet<F101> F101 { get; set; }
        public virtual DbSet<F107> F107 { get; set; }
        public virtual DbSet<F114> F114 { get; set; }
        public virtual DbSet<F120> F120 { get; set; }
        public virtual DbSet<F121> F121 { get; set; }
        public virtual DbSet<FACTOR_BACK> FACTOR_BACK { get; set; }
        public virtual DbSet<FICONTC> FICONTC { get; set; }
        public virtual DbSet<FRONTECU> FRONTECU { get; set; }
        public virtual DbSet<ING012004741> ING012004741 { get; set; }
        public virtual DbSet<ING012004742> ING012004742 { get; set; }
        public virtual DbSet<INTERES> INTERES { get; set; }
        public virtual DbSet<INTERIOR> INTERIOR { get; set; }
        public virtual DbSet<JULIOCTACTE> JULIOCTACTE { get; set; }
        public virtual DbSet<JUNIO2004> JUNIO2004 { get; set; }
        public virtual DbSet<MIGRA01B> MIGRA01B { get; set; }
        public virtual DbSet<MIGRA02B> MIGRA02B { get; set; }
        public virtual DbSet<MIGRA03B> MIGRA03B { get; set; }
        public virtual DbSet<MORA_MARZO> MORA_MARZO { get; set; }
        public virtual DbSet<MORA080> MORA080 { get; set; }
        public virtual DbSet<MORA101> MORA101 { get; set; }
        public virtual DbSet<MORA107> MORA107 { get; set; }
        public virtual DbSet<MORA112> MORA112 { get; set; }
        public virtual DbSet<MORA113> MORA113 { get; set; }
        public virtual DbSet<MORA114> MORA114 { get; set; }
        public virtual DbSet<MORA120> MORA120 { get; set; }
        public virtual DbSet<MORA121> MORA121 { get; set; }
        public virtual DbSet<MOVING01> MOVING01 { get; set; }
        public virtual DbSet<MOVING01B> MOVING01B { get; set; }
        public virtual DbSet<MOVING02> MOVING02 { get; set; }
        public virtual DbSet<MOVING02B> MOVING02B { get; set; }
        public virtual DbSet<MOVING03> MOVING03 { get; set; }
        public virtual DbSet<MOVING03B> MOVING03B { get; set; }
        public virtual DbSet<NIVEL> NIVEL { get; set; }
        public virtual DbSet<OFICINA> OFICINA { get; set; }
        public virtual DbSet<PERSONALBACKUP> PERSONALBACKUP { get; set; }
        public virtual DbSet<PERSONALTEMP> PERSONALTEMP { get; set; }
        public virtual DbSet<PILVEH_TEMP> PILVEH_TEMP { get; set; }
        public virtual DbSet<PROVEED> PROVEED { get; set; }
        public virtual DbSet<PROVICIONAL> PROVICIONAL { get; set; }
        public virtual DbSet<PROVINC> PROVINC { get; set; }
        public virtual DbSet<REPUEST> REPUEST { get; set; }
        public virtual DbSet<REVISION> REVISION { get; set; }
        public virtual DbSet<SISTAB> SISTAB { get; set; }
        public virtual DbSet<T080> T080 { get; set; }
        public virtual DbSet<T080S> T080S { get; set; }
        public virtual DbSet<T101> T101 { get; set; }
        public virtual DbSet<T101S> T101S { get; set; }
        public virtual DbSet<T107> T107 { get; set; }
        public virtual DbSet<T107S> T107S { get; set; }
        public virtual DbSet<T112> T112 { get; set; }
        public virtual DbSet<T113> T113 { get; set; }
        public virtual DbSet<T114> T114 { get; set; }
        public virtual DbSet<T114S> T114S { get; set; }
        public virtual DbSet<T115> T115 { get; set; }
        public virtual DbSet<T120> T120 { get; set; }
        public virtual DbSet<T120S> T120S { get; set; }
        public virtual DbSet<T121> T121 { get; set; }
        public virtual DbSet<T566> T566 { get; set; }
        public virtual DbSet<T566A> T566A { get; set; }
        public virtual DbSet<TABMORA2005> TABMORA2005 { get; set; }
        public virtual DbSet<TB54> TB54 { get; set; }
        public virtual DbSet<TB54A> TB54A { get; set; }
        public virtual DbSet<TBLSEG> TBLSEG { get; set; }
        public virtual DbSet<TBMONTOCONTRATO> TBMONTOCONTRATO { get; set; }
        public virtual DbSet<TEMP_DEPENDENCIA> TEMP_DEPENDENCIA { get; set; }
        public virtual DbSet<TEMP_PERSONAL> TEMP_PERSONAL { get; set; }
        public virtual DbSet<TEMP84> TEMP84 { get; set; }
        public virtual DbSet<TEMPALAMIS> TEMPALAMIS { get; set; }
        public virtual DbSet<TIP_PAGO> TIP_PAGO { get; set; }
        public virtual DbSet<TIPMOV> TIPMOV { get; set; }
        public virtual DbSet<TMORA> TMORA { get; set; }
    }
}
