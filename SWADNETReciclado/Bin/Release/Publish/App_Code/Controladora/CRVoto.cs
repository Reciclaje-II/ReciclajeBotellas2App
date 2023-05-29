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

    public ERVoto Obtener_RVoto_O_Codigo_Campania(string Codigo, string Campania)
    {
        ERVoto eRVoto = new ERVoto();
        DTORVoto dtoRVoto = adRVoto.Obtener_RVoto_O_Codigo_Campania(Codigo, Campania);
        foreach (DTORVoto.RVotoRow drRVoto in dtoRVoto.RVoto.Rows)
        {
            eRVoto = new ERVoto();
            eRVoto.Codigo = drRVoto.Codigo.TrimEnd();
            eRVoto.Campania = drRVoto.Campania.TrimEnd();
            eRVoto.Organizacion = drRVoto.Organizacion.TrimEnd();
            eRVoto.Fecha = drRVoto.Fecha;
            eRVoto.Donacion = drRVoto.Donacion.ToString().TrimEnd();
            eRVoto.Estado = drRVoto.Estado.ToString().TrimEnd();
        }
        return eRVoto;
    }

    public int Obtener_RVotos_O_Campania(string Campania)
    {
        return adRVoto.Obtener_RVotos_O_Campania(Campania);
    }

    public int Obtener_RVotos_O_Campania_Organizacion(string Campania, string Organizacion)
    {
        return adRVoto.Obtener_RVotos_O_Campania_Organizacion(Campania, Organizacion);
    }

    public int Obtener_RVoto_O_Donacion_Total(string Campania)
    {
        return adRVoto.Obtener_RVoto_O_Donacion_Total(Campania);
    }

    public ERVoto Obtener_RVoto_O_Donacion_Maxima(string Campania)
    {
        ERVoto eRVoto = new ERVoto();
        DTORVoto dtoRVoto = adRVoto.Obtener_RVoto_O_Donacion_Maxima(Campania);
        foreach (DTORVoto.RVotoRow drRVoto in dtoRVoto.RVoto.Rows)
        {
            eRVoto = new ERVoto();
            eRVoto.Codigo = drRVoto.Codigo.TrimEnd();
            eRVoto.Donacion = drRVoto.Donacion.ToString().TrimEnd();
        }
        return eRVoto;
    }

    public string Obtener_RVoto_O_Organizacion(string Campania)
    {
        return adRVoto.Obtener_RVoto_O_Organizacion(Campania);
    }
    #endregion
}