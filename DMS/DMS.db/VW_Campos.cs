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
    
    public partial class VW_Campos
    {
        public int IdCatalogo { get; set; }
        public string NombreCatalogo { get; set; }
        public string NombreFisico { get; set; }
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Esquema { get; set; }
        public Nullable<int> TotalEsperado { get; set; }
        public Nullable<int> TotalObligatorio { get; set; }
        public string NombreCompletoCatalogo { get; set; }
        public bool Activa { get; set; }
        public bool TablaCreada { get; set; }
        public bool LlavePrimaria { get; set; }
        public string NombreTecnico { get; set; }
        public string DescriptionCampo { get; set; }
        public bool Activo { get; set; }
        public string TipoDato { get; set; }
        public int Tamanio { get; set; }
        public Nullable<int> Precision { get; set; }
        public bool Requerido { get; set; }
        public long CatalogoCampoId { get; set; }
    }
}
