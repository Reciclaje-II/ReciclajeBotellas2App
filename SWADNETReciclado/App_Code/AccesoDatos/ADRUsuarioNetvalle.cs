using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.SqlClient;
using System.ServiceModel;

/// <summary>
/// Descripción breve de ADRUsuarioNetvalle
/// </summary>
public class ADRUsuarioNetvalle
{
    #region Metodos Privados
    /// <summary>
    /// Contruir el Error del servicio > metodo
    /// </summary>
    /// <param name="tipoError"></param>
    /// <param name="metodo"></param>
    /// <param name="excepcion"></param>
    /// <param name="mensaje"></param>
    /// <returns></returns>
    private EDefectoAD ContruirErrorServicio(TTipoError tipoError, string metodo, string excepcion, string mensaje)
    {
        EDefectoAD eDefectoAD = new EDefectoAD();
        eDefectoAD.TipoError = tipoError;
        eDefectoAD.Servicio = "SWADNETReciclado";
        eDefectoAD.Clase = "ADRUsuarioNetvalle";
        eDefectoAD.Metodo = metodo;
        eDefectoAD.Excepcion = excepcion;
        eDefectoAD.Mensaje = mensaje;
        return eDefectoAD;
    }
    #endregion 
    #region Metodos publicos
    /// <summary>
    /// Obtener un usuarionetvalle mediante sede y codigo
    /// </summary>
    /// <param name="Sede"></param>
    /// <param name="Codigo"></param>
    /// <returns>Retorna nombres y apellidos de un usuarionetvalle por sede y codigo</returns>
    public DTORUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(string SedeUsuarioNetvalle, string CodigoUsuarioNetvalle)
    {
        DTORUsuarioNetvalle dtoRUsuarioNetvalle = new DTORUsuarioNetvalle();
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RUsuarioNetvalle_O_Top_Sede_Codigo");
            BDSWADNETReciclado.AddInParameter(dbCommand, "sede", DbType.String, SedeUsuarioNetvalle);
            BDSWADNETReciclado.AddInParameter(dbCommand, "codigo", DbType.String, CodigoUsuarioNetvalle);
            BDSWADNETReciclado.LoadDataSet(dbCommand, dtoRUsuarioNetvalle, "RUsuarioNetvalle");
        }

        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ContruirErrorServicio(TTipoError.BaseDatos, "Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dtoRUsuarioNetvalle;
    }

    /// <summary>
    ///  Obtener un usuarionetvalle por codigo
    /// </summary>
    /// <param name="Codigo"></param>
    /// <returns>Retorna un usuarionetvalle</returns>
    public DTORUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Codigo(string CodigoUsuarioNetvalle)
    {
        DTORUsuarioNetvalle dtoRUsuarioNetvalle = new DTORUsuarioNetvalle();
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RUsuarioNetvalle_O_Codigo");
            BDSWADNETReciclado.AddInParameter(dbCommand, "codigo", DbType.String, CodigoUsuarioNetvalle);
            BDSWADNETReciclado.LoadDataSet(dbCommand, dtoRUsuarioNetvalle, "RUsuarioNetvalle");
        }

        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ContruirErrorServicio(TTipoError.BaseDatos, "Obtener_RUsuarioNetvalle_O_Codigo", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dtoRUsuarioNetvalle;
    }

    /// <summary>
    /// Obtener un usuarionetvalle por tarjeta
    /// </summary>
    /// <param name="Tarjeta"></param>
    /// <returns>Retorna un usuarionetvalle</returns>
    public DTORUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Tarjeta(string TarjetaUsuarioNetvalle)
    {
        DTORUsuarioNetvalle dtoRUsuarioNetvalle = new DTORUsuarioNetvalle();
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RUsuarioNetvalle_O_Tarjeta");
            BDSWADNETReciclado.AddInParameter(dbCommand, "tarjeta", DbType.String, TarjetaUsuarioNetvalle);
            BDSWADNETReciclado.LoadDataSet(dbCommand, dtoRUsuarioNetvalle, "RUsuarioNetvalle");
        }

        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ContruirErrorServicio(TTipoError.BaseDatos, "Obtener_RUsuarioNetvalle_O_Tarjeta", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dtoRUsuarioNetvalle;
    }
    #endregion
}