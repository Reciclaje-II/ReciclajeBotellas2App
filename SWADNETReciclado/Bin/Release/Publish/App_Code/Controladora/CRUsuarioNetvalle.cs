using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CRUsuarioNetvalle
/// </summary>
public class CRUsuarioNetvalle
{
    #region Metodos privados
    private ADRUsuarioNetvalle adRUsuarioNetvalle;
    #endregion
    #region Metodo publicos
    public CRUsuarioNetvalle()
    {
        adRUsuarioNetvalle = new ADRUsuarioNetvalle();
    }

    public ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(string sedeUsuarioNetvalle, string codigoUsuarioNetvalle)
    {
        ERUsuarioNetvalle eRUsuarioNetvalle = new ERUsuarioNetvalle();
        DTORUsuarioNetvalle dtoRUsuarioNetvalle = adRUsuarioNetvalle.Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(sedeUsuarioNetvalle, codigoUsuarioNetvalle);
        foreach (DTORUsuarioNetvalle.RUsuarioNetvalleRow drRUsuarioNetvalle in dtoRUsuarioNetvalle.RUsuarioNetvalle.Rows)
        {
            eRUsuarioNetvalle = new ERUsuarioNetvalle();
            eRUsuarioNetvalle.NombresUsuarioNetvalle = drRUsuarioNetvalle.NombresUsuarioNetvalle.ToString().TrimEnd();
            eRUsuarioNetvalle.ApellidosUsuarioNetvalle = drRUsuarioNetvalle.ApellidosUsuarioNetvalle.ToString().TrimEnd();
        }
        return eRUsuarioNetvalle;
    }

    public ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Codigo(string codigoUsuarioNetvalle)
    {
        ERUsuarioNetvalle eRUsuarioNetvalle = new ERUsuarioNetvalle();
        DTORUsuarioNetvalle dtoRUsuarioNetvalle = adRUsuarioNetvalle.Obtener_RUsuarioNetvalle_O_Codigo(codigoUsuarioNetvalle);
        foreach (DTORUsuarioNetvalle.RUsuarioNetvalleRow drRUsuarioNetvalle in dtoRUsuarioNetvalle.RUsuarioNetvalle.Rows)
        {
            eRUsuarioNetvalle = new ERUsuarioNetvalle();
            eRUsuarioNetvalle.CodigoUsuarioNetvalle = drRUsuarioNetvalle.CodigoUsuarioNetvalle.ToString().TrimEnd();
            eRUsuarioNetvalle.NombresUsuarioNetvalle = drRUsuarioNetvalle.NombresUsuarioNetvalle.ToString().TrimEnd();
            eRUsuarioNetvalle.ApellidosUsuarioNetvalle = drRUsuarioNetvalle.ApellidosUsuarioNetvalle.ToString().TrimEnd();
            eRUsuarioNetvalle.CargoUsuarioNetvalle = drRUsuarioNetvalle.CargoUsuarioNetvalle.ToString().TrimEnd();
            eRUsuarioNetvalle.TarjetaUsuarioNetvalle = drRUsuarioNetvalle.TarjetaUsuarioNetvalle.ToString().TrimEnd();
            eRUsuarioNetvalle.SedeUsuarioNetvalle = drRUsuarioNetvalle.SedeUsuarioNetvalle.ToString().TrimEnd();
        }
        return eRUsuarioNetvalle;
    }

    public ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Tarjeta(string tarjetaUsuarioNetvalle)
    {
        ERUsuarioNetvalle eRUsuarioNetvalle = new ERUsuarioNetvalle();
        DTORUsuarioNetvalle dtoRUsuarioNetvalle = adRUsuarioNetvalle.Obtener_RUsuarioNetvalle_O_Tarjeta(tarjetaUsuarioNetvalle);
        foreach (DTORUsuarioNetvalle.RUsuarioNetvalleRow drRUsuarioNetvalle in dtoRUsuarioNetvalle.RUsuarioNetvalle.Rows)
        {
            eRUsuarioNetvalle = new ERUsuarioNetvalle();
            eRUsuarioNetvalle.CodigoUsuarioNetvalle = drRUsuarioNetvalle.CodigoUsuarioNetvalle.ToString().TrimEnd();
            eRUsuarioNetvalle.NombresUsuarioNetvalle = drRUsuarioNetvalle.NombresUsuarioNetvalle.ToString().TrimEnd();
            eRUsuarioNetvalle.ApellidosUsuarioNetvalle = drRUsuarioNetvalle.ApellidosUsuarioNetvalle.ToString().TrimEnd();
            eRUsuarioNetvalle.CargoUsuarioNetvalle = drRUsuarioNetvalle.CargoUsuarioNetvalle.ToString().TrimEnd();
            eRUsuarioNetvalle.TarjetaUsuarioNetvalle = drRUsuarioNetvalle.TarjetaUsuarioNetvalle.ToString().TrimEnd();
            eRUsuarioNetvalle.SedeUsuarioNetvalle = drRUsuarioNetvalle.SedeUsuarioNetvalle.ToString().TrimEnd();
        }
        return eRUsuarioNetvalle;
    }
    #endregion
}