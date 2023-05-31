using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CRUsuario
/// </summary>
public class CRUsuario
{
    #region Metodos privados
    private ADRUsuario adRUsuario;
    #endregion
    #region Metodos publicos
    public CRUsuario()
    {
        adRUsuario = new ADRUsuario();
    }

    public ERUsuario Obtener_RUsuario_O_Codigo(string Codigo)
    {
        ERUsuario eRUsuario = new ERUsuario();
        DTORUsuario dtoRUsuario = adRUsuario.Obtener_RUsuario_O_Codigo(Codigo);
        foreach (DTORUsuario.RUsuarioRow drRUsuario in dtoRUsuario.RUsuario.Rows)
        {
            eRUsuario = new ERUsuario();
            eRUsuario.CodigoUsuario = drRUsuario.Codigo.ToString().TrimEnd();
            eRUsuario.CreditosUsuario = drRUsuario.Creditos.ToString().TrimEnd();
            eRUsuario.RolUsuario = drRUsuario.Rol.ToString().TrimEnd();
        }
        return eRUsuario;
    }

    public List<ERUsuario> Obtener_RUsuarios_O_Top_Creditos(string Sede)
    {
        ERUsuario eRUsuario = new ERUsuario();
        List<ERUsuario> lsteRUsuario = new List<ERUsuario>();
        DTORUsuario dtoRUsuario = adRUsuario.Obtener_RUsuarios_O_Top_Creditos(Sede);
        foreach (DTORUsuario.RUsuarioRow drRUsuario in dtoRUsuario.RUsuario.Rows)
        {
            eRUsuario = new ERUsuario();
            eRUsuario.CodigoUsuario = drRUsuario.Codigo.ToString().TrimEnd();
            eRUsuario.CreditosUsuario = drRUsuario.Creditos.ToString().TrimEnd();
            eRUsuario.RolUsuario = drRUsuario.Rol.ToString().TrimEnd();
            lsteRUsuario.Add(eRUsuario);
        }
        return lsteRUsuario;
    }

    public List<ERUsuario> Obtener_RUsuarios_O_Sede(string Sede)
    {
        ERUsuario eRUsuario = new ERUsuario();
        List<ERUsuario> lsteRUsuario = new List<ERUsuario>();
        DTORUsuario dtoRUsuario = adRUsuario.Obtener_RUsuarios_O_Sede(Sede);
        foreach (DTORUsuario.RUsuarioRow drRUsuario in dtoRUsuario.RUsuario.Rows)
        {
            eRUsuario = new ERUsuario();
            eRUsuario.CodigoUsuario = drRUsuario.Codigo.ToString().TrimEnd();
            eRUsuario.CreditosUsuario = drRUsuario.Creditos.ToString().TrimEnd();
            lsteRUsuario.Add(eRUsuario);
        }
        return lsteRUsuario;
    }

    public void Actualizar_RUsuario_A_Creditos_Sede(string Campania, string Codigo)
    {
        adRUsuario.Actualizar_RUsuario_A_Creditos_Sede(Campania, Codigo);
    }

    public void Actualizar_RUsuario_A_Creditos_Codigo(string Codigo, string Creditos)
    {
        adRUsuario.Actualizar_RUsuario_A_Creditos_Codigo(Codigo, Creditos);
    }
    #endregion

}