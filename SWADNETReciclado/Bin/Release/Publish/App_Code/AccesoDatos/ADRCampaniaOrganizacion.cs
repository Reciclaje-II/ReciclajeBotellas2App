using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

/// <summary>
/// Descripción breve de ADRCampaniaOrganizacion
/// </summary>
public class ADRCampaniaOrganizacion
{
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
        catch (Exception)
        {
            throw;
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
        catch (Exception)
        {

            throw;
        }
        return dTORCampaniaOrganizacion;
    }

    #endregion
}