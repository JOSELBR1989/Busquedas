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
    
    public partial class CamposCatalogoReferenciasPorCatalogo_Result
    {
        public Nullable<int> CatalogoCampoIdPK { get; set; }
        public string NombreCompletoCatalogoPK { get; set; }
        public string NombreTecnicoCampoPK { get; set; }
        public string NombreTecnicoCampoFK { get; set; }
        public string TipoDato { get; set; }
        public Nullable<int> Largo { get; set; }
        public Nullable<int> Precision { get; set; }
        public Nullable<int> CatalogoCampoIdFK { get; set; }
        public string DetalleError { get; set; }
    }
}