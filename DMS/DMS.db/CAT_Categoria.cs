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
    
    public partial class CAT_Categoria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAT_Categoria()
        {
            this.Catalogos = new HashSet<Catalogos>();
        }
    
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Esquema { get; set; }
        public Nullable<int> TotalEsperado { get; set; }
        public Nullable<int> TotalObligatorio { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Catalogos> Catalogos { get; set; }
    }
}
