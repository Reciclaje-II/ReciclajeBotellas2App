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
/// Descripción breve de ADRImagen
/// </summary>
public class ADRImagen
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
        EDefectoAD EDefectoAD = new EDefectoAD();
        EDefectoAD.TipoError = tipoError;
        EDefectoAD.Servicio = "SWADNETReciclado";
        EDefectoAD.Clase = "ADRImagen";
        EDefectoAD.Metodo = metodo;
        EDefectoAD.Excepcion = excepcion;
        EDefectoAD.Mensaje = mensaje;
        return EDefectoAD;
    }
    #endregion 
    #region Metodos publicos

    /// <summary>
    /// Inserta un tipo de imagen para la organización
    /// </summary>
    /// <param name="eRImagen">Solo enviar el nombre de la imagen, tipo logo o descripción y el nombre de la organización registrada</param>
    public void Insertar_RImagen_I(ERImagen eRImagen)
    {
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RImagen_I");
            BDSWADNETReciclado.AddInParameter(dbCommand, "nombreImagen", DbType.String, eRImagen.NombreImagen);
            BDSWADNETReciclado.AddInParameter(dbCommand, "tipoImagen", DbType.Byte, eRImagen.TipoImagen);
            BDSWADNETReciclado.AddInParameter(dbCommand, "organizacionImagen", DbType.String, eRImagen.OrganizacionImagen);
            BDSWADNETReciclado.AddInParameter(dbCommand, "estadoImagen", DbType.String, eRImagen.EstadoImagen);
            BDSWADNETReciclado.AddInParameter(dbCommand, "fechaRegistroImagen", DbType.DateTime, eRImagen.FechaRegistroImagen);
            BDSWADNETReciclado.AddInParameter(dbCommand, "fechaModificacionImagen", DbType.DateTime, eRImagen.FechaModificacionImagen);
            BDSWADNETReciclado.ExecuteNonQuery(dbCommand);
        }
 
        catch (SqlException SQLEx)
        {
            EDefectoAD EDefectoAD = ContruirErrorServicio(TTipoError.BaseDatos, "Insertar_RImagen_I", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(EDefectoAD);
        }
    }

    /// <summary>
    /// Obtener Imagen por organizacion
    /// </summary>
    /// <param name="OrganizacionImagen"></param>
    /// <param name="TipoImagen"></param>
    /// <returns>Retorna una lista de RImagen</returns>
    public DTORImagen Obtener_RImagen_O_Organizacion(string OrganizacionImagen, byte TipoImagen)
    {
        DTORImagen dTORImagen = new DTORImagen();
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RImagen_O_Organizacion");
            BDSWADNETReciclado.AddInParameter(dbCommand, "organizacionImagen", DbType.String, OrganizacionImagen);
            BDSWADNETReciclado.AddInParameter(dbCommand, "tipoImagen", DbType.Byte, TipoImagen);
            BDSWADNETReciclado.LoadDataSet(dbCommand, dTORImagen, "RImagen");
        }
    
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ContruirErrorServicio(TTipoError.BaseDatos, "Obtener_RImagen_O_Organizacion", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dTORImagen;
    }
    #endregion
}