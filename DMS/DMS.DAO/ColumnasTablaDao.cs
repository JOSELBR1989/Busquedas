﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMS.Modelos; 
namespace DMS.DAO
{
    public interface ColumnasTablaDao : ExecuteQuery
    {
        List<Object> columnasTabla(Catalogos catalogoPadre);
        List<Object> columnasTablaPK(Catalogos catalogoPadre);
        List<Object> columnasYTablas(string busqueda, CamposCatalogo campos);
        void nuevo(DMS.Modelos.CamposCatalogo campo);
        void actualizar(DMS.Modelos.CamposCatalogo campo);
        void actualizarPK(DMS.Modelos.CamposCatalogo campo);
        void actualizarGrupo(DMS.Modelos.CamposCatalogo campo);

        void crearAsociacionCampos(DMS.Modelos.CamposCatalogo campoFK, DMS.Modelos.CamposCatalogo campoPK);
        List<object> obtenerAsociacionesColumna(DMS.Modelos.CamposCatalogo campo);
        CamposCatalogo obtenePorId(DMS.Modelos.CamposCatalogo campoBusqueda);
    }
}