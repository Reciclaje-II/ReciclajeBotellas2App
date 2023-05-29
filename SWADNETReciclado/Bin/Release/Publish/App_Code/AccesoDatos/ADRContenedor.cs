using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

/// <summary>
/// Descripción breve de ADRContenedor
/// </summary>
public class ADRContenedor
{
    #region Metodos Publicos
    /// <summary>
    /// Insertar registro de un contenedor
    /// </summary>
    /// <param name="eRContenedor">Enviar entidad contenedor</param>
    public void Insertar_RContenedor_I(ERContenedor eRContenedor)
    {
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RContenedor_I");
            BDSWADNETReciclado.AddInParameter(dbCommand, "codigo", DbType.String, eRContenedor.Codigo);
            BDSWADNETReciclado.AddInParameter(dbCommand, "maquina", DbType.Byte, eRContenedor.IdMaquina);
            BDSWADNETReciclado.AddInParameter(dbCommand, "gramos", DbType.String, eRContenedor.Gramos);
            BDSWADNETReciclado.AddInParameter(dbCommand, "fecha", DbType.DateTime, eRContenedor.Fecha);
            BDSWADNETReciclado.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
        
    }

    /// <summary>
    /// Obtener registros de contenedor por el codigo de un usuario
    /// </summary>
    /// <param name="Codigo"></param>
    /// <returns>Retorna una lista de contenedor</returns>
    public DTORContenedor Obtener_RContenedor_O_Codigo(string Codigo)
    {
        DTORContenedor dTORContenedor = new DTORContenedor();
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RContenedor_O_Codigo");
            BDSWADNETReciclado.AddInParameter(dbCommand, "codigo", DbType.String, Codigo);
            BDSWADNETReciclado.LoadDataSet(dbCommand, dTORContenedor, "RContenedor");
        }
        catch (Exception)
        {
            throw;
        }
        return dTORContenedor;
    }
    #endregion
}