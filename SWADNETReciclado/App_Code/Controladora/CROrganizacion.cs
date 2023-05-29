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

    public EROrganizacion Obtener_ROrganizacion_O_Nombre(string Nombre)
    {
        EROrganizacion eROrganizacion = new EROrganizacion();
        DTOROrganizacion dtoROrganizacion = adROrganizacion.Obtener_ROrganizacion_O_Nombre(Nombre);
        foreach (DTOROrganizacion.ROrganizacionRow drRCampania in dtoROrganizacion.ROrganizacion.Rows)
        {
            eROrganizacion.Nombre = drRCampania.Nombre.TrimEnd();
            eROrganizacion.Descripcion = drRCampania.Descripcion.TrimEnd();
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
            eROrganizacion.Nombre = drROrganizacion.Nombre.ToString();
            lstROrganizaciones.Add(eROrganizacion);
        }
        return lstROrganizaciones;
    }

    public void Eliminar_ROrganizacion_E_Nombre(string Nombre)
    {
        adROrganizacion.Eliminar_ROrganizacion_E_Nombre(Nombre);
    }
    #endregion
}