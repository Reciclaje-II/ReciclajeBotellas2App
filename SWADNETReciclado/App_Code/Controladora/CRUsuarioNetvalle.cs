﻿using System;
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

    public ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(string Sede, string Codigo)
    {
        ERUsuarioNetvalle eRUsuarioNetvalle = new ERUsuarioNetvalle();
        DTORUsuarioNetvalle dtoRUsuarioNetvalle = adRUsuarioNetvalle.Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(Sede,Codigo);
        foreach (DTORUsuarioNetvalle.RUsuarioNetvalleRow drRUsuarioNetvalle in dtoRUsuarioNetvalle.RUsuarioNetvalle.Rows)
        {
            eRUsuarioNetvalle = new ERUsuarioNetvalle();
            eRUsuarioNetvalle.NombresUsuarioNetvalle = drRUsuarioNetvalle.Nombres.ToString().TrimEnd();
            eRUsuarioNetvalle.ApellidosUsuarioNetvalle = drRUsuarioNetvalle.Apellidos.ToString().TrimEnd();
        }
        return eRUsuarioNetvalle;
    }

    public ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Codigo(string Codigo)
    {
        ERUsuarioNetvalle eRUsuarioNetvalle = new ERUsuarioNetvalle();
        DTORUsuarioNetvalle dtoRUsuarioNetvalle = adRUsuarioNetvalle.Obtener_RUsuarioNetvalle_O_Codigo(Codigo);
        foreach (DTORUsuarioNetvalle.RUsuarioNetvalleRow drRUsuarioNetvalle in dtoRUsuarioNetvalle.RUsuarioNetvalle.Rows)
        {
            eRUsuarioNetvalle = new ERUsuarioNetvalle();
            eRUsuarioNetvalle.CodigoUsuarioNetvalle = drRUsuarioNetvalle.Codigo.ToString().TrimEnd();
            eRUsuarioNetvalle.NombresUsuarioNetvalle = drRUsuarioNetvalle.Nombres.ToString().TrimEnd();
            eRUsuarioNetvalle.ApellidosUsuarioNetvalle = drRUsuarioNetvalle.Apellidos.ToString().TrimEnd();
            eRUsuarioNetvalle.CargoUsuarioNetvalle = drRUsuarioNetvalle.Cargo.ToString().TrimEnd();
            eRUsuarioNetvalle.TarjetaUsuarioNetvalle = drRUsuarioNetvalle.Tarjeta.ToString().TrimEnd();
            eRUsuarioNetvalle.SedeUsuarioNetvalle = drRUsuarioNetvalle.Sede.ToString().TrimEnd();
        }
        return eRUsuarioNetvalle;
    }

    public ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Tarjeta(string Tarjeta)
    {
        ERUsuarioNetvalle eRUsuarioNetvalle = new ERUsuarioNetvalle();
        DTORUsuarioNetvalle dtoRUsuarioNetvalle = adRUsuarioNetvalle.Obtener_RUsuarioNetvalle_O_Tarjeta(Tarjeta);
        foreach (DTORUsuarioNetvalle.RUsuarioNetvalleRow drRUsuarioNetvalle in dtoRUsuarioNetvalle.RUsuarioNetvalle.Rows)
        {
            eRUsuarioNetvalle = new ERUsuarioNetvalle();
            eRUsuarioNetvalle.CodigoUsuarioNetvalle = drRUsuarioNetvalle.Codigo.ToString().TrimEnd();
            eRUsuarioNetvalle.NombresUsuarioNetvalle = drRUsuarioNetvalle.Nombres.ToString().TrimEnd();
            eRUsuarioNetvalle.ApellidosUsuarioNetvalle = drRUsuarioNetvalle.Apellidos.ToString().TrimEnd();
            eRUsuarioNetvalle.CargoUsuarioNetvalle = drRUsuarioNetvalle.Cargo.ToString().TrimEnd();
            eRUsuarioNetvalle.TarjetaUsuarioNetvalle = drRUsuarioNetvalle.Tarjeta.ToString().TrimEnd();
            eRUsuarioNetvalle.SedeUsuarioNetvalle = drRUsuarioNetvalle.Sede.ToString().TrimEnd();
        }
        return eRUsuarioNetvalle;
    }
    #endregion
}