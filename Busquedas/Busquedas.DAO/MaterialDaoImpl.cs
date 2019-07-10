using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Busquedas.modelo;
using Busquedas.modelos;

namespace Busquedas.DAO
{
    public class MaterialDaoImpl : MaterialDao
    { 
        Busquedas.db.DB_DMsEntities dms;

        public List<Material> materialesEquivalentes(long IdMaterialSistema)
        {
            List<Material> respuesta = new List<Material>();
            try
            {
                using (dms = new db.DB_DMsEntities())
                {
                    respuesta = (from da in dms.VW_CAT_MaterialesEquivalentesDescripcionLarga_Sel(IdMaterialSistema)
                                 select new Material
                                 {
                                     IdMaterialSistema = da.IdMaterialSistema,
                                     IdSistemaCatalogo = da.IdSistemaCatalogo,
                                     CompanyBuildId = da.CompanyBuildId,
                                     IdMaterial = da.IdMaterial,
                                     CodigoVisible = da.Codigo,
                                     DescripcionAmpliada = da.FullDescription,
                                     CodigoMaterialSistemaBase = da.IdMaterialSistema.ToString(),
                                     Nombre = da.Nombre
                                 }).ToList(); 
                }
            }
            catch (Exception ex)
            {
                respuesta = new List<Material>(); 
            }

            return respuesta; 
        }

        public TotalRegistros obtenerTotalRegistros(bool? manejaLotes, bool? activos, bool? paraMigrarSap, string Busqueda)
        {
            TotalRegistros resultado = new TotalRegistros(); 
            try
            {
                using (dms = new db.DB_DMsEntities())
                {
                    resultado = (from da in dms.CAT_Materiales_TotalRegistrosBuscados(manejaLotes, activos, paraMigrarSap, Busqueda)
                                 select new TotalRegistros
                                 {
                                     TotalRegistro = Convert.ToInt64(da.Total),
                                     Descripcion = da.Nombre
                                 }).ToList().FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                resultado = new TotalRegistros(); 
            }

            return resultado; 
        }

        public List<Material> porFiltrosBusqueda(bool? manejaLotes, bool? activos, bool? paraMigrarSap, string Busqueda, int inicio, int tamanioLote, string Orden)
        {
            return CAT_Materiales_Sel(manejaLotes, activos, paraMigrarSap, Busqueda,inicio,tamanioLote,Orden);
        }

        public List<Material> porNombre(string busqueda, int inicio, int tamanioLote, string Orden)
        {
            return CAT_Materiales_Sel(null, null, null, busqueda,inicio, tamanioLote,Orden);
        }

        public List<Material> todos(int inicio, int tamanioLote, string Orden)
        {
            return CAT_Materiales_Sel(null, null, null, null,inicio,tamanioLote,Orden);
        }

        private List<Material> CAT_Materiales_Sel(bool? manejaLotes, bool? activos, bool? paraMigrarSap, string Busqueda, int inicio, int tamanioLote, string Orden)
        {
            List<Material> resultado = new List<Material>();
            try
            {
                using (dms = new db.DB_DMsEntities())
                {
                    resultado = (from da in dms.CAT_Materiales_Sel(manejaLotes, activos, paraMigrarSap, Busqueda,inicio,tamanioLote,Orden)
                                 select new Material
                                 {
                                     IdMaterial = da.IdMaterial,
                                     IdSistemaCatalogo = da.IdSistemaCatalogo,
                                     NombreSistema = da.NombreSistema,
                                     NombreCatalogo = da.NombreCatalogo,
                                     Nombre = da.NombreBase,
                                     ManejaLote = da.ManejaLote,
                                     DiasVencimiento = da.DiasVencimiento,
                                     CodigoMaterialSistemaBase = da.IdMaterialSistemaBase.ToString(),
                                     Activo = da.Activo,
                                     MigrarSap = da.MigrarSAP,
                                     CodigoTipoMaterial = da.CodigoTipoMaterial,
                                     TipoMaterialDescripcion = da.TipoMaterialDescripcion
                                 }).ToList();
                }
            }
            catch (Exception ex)
            {
                resultado = new List<Material>();
            }

            return resultado; 
        }

    }
}
