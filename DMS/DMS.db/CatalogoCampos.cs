//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class CatalogoCampos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatalogoCampos()
        {
            this.RelacionCatalogoCampos = new HashSet<RelacionCatalogoCampos>();
            this.RelacionCatalogoCampos1 = new HashSet<RelacionCatalogoCampos>();
        }
    
        public long CatalogoCampoId { get; set; }
        public int IdCatalogo { get; set; }
        public Nullable<int> IdAgrupacion { get; set; }
        public string NombreCampo { get; set; }
        public string Descripcion { get; set; }
        public string NombreTecnico { get; set; }
        public string TipoDato { get; set; }
        public int Tamanio { get; set; }
        public Nullable<int> Precision { get; set; }
        public bool CampoConReferencia { get; set; }
        public bool Requerido { get; set; }
        public bool LlavePrimaria { get; set; }
        public int Orden { get; set; }
        public bool Activo { get; set; }
    
        public virtual Agrupaciones Agrupaciones { get; set; }
        public virtual Catalogos Catalogos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelacionCatalogoCampos> RelacionCatalogoCampos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelacionCatalogoCampos> RelacionCatalogoCampos1 { get; set; }
    }
}
