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
/// Descripción breve de ADROrganizacion
/// </summary>
public class ADROrganizacion
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
        eDefectoAD.Clase = "ADROrganizacion";
        eDefectoAD.Metodo = metodo;
        eDefectoAD.Excepcion = excepcion;
        eDefectoAD.Mensaje = mensaje;
        return eDefectoAD;
    }
    #endregion 
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
            BDSWADNETReciclado.AddInParameter(dbCommand, "nombreOrganizacion", DbType.String, eROrganizacion.NombreOrganizacion);
            BDSWADNETReciclado.AddInParameter(dbCommand, "descripcionOrganizacion", DbType.String, eROrganizacion.DescripcionOrganizacion);
            BDSWADNETReciclado.AddInParameter(dbCommand, "estadoOrganizacion", DbType.String, EPAEstaticos.EstadoActiva);
            BDSWADNETReciclado.AddInParameter(dbCommand, "fechaRegistroOrganizacion", DbType.String, EPAEstaticos.FechaRegistro);
            BDSWADNETReciclado.AddInParameter(dbCommand, "fechaModificacionOrganizacion", DbType.String, EPAEstaticos.FechaModificacion);
            BDSWADNETReciclado.ExecuteNonQuery(dbCommand);
    }

        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ContruirErrorServicio(TTipoError.BaseDatos, "Insertar_ROrganizacion_I", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
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
            BDSWADNETReciclado.AddInParameter(dbCommand, "nombreOrganizacion", DbType.String, eROrganizacion.NombreOrganizacion);
            BDSWADNETReciclado.AddInParameter(dbCommand, "descripcionOrganizacion", DbType.String, eROrganizacion.DescripcionOrganizacion);
            BDSWADNETReciclado.AddInParameter(dbCommand, "fechaModificacionOrganizacion", DbType.String, EPAEstaticos.FechaModificacion);
            BDSWADNETReciclado.AddInParameter(dbCommand, "estadoOrganizacion", DbType.String, EPAEstaticos.EstadoActiva);

            BDSWADNETReciclado.ExecuteNonQuery(dbCommand);
        }
   
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ContruirErrorServicio(TTipoError.BaseDatos, "Actualizar_ROrganizacion_A", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
    }

    /// <summary>
    /// Obtener organización por nombre
    /// </summary>
    /// <param name="nombreOrganizacion"></param>
    /// <returns>Retorna una organización</returns>
    public DTOROrganizacion Obtener_ROrganizacion_O_Nombre(string nombreOrganizacion)
    {
        DTOROrganizacion dTOROrganizacion = new DTOROrganizacion();
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("ROrganizacion_O_Nombre");
            BDSWADNETReciclado.AddInParameter(dbCommand, "nombreOrganizacion", DbType.String, nombreOrganizacion);
            BDSWADNETReciclado.LoadDataSet(dbCommand, dTOROrganizacion, "ROrganizacion");
        }
   
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ContruirErrorServicio(TTipoError.BaseDatos, "Obtener_ROrganizacion_O_Nombre", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
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
            BDSWADNETReciclado.AddInParameter(dbCommand, "estadoOrganizacion", DbType.String, EPAEstaticos.EstadoActiva);
            BDSWADNETReciclado.LoadDataSet(dbCommand, dtoROrganizacion, "ROrganizacion");
        }
    
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ContruirErrorServicio(TTipoError.BaseDatos, "Obtener_ROrganizaciones_O", SQLEx.ToString(), SQLEx.Message);
            //throw new FaultException<EDefectoAD>(eDefectoAD);
            throw SQLEx;
        }
        return dtoROrganizacion;
    }

    /// <summary>
    /// Deshabilita una organizacion cambiando su estado a 0
    /// </summary>
    /// <param name="nombreOrganizacion">Solo enviar el nombre de la organización que no este asociada a una campaña activa</param>
    public void Eliminar_ROrganizacion_E_Nombre(string nombreOrganizacion)
    {
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("ROrganizacion_E_Nombre");
            BDSWADNETReciclado.AddInParameter(dbCommand, "nombreOrganizacion", DbType.String, nombreOrganizacion);
            BDSWADNETReciclado.AddInParameter(dbCommand, "estadoOrganizacion", DbType.String, EPAEstaticos.EstadoCancelada);
            BDSWADNETReciclado.AddInParameter(dbCommand, "fechaActualizacion", DbType.String, EPAEstaticos.FechaModificacion);
            BDSWADNETReciclado.ExecuteNonQuery(dbCommand);
        }
  
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ContruirErrorServicio(TTipoError.BaseDatos, "Eliminar_ROrganizacion_E_Nombre", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
    }
    #endregion
}