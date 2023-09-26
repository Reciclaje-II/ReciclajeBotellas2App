using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNReciclado;


public partial class PAgregarCampania : System.Web.UI.Page
{
    ERCampania eCampaniaEdit = new ERCampania();
    List<ERCampaniaOrganizacion> eCampaniaOrganizacion = new List<ERCampaniaOrganizacion>();
    List<EROrganizacion> eOrganizaciones = new List<EROrganizacion>();
    COrganizacion cOrganizacion = new COrganizacion();
    CCampania cCampania = new CCampania();
    CCampaniaOrganizacion cCampaniaOrganizacion = new CCampaniaOrganizacion();
    List<ECampaniaAux> lstOrganizaciones;

    #region Metodos privados
    public void PaginaCrearCampania()
    {
        btnAñadirListaOrganizaciones.Visible = true;
        txbNombreCmpania.Enabled = true;
        btnGuardarCampania.Text = "Crear";
        lblCampaniaEditAddTitulo.Text = "CREAR CAMPAÑA";
    }
    public void PaginaEditarCampania()
    {
        lblCampaniaEditAddTitulo.Text = "EDITAR CAMPAÑA";
        btnAñadirListaOrganizaciones.Visible = false;
        txbNombreCmpania.Enabled = false;
        btnGuardarCampania.Text = "Guardar";
        txbNombreCmpania.Text = (Session["EditarCampania"].ToString().Split('-'))[1];
        txbDescripcion.Text = eCampaniaEdit.DescripcionCampania;
    }
    public void CleanPage()
    {
        lblExep.Text = "";
        txbNombreCmpania.Text = "";
        txbDescripcion.Text = "";
        txbFechaFin.Text = "";
        txbFechaInicio.Text = "";
        GridViewListaOrganizaciones.DataSource = null;
        GridViewListaOrganizaciones.DataBind();
        txbFechaInicio.Text = "";
        lblCampaniaEditAddTitulo.Text = "CREAR CAMPAÑA";
        txbFechaFin.Text = "";
        lblExep.Text = "";
        txbDescripcion.Text = "";
        txbNombreCmpania.Text = "";
        Session["OrganizacionesListAgregar"] = null;
        grvOrganizacionesModal.DataSource = null;
        grvOrganizacionesModal.DataBind();
    }
    public void ResetPage()
    {
        CleanPage();
        btnAñadirListaOrganizaciones.Visible = true;
        txbNombreCmpania.Enabled = true;
        GridViewListaOrganizaciones.Columns[1].Visible = true;
        DropDownListOrganizaciones.Visible = true;
    }
    public void CargarOrganizaciones()
    {
        DropDownListOrganizaciones.DataSource = null;
        eOrganizaciones = cOrganizacion.Obtener_ROrganizaciones_O_CO();
        DropDownListOrganizaciones.DataSource = eOrganizaciones;
        DropDownListOrganizaciones.DataBind();

        if (eOrganizaciones.Count == 0)
        {
            btnAñadirListaOrganizaciones.Visible = false;
            lblExep.Text = "No hay ninguna organización!";

        }
    }

    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["OpcionCampania"].ToString() == "0")
        {
            if (!Page.IsPostBack) ResetPage();
            PaginaCrearCampania();

            if (GridViewListaOrganizaciones.Rows.Count > 0)
            {
                lstOrganizaciones = new List<ECampaniaAux>();
                for (int i = 0; i < GridViewListaOrganizaciones.Rows.Count; i++)
                {
                    string valor = GridViewListaOrganizaciones.Rows[i].Cells[0].Text;
                    lstOrganizaciones.Add(new ECampaniaAux(valor));
                }
            }
        }
        if (Session["OpcionCampania"].ToString() == "1" && !Page.IsPostBack)
        {
            eCampaniaEdit = cCampania.Obtener_RCampania_O_Sede_Campania_CC(Session["EditarCampania"].ToString(), Session["Sede"].ToString());
            eCampaniaOrganizacion = cCampaniaOrganizacion.Obtener_RCampaniaOrganizacion_O_Campania_CCO(Session["EditarCampania"].ToString());



            PaginaEditarCampania();



            List<ECampaniaAux> lstOrganizaciones = new List<ECampaniaAux>(); ;
            for (int i = 0; i < eCampaniaOrganizacion.Count(); i++)
            {
                lstOrganizaciones.Add(new ECampaniaAux(eCampaniaOrganizacion[i].OrganizacionCampaniaOrganizacion));
            }
            GridViewListaOrganizaciones.DataSource = null;
            GridViewListaOrganizaciones.DataSource = lstOrganizaciones;
            GridViewListaOrganizaciones.Columns[1].Visible = false;
            GridViewListaOrganizaciones.DataBind();
            DropDownListOrganizaciones.Visible = false;



            string mesInicio = eCampaniaEdit.FechaInicioCampania.Month.ToString(), diaInicio = eCampaniaEdit.FechaInicioCampania.Day.ToString(), mesFin = eCampaniaEdit.FechaFinCampania.Month.ToString(), diaFin = eCampaniaEdit.FechaFinCampania.Day.ToString();
            string fechaInicio = eCampaniaEdit.FechaInicioCampania.Year + "-" + SUtil.ConvertirFechas(mesInicio) + "-" + SUtil.ConvertirFechas(diaInicio);
            string fechaFin = eCampaniaEdit.FechaFinCampania.Year + "-" + SUtil.ConvertirFechas(mesFin) + "-" + SUtil.ConvertirFechas(diaFin);
            txbFechaInicio.Text = fechaInicio;
            txbFechaFin.Text = fechaFin;
        }

        if (!Page.IsPostBack) CargarOrganizaciones();
    }
    protected void btnAñadirListaOrganizaciones_Click(object sender, EventArgs e)
    {
        if (lstOrganizaciones == null)
            lstOrganizaciones = new List<ECampaniaAux>();
        if (!lstOrganizaciones.Exists(orgizacionAux => orgizacionAux.NombreOrganizacion == DropDownListOrganizaciones.SelectedValue))
        {
            lstOrganizaciones.Add(new ECampaniaAux(DropDownListOrganizaciones.SelectedValue));
            GridViewListaOrganizaciones.DataSource = null;
            GridViewListaOrganizaciones.DataSource = lstOrganizaciones;
            GridViewListaOrganizaciones.DataBind();
        }
    }

    protected void btnGuardarCampania_Click(object sender, EventArgs e)
    {
        if (Session["OpcionCampania"].ToString() == "0")
        {
            if (SUtil.ValidacionesTextBox(txbNombreCmpania.Text) && SUtil.ValidacionesTextBox(txbDescripcion.Text))
            {
                if (txbNombreCmpania.Text.Trim() != "" && txbDescripcion.Text.Trim() != "" && txbFechaInicio.Text.Trim() != "" && txbFechaFin.Text.Trim() != "" && lstOrganizaciones != null && lstOrganizaciones.Count >= 2)
                {
                    if (DateTime.Parse(txbFechaInicio.Text) < DateTime.Parse(txbFechaFin.Text))
                    {
                        lblDatosNombreCampania.Text = txbNombreCmpania.Text.Trim();
                        lblDatosDescripcionCampania.Text = txbDescripcion.Text.Trim();

                        lblExep.Text = SUtil.NombreCampaniasConvert(txbNombreCmpania.Text.Trim().ToUpper(), Session["Sede"].ToString(), txbFechaFin.Text.Trim()).ToString();
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Open()", true);

                        grvOrganizacionesModal.DataSource = lstOrganizaciones;
                        grvOrganizacionesModal.DataBind();
                    }
                    else lblExep.Text = "Las fechas no son coherentes";
                }
                else lblExep.Text = "Faltan llenar datos";
            }
            else lblExep.Text = "Fallo en los campos de Nombre y Descripción";
        }
        if (Session["OpcionCampania"].ToString() == "1")
        {
            if (SUtil.ValidacionesTextBox(txbDescripcion.Text))
            {
                if (txbDescripcion.Text.Trim() != "" && txbFechaInicio.Text.Trim() != "" && txbFechaFin.Text.Trim() != "")
                {
                    if (DateTime.Parse(txbFechaInicio.Text) < DateTime.Parse(txbFechaFin.Text))
                    {
                        if (DateTime.Parse(txbFechaInicio.Text) > DateTime.Now)
                        {
                            cCampania.Editar_Campania(txbDescripcion.Text, txbFechaInicio.Text, txbFechaFin.Text);

                            CleanPage();
                            Response.Redirect("PGestionCampanias.aspx");
                        }
                        else lblExep.Text = "La fecha inicial debe ser mayor a la fecha actual";
                    }
                    else lblExep.Text = "Las fechas no son coherentes";
                }
                else lblExep.Text = "Faltan llenar datos";
            }
            else lblExep.Text = "Fallo en el campo Descripción";
        }
    }

    protected void GridViewListaOrganizaciones_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "btnEliminar")
        {
            lstOrganizaciones = new List<ECampaniaAux>();
            for (int i = 0; i < GridViewListaOrganizaciones.Rows.Count; i++)
            {
                string valor = GridViewListaOrganizaciones.Rows[i].Cells[0].Text;
                lstOrganizaciones.Add(new ECampaniaAux(valor));
            }
            int index = Convert.ToInt32(e.CommandArgument.ToString());
            lstOrganizaciones.RemoveAt(index);
            GridViewListaOrganizaciones.DataSource = null;
            GridViewListaOrganizaciones.DataSource = lstOrganizaciones;
            GridViewListaOrganizaciones.DataBind();
        }
    }
    protected void btnAniadirOrganizacion_Click(object sender, EventArgs e)
    {
        Session["Accion"] = "1";
        Response.Redirect("PNuevaOrganizacion.aspx");
    }

    #region Acciones Modal
    protected void btnGuardarAccionesRealizadas_Click(object sender, EventArgs e)
    {
        lstOrganizaciones = new List<ECampaniaAux>();
        for (int i = 0; i < GridViewListaOrganizaciones.Rows.Count; i++)
        {
            string valor = GridViewListaOrganizaciones.Rows[i].Cells[0].Text;
            lstOrganizaciones.Add(new ECampaniaAux(valor));
        }
        cCampaniaOrganizacion.Insertar_Campania_Organizacion(txbNombreCmpania.Text, txbFechaFin.Text, txbDescripcion.Text, txbFechaInicio.Text, lstOrganizaciones);
        CleanPage();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Close()", true);
        Response.Redirect("PGestionCampanias.aspx");
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Close()", true);
    }
    #endregion

}