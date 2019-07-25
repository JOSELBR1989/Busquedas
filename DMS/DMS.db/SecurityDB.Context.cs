﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DMS.db
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DB_DMsEntities : DbContext
    {
        public DB_DMsEntities()
            : base("name=DB_DMsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Agrupaciones> Agrupaciones { get; set; }
        public virtual DbSet<CAT_Categoria> CAT_Categoria { get; set; }
        public virtual DbSet<CatalogoCampos> CatalogoCampos { get; set; }
        public virtual DbSet<Catalogos> Catalogos { get; set; }
        public virtual DbSet<CamposCatalogoReferencias> CamposCatalogoReferencias { get; set; }
        public virtual DbSet<CatalogoConsultas> CatalogoConsultas { get; set; }
        public virtual DbSet<VW_Campos> VW_Campos { get; set; }
    
        [DbFunction("DB_DMsEntities", "CamposCatalogoReferenciasPorCatalogo")]
        public virtual IQueryable<CamposCatalogoReferenciasPorCatalogo_Result> CamposCatalogoReferenciasPorCatalogo(Nullable<int> pIdCatalogo)
        {
            var pIdCatalogoParameter = pIdCatalogo.HasValue ?
                new ObjectParameter("pIdCatalogo", pIdCatalogo) :
                new ObjectParameter("pIdCatalogo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<CamposCatalogoReferenciasPorCatalogo_Result>("[DB_DMsEntities].[CamposCatalogoReferenciasPorCatalogo](@pIdCatalogo)", pIdCatalogoParameter);
        }
    }
}
