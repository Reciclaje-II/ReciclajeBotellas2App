using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

/// <summary>
/// Descripción breve de ADRUsuarioNetvalle
/// </summary>
public class ADRUsuarioNetvalle
{
    #region Metodos publicos
    /// <summary>
    /// Obtener un usuarionetvalle mediante sede y codigo
    /// </summary>
    /// <param name="Sede"></param>
    /// <param name="Codigo"></param>
    /// <returns>Retorna nombres y apellidos de un usuarionetvalle por sede y codigo</returns>
    public DTORUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(string Sede, string Codigo)
    {
        DTORUsuarioNetvalle dtoRUsuarioNetvalle = new DTORUsuarioNetvalle();
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RUsuarioNetvalle_O_Top_Sede_Codigo");
            BDSWADNETReciclado.AddInParameter(dbCommand, "sede", DbType.String, Sede);
            BDSWADNETReciclado.AddInParameter(dbCommand, "codigo", DbType.String, Codigo);
            BDSWADNETReciclado.LoadDataSet(dbCommand, dtoRUsuarioNetvalle, "RUsuarioNetvalle");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoRUsuarioNetvalle;
    }

    /// <summary>
    ///  Obtener un usuarionetvalle por codigo
    /// </summary>
    /// <param name="Codigo"></param>
    /// <returns>Retorna un usuarionetvalle</returns>
    public DTORUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Codigo(string Codigo)
    {
        DTORUsuarioNetvalle dtoRUsuarioNetvalle = new DTORUsuarioNetvalle();
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RUsuarioNetvalle_O_Codigo");
            BDSWADNETReciclado.AddInParameter(dbCommand, "codigo", DbType.String, Codigo);
            BDSWADNETReciclado.LoadDataSet(dbCommand, dtoRUsuarioNetvalle, "RUsuarioNetvalle");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoRUsuarioNetvalle;
    }

    /// <summary>
    /// Obtener un usuarionetvalle por tarjeta
    /// </summary>
    /// <param name="Tarjeta"></param>
    /// <returns>Retorna un usuarionetvalle</returns>
    public DTORUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Tarjeta(string Tarjeta)
    {
        DTORUsuarioNetvalle dtoRUsuarioNetvalle = new DTORUsuarioNetvalle();
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RUsuarioNetvalle_O_Tarjeta");
            BDSWADNETReciclado.AddInParameter(dbCommand, "tarjeta", DbType.String, Tarjeta);
            BDSWADNETReciclado.LoadDataSet(dbCommand, dtoRUsuarioNetvalle, "RUsuarioNetvalle");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoRUsuarioNetvalle;
    }
    #endregion
}