using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CRVoto
/// </summary>
public class CRVoto
{
    #region Metodos privados
    private ADRVoto adRVoto;
    #endregion
    #region Metodos publicos
    public CRVoto()
    {
        adRVoto = new ADRVoto();
    }

    public void Insertar_RVoto_I(ERVoto eRVoto)
    {
        adRVoto.Insertar_RVoto_I(eRVoto);
    }

    public void Actualizar_RVoto_A(ERVoto eRVoto)
    {
        adRVoto.Actualizar_RVoto_A(eRVoto);
    }

    public ERVoto Obtener_RVoto_O_Codigo_Campania(string codigoUsuario, string nombreCampania)
    {
        ERVoto eRVoto = new ERVoto();
        DTORVoto dtoRVoto = adRVoto.Obtener_RVoto_O_Codigo_Campania(codigoUsuario, nombreCampania);
        foreach (DTORVoto.RVotoRow drRVoto in dtoRVoto.RVoto.Rows)
        {
            eRVoto = new ERVoto();
            eRVoto.CodigoUsuario = drRVoto.CodigoUsuario.TrimEnd();
            eRVoto.CampaniaVoto = drRVoto.CampaniaVoto.TrimEnd();
            eRVoto.OrganizacionVoto = drRVoto.OrganizacionVoto.TrimEnd();
            eRVoto.FechaRegistroVoto = drRVoto.FechaRegistroVoto;
            eRVoto.DonacionVoto = drRVoto.DonacionVoto.ToString().TrimEnd();
            eRVoto.EstadoVoto = drRVoto.EstadoVoto.ToString().TrimEnd();
            eRVoto.FechaModificacionVoto = drRVoto.FechaModificacionVoto;
            eRVoto.IdVoto = drRVoto.IdVoto;
            
        }
        return eRVoto;
    }

    public int Obtener_RVotos_O_Campania(string nombeCampaniaVoto )
    {
        return adRVoto.Obtener_RVotos_O_Campania(nombeCampaniaVoto);
    }

    public int Obtener_RVotos_O_Campania_Organizacion(string campaniaVoto, string nombreOrganizacionVoto)
    {
        return adRVoto.Obtener_RVotos_O_Campania_Organizacion(campaniaVoto, nombreOrganizacionVoto);
    }

    public int Obtener_RVoto_O_Donacion_Total(string nombreCampaniaVoto)
    {
        return adRVoto.Obtener_RVoto_O_Donacion_Total(nombreCampaniaVoto);
    }

    public ERVoto Obtener_RVoto_O_Donacion_Maxima(string nombreCampania)
    {
        ERVoto eRVoto = new ERVoto();
        DTORVoto dtoRVoto = adRVoto.Obtener_RVoto_O_Donacion_Maxima(nombreCampania);
        foreach (DTORVoto.RVotoRow drRVoto in dtoRVoto.RVoto.Rows)
        {
            eRVoto = new ERVoto();
            eRVoto.CodigoUsuario = drRVoto.CodigoUsuario.TrimEnd();
            eRVoto.DonacionVoto = drRVoto.DonacionVoto.ToString().TrimEnd();
        }
        return eRVoto;
    }

    public string Obtener_RVoto_O_Organizacion(string nombreCampania)
    {
        return adRVoto.Obtener_RVoto_O_Organizacion(nombreCampania);
    }
    #endregion
}