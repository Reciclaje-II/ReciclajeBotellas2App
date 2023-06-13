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

    public ERUsuario Obtener_RUsuario_O_Codigo(string codigoUsuario)
    {
        ERUsuario eRUsuario = new ERUsuario();
        DTORUsuario dtoRUsuario = adRUsuario.Obtener_RUsuario_O_Codigo(codigoUsuario);
        foreach (DTORUsuario.RUsuarioRow drRUsuario in dtoRUsuario.RUsuario.Rows)
        {
            eRUsuario = new ERUsuario();
            eRUsuario.CodigoUsuario = drRUsuario.CodigoUsuario.ToString().TrimEnd();
            eRUsuario.CreditosUsuario = drRUsuario.CreditosUsuario.ToString().TrimEnd();
            eRUsuario.RolUsuario = drRUsuario.RolUsuario.ToString().TrimEnd();
            ///eRUsuario.RolUsuario = drRUsuario.RolUsuario.ToString().TrimEnd();
        }
        return eRUsuario;
    }

    public List<ERUsuario> Obtener_RUsuarios_O_Top_Creditos(string sedeUsuarioNetvalle)
    {
        ERUsuario eRUsuario = new ERUsuario();
        List<ERUsuario> lsteRUsuario = new List<ERUsuario>();
        DTORUsuario dtoRUsuario = adRUsuario.Obtener_RUsuarios_O_Top_Creditos(sedeUsuarioNetvalle);
        foreach (DTORUsuario.RUsuarioRow drRUsuario in dtoRUsuario.RUsuario.Rows)
        {
            eRUsuario = new ERUsuario();
            eRUsuario.CodigoUsuario = drRUsuario.CodigoUsuario.ToString().TrimEnd();
            eRUsuario.CreditosUsuario = drRUsuario.CreditosUsuario.ToString().TrimEnd();
            eRUsuario.RolUsuario = drRUsuario.RolUsuario.ToString().TrimEnd();
            //eRUsuario.RolUsuario = drRUsuario.RolUsuario.ToString().TrimEnd();
            lsteRUsuario.Add(eRUsuario);
        }
        return lsteRUsuario;
    }
    public List<ERUsuario> Obtener_RUsuarios_O_Sede(string sedeUsuarioNetvalle)
    {
        ERUsuario eRUsuario = new ERUsuario();
        List<ERUsuario> lsteRUsuario = new List<ERUsuario>();
        DTORUsuario dtoRUsuario = adRUsuario.Obtener_RUsuarios_O_Sede(sedeUsuarioNetvalle);
        foreach (DTORUsuario.RUsuarioRow drRUsuario in dtoRUsuario.RUsuario.Rows)
        {
            eRUsuario = new ERUsuario();
            eRUsuario.CodigoUsuario = drRUsuario.CodigoUsuario.ToString().TrimEnd();
            eRUsuario.CreditosUsuario = drRUsuario.CreditosUsuario.ToString().TrimEnd();
            lsteRUsuario.Add(eRUsuario);
        }
        return lsteRUsuario;
    }

    public void Actualizar_RUsuario_A_Creditos_Sede(string codigoUsuarioNetvalle)
    {
        adRUsuario.Actualizar_RUsuario_A_Creditos_Sede(codigoUsuarioNetvalle);
    }

    public void Actualizar_RUsuario_A_Creditos_Codigo(string Codigo, string Creditos)
    {
        adRUsuario.Actualizar_RUsuario_A_Creditos_Codigo(Codigo, Creditos);
    }
    #endregion

}