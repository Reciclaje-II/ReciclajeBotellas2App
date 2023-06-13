using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
/// <summary>
/// Descripción breve de ADROrganizacion
/// </summary>
public class ADROrganizacion
{
    #region Metodos publicos
    /// <summary>
    /// Insertar una nueva organización
    /// </summary>
    /// <param name="eROrganizacion">Solo enviar nombre y descripción de la organización</param>
    public void Insertar_ROrganizacion_I(EROrganizacion eROrganizacion)
    {
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("ROrganizacion_I");
            BDSWADNETReciclado.AddInParameter(dbCommand, "nombre", DbType.String, eROrganizacion.Nombre);
            BDSWADNETReciclado.AddInParameter(dbCommand, "descripcion", DbType.String, eROrganizacion.Descripcion);
            BDSWADNETReciclado.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }

    /// <summary>
    /// Actualizar la descripcion de una organización
    /// </summary>
    /// <param name="eROrganizacion">Solo enviar nombre de la organización y la nueva descripción</param>
    public void Actualizar_ROrganizacion_A(EROrganizacion eROrganizacion)
    {
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("ROrganizacion_A");
            BDSWADNETReciclado.AddInParameter(dbCommand, "nombre", DbType.String, eROrganizacion.Nombre);
            BDSWADNETReciclado.AddInParameter(dbCommand, "descripcion", DbType.String, eROrganizacion.Descripcion);
            BDSWADNETReciclado.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }

    /// <summary>
    /// Obtener organización por nombre
    /// </summary>
    /// <param name="Nombre"></param>
    /// <returns>Retorna una organización</returns>
    public DTOROrganizacion Obtener_ROrganizacion_O_Nombre(string Nombre)
    {
        DTOROrganizacion dTOROrganizacion = new DTOROrganizacion();
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("ROrganizacion_O_Nombre");
            BDSWADNETReciclado.AddInParameter(dbCommand, "nombre", DbType.String, Nombre);
            BDSWADNETReciclado.LoadDataSet(dbCommand, dTOROrganizacion, "ROrganizacion");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOROrganizacion;
    }

    /// <summary>
    /// Obtener un lista de las organizaciones habilitadas
    /// </summary>
    /// <returns>Retorna todos los nombres de las organizaciones</returns>
    public DTOROrganizacion Obtener_ROrganizaciones_O()
    {
        DTOROrganizacion dtoROrganizacion = new DTOROrganizacion();
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("ROrganizaciones_O");
            BDSWADNETReciclado.LoadDataSet(dbCommand, dtoROrganizacion, "ROrganizacion");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoROrganizacion;
    }

    /// <summary>
    /// Deshabilita una organizacion cambiando su estado a 0
    /// </summary>
    /// <param name="Nombre">Solo enviar el nombre de la organización que no este asociada a una campaña activa</param>
    public void Eliminar_ROrganizacion_E_Nombre(string Nombre)
    {
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("ROrganizacion_E_Nombre");
            BDSWADNETReciclado.AddInParameter(dbCommand, "nombre", DbType.String, Nombre);
            BDSWADNETReciclado.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}