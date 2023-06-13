using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CRContenedor
/// </summary>
public class CRContenedor
{

    #region Metodo privado
    private ADRContenedor adRContenedor;
    #endregion
    #region Metodos publicos
    public CRContenedor()
    {
        adRContenedor = new ADRContenedor();
    }

    public List<ERContenedor> Obtener_RContenedor_O_Codigo(string codigoUsuario)
    {
        ERContenedor eRContenedor;
        List<ERContenedor> lstERContenedor = new List<ERContenedor>();
        DTORContenedor dtoRContenedor = adRContenedor.Obtener_RContenedor_O_Codigo(codigoUsuario);
        foreach (DTORContenedor.RContenedorRow drRContenedor in dtoRContenedor.RContenedor.Rows)
        {
            eRContenedor = new ERContenedor();
            eRContenedor.CodigoUsuario = drRContenedor.CodigoUsuario.TrimEnd();
            eRContenedor.IdMaquinaContenedor = drRContenedor.IdMaquinaContenedor;
            eRContenedor.GramosContenedor = drRContenedor.GramosContenedor.ToString().TrimEnd();
            eRContenedor.FechaRegistroContenedor = drRContenedor.FechaRegistroContenedor;
            lstERContenedor.Add(eRContenedor);
        }
        return lstERContenedor;
    }

    public void Insertar_RContenedor_I(ERContenedor eRContenedor)
    {
        adRContenedor.Insertar_RContenedor_I(eRContenedor);
    }
    #endregion
}