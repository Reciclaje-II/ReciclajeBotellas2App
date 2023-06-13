using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CROrganizacion
/// </summary>
public class CROrganizacion
{
    #region Metodos privados
    private ADROrganizacion adROrganizacion;
    #endregion
    #region Metodos publicos
    public CROrganizacion()
    {
        adROrganizacion = new ADROrganizacion();
    }

    public void Insertar_ROrganizacion_I(EROrganizacion eROrganizacion)
    {
        adROrganizacion.Insertar_ROrganizacion_I(eROrganizacion);
    }

    public void Actualizar_ROrganizacion_A(EROrganizacion eROrganizacion)
    {
        adROrganizacion.Actualizar_ROrganizacion_A(eROrganizacion);
    }

    public EROrganizacion Obtener_ROrganizacion_O_Nombre(string nombreOrganizacion)
    {
        EROrganizacion eROrganizacion = new EROrganizacion();
        DTOROrganizacion dtoROrganizacion = adROrganizacion.Obtener_ROrganizacion_O_Nombre(nombreOrganizacion);
        foreach (DTOROrganizacion.ROrganizacionRow drRCampania in dtoROrganizacion.ROrganizacion.Rows)
        {
            eROrganizacion.NombreOrganizacion = drRCampania.NombreOrganizacion.TrimEnd();
            eROrganizacion.DescripcionOrganizacion = drRCampania.DescripcionOrganizacion.TrimEnd();
            eROrganizacion.EstadoOrganizacion = drRCampania.EstadoOrganizacion.TrimEnd();

        }
        return eROrganizacion;
    }

    public List<EROrganizacion> Obtener_ROrganizaciones_O()
    {
        EROrganizacion eROrganizacion = new EROrganizacion();
        List<EROrganizacion> lstROrganizaciones = new List<EROrganizacion>();
        DTOROrganizacion dtoROrganizacion = adROrganizacion.Obtener_ROrganizaciones_O();
        foreach (DTOROrganizacion.ROrganizacionRow drROrganizacion in dtoROrganizacion.ROrganizacion.Rows)
        {
            eROrganizacion = new EROrganizacion();
            eROrganizacion.NombreOrganizacion = drROrganizacion.NombreOrganizacion.ToString();
            lstROrganizaciones.Add(eROrganizacion);
        }
        return lstROrganizaciones;
    }

    public void Eliminar_ROrganizacion_E_Nombre(string nombreOrganizacion)
    {
        adROrganizacion.Eliminar_ROrganizacion_E_Nombre(nombreOrganizacion);
    }
    #endregion
}