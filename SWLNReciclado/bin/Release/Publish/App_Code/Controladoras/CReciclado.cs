using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI.WebControls;
using System.Xml;
using SWADNETReciclado;
using SWReciclaje;

/// <summary>
/// Descripción breve de CReciclado
/// </summary>
public class CReciclado
{
    #region Variable de miembro
    ASNETReciclado asNetReciclado;
    #endregion
    public CReciclado()
    {
        asNetReciclado = new ASNETReciclado();
    }
    #region Metodos privados

    private EDefecto ContruirErrorServicio(TTipoDefecto tipoDefecto, string metodo, string excepcion, string mensaje)
    {
        EDefecto eDefecto = new EDefecto();
        eDefecto.TipoDefecto = tipoDefecto;
        eDefecto.Servicio = "SWLNReciclado";
        eDefecto.Clase = "CReciclado";
        eDefecto.Metodo = metodo;
        eDefecto.Excepcion = excepcion;
        eDefecto.Mensaje = mensaje;
        return eDefecto;
    }

    #endregion
    #region Metodos publicos    
    #region RCampania
    public ERCampania Obtener_RCampania_O_Sede(string sedeCampania)
    {
        ERCampania erCampania = new ERCampania();
        try
        {
            erCampania = asNetReciclado.Obtener_RCampania_O_Sede(sedeCampania);

        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RCampania_O_Sede", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            //if (feaultEx == null)
            //{
            erCampania = asNetReciclado.Obtener_RCampania_O_Sede(sedeCampania);
            //}
            //else
            //{
            //    EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RCampania_O_Sede", CommEx.ToString(), CommEx.Message);
            //    throw new FaultException<EDefecto>(eDefecto);
            //}

        }
        return erCampania;
    }
    public ERCampania Obtener_RCampania_O_Sede_Campania(string nombreCampania, string SedeCampania)
    {
        ERCampania erCampania = new ERCampania();
        try
        {
            erCampania = asNetReciclado.Obtener_RCampania_O().Find(campania => campania.NombreCampania == nombreCampania && campania.SedeCampania.ToUpper() == SedeCampania.ToUpper());

        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RCampania_O_Sede_Campania", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                erCampania = asNetReciclado.Obtener_RCampania_O().Find(campania => campania.NombreCampania == nombreCampania && campania.SedeCampania.ToUpper() == SedeCampania.ToUpper());
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RCampania_O_Sede_Campania", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return erCampania;
    }
    public List<ERCampania> Obtener_RCampania_O(string SedeCampania)
    {
        List<ERCampania> lstErCampania = new List<ERCampania>();
        try
        {
            lstErCampania = asNetReciclado.Obtener_RCampania_O().Where(campania => campania.SedeCampania.ToUpper() == SedeCampania.ToUpper()).ToList();

        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RCampania_O", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstErCampania = asNetReciclado.Obtener_RCampania_O().Where(campania => campania.SedeCampania.ToUpper() == SedeCampania.ToUpper()).ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RCampania_O", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
                //throw feaultEx;
            }

        }
        return lstErCampania;
    }
    public void Insertar_RCampania_I(string nombreCampania, string descripcionCampania, DateTime fechaInicioCampania, DateTime fechaFinCampania, string sedeCampania)
    {
        ERCampania eRCampania = new ERCampania();
        try
        {
            eRCampania.NombreCampania = nombreCampania;
            eRCampania.DescripcionCampania = descripcionCampania;
            eRCampania.FechaInicioCampania = fechaInicioCampania;
            eRCampania.FechaFinCampania = fechaFinCampania;
            eRCampania.SedeCampania = sedeCampania;
            asNetReciclado.Insertar_RCampania_I(eRCampania);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_RCampania_I", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                asNetReciclado.Insertar_RCampania_I(eRCampania);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_RCampania_I", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }
    public void Actualizar_RCampania_A(string nombreCampania, string descripcionCampania, DateTime fechaInicioCampania, DateTime fechaFinCampania, string sedeCampania)
    {
        ERCampania eRCampania = new ERCampania();
        try
        {
            eRCampania.NombreCampania = nombreCampania;
            eRCampania.DescripcionCampania = descripcionCampania;
            eRCampania.FechaInicioCampania = fechaInicioCampania;
            eRCampania.FechaFinCampania = fechaFinCampania;
            eRCampania.SedeCampania = sedeCampania;
            asNetReciclado.Actualizar_RCampania_A(eRCampania);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_RCampania_A", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                asNetReciclado.Actualizar_RCampania_A(eRCampania);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_RCampania_A", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }
    public void Actualizar_RCampania_A_Estado(string NombreCampania)
    {
        try
        {
            asNetReciclado.Actualizar_RCampania_A_Estado(NombreCampania);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_RCampania_A_Estado", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                asNetReciclado.Actualizar_RCampania_A_Estado(NombreCampania);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_RCampania_A_Estado", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }
    public void Actualizar_RCampania_A_Estado_Cancelado(string NombreCampania)
    {
        try
        {
            asNetReciclado.Actualizar_RCampania_A_Estado_Cancelado(NombreCampania);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_RCampania_A_Estado_Cancelado", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                asNetReciclado.Actualizar_RCampania_A_Estado_Cancelado(NombreCampania);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_RCampania_A_Estado_Cancelado", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }
    #endregion
    #region RCampaniaOrganizacion
    public List<ERCampaniaOrganizacion> Obtener_RCampaniaOrganizacion_O_Campania(string CampaniaCampaniaOrganizacion)
    {
        List<ERCampaniaOrganizacion> lstErCampania = new List<ERCampaniaOrganizacion>();
        try
        {
            lstErCampania = asNetReciclado.Obtener_RCampaniaOrganizacion_O_Campania(CampaniaCampaniaOrganizacion);

        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RCampaniaOrganizacion_O_Campania", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstErCampania = asNetReciclado.Obtener_RCampaniaOrganizacion_O_Campania(CampaniaCampaniaOrganizacion);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RCampaniaOrganizacion_O_Campania", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return lstErCampania;
    }
    public void Insertar_RCampaniaOrganizacion_I(string CampaniaCampaniaOrganizacion, string OrganizacionampaniaOrganizacion)
    {
        ERCampaniaOrganizacion eRCampaniaOrganizacion = new ERCampaniaOrganizacion();
        try
        {
            eRCampaniaOrganizacion.CampaniaCampaniaOrganizacion = CampaniaCampaniaOrganizacion;
            eRCampaniaOrganizacion.OrganizacionCampaniaOrganizacion = OrganizacionampaniaOrganizacion;
            asNetReciclado.Insertar_RCampaniaOrganizacion_I(eRCampaniaOrganizacion);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_RCampaniaOrganizacion_I", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                asNetReciclado.Insertar_RCampaniaOrganizacion_I(eRCampaniaOrganizacion);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_RCampaniaOrganizacion_I", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }

    #endregion
    #region ROrganizacion
    public EROrganizacion Obtener_ROrganizacion_O_Nombre(string nombre)
    {
        EROrganizacion erOganizacion = new EROrganizacion();
        try
        {
            erOganizacion = asNetReciclado.Obtener_ROrganizacion_O_Nombre(nombre);

        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_ROrganizacion_O_Nombre", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                erOganizacion = asNetReciclado.Obtener_ROrganizacion_O_Nombre(nombre);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_ROrganizacion_O_Nombre", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return erOganizacion;
    }
    public List<EROrganizacion> Obtener_ROrganizaciones_O()
    {
        List<EROrganizacion> lstErOrganizacion = new List<EROrganizacion>();
        try
        {
            lstErOrganizacion = asNetReciclado.Obtener_ROrganizaciones_O();

        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_ROrganizaciones_O", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstErOrganizacion = asNetReciclado.Obtener_ROrganizaciones_O();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_ROrganizaciones_O", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return lstErOrganizacion;
    }
    public void Insertar_ROrganizacion_I(string nombreOrganizacion, string descripcionOrganizacion)
    {
        EROrganizacion eROrganizacion = new EROrganizacion();
        try
        {
            eROrganizacion.NombreOrganizacion = nombreOrganizacion;
            eROrganizacion.DescripcionOrganizacion = descripcionOrganizacion;
            asNetReciclado.Insertar_ROrganizacion_I(eROrganizacion);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_ROrganizacion_I", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                asNetReciclado.Insertar_ROrganizacion_I(eROrganizacion);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_ROrganizacion_I", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }
    public void Actualizar_ROrganizacion_A(string nombreOrganizacion, string descripcionOrganizacion)
    {
        EROrganizacion eROrganizacion = new EROrganizacion();
        try
        {
            eROrganizacion.NombreOrganizacion = nombreOrganizacion;
            eROrganizacion.DescripcionOrganizacion = descripcionOrganizacion;
            asNetReciclado.Actualizar_ROrganizacion_A(eROrganizacion);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_ROrganizacion_A", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                asNetReciclado.Actualizar_ROrganizacion_A(eROrganizacion);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_ROrganizacion_A", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }
    public void Eliminar_ROrganizacion_E_Nombre(string Nombre)
    {
        try
        {
            asNetReciclado.Eliminar_ROrganizacion_E_Nombre(Nombre);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Eliminar_ROrganizacion_E_Nombre", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                asNetReciclado.Eliminar_ROrganizacion_E_Nombre(Nombre);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Eliminar_ROrganizacion_E_Nombre", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }
    #endregion
    #region RImagen
    public List<ERImagen> Obtener_RImagen_O_Organizacion(string organizacionImagen, byte tipoImagen)
    {
        List<ERImagen> lstErImagen = new List<ERImagen>();
        try
        {
            lstErImagen = asNetReciclado.Obtener_RImagen_O_Organizacion(organizacionImagen, tipoImagen);

        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RImagen_O_Organizacion", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstErImagen = asNetReciclado.Obtener_RImagen_O_Organizacion(organizacionImagen, tipoImagen);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RImagen_O_Organizacion", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return lstErImagen;
    }
    #endregion
    #region RVoto
    public void Insertar_RVoto_I(string codigoUsuario, string nombreCampania, string nombreOrganizacion, DateTime fechaRegistroVoto, string donacionVoto, string estadoVoto)
    {
        ERVoto eRVoto = new ERVoto();
        try
        {
            eRVoto.CodigoUsuario = codigoUsuario;
            eRVoto.CampaniaVoto = nombreCampania;
            eRVoto.OrganizacionVoto = nombreOrganizacion;
            eRVoto.FechaRegistroVoto = fechaRegistroVoto;
            eRVoto.DonacionVoto = donacionVoto;
            eRVoto.EstadoVoto = estadoVoto;
            asNetReciclado.Insertar_RVoto_I(eRVoto);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_RVoto_I", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                asNetReciclado.Insertar_RVoto_I(eRVoto);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_RVoto_I", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }
    public void Actualizar_RVoto_A(string codigoUsuario, string nombreCampaniaVoto, string organizacionVoto, DateTime fechaRegistroVoto, string donacionVoto, string estadoVoto)
    {
        ERVoto eRVoto = new ERVoto();
        try
        {
            eRVoto.CodigoUsuario = codigoUsuario;
            eRVoto.CampaniaVoto = nombreCampaniaVoto;
            eRVoto.OrganizacionVoto = organizacionVoto;
            eRVoto.FechaRegistroVoto = fechaRegistroVoto;
            eRVoto.DonacionVoto = donacionVoto;
            eRVoto.EstadoVoto = estadoVoto;
            asNetReciclado.Actualizar_RVoto_A(eRVoto);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_RVoto_A", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                asNetReciclado.Actualizar_RVoto_A(eRVoto);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_RVoto_A", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }
    public ERVoto Obtener_RVoto_O_Codigo_Campania(string codigoUsuario, string nombreCampania)
    {
        ERVoto erVoto = new ERVoto();
        try
        {
            erVoto = asNetReciclado.Obtener_RVoto_O_Codigo_Campania(codigoUsuario, nombreCampania);

        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RVoto_O_Codigo_Campania", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                erVoto = asNetReciclado.Obtener_RVoto_O_Codigo_Campania(codigoUsuario, nombreCampania);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RVoto_O_Codigo_Campania", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return erVoto;
    }
    public int Obtener_RVotos_O_Campania(string nombeCampaniaVoto)
    {
        int votos = 0;
        try
        {
            votos = asNetReciclado.Obtener_RVotos_O_Campania(nombeCampaniaVoto);

        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RVotos_O_Campania", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                votos = asNetReciclado.Obtener_RVotos_O_Campania(nombeCampaniaVoto);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RVotos_O_Campania", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return votos;
    }
    public int Obtener_RVotos_O_Campania_Organizacion(string campaniaVoto, string nombreOrganizacionVoto)
    {
        int votos = 0;
        try
        {
            votos = asNetReciclado.Obtener_RVotos_O_Campania_Organizacion(campaniaVoto, nombreOrganizacionVoto);

        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RVotos_O_Campania_Organizacion", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                votos = asNetReciclado.Obtener_RVotos_O_Campania_Organizacion(campaniaVoto, nombreOrganizacionVoto);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RVotos_O_Campania_Organizacion", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return votos;
    }
    public int Obtener_RVoto_O_Donacion_Total(string nombreCampaniaVoto)
    {
        int total = 0;
        try
        {
            total = asNetReciclado.Obtener_RVoto_O_Donacion_Total(nombreCampaniaVoto);

        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RVoto_O_Donacion_Total", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                total = asNetReciclado.Obtener_RVoto_O_Donacion_Total(nombreCampaniaVoto);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RVoto_O_Donacion_Total", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return total;
    }
    public ERVoto Obtener_RVoto_O_Donacion_Maxima(string nombreCampania)
    {
        ERVoto erVoto = new ERVoto();
        try
        {
            erVoto = asNetReciclado.Obtener_RVoto_O_Donacion_Maxima(nombreCampania);

        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RVoto_O_Donacion_Maxima", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                erVoto = asNetReciclado.Obtener_RVoto_O_Donacion_Maxima(nombreCampania);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RVoto_O_Donacion_Maxima", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return erVoto;
    }
    public string Obtener_RVoto_O_Organizacion(string nombreCampania)
    {
        string organizacion = string.Empty;
        try
        {
            organizacion = asNetReciclado.Obtener_RVoto_O_Organizacion(nombreCampania);

        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RVoto_O_Organizacion", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                organizacion = asNetReciclado.Obtener_RVoto_O_Organizacion(nombreCampania);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RVoto_O_Organizacion", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return organizacion;
    }
    #endregion
    #region RUsuarioNetValle
    public ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(string sedeUsuarioNetValle, string codigoUsuarioNetValle)
    {
        ERUsuarioNetvalle erUsuarioNetvalle = new ERUsuarioNetvalle();
        try
        {
            erUsuarioNetvalle = asNetReciclado.Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(sedeUsuarioNetValle, codigoUsuarioNetValle);

        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                erUsuarioNetvalle = asNetReciclado.Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(sedeUsuarioNetValle, codigoUsuarioNetValle);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return erUsuarioNetvalle;
    }

    public ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Codigo(string codigoUsuarioNetValle)
    {
        ERUsuarioNetvalle erUsuarioNetvalle = new ERUsuarioNetvalle();
        try
        {
            erUsuarioNetvalle = asNetReciclado.Obtener_RUsuarioNetvalle_O_Codigo(codigoUsuarioNetValle);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RUsuarioNetvalle_O_Codigo", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                erUsuarioNetvalle = asNetReciclado.Obtener_RUsuarioNetvalle_O_Codigo(codigoUsuarioNetValle);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RUsuarioNetvalle_O_Codigo", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return erUsuarioNetvalle;
    }
    public ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Tarjeta(string tarjetaUsuarioNetValle)
    {
        ERUsuarioNetvalle erUsuarioNetvalle = new ERUsuarioNetvalle();
        try
        {
            erUsuarioNetvalle = asNetReciclado.Obtener_RUsuarioNetvalle_O_Tarjeta(tarjetaUsuarioNetValle);

        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RUsuarioNetvalle_O_Tarjeta", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                erUsuarioNetvalle = asNetReciclado.Obtener_RUsuarioNetvalle_O_Tarjeta(tarjetaUsuarioNetValle);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RUsuarioNetvalle_O_Tarjeta", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return erUsuarioNetvalle;
    }

    public ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Tarjeta_NetValle(string tarjetaUsuarioNetValle)
    {
        ERUsuarioNetvalle erUsuarioNetvalle = new ERUsuarioNetvalle();
        try
        {
            erUsuarioNetvalle = asNetReciclado.Obtener_RUsuarioNetvalle_O_Tarjeta(tarjetaUsuarioNetValle);
            if (erUsuarioNetvalle.CodigoUsuarioNetvalle == string.Empty || erUsuarioNetvalle.CodigoUsuarioNetvalle == null)
            {
                erUsuarioNetvalle = RUsuarioNetvalle_RUsuaro_I(tarjetaUsuarioNetValle);
                if (erUsuarioNetvalle.CodigoUsuarioNetvalle != string.Empty || erUsuarioNetvalle.CodigoUsuarioNetvalle != null)
                {
                    Insertar_RUsuarioNetvalle_y_RUsuario("Usuario", erUsuarioNetvalle.CodigoUsuarioNetvalle,
                        erUsuarioNetvalle.NombresUsuarioNetvalle, erUsuarioNetvalle.ApellidosUsuarioNetvalle,
                        erUsuarioNetvalle.CargoUsuarioNetvalle, erUsuarioNetvalle.TarjetaUsuarioNetvalle, erUsuarioNetvalle.SedeUsuarioNetvalle);
                }
            }

        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RUsuarioNetvalle_O_Tarjeta_NetValle", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                erUsuarioNetvalle = asNetReciclado.Obtener_RUsuarioNetvalle_O_Tarjeta(tarjetaUsuarioNetValle);
                if (erUsuarioNetvalle.CodigoUsuarioNetvalle == string.Empty || erUsuarioNetvalle.CodigoUsuarioNetvalle == null)
                {
                    erUsuarioNetvalle = RUsuarioNetvalle_RUsuaro_I(tarjetaUsuarioNetValle);
                    if (erUsuarioNetvalle.CodigoUsuarioNetvalle != string.Empty || erUsuarioNetvalle.CodigoUsuarioNetvalle != null)
                    {
                        Insertar_RUsuarioNetvalle_y_RUsuario("Usuario", erUsuarioNetvalle.CodigoUsuarioNetvalle,
                            erUsuarioNetvalle.NombresUsuarioNetvalle, erUsuarioNetvalle.ApellidosUsuarioNetvalle,
                            erUsuarioNetvalle.CargoUsuarioNetvalle, erUsuarioNetvalle.TarjetaUsuarioNetvalle, erUsuarioNetvalle.SedeUsuarioNetvalle);
                    }
                }
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RUsuarioNetvalle_O_Tarjeta_NetValle", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return erUsuarioNetvalle;
    }

    public void Insertar_RUsuarioNetvalle_y_RUsuario(string roleUsuario,
        string codigoUsuarioNetvalle,
        string nombresUsuarioNetvalle,
        string apellidosUsuarioNetvalle,
        string cargoUsuarioNetvalle,
        string tarjetaUsuarioNetvalle,
        string sedeUsuarioNetvalle)
    {
        try
        {
            asNetReciclado.Insertar_RUsuarioNetvalle_y_RUsuario(roleUsuario,
        codigoUsuarioNetvalle,
        nombresUsuarioNetvalle,
        apellidosUsuarioNetvalle,
        cargoUsuarioNetvalle,
        tarjetaUsuarioNetvalle,
        sedeUsuarioNetvalle);

        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_RUsuarioNetvalle_y_RUsuario", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                asNetReciclado.Insertar_RUsuarioNetvalle_y_RUsuario(roleUsuario,
                  codigoUsuarioNetvalle,
                  nombresUsuarioNetvalle,
                  apellidosUsuarioNetvalle,
                  cargoUsuarioNetvalle,
                  tarjetaUsuarioNetvalle,
                  sedeUsuarioNetvalle);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_RUsuarioNetvalle_y_RUsuario", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }
    #endregion
    #region RUsuario
    public ERUsuario Obtener_RUsuario_O_Codigo(string codigoUsuario)
    {
        ERUsuario erUsuario = new ERUsuario();
        try
        {
            erUsuario = asNetReciclado.Obtener_RUsuario_O_Codigo(codigoUsuario);

        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RUsuario_O_Codigo", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                erUsuario = asNetReciclado.Obtener_RUsuario_O_Codigo(codigoUsuario);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RUsuario_O_Codigo", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return erUsuario;
    }
    public List<ERUsuario> Obtener_RUsuarios_O_Top_Creditos(string sedeUsuarioNetValle)
    {
        List<ERUsuario> lstErUsuario = new List<ERUsuario>();
        try
        {
            lstErUsuario = asNetReciclado.Obtener_RUsuarios_O_Top_Creditos(sedeUsuarioNetValle);

        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RUsuarios_O_Top_Creditos", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstErUsuario = asNetReciclado.Obtener_RUsuarios_O_Top_Creditos(sedeUsuarioNetValle);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RUsuarios_O_Top_Creditos", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return lstErUsuario;
    }

    public List<ERUsuario> Obtener_RUsuarios_O_Sede(string sedeUsuarioNetValle)
    {
        List<ERUsuario> lstErUsuario = new List<ERUsuario>();
        try
        {
            lstErUsuario = asNetReciclado.Obtener_RUsuarios_O_Sede(sedeUsuarioNetValle);

        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RUsuarios_O_Sede", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstErUsuario = asNetReciclado.Obtener_RUsuarios_O_Sede(sedeUsuarioNetValle);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RUsuarios_O_Sede", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return lstErUsuario;
    }

    public void Actualizar_RUsuario_A_Creditos_Sede(string codigoUsuarioNetValle)
    {
        try
        {
            asNetReciclado.Actualizar_RUsuario_A_Creditos_Sede(codigoUsuarioNetValle);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_RUsuario_A_Creditos_Sede", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                asNetReciclado.Actualizar_RUsuario_A_Creditos_Sede(codigoUsuarioNetValle);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_RUsuario_A_Creditos_Sede", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }

    public void Actualizar_RUsuario_A_Creditos_Codigo(string codigoUsuario, string creditosUsuario)
    {
        try
        {
            asNetReciclado.Actualizar_RUsuario_A_Creditos_Codigo(codigoUsuario, creditosUsuario);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_RUsuario_A_Creditos_Codigo", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                asNetReciclado.Actualizar_RUsuario_A_Creditos_Codigo(codigoUsuario, creditosUsuario);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_RUsuario_A_Creditos_Codigo", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }
    #endregion
    #region RContenedor
    public void Insertar_RContenedor_I(string codigoUsuario, byte maquinaContenedor, string gramosContenedor, DateTime fechaRegistroContenedor)
    {
        ERContenedor eRContenedor = new ERContenedor();
        try
        {
            eRContenedor.CodigoUsuario = codigoUsuario;
            eRContenedor.IdMaquinaContenedor = maquinaContenedor;
            eRContenedor.GramosContenedor = gramosContenedor;
            eRContenedor.FechaRegistroContenedor = fechaRegistroContenedor;
            asNetReciclado.Insertar_RContenedor_I(eRContenedor);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_RContenedor_I", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                eRContenedor.CodigoUsuario = codigoUsuario;
                eRContenedor.IdMaquinaContenedor = maquinaContenedor;
                eRContenedor.GramosContenedor = gramosContenedor;
                eRContenedor.FechaRegistroContenedor = fechaRegistroContenedor;
                asNetReciclado.Insertar_RContenedor_I(eRContenedor);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_RContenedor_I", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }
    public List<ERContenedor> Obtener_RContenedor_O_Codigo(string codigoUsuario)
    {
        List<ERContenedor> lstErContenedor = new List<ERContenedor>();
        try
        {
            lstErContenedor = asNetReciclado.Obtener_RContenedor_O_Codigo(codigoUsuario);

        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RContenedor_O_Codigo", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstErContenedor = asNetReciclado.Obtener_RContenedor_O_Codigo(codigoUsuario);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RContenedor_O_Codigo", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return lstErContenedor;
    }
    #endregion
    //COMPLEJAS
    #region EUsuarioCompleja
    public List<EUsuarioCompleja> Obtener_EUsuarioCompleja_O_Sede(string sedeUsuario)
    {
        List<EUsuarioCompleja> lstEUsuarioCompleja = new List<EUsuarioCompleja>();
        List<ERUsuario> lstRUsuario = new List<ERUsuario>();
        ERUsuarioNetvalle erUsuarioNetvalle;
        EUsuarioCompleja eUsuarioCompleja;
        try
        {
            lstRUsuario = asNetReciclado.Obtener_RUsuarios_O_Top_Creditos(sedeUsuario);
            foreach (ERUsuario erUsuario in lstRUsuario)
            {
                eUsuarioCompleja = new EUsuarioCompleja();
                erUsuarioNetvalle = new ERUsuarioNetvalle();
                erUsuarioNetvalle = asNetReciclado.Obtener_RUsuarioNetvalle_O_Codigo(erUsuario.CodigoUsuario);
                eUsuarioCompleja.NombreCompleto = erUsuarioNetvalle.NombresUsuarioNetvalle + " " + erUsuarioNetvalle.ApellidosUsuarioNetvalle;
                eUsuarioCompleja.Creditos = int.Parse(erUsuario.CreditosUsuario);
                lstEUsuarioCompleja.Add(eUsuarioCompleja);
            }
            return lstEUsuarioCompleja;
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_EUsuarioCompleja_O_Sede", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstRUsuario = asNetReciclado.Obtener_RUsuarios_O_Top_Creditos(sedeUsuario);
                foreach (ERUsuario erUsuario in lstRUsuario)
                {
                    eUsuarioCompleja = new EUsuarioCompleja();
                    erUsuarioNetvalle = new ERUsuarioNetvalle();
                    erUsuarioNetvalle = asNetReciclado.Obtener_RUsuarioNetvalle_O_Codigo(erUsuario.CodigoUsuario);
                    eUsuarioCompleja.NombreCompleto = erUsuarioNetvalle.NombresUsuarioNetvalle + " " + erUsuarioNetvalle.ApellidosUsuarioNetvalle;
                    eUsuarioCompleja.Creditos = int.Parse(erUsuario.CreditosUsuario);
                    lstEUsuarioCompleja.Add(eUsuarioCompleja);
                }
                return lstEUsuarioCompleja;
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_EUsuarioCompleja_O_Sede", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }

    }
    #endregion
    #region ECampaniaFinalizadaCompleja
    public ECampaniaFinalizadaCompleja Obtener_ECampaniaFinalizadaCompleja_O_Campania(string nombreCampania, string Sede)
    {
        ECampaniaFinalizadaCompleja eCampaniaFinalizadaCompleja = new ECampaniaFinalizadaCompleja();
        ERUsuarioNetvalle erUsuarioNetvalle;
        ERVoto eRVoto;
        try
        {
            eRVoto = asNetReciclado.Obtener_RVoto_O_Donacion_Maxima(nombreCampania);
            erUsuarioNetvalle = asNetReciclado.Obtener_RUsuarioNetvalle_O_Codigo(eRVoto.CodigoUsuario);
            eCampaniaFinalizadaCompleja.MejorDonadorCampania = erUsuarioNetvalle.NombresUsuarioNetvalle + " " + erUsuarioNetvalle.ApellidosUsuarioNetvalle;
            eCampaniaFinalizadaCompleja.DonacionCampania = int.Parse(eRVoto.DonacionVoto);
            eCampaniaFinalizadaCompleja.OrganizacionCampania = asNetReciclado.Obtener_RVoto_O_Organizacion(nombreCampania);
            eCampaniaFinalizadaCompleja.RecaudacionCampania = asNetReciclado.Obtener_RVoto_O_Donacion_Total(nombreCampania);

        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_ECampaniaFinalizadaCompleja_O_Campania", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                eRVoto = asNetReciclado.Obtener_RVoto_O_Donacion_Maxima(nombreCampania);
                erUsuarioNetvalle = asNetReciclado.Obtener_RUsuarioNetvalle_O_Codigo(eRVoto.CodigoUsuario);
                eCampaniaFinalizadaCompleja.MejorDonadorCampania = erUsuarioNetvalle.NombresUsuarioNetvalle + " " + erUsuarioNetvalle.ApellidosUsuarioNetvalle;
                eCampaniaFinalizadaCompleja.DonacionCampania = int.Parse(eRVoto.DonacionVoto);
                eCampaniaFinalizadaCompleja.OrganizacionCampania = asNetReciclado.Obtener_RVoto_O_Organizacion(nombreCampania);
                eCampaniaFinalizadaCompleja.RecaudacionCampania = asNetReciclado.Obtener_RVoto_O_Donacion_Total(nombreCampania);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_ECampaniaFinalizadaCompleja_O_Campania", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return eCampaniaFinalizadaCompleja;
    }
    #endregion

    #region LNReciclaje
    public ERUsuarioNetvalle RUsuarioNetvalle_RUsuaro_I(string tarjeta)
    {
        SWReciclajeClient client = new SWReciclajeClient();
        ERUsuarioNetvalle usuarioNetvalle = new ERUsuarioNetvalle();
        //00055840406248
        string usuarioEncrip = client.Encriptar("Reciclaje1");
        string claveEncriptada = client.Encriptar("Reciclaje123");
        string tarjetaEncriptada = client.Encriptar(tarjeta);

        object result = client.ObtenerInformacionEstudiante(usuarioEncrip, claveEncriptada, tarjetaEncriptada);

        result = client.Desencriptar(result.ToString());

        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(result.ToString());

        XmlNode root = xmlDoc.DocumentElement;

        XmlNode XMLCodigo = root.SelectSingleNode("Codigo");
        XmlNode XMLMensaje = root.SelectSingleNode("Mensaje");
        if (XMLMensaje != null && XMLCodigo != null)
        {
            usuarioNetvalle.NombresUsuarioNetvalle = XMLCodigo.InnerText.ToString() + "," + XMLMensaje.InnerText.ToString();
            return usuarioNetvalle;
        }
        else
        {
            XmlNode XMLcarrera = root.SelectSingleNode("Carrera");
            XmlNode XMLcodigoUsuario = root.SelectSingleNode("CodigoUsuario");
            XmlNode XMLcodigoSedeAcademica = root.SelectSingleNode("CodigoSedeAcademica");
            XmlNode XMLnombreCompleto = root.SelectSingleNode("NombreCompleto");
            XmlNode XMLId_TipoUsuario = root.SelectSingleNode("Id_TipoUsuario");


            if (XMLId_TipoUsuario.InnerText.ToString() == "ES" && XMLcarrera.InnerText.ToString()!= string.Empty)
            {
                string carrera = XMLcarrera.InnerText;
                string codigoUsuario = XMLcodigoUsuario.InnerText;
                string codigoSedeAcademica = XMLcodigoSedeAcademica.InnerText;
                string nombreCompleto = XMLnombreCompleto.InnerText;
                string[] nombreCompletoEstudiante = nombreCompleto.Split(' ');
                if (codigoSedeAcademica == "C")
                {
                    codigoSedeAcademica = "Cochabamba";
                }

                usuarioNetvalle.CodigoUsuarioNetvalle = codigoUsuario;
                usuarioNetvalle.SedeUsuarioNetvalle = codigoSedeAcademica;
                usuarioNetvalle.TarjetaUsuarioNetvalle = tarjeta;
                usuarioNetvalle.CargoUsuarioNetvalle = "Estudiante";
                
                usuarioNetvalle.EstadoUsuarioNetvalle = EPAEstaticos.EstadoActiva;
                usuarioNetvalle.FechaModificacionUsuarioNetvalle = EPAEstaticos.FechaModificacion;
                usuarioNetvalle.FechaRegistroUsuarioNetvalle = EPAEstaticos.FechaRegistro;
                if (nombreCompletoEstudiante.Length > 3)
                {
                    usuarioNetvalle.NombresUsuarioNetvalle = nombreCompletoEstudiante[2] + " " + nombreCompletoEstudiante[3];
                    usuarioNetvalle.ApellidosUsuarioNetvalle = nombreCompletoEstudiante[0] + " " + nombreCompletoEstudiante[1];
                }
                usuarioNetvalle.NombresUsuarioNetvalle = nombreCompletoEstudiante[2];
                usuarioNetvalle.ApellidosUsuarioNetvalle = nombreCompletoEstudiante[0] + " " + nombreCompletoEstudiante[1];
                return usuarioNetvalle;
            }
            else
            {
                if(XMLId_TipoUsuario.InnerText.ToString() == "AD" && XMLcarrera.InnerText.ToString() == string.Empty)
                {
                    string carrera = XMLcarrera.InnerText;
                    string codigoUsuario = XMLcodigoUsuario.InnerText;
                    string codigoSedeAcademica = XMLcodigoSedeAcademica.InnerText;
                    string nombreCompleto = XMLnombreCompleto.InnerText;
                    string[] nombreCompletoEstudiante = nombreCompleto.Split(' ');
                    {
                        codigoSedeAcademica = "Cochabamba";
                    }

                    usuarioNetvalle.CodigoUsuarioNetvalle = codigoUsuario;
                    usuarioNetvalle.SedeUsuarioNetvalle = codigoSedeAcademica;
                    usuarioNetvalle.TarjetaUsuarioNetvalle = tarjeta;
                    usuarioNetvalle.CargoUsuarioNetvalle = "Administrador";

                    usuarioNetvalle.EstadoUsuarioNetvalle = EPAEstaticos.EstadoActiva;
                    usuarioNetvalle.FechaModificacionUsuarioNetvalle = EPAEstaticos.FechaModificacion;
                    usuarioNetvalle.FechaRegistroUsuarioNetvalle = EPAEstaticos.FechaRegistro;
                    if (nombreCompletoEstudiante.Length > 3)
                    {
                        usuarioNetvalle.NombresUsuarioNetvalle = nombreCompletoEstudiante[2] + " " + nombreCompletoEstudiante[3];
                        usuarioNetvalle.ApellidosUsuarioNetvalle = nombreCompletoEstudiante[0] + " " + nombreCompletoEstudiante[1];
                    }
                    usuarioNetvalle.NombresUsuarioNetvalle = nombreCompletoEstudiante[2];
                    usuarioNetvalle.ApellidosUsuarioNetvalle = nombreCompletoEstudiante[0] + " " + nombreCompletoEstudiante[1];
                    return usuarioNetvalle;
                }
                usuarioNetvalle.NombresUsuarioNetvalle = "Cuenta no habilitada";
                return usuarioNetvalle;
            }
        }
        return usuarioNetvalle;



    }


    #endregion
    #endregion
}