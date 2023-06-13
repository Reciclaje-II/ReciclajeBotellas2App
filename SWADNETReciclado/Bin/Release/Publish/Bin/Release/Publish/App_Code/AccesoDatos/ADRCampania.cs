using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;


/// <summary>
/// Descripción breve de ADRCampania
/// </summary>
public class ADRCampania
{
    #region Metodos Publicos
    /// <summary>
    /// Obtener campaña activa por sede
    /// </summary>
    /// <param name="Sede"></param>
    /// <returns>Retorna una campania</returns>
    public DTORCampania Obtener_RCampania_O_Sede(string Sede)
    {
        DTORCampania dTORCampania = new DTORCampania();
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RCampania_O_Sede");
            BDSWADNETReciclado.AddInParameter(dbCommand, "sede", DbType.String, Sede);
            BDSWADNETReciclado.LoadDataSet(dbCommand, dTORCampania, "RCampania");
        }
        catch (Exception)
        {
            throw;
        }
        return dTORCampania;
    }

    /// <summary>
    /// Obtener todas las campañas
    /// </summary>
    /// <returns>Retorna una lista de campañas</returns>
    public DTORCampania Obtener_RCampania_O()
    {
        DTORCampania dTORCampania = new DTORCampania();
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RCampania_O");
            BDSWADNETReciclado.LoadDataSet(dbCommand, dTORCampania, "RCampania");
        }
        catch (Exception)
        {
            throw;
        }
        return dTORCampania;
    }

    /// <summary>
    /// Metodo para insertar una Campaña
    /// </summary>
    /// <param name="eRCampania"></param>
    public void Insertar_RCampania_I(ERCampania eRCampania)
    {
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RCampania_I");
            BDSWADNETReciclado.AddInParameter(dbCommand, "nombre", DbType.String, eRCampania.Nombre);
            BDSWADNETReciclado.AddInParameter(dbCommand, "descripcion", DbType.String, eRCampania.Descripcion);
            BDSWADNETReciclado.AddInParameter(dbCommand, "fechaInicio", DbType.DateTime, eRCampania.FechaInicio);
            BDSWADNETReciclado.AddInParameter(dbCommand, "fechaFin", DbType.DateTime, eRCampania.FechaFin);
            BDSWADNETReciclado.AddInParameter(dbCommand, "sede", DbType.String, eRCampania.Sede);
            BDSWADNETReciclado.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }

    /// <summary>
    /// Actualizar una Campaña
    /// </summary>
    /// <param name="eRCampania"></param>
    public void Actualizar_RCampania_A(ERCampania eRCampania)
    {
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RCampania_A");
            BDSWADNETReciclado.AddInParameter(dbCommand, "nombre", DbType.String, eRCampania.Nombre);
            BDSWADNETReciclado.AddInParameter(dbCommand, "descripcion", DbType.String, eRCampania.Descripcion);
            BDSWADNETReciclado.AddInParameter(dbCommand, "fechaInicio", DbType.DateTime, eRCampania.FechaInicio);
            BDSWADNETReciclado.AddInParameter(dbCommand, "fechaFin", DbType.DateTime, eRCampania.FechaFin);
            BDSWADNETReciclado.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }

    /// <summary>
    /// Actualiza el estado de una campaña a 'FINALIAZADA'
    /// </summary>
    /// <param name="eRCampania"></param>
    public void Actualizar_RCampania_A_Estado(string Nombre)
    {
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RCampania_A_Estado");
            BDSWADNETReciclado.AddInParameter(dbCommand, "nombre", DbType.String, Nombre);
            BDSWADNETReciclado.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }

    /// <summary>
    /// Actualizar el estado de una campaña a cancelado
    /// </summary>
    /// <param name="Nombre"></param>
    public void Actualizar_RCampania_A_Estado_Cancelado(string Nombre)
    {
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RCampania_A_Estado_Cancelado");
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