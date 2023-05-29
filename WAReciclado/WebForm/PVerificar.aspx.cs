using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;
using SWLNReciclado;

public partial class WebForms_PVerificar : System.Web.UI.Page
{
    //SWLNRecicladoClient swLNReciclado = new SWLNRecicladoClient();
    //ERUsuarioNetvalle eUsuarioNetvalle = new ERUsuarioNetvalle();

    #region Metodos Protegidos
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        string urlInicio = ConfigurationManager.AppSettings["UrlAutenticar"];
        ScriptManager.RegisterStartupScript(UpdatePanel1,UpdatePanel1.GetType(), "Redirect", "window.location.href='" + urlInicio + "';", true);

        //string cuentaCifrada = Page.Request.QueryString["ET"].ToString();
        //string tipoUsuarioCifrado = Page.Request.QueryString["P"].ToString();
        //string sedeAcademicaCifrada = Page.Request.QueryString["D"].ToString();

        SUtil.BorrarSesiones(Session);

        string cuentaCifrada = "sdaasdasdsdaasdasdsdaaasdasdsdaasdasdsdaasdasdsdaasdasdsdaasdasad";
        try
        {
            if (cuentaCifrada.Length > 18)
            {
                //Tuple<string, string, string> tuple = Descifrar_Cadena(cuentaCifrada, tipoUsuarioCifrado, sedeAcademicaCifrada);

                //string cuentaDescifrada = tuple.Item1;
                //string tipoUsuarioDescifrado = tuple.Item2;
                //string sedeAcademicaDescifrada = tuple.Item3;

                string cuentaDescifrada = "BVR5001132"; //*Session["Codigo"].ToString()* /// usuario
                string tipoUsuarioDescifrado = "AD"; /*Session["Rol"].ToString()*/ // rol estudiante
                string sedeAcademicaDescifrada = "Cochabamba"; /*Session["Sede"].ToString()*/ // sede

                if (cuentaDescifrada.Trim() != "")
                {
                    Session["Codigo"] = cuentaDescifrada;
                    Session["Sede"] = sedeAcademicaDescifrada;
                    if (tipoUsuarioDescifrado == "AD")
                    {
                        Session["Rol"] = "ADMINISTRATIVO";
                        Response.Redirect("/WebForm/Administrador/PMenuAdministrador.aspx");
                    }
                    if (tipoUsuarioDescifrado == "EU")
                    {
                        Session["Rol"] = "ESTUDIANTE";
                        Response.Redirect("/WebForm/Usuario/PMenuEstudiante.aspx");
                    }
                }

                CAutenticar cAutenticar = ObtenerAutenticar();

                if (tipoUsuarioDescifrado.Equals("AD"))
                {
                    Tuple<EEmpleado, EMensajeError> tuplaResultado = cAutenticar.Obtener_Empleado_Id_Emp_SedeAcademica(cuentaDescifrada, sedeAcademicaDescifrada);

                    if (tuplaResultado != null && tuplaResultado.Item1 != null)
                    {
                        EEmpleado eEmpleado = tuplaResultado.Item1;
                        if (eEmpleado != null && !string.IsNullOrEmpty(eEmpleado.CodigoEmpleado))
                        {
                            Session["Verificar"] = cuentaDescifrada;

                            Tuple<byte[], EMensajeError> tuplaFotografia = cAutenticar.Obtener_EmpleadoFotografia(eEmpleado.CodigoEmpleado, eEmpleado.SedeAcademica);

                            EUsuarioSesion UsuarioSesion = new EUsuarioSesion(eEmpleado, tuplaFotografia.Item1);
                            cAutenticar.UsuarioSesion = UsuarioSesion;

                            Session["UsuarioSesion"] = UsuarioSesion;

                            Server.Transfer("~/WebForm/PInicio.aspx");
                        }
                        else
                        {
                            SalirAplicacion();
                        }
                    }
                    else
                    {
                        SalirAplicacion();
                    }
                }
                else
                {
                    SalirAplicacion();
                }
            }
            else
            {
                SalirAplicacion();
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            SalirAplicacion();
        }
    }
    #endregion

    #region Metodos privados

    #region Obtener Autenticar
    private CAutenticar ObtenerAutenticar()
    {
        if ((Session["CAutenticar"] as CAutenticar) == null)
        {
            Session["CAutenticar"] = new CAutenticar();
        }

        return Session["CAutenticar"] as CAutenticar;
    }

    #endregion

    #region Salir Aplicacion
    private void SalirAplicacion()
    {
        SUtil.BorrarSesiones(Session);

        string urlInicio = ConfigurationManager.AppSettings["UrlAutenticar"];

        Response.Redirect(urlInicio);
    }

    #endregion

    #region Descifrar Cadena
    private Tuple<string, string, string> Descifrar_Cadena(string cuentaCifrada, string tipoUsuarioCifrado, string sedeAcademicaCifrada)
    {
        string cuentaDescifrada = string.Empty;
        string tipoUsuarioDescifrado = string.Empty;
        string sedeAcademicaDescifrada = string.Empty;

        try
        {
            CDescifrado cDescifrado = new CDescifrado();
            cuentaDescifrada = cDescifrado.Descifrar_Cadena(cuentaCifrada, "Cuenta");
            tipoUsuarioDescifrado = cDescifrado.Descifrar_Cadena(tipoUsuarioCifrado, "TipoUsuario");
            sedeAcademicaDescifrada = cDescifrado.Descifrar_Cadena(sedeAcademicaCifrada, "Sede");
        }
        catch (FaultException<EDefecto> ex)
        {
            //CCorreo cCorreo = new CCorreo();
            //cCorreo.EnviarCorreoError(ex.Detail, "PVerificar", "Descifrar_Cadena");

            throw new FaultException<EDefecto>(null);
        }

        return new Tuple<string, string, string>(cuentaDescifrada, tipoUsuarioDescifrado, sedeAcademicaDescifrada);
    }

    #endregion

    #endregion
}