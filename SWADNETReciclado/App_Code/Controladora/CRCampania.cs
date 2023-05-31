using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/// <summary>
/// Descripción breve de CRCampania
/// </summary>
public class CRCampania
{
    #region Metodos privados
    private ADRCampania adRCampania;
    #endregion
    #region Metodos publicos
    public CRCampania()
    {
        adRCampania = new ADRCampania();
    }

    public ERCampania Obtener_RCampania_O_Sede(string SedeCampania)
    {
        ERCampania eRCampania = new ERCampania();
        DTORCampania dtoRCampania = adRCampania.Obtener_RCampania_O_Sede(SedeCampania);
        foreach (DTORCampania.RCampaniaRow drRCampania in dtoRCampania.RCampania.Rows)
        {
            eRCampania.NombreCampania = drRCampania.NombreCampania.TrimEnd();
            eRCampania.DescripcionCampania = drRCampania.DescripcionCampania.TrimEnd();
            eRCampania.FechaInicioCampania = drRCampania.FechaInicioCampania;
            eRCampania.FechaFinCampania = drRCampania.FechaFinCampania;
            eRCampania.EstadoCampania = drRCampania.EstadoCampania.TrimEnd();
            eRCampania.SedeCampania = drRCampania.SedeCampania.ToString().TrimEnd();
            eRCampania.FechaRegistroCampania = drRCampania.FechaRegistroCampania;
            eRCampania.FechaModificacionCampania = drRCampania.FechaModificacionCampania;
            eRCampania.IdCampania = drRCampania.IdCampania;
            eRCampania.IdOrganizacion = drRCampania.IdOrganizacion;
            eRCampania.IdCampaniaOrganizacion = drRCampania.IdCampaniaOrganizacion;
        }
        return eRCampania;
    }

    public List<ERCampania> Obtener_RCampania_O()
    {
        ERCampania eRCampania;
        List<ERCampania> lstERCampania = new List<ERCampania>();
        DTORCampania dtoRCampania = adRCampania.Obtener_RCampania_O();
        foreach (DTORCampania.RCampaniaRow drRCampania in dtoRCampania.RCampania.Rows)
        {
            eRCampania = new ERCampania();
            eRCampania.NombreCampania = drRCampania.NombreCampania.TrimEnd();
            eRCampania.DescripcionCampania = drRCampania.DescripcionCampania.TrimEnd();
            eRCampania.FechaInicioCampania = drRCampania.FechaInicioCampania;
            eRCampania.FechaFinCampania = drRCampania.FechaFinCampania;
            eRCampania.EstadoCampania = drRCampania.EstadoCampania.TrimEnd();
            eRCampania.SedeCampania = drRCampania.SedeCampania.ToString().TrimEnd();
            eRCampania.FechaRegistroCampania = drRCampania.FechaRegistroCampania;
            eRCampania.FechaModificacionCampania = drRCampania.FechaModificacionCampania;
            eRCampania.IdCampania = drRCampania.IdCampania;
            eRCampania.IdOrganizacion = drRCampania.IdOrganizacion;
            eRCampania.IdCampaniaOrganizacion = drRCampania.IdCampaniaOrganizacion;
            lstERCampania.Add(eRCampania);
        }
        return lstERCampania;
    }

    public void Insertar_RCampania_I(ERCampania eRCampania)
    {
        adRCampania.Insertar_RCampania_I(eRCampania);
    }

    public void Actualizar_RCampania_A(ERCampania eRCampania)
    {
        adRCampania.Actualizar_RCampania_A(eRCampania);
    }

    public void Actualizar_RCampania_A_Estado(string NombreCampania)
    {
        adRCampania.Actualizar_RCampania_A_Estado(NombreCampania);
    }

    public void Actualizar_RCampania_A_Estado_Cancelado(string NombreCampania)
    {
        adRCampania.Actualizar_RCampania_A_Estado_Cancelado(NombreCampania);
    }
    #endregion

}