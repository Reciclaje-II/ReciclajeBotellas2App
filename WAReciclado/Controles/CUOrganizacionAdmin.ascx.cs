using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CUOrganizacionAdmin : System.Web.UI.UserControl
{
    public string PathImage { get; set; }
    public int Votos { get; set; }
    public string OrganizacionNombre { get; set; }
    protected void Page_Load(object sender, EventArgs e)
    {
        imgOrganizacion.ImageUrl = PathImage;
        lblVotos.Text = Votos.ToString();
    }
}