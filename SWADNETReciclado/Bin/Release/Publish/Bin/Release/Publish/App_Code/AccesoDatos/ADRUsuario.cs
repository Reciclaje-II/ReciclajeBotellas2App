﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

/// <summary>
/// Descripción breve de ADRUsuario
/// </summary>
public class ADRUsuario
{
    #region Metodos publicos
    /// <summary>
    /// Obtener un usuario por codigo
    /// </summary>
    /// <param name="Codigo"></param>
    /// <returns>Retorna un usuario</returns>
    public DTORUsuario Obtener_RUsuario_O_Codigo(string Codigo)
    {
        DTORUsuario dtoRUsuario = new DTORUsuario();
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RUsuario_O_Codigo");
            BDSWADNETReciclado.AddInParameter(dbCommand, "codigo", DbType.String, Codigo);
            BDSWADNETReciclado.LoadDataSet(dbCommand, dtoRUsuario, "RUsuario");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoRUsuario;
    }
    /// <summary>
    /// Obtener el top de usuarios en créditos
    /// </summary>
    /// <param name="Sede"></param>
    /// <returns>Retorna una lista de usuarios ordenados por créditos</returns>
    public DTORUsuario Obtener_RUsuarios_O_Top_Creditos(string Sede)
    {
        DTORUsuario dtoRUsuario = new DTORUsuario();
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RUsuarios_O_Top_Creditos");
            BDSWADNETReciclado.AddInParameter(dbCommand, "sede", DbType.String, Sede);
            BDSWADNETReciclado.LoadDataSet(dbCommand, dtoRUsuario, "RUsuario");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoRUsuario;
    }

    /// <summary>
    /// Obtener a todos los usuarios
    /// </summary>
    /// <param name="Sede"></param>
    /// <returns>Retorna la lista del codigo de los usuarios con sus créditos</returns>
    public DTORUsuario Obtener_RUsuarios_O_Sede(string Sede)
    {
        DTORUsuario dtoRUsuario = new DTORUsuario();
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RUsuarios_O_Sede");
            BDSWADNETReciclado.AddInParameter(dbCommand, "sede", DbType.String, Sede);
            BDSWADNETReciclado.LoadDataSet(dbCommand, dtoRUsuario, "RUsuario");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoRUsuario;
    }

    /// <summary>
    /// Actualizar los créditos de los usuarios a 0 en la sede donde se finalizó la campaña
    /// </summary>
    /// <param name="Campania"></param>
    /// <param name="Codigo"></param>
    public void Actualizar_RUsuario_A_Creditos_Sede(string Campania, string Codigo)
    {
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RUsuarios_A_Creditos_Sede");
            BDSWADNETReciclado.AddInParameter(dbCommand, "campania", DbType.String, Campania);
            BDSWADNETReciclado.AddInParameter(dbCommand, "codigo", DbType.String, Codigo);
            BDSWADNETReciclado.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }

    /// <summary>
    /// Actualizar los créditos del usuario a la nueva cantidad enviada
    /// </summary>
    /// <param name="Codigo"></param>
    /// <param name="Creditos"></param>
    public void Actualizar_RUsuario_A_Creditos_Codigo(string Codigo, string Creditos)
    {
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RUsuario_A_Creditos_Codigo");
            BDSWADNETReciclado.AddInParameter(dbCommand, "codigo", DbType.String, Codigo);
            BDSWADNETReciclado.AddInParameter(dbCommand, "creditos", DbType.String, Creditos);
            BDSWADNETReciclado.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}