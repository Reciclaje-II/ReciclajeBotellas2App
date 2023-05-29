using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

/// <summary>
/// Descripción breve de ADRVoto
/// </summary>
public class ADRVoto
{
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
            BDSWADNETReciclado.AddInParameter(dbCommand, "codigo", DbType.String, eRVoto.Codigo);
            BDSWADNETReciclado.AddInParameter(dbCommand, "campania", DbType.String, eRVoto.Campania);
            BDSWADNETReciclado.AddInParameter(dbCommand, "organizacion", DbType.String, eRVoto.Organizacion);
            BDSWADNETReciclado.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
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
            BDSWADNETReciclado.AddInParameter(dbCommand, "codigo", DbType.String, eRVoto.Codigo);
            BDSWADNETReciclado.AddInParameter(dbCommand, "campania", DbType.String, eRVoto.Campania);
            BDSWADNETReciclado.AddInParameter(dbCommand, "organizacion", DbType.String, eRVoto.Organizacion);
            BDSWADNETReciclado.AddInParameter(dbCommand, "donacion", DbType.String, eRVoto.Donacion);
            BDSWADNETReciclado.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }

    /// <summary>
    /// Obtener un voto por codigo y campaña
    /// </summary>
    /// <param name="Codigo"></param>
    /// <param name="Campania"></param>
    /// <returns>Retorna un voto</returns>
    public DTORVoto Obtener_RVoto_O_Codigo_Campania(string Codigo, string Campania)
    {
        DTORVoto dTORVoto = new DTORVoto();
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RVoto_O_Codigo_Campania");
            BDSWADNETReciclado.AddInParameter(dbCommand, "codigo", DbType.String, Codigo);
            BDSWADNETReciclado.AddInParameter(dbCommand, "campania", DbType.String,Campania);
            BDSWADNETReciclado.LoadDataSet(dbCommand, dTORVoto, "RVoto");
        }
        catch (Exception)
        {
            throw;
        }
        return dTORVoto;
    }

    /// <summary>
    /// Obtener el total de los votos por campaña
    /// </summary>
    /// <param name="Campania"></param>
    /// <returns>El número de votos en esa campaña</returns>
    public int Obtener_RVotos_O_Campania(string Campania)
    {
        int votosTotal = int.MinValue;
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RVotos_O_Campania");
            BDSWADNETReciclado.AddInParameter(dbCommand, "campania", DbType.String, Campania);
            IDataReader reader = BDSWADNETReciclado.ExecuteReader(dbCommand);
            while (reader.Read())
            {
                votosTotal = int.Parse(reader.GetValue(0).ToString());
            }
        }
        catch (Exception)
        {
            throw;
        }
        return votosTotal;
    }

    /// <summary>
    /// Obtener el total de votos por organizacion en una campaña
    /// </summary>
    /// <param name="Campania"></param>
    /// <param name="Organizacion"></param>
    /// <returns>El número de votos por organización en esa campaña</returns>
    public int Obtener_RVotos_O_Campania_Organizacion(string Campania, string Organizacion)
    {
        int votosTotal = int.MinValue;
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RVotos_O_Campania_Organizacion");
            BDSWADNETReciclado.AddInParameter(dbCommand, "campania", DbType.String, Campania);
            BDSWADNETReciclado.AddInParameter(dbCommand, "organizacion", DbType.String, Organizacion);
            IDataReader reader = BDSWADNETReciclado.ExecuteReader(dbCommand);
            while (reader.Read())
            {
                votosTotal = int.Parse(reader.GetValue(0).ToString());
            }
        }
        catch (Exception)
        {
            throw;
        }
        return votosTotal;
    }

    /// <summary>
    /// Obtener toda la donacion (créditos de los usuarios) por campaña finalizada
    /// </summary>
    /// <param name="Campania"></param>
    /// <returns>El número de donación (todos los créditos de los que votaron) en esa campaña finalizada</returns>
    public int Obtener_RVoto_O_Donacion_Total(string Campania)
    {
        int donacionTotal = int.MinValue;
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RVoto_O_Donacion_Total");
            BDSWADNETReciclado.AddInParameter(dbCommand, "campania", DbType.String, Campania);
            IDataReader reader = BDSWADNETReciclado.ExecuteReader(dbCommand);
            while (reader.Read())
            {
                donacionTotal = int.Parse(reader.GetValue(0).ToString());
            }
        }
        catch (Exception)
        {
            throw;
        }
        return donacionTotal;
    }

    /// <summary>
    /// Obtener el codigo del usuario con la mayor donación 
    /// </summary>
    /// <param name="Campania"></param>
    /// <returns>Retorna un voto: codigo y donación</returns>
    public DTORVoto Obtener_RVoto_O_Donacion_Maxima(string Campania)
    {
        DTORVoto dTORVoto = new DTORVoto();
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RVoto_O_Donacion_Maxima");
            BDSWADNETReciclado.AddInParameter(dbCommand, "campania", DbType.String, Campania);
            BDSWADNETReciclado.LoadDataSet(dbCommand, dTORVoto, "RVoto");
        }
        catch (Exception)
        {
            throw;
        }
        return dTORVoto;
    }

    /// <summary>
    /// Obtener la organización con mas votos válidos
    /// </summary>
    /// <param name="Campania"></param>
    /// <returns>El nombre de la organización ganadora por mas votos válidos</returns>
    public string Obtener_RVoto_O_Organizacion(string Campania)
    {
        string organizacionGanadora = string.Empty;
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RVoto_O_Organizacion");
            BDSWADNETReciclado.AddInParameter(dbCommand, "campania", DbType.String, Campania);
            IDataReader reader = BDSWADNETReciclado.ExecuteReader(dbCommand);
            while (reader.Read())
            {
                organizacionGanadora = reader.GetValue(0).ToString();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return organizacionGanadora;
    }
    #endregion
}