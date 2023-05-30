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
/// Descripción breve de ADRCampania
/// </summary>
public class ADRCampania
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
    private EDefectoAD ConstruirErrorServicio(TTipoError tipoError, string metodo, string excepcion, string mensaje)
    {
        EDefectoAD eDefectoAD = new EDefectoAD();
        eDefectoAD.TipoError = tipoError;
        eDefectoAD.Servicio = "SWADNETReciclado";
        eDefectoAD.Clase = "ADRCampania";
        eDefectoAD.Metodo = metodo;
        eDefectoAD.Excepcion = excepcion;
        eDefectoAD.Mensaje = mensaje;
        return eDefectoAD;
    }
    #endregion 
    #region Metodos Publicos
    /// <summary>
    /// Obtener campaña activa por sede
    /// </summary>
    /// <param name="SedeCampania"></param>
    /// <returns>Retorna una campania</returns>
    public DTORCampania Obtener_RCampania_O_Sede(string SedeCampania)
    {
        //ok
        //modificando
        DTORCampania dTORCampania = new DTORCampania();
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RCampania_O_Sede");
            BDSWADNETReciclado.AddInParameter(dbCommand, "sedeCampania", DbType.String, SedeCampania);
            BDSWADNETReciclado.AddInParameter(dbCommand, "EstadoCampania", DbType.String, EPAEstaticos.EstadoActiva);
            BDSWADNETReciclado.LoadDataSet(dbCommand, dTORCampania, "RCampania");
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_RCampania_O_Sede", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
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
            BDSWADNETReciclado.AddInParameter(dbCommand, "EstadoCampaniaF", DbType.DateTime, EPAEstaticos.EstadoFinalizada);
            BDSWADNETReciclado.AddInParameter(dbCommand, "EstadoCampaniaA", DbType.DateTime, EPAEstaticos.EstadoActiva);
            BDSWADNETReciclado.AddInParameter(dbCommand, "EstadoCampaniaC", DbType.DateTime, EPAEstaticos.EstadoCancelada);

            BDSWADNETReciclado.LoadDataSet(dbCommand, dTORCampania, "RCampania");
        }

        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_RCampania_O", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
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
            BDSWADNETReciclado.AddInParameter(dbCommand, "nombreCampania", DbType.String, eRCampania.NombreCampania);
            BDSWADNETReciclado.AddInParameter(dbCommand, "descripcionCampania", DbType.String, eRCampania.DescripcionCampania);
            BDSWADNETReciclado.AddInParameter(dbCommand, "fechaInicioCampania", DbType.DateTime, eRCampania.FechaInicioCampania);
            BDSWADNETReciclado.AddInParameter(dbCommand, "fechaFinCampania", DbType.DateTime, eRCampania.FechaFinCampania);
            BDSWADNETReciclado.AddInParameter(dbCommand, "sedeCampania", DbType.String, eRCampania.SedeCampania);
            BDSWADNETReciclado.AddInParameter(dbCommand, "estadoCampania", DbType.String, EPAEstaticos.EstadoActiva);
            BDSWADNETReciclado.AddInParameter(dbCommand, "fechaModificacionCampania", DbType.DateTime, EPAEstaticos.FechaModificacion);
            BDSWADNETReciclado.AddInParameter(dbCommand, "fechaRegistroCampania", DbType.DateTime, EPAEstaticos.FechaModificacion);
            BDSWADNETReciclado.AddInParameter(dbCommand, "idCampania", DbType.String, eRCampania.IdCampania);
            BDSWADNETReciclado.AddInParameter(dbCommand, "idOrganiziacion", DbType.String, eRCampania.IdOrganizacion);
            BDSWADNETReciclado.AddInParameter(dbCommand, "idCampaniaOrganizacion", DbType.String, eRCampania.IdCampaniaOrganizacion);


            BDSWADNETReciclado.ExecuteNonQuery(dbCommand);
        }

        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Insertar_RCampania_I", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
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
            BDSWADNETReciclado.AddInParameter(dbCommand, "@nombreCampania", DbType.String, eRCampania.NombreCampania);
            BDSWADNETReciclado.AddInParameter(dbCommand, "@descripcionCampania", DbType.String, eRCampania.DescripcionCampania);
            BDSWADNETReciclado.AddInParameter(dbCommand, "@fechaInicioCampania", DbType.DateTime, eRCampania.FechaInicioCampania);
            BDSWADNETReciclado.AddInParameter(dbCommand, "@fechaFinCampania", DbType.DateTime, eRCampania.FechaFinCampania);
            BDSWADNETReciclado.AddInParameter(dbCommand, "@sedeCampania", DbType.String, eRCampania.SedeCampania);
            BDSWADNETReciclado.AddInParameter(dbCommand, "@estadoCampania", DbType.DateTime, EPAEstaticos.EstadoActiva);
            BDSWADNETReciclado.AddInParameter(dbCommand, "@fechaModificacionCampania", DbType.DateTime, EPAEstaticos.FechaModificacion);
            BDSWADNETReciclado.ExecuteNonQuery(dbCommand);
        }

        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Actualizar_RCampania_A", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
    }

    /// <summary>
    /// Actualiza el estado de una campaña a 'FINALIAZADA'
    /// </summary>
    /// <param name="eRCampania"></param>
    public void Actualizar_RCampania_A_Estado(string NombreCampania)
    {
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RCampania_A_Estado");
            BDSWADNETReciclado.AddInParameter(dbCommand, "@nombreCampania", DbType.String, NombreCampania);
            BDSWADNETReciclado.AddInParameter(dbCommand, "@estadoCampaniaA", DbType.String, EPAEstaticos.EstadoActiva);
            BDSWADNETReciclado.AddInParameter(dbCommand, "@estadoCampaniaF", DbType.String, EPAEstaticos.EstadoFinalizada);
            BDSWADNETReciclado.AddInParameter(dbCommand, "@fechaModificacionCampania", DbType.DateTime, EPAEstaticos.FechaModificacion);
            BDSWADNETReciclado.ExecuteNonQuery(dbCommand);
        }

        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Actualizar_RCampania_A_Estado", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
    }

    /// <summary>
    /// Actualizar el estado de una campaña a cancelado
    /// </summary>
    /// <param name="NombreCampania"></param>
    public void Actualizar_RCampania_A_Estado_Cancelado(string NombreCampania)
    {
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RCampania_A_Estado_Cancelado");
            BDSWADNETReciclado.AddInParameter(dbCommand, "@nombreCampania", DbType.String, NombreCampania);
            BDSWADNETReciclado.AddInParameter(dbCommand, "@estadoCampania", DbType.String, EPAEstaticos.EstadoCancelada);
            BDSWADNETReciclado.AddInParameter(dbCommand, "@fechaModificacionCampania", DbType.DateTime, EPAEstaticos.FechaModificacion);
            BDSWADNETReciclado.ExecuteNonQuery(dbCommand);
        }

        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Actualizar_RCampania_A_Estado_Cancelado", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);

        }


    }
    #endregion
}