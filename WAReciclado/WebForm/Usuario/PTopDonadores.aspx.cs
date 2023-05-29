using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNReciclado;

public partial class PTopDonadores : System.Web.UI.Page
{

    SWLNRecicladoClient swlnReciclado = new SWLNRecicladoClient();
    CUsuario cUsuario = new CUsuario();
    List<EUsuarioCompleja> lstEusuarioCompleja = new List<EUsuarioCompleja>();
    int lugar;
    protected void Page_Load(object sender, EventArgs e)
    {
        lstEusuarioCompleja = cUsuario.Obtener_EUsuarioCompleja_O_Sede_CU(Session["Sede"].ToString()).ToList();
        lstEusuarioCompleja.OrderByDescending(a => a.Creditos);
        divContenedor.Controls.Clear();
        lugar = 1;
        foreach (EUsuarioCompleja eUsuarioCompleja in lstEusuarioCompleja)
        {
            CargarDatos(lugar, eUsuarioCompleja.NombreCompleto, eUsuarioCompleja.Creditos);
            lugar++;
        }
    }
    private void CargarDatos(int numeroLugar, string nombre, int creditos)
    {
        CUTopUsuario ucTopUsuario;
        ucTopUsuario = (CUTopUsuario)LoadControl("~/Controles/CUTopUsuario.ascx");
        ucTopUsuario.NumeroLugar = numeroLugar;
        ucTopUsuario.Nombre = nombre;
        ucTopUsuario.Creditos = creditos;
        divContenedor.Controls.Add(ucTopUsuario);
    }
}