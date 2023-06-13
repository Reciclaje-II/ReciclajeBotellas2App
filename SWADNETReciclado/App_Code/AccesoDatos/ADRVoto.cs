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
/// Descripción breve de ADRVoto
/// </summary>
public class ADRVoto
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
        eDefectoAD.Clase = "ADRVoto";
        eDefectoAD.Metodo = metodo;
        eDefectoAD.Excepcion = excepcion;
        eDefectoAD.Mensaje = mensaje;
        return eDefectoAD;
    }
    #endregion 
    #region Metodos publicos
    /// <summary>
    /// Insertar un voto
    /// </summary>
    /// <param name="eRVoto">Solo enviar codigo, campaña y organización</param>
    public void Insertar_RVoto_I(ERVoto eRVoto)
    {
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RVoto_I");
            BDSWADNETReciclado.AddInParameter(dbCommand, "codigoUsuario", DbType.String, eRVoto.CodigoUsuario);
            BDSWADNETReciclado.AddInParameter(dbCommand, "nombreCampania", DbType.String, eRVoto.CampaniaVoto);
            BDSWADNETReciclado.AddInParameter(dbCommand, "nombreOrganizacion", DbType.String, eRVoto.OrganizacionVoto);
            BDSWADNETReciclado.AddInParameter(dbCommand, "fechaRegistroVoto", DbType.DateTime, EPAEstaticos.FechaRegistro);
            BDSWADNETReciclado.AddInParameter(dbCommand, "fechaModificacionVoto", DbType.DateTime, EPAEstaticos.FechaModificacion);
            BDSWADNETReciclado.AddInParameter(dbCommand, "estadoVoto", DbType.String, eRVoto.EstadoVoto);
            BDSWADNETReciclado.AddInParameter(dbCommand, "donacionVoto", DbType.String, eRVoto.DonacionVoto);
            BDSWADNETReciclado.ExecuteNonQuery(dbCommand);
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ContruirErrorServicio(TTipoError.BaseDatos, "Insertar_RVoto_I", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
    }

    /// <summary>
    /// Actualizar la donacion de un voto
    /// </summary>
    /// <param name="eRVoto">Solo enviar codigo, campaña finalizada, organización ganadora y creditos como donación</param>
    public void Actualizar_RVoto_A(ERVoto eRVoto)
    {
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RVoto_A");
            BDSWADNETReciclado.AddInParameter(dbCommand, "codigoUsuario", DbType.String, eRVoto.CodigoUsuario);
            BDSWADNETReciclado.AddInParameter(dbCommand, "fechaModificacionVoto", DbType.DateTime, EPAEstaticos.FechaModificacion);
            BDSWADNETReciclado.AddInParameter(dbCommand, "donacionVoto", DbType.String, eRVoto.DonacionVoto);
            BDSWADNETReciclado.ExecuteNonQuery(dbCommand);
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ContruirErrorServicio(TTipoError.BaseDatos, "Actualizar_RVoto_A", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
    }

    /// <summary>
    /// Obtener un voto por codigo y campaña
    /// </summary>
    /// <param name="CodigoUsuario"></param>
    /// <param name="Campania"></param>
    /// <returns>Retorna un voto</returns>
    public DTORVoto Obtener_RVoto_O_Codigo_Campania(string CodigoUsuario, string CampaniaVoto)
    {
        DTORVoto dTORVoto = new DTORVoto();
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RVoto_O_Codigo_Campania");
            BDSWADNETReciclado.AddInParameter(dbCommand, "codigoUsuario", DbType.String, CodigoUsuario);
            BDSWADNETReciclado.AddInParameter(dbCommand, "nombreCampania", DbType.String, CampaniaVoto);
            BDSWADNETReciclado.LoadDataSet(dbCommand, dTORVoto, "RVoto");
            //BDSWADNETReciclado.ExecuteNonQuery(dbCommand);

        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ContruirErrorServicio(TTipoError.BaseDatos, "Obtener_RVoto_O_Codigo_Campania", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dTORVoto;
    }

    /// <summary>
    /// Obtener el total de los votos por campaña
    /// </summary>
    /// <param name="nombeCampaniaVoto"></param>
    /// <returns>El número de votos en esa campaña</returns>
    public int Obtener_RVotos_O_Campania(string nombeCampaniaVoto)
    {
        int votosTotal = int.MinValue;
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RVotos_O_Campania");
            BDSWADNETReciclado.AddInParameter(dbCommand, "nombeCampaniaVoto", DbType.String, nombeCampaniaVoto);
            BDSWADNETReciclado.AddInParameter(dbCommand, "estadoVoto", DbType.String, EPAEstaticos.EstadoValido);
            IDataReader reader = BDSWADNETReciclado.ExecuteReader(dbCommand);
            while (reader.Read())
            {
                votosTotal = int.Parse(reader.GetValue(0).ToString());
            }
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ContruirErrorServicio(TTipoError.BaseDatos, "Obtener_RVotos_O_Campania", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return votosTotal;
    }

    /// <summary>
    /// Obtener el total de votos por organizacion en una campaña
    /// </summary>
    /// <param name="campaniaVoto"></param>
    /// <param name="nombreOrganizacionVoto"></param>
    /// <returns>El número de votos por organización en esa campaña</returns>
    public int Obtener_RVotos_O_Campania_Organizacion(string campaniaVoto, string nombreOrganizacionVoto)
    {
        int votosTotal = int.MinValue;
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RVotos_O_Campania_Organizacion");
            BDSWADNETReciclado.AddInParameter(dbCommand, "campaniaVoto", DbType.String, campaniaVoto);
            BDSWADNETReciclado.AddInParameter(dbCommand, "nombreOrganizacionVoto", DbType.String, nombreOrganizacionVoto);
            BDSWADNETReciclado.AddInParameter(dbCommand, "estadoVoto", DbType.String, EPAEstaticos.EstadoValido);
            IDataReader reader = BDSWADNETReciclado.ExecuteReader(dbCommand);
            while (reader.Read())
            {
                votosTotal = int.Parse(reader.GetValue(0).ToString());
            }
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ContruirErrorServicio(TTipoError.BaseDatos, "Obtener_RVotos_O_Campania_Organizacion", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return votosTotal;
    }

    /// <summary>
    /// Obtener toda la donacion (créditos de los usuarios) por campaña finalizada
    /// </summary>
    /// <param name="nombreCampaniaVoto"></param>
    /// <returns>El número de donación (todos los créditos de los que votaron) en esa campaña finalizada</returns>
    public int Obtener_RVoto_O_Donacion_Total(string nombreCampaniaVoto)
    {
        int donacionTotal = int.MinValue;
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RVoto_O_Donacion_Total");
            BDSWADNETReciclado.AddInParameter(dbCommand, "nombreCampaniaVoto", DbType.String, nombreCampaniaVoto);
            IDataReader reader = BDSWADNETReciclado.ExecuteReader(dbCommand);
            while (reader.Read())
            {
                donacionTotal = int.Parse(reader.GetValue(0).ToString());
            }
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ContruirErrorServicio(TTipoError.BaseDatos, "Obtener_RVoto_O_Donacion_Total", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return donacionTotal;
    }

    /// <summary>
    /// Obtener el codigo del usuario con la mayor donación 
    /// </summary>
    /// <param name="nombreCampania"></param>
    /// <returns>Retorna un voto: codigo y donación</returns>
    public DTORVoto Obtener_RVoto_O_Donacion_Maxima(string nombreCampania)
    {
        DTORVoto dTORVoto = new DTORVoto();
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RVoto_O_Donacion_Maxima");
            BDSWADNETReciclado.AddInParameter(dbCommand, "nombreCampania", DbType.String, nombreCampania);
            BDSWADNETReciclado.AddInParameter(dbCommand, "estadoVoto", DbType.String, EPAEstaticos.EstadoFinalizada);
            BDSWADNETReciclado.LoadDataSet(dbCommand, dTORVoto, "RVoto");
        }
     
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ContruirErrorServicio(TTipoError.BaseDatos, "Obtener_RVoto_O_Donacion_Maxima", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dTORVoto;
    }

    /// <summary>
    /// Obtener la organización con mas votos válidos
    /// </summary>
    /// <param name="nombreCampania"></param>
    /// <returns>El nombre de la organización ganadora por mas votos válidos</returns>
    public string Obtener_RVoto_O_Organizacion(string nombreCampania)
    {
        string organizacionGanadora = string.Empty;
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RVoto_O_Organizacion");
            BDSWADNETReciclado.AddInParameter(dbCommand, "nombreCampania", DbType.String, nombreCampania);
            BDSWADNETReciclado.AddInParameter(dbCommand, "estadoVoto", DbType.String, EPAEstaticos.EstadoValido);
            IDataReader reader = BDSWADNETReciclado.ExecuteReader(dbCommand);
            while (reader.Read())
            {
                organizacionGanadora = reader.GetValue(0).ToString();
            }
        }

        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ContruirErrorServicio(TTipoError.BaseDatos, "Obtener_RVoto_O_Organizacion", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return organizacionGanadora;
    }
    #endregion
}