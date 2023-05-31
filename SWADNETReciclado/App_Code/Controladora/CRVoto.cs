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

    public ERVoto Obtener_RVoto_O_Codigo_Campania(string CodigoUsuario, string NombreCampania)
    {
        ERVoto eRVoto = new ERVoto();
        DTORVoto dtoRVoto = adRVoto.Obtener_RVoto_O_Codigo_Campania(CodigoUsuario, NombreCampania);
        foreach (DTORVoto.RVotoRow drRVoto in dtoRVoto.RVoto.Rows)
        {
            eRVoto = new ERVoto();
            eRVoto.CodigoUsuario = drRVoto.CodigoUsuario.TrimEnd();
            eRVoto.CampaniaVoto = drRVoto.CampaniaVoto.TrimEnd();
            eRVoto.OrganizacionVoto = drRVoto.OrganizacionVoto.TrimEnd();
            eRVoto.FechaRegistroVoto = drRVoto.FechaRegistroVoto;
            eRVoto.DonacionVoto = drRVoto.DonacionVoto.ToString().TrimEnd();
            eRVoto.EstadoVoto = drRVoto.EstadoVoto.ToString().TrimEnd();
            eRVoto.IdVoto = drRVoto.IdVoto.ToString().TrimEnd();
            
        }
        return eRVoto;
    }

    public int Obtener_RVotos_O_Campania(string NombreCampania)
    {
        return adRVoto.Obtener_RVotos_O_Campania(NombreCampania);
    }

    public int Obtener_RVotos_O_Campania_Organizacion(string CampaniaCampaniaOrganizacion, string OrganizacionCampaniaOrganizacion)
    {
        return adRVoto.Obtener_RVotos_O_Campania_Organizacion(CampaniaCampaniaOrganizacion, OrganizacionCampaniaOrganizacion);
    }

    public int Obtener_RVoto_O_Donacion_Total(string CampaniaVoto)
    {
        return adRVoto.Obtener_RVoto_O_Donacion_Total(CampaniaVoto);
    }

    public ERVoto Obtener_RVoto_O_Donacion_Maxima(string NombreCampania)
    {
        ERVoto eRVoto = new ERVoto();
        DTORVoto dtoRVoto = adRVoto.Obtener_RVoto_O_Donacion_Maxima(NombreCampania);
        foreach (DTORVoto.RVotoRow drRVoto in dtoRVoto.RVoto.Rows)
        {
            eRVoto = new ERVoto();
            eRVoto.CodigoUsuario = drRVoto.CodigoUsuario.TrimEnd();
            eRVoto.DonacionVoto = drRVoto.DonacionVoto.ToString().TrimEnd();
        }
        return eRVoto;
    }

    public string Obtener_RVoto_O_Organizacion(string NombreCampania)
    {
        return adRVoto.Obtener_RVoto_O_Organizacion(NombreCampania);
    }
    #endregion
}