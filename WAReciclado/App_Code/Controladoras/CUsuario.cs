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
public class CUsuario : System.Web.UI.Page
{
    LNServicio lnServicio = new LNServicio();
    List<ERCampania> lstERCampania = new List<ERCampania>();
    List<ERUsuario> eUsuarios = new List<ERUsuario>();
    ERCampania eCampania = new ERCampania();
    ECampaniaFinalizadaCompleja eCampaniaFinalizadaCompleja = new ECampaniaFinalizadaCompleja();

    public CUsuario()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    #region Metodos publicos

    #region LNServicio
    public ERUsuario Obtener_RUsuario_O_Codigo_CU(string CodigoUsuario)
    {
        ERUsuario erUsuario = new ERUsuario();
        try
        {
            erUsuario = lnServicio.Obtener_RUsuario_O_Codigo(CodigoUsuario);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return erUsuario;

    }
    public List<EUsuarioCompleja> Obtener_EUsuarioCompleja_O_Sede_CU(string SedeUsuarioNetvalle)
    {
        List<EUsuarioCompleja> lstEUsuarioCompleja = new List<EUsuarioCompleja>();
        try
        {
            lstEUsuarioCompleja = lnServicio.Obtener_EUsuarioCompleja_O_Sede(SedeUsuarioNetvalle).ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return lstEUsuarioCompleja;
    }
    #endregion

    #endregion
}