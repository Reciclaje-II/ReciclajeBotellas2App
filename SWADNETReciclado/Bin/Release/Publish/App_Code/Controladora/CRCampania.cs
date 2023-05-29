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

    public ERCampania Obtener_RCampania_O_Sede(string Sede)
    {
        ERCampania eRCampania = new ERCampania();
        DTORCampania dtoRCampania = adRCampania.Obtener_RCampania_O_Sede(Sede);
        foreach (DTORCampania.RCampaniaRow drRCampania in dtoRCampania.RCampania.Rows)
        {
            eRCampania.Nombre = drRCampania.Nombre.TrimEnd();
            eRCampania.Descripcion = drRCampania.Descripcion.TrimEnd();
            eRCampania.FechaInicio = drRCampania.FechaInicio;
            eRCampania.FechaFin = drRCampania.FechaFin;
            eRCampania.Estado = drRCampania.Estado.TrimEnd();
            eRCampania.Sede = drRCampania.Sede.ToString().TrimEnd();
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
            eRCampania.Nombre = drRCampania.Nombre.TrimEnd();
            eRCampania.Descripcion = drRCampania.Descripcion.TrimEnd();
            eRCampania.FechaInicio = drRCampania.FechaInicio;
            eRCampania.FechaFin = drRCampania.FechaFin;
            eRCampania.Estado = drRCampania.Estado.TrimEnd();
            eRCampania.Sede = drRCampania.Sede.ToString().TrimEnd();
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

    public void Actualizar_RCampania_A_Estado(string Nombre)
    {
        adRCampania.Actualizar_RCampania_A_Estado(Nombre);
    }

    public void Actualizar_RCampania_A_Estado_Cancelado(string Nombre)
    {
        adRCampania.Actualizar_RCampania_A_Estado_Cancelado(Nombre);
    }
    #endregion

}