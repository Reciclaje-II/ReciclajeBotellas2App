using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CUTopUsuario : System.Web.UI.UserControl
{
    public int NumeroLugar { get; set; }
    public string Nombre { get; set; }
    public int Creditos { get; set; }
    protected void Page_Load(object sender, EventArgs e)
    {
        lblLugar.Text = NumeroLugar.ToString();
        lblNombre.Text = Nombre;
        lblCreditos.Text = Creditos + " Créditos";
    }
}