using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using SWLNReciclado;
using System.Web.UI;
using System.Text.RegularExpressions;
using System.ServiceModel;

/// <summary>
/// Summary description for CCampania
/// </summary>
public class CContenedor : System.Web.UI.Page
{
    LNServicio lnServicio = new LNServicio();

    public CContenedor()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    #region Metodos publicos

    #region LNServicio
    public List<ERContenedor> Obtener_RContenedor_O_Codigo_CTR(string codigoUsuario)
    {
        List<ERContenedor> lsteRContenedor = new List<ERContenedor>();
        try
        {
            lsteRContenedor = lnServicio.Obtener_RContenedor_O_Codigo(codigoUsuario);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return lsteRContenedor;
    }
    #endregion

    #endregion
}