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
/// Descripción breve de ADRCampaniaOrganizacion
/// </summary>
public class ADRCampaniaOrganizacion
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
    private EDefectoAD ContruirErrorServicio(TTipoError tipoDefecto, string metodo, string excepcion, string mensaje)
    {
        EDefectoAD eDefectoAD = new EDefectoAD();
        eDefectoAD.TipoError = tipoDefecto;
        eDefectoAD.Servicio = "SWADNETReciclado";
        eDefectoAD.Clase = "ADRCampaniaOrganizacion";
        eDefectoAD.Metodo = metodo;
        eDefectoAD.Excepcion = excepcion;
        eDefectoAD.Mensaje = mensaje;
        return eDefectoAD;
    }
    #endregion 
    #region Metodos publicos
    /// <summary>
    /// Insertar una campaña - organización
    /// </summary>
    /// <param name="eRCampaniaOrganizacion">Solo enviar el nombre de la campaña activa y el nombre de una organización habilitada</param>
    public void Insertar_RCampaniaOrganizacion_I(ERCampaniaOrganizacion eRCampaniaOrganizacion)
    {
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RCampaniaOrganizacion_I");
            BDSWADNETReciclado.AddInParameter(dbCommand, "campania", DbType.String, eRCampaniaOrganizacion.Campania);
            BDSWADNETReciclado.AddInParameter(dbCommand, "organizacion", DbType.String, eRCampaniaOrganizacion.Organizacion);
            BDSWADNETReciclado.ExecuteNonQuery(dbCommand);
        }
  
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ContruirErrorServicio(TTipoError.BaseDatos, "Insertar_RCampaniaOrganizacion_I", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
    }

    /// <summary>
    /// Obtener campaña - organizacion por campaña
    /// </summary>
    /// <param name="Campania"></param>
    /// <returns>Retorna una lista de RCampaniaOrganizacion</returns>
    public DTORCampaniaOrganizacion Obtener_RCampaniaOrganizacion_O_Campania(string Campania)
    {
        DTORCampaniaOrganizacion dTORCampaniaOrganizacion = new DTORCampaniaOrganizacion();
        try
        {
            Database BDSWADNETReciclado = SBaseDatos.BDSWADNETReciclado;
            DbCommand dbCommand = BDSWADNETReciclado.GetStoredProcCommand("RCampaniaOrganizacion_O_Campania");
            BDSWADNETReciclado.AddInParameter(dbCommand, "campania", DbType.String, Campania);
            BDSWADNETReciclado.LoadDataSet(dbCommand, dTORCampaniaOrganizacion, "RCampaniaOrganizacion");
        }
    
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ContruirErrorServicio(TTipoError.BaseDatos, "Obtener_RCampaniaOrganizacion_O_Campania", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dTORCampaniaOrganizacion;
    }

    #endregion
}