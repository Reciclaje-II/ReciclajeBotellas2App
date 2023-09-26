using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Web;
using SWADNETReciclado;

/// <summary>
/// Descripción breve de ASNETReciclado
/// </summary>
public class ASNETReciclado
{
    #region Variables miembro
    private SWADNETRecicladoClient swADNETReciclado;
    #endregion
    public ASNETReciclado()
    {
        swADNETReciclado = new SWADNETRecicladoClient();
    }
    #region Metodos privados

    private EDefecto ContruirErrorServicio(TTipoDefecto tipoDefecto, string metodo, string excepcion, string mensaje)
    {
        EDefecto eDefecto = new EDefecto();
        eDefecto.TipoDefecto = tipoDefecto;
        eDefecto.Servicio = "SWLNReciclado";
        eDefecto.Clase = "ASNETReciclado";
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
            erCampania = swADNETReciclado.Obtener_RCampania_O_Sede(sedeCampania);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RCampania_O_Sede", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                erCampania = swADNETReciclado.Obtener_RCampania_O_Sede(sedeCampania);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RCampania_O_Sede", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return erCampania;
    }

    public List<ERCampania> Obtener_RCampania_O()
    {
        List<ERCampania> lstErCampania = new List<ERCampania>();
        try
        {
            lstErCampania = swADNETReciclado.Obtener_RCampania_O().ToList();

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
                lstErCampania = swADNETReciclado.Obtener_RCampania_O().ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RCampania_O", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return lstErCampania;
    }

    public void Insertar_RCampania_I(ERCampania eRCampania)
    {
        try
        {
            swADNETReciclado.Insertar_RCampania_I(eRCampania);
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
                swADNETReciclado.Insertar_RCampania_I(eRCampania);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_RCampania_I", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }

    public void Actualizar_RCampania_A(ERCampania eRCampania)
    {
        try
        {
            swADNETReciclado.Actualizar_RCampania_A(eRCampania);
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
                swADNETReciclado.Actualizar_RCampania_A(eRCampania);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_RCampania_A", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }

    public void Actualizar_RCampania_A_Estado(string nombreCampania)
    {
        try
        {
            swADNETReciclado.Actualizar_RCampania_A_Estado(nombreCampania);
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
                swADNETReciclado.Actualizar_RCampania_A_Estado(nombreCampania);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_RCampania_A_Estado", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }

    public void Actualizar_RCampania_A_Estado_Cancelado(string nombreCampania)
    {
        try
        {
            swADNETReciclado.Actualizar_RCampania_A_Estado_Cancelado(nombreCampania);
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
                swADNETReciclado.Actualizar_RCampania_A_Estado_Cancelado(nombreCampania);
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
    public List<ERCampaniaOrganizacion> Obtener_RCampaniaOrganizacion_O_Campania(string campaniaCampaniaOrganizacion)
    {
        List<ERCampaniaOrganizacion> lstErCampania = new List<ERCampaniaOrganizacion>();
        try
        {
            lstErCampania = swADNETReciclado.Obtener_RCampaniaOrganizacion_O_Campania(campaniaCampaniaOrganizacion).ToList();

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
                lstErCampania = swADNETReciclado.Obtener_RCampaniaOrganizacion_O_Campania(campaniaCampaniaOrganizacion).ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RCampaniaOrganizacion_O_Campania", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return lstErCampania;
    }
    public void Insertar_RCampaniaOrganizacion_I(ERCampaniaOrganizacion eRCampaniaOrganizacion)
    {
        try
        {
            swADNETReciclado.Insertar_RCampaniaOrganizacion_I(eRCampaniaOrganizacion);
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
                swADNETReciclado.Insertar_RCampaniaOrganizacion_I(eRCampaniaOrganizacion);
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
    public EROrganizacion Obtener_ROrganizacion_O_Nombre(string nombreOrganizacion)
    {
        EROrganizacion erOganizacion = new EROrganizacion();
        try
        {
            erOganizacion = swADNETReciclado.Obtener_ROrganizacion_O_Nombre(nombreOrganizacion);
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
                erOganizacion = swADNETReciclado.Obtener_ROrganizacion_O_Nombre(nombreOrganizacion);
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
            lstErOrganizacion = swADNETReciclado.Obtener_ROrganizaciones_O().ToList();
            
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
                lstErOrganizacion = swADNETReciclado.Obtener_ROrganizaciones_O().ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_ROrganizaciones_O", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return lstErOrganizacion;
    }
    public void Insertar_ROrganizacion_I(EROrganizacion eROrganizacion)
    {
        try
        {
            swADNETReciclado.Insertar_ROrganizacion_I(eROrganizacion);
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
                swADNETReciclado.Insertar_ROrganizacion_I(eROrganizacion);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_ROrganizacion_I", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }
    public void Actualizar_ROrganizacion_A(EROrganizacion eROrganizacion)
    {
        try
        {
            swADNETReciclado.Actualizar_ROrganizacion_A(eROrganizacion);
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
                swADNETReciclado.Actualizar_ROrganizacion_A(eROrganizacion);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_ROrganizacion_A", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }
    public void Eliminar_ROrganizacion_E_Nombre(string nombreOrganizacion)
    {
        try
        {
            swADNETReciclado.Eliminar_ROrganizacion_E_Nombre(nombreOrganizacion);
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
                swADNETReciclado.Eliminar_ROrganizacion_E_Nombre(nombreOrganizacion);
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
            lstErImagen = swADNETReciclado.Obtener_RImagen_O_Organizacion(organizacionImagen, tipoImagen).ToList();
           
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
                lstErImagen = swADNETReciclado.Obtener_RImagen_O_Organizacion(organizacionImagen, tipoImagen).ToList();
            }
            else
            {
                EDefecto EDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RImagen_O_Organizacion", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(EDefecto);
            }

        }
        return lstErImagen;
    }
    #endregion
    #region RVoto
    public void Insertar_RVoto_I(ERVoto eRVoto)
    {
        try
        {
            swADNETReciclado.Insertar_RVoto_I(eRVoto);
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
                swADNETReciclado.Insertar_RVoto_I(eRVoto);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_RVoto_I", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }
    public void Actualizar_RVoto_A(ERVoto eRVoto)
    {
        try
        {
            swADNETReciclado.Actualizar_RVoto_A(eRVoto);
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
                swADNETReciclado.Actualizar_RVoto_A(eRVoto);
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
            erVoto = swADNETReciclado.Obtener_RVoto_O_Codigo_Campania(codigoUsuario, nombreCampania);
            
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
                erVoto = swADNETReciclado.Obtener_RVoto_O_Codigo_Campania(codigoUsuario, nombreCampania);
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
            votos = swADNETReciclado.Obtener_RVotos_O_Campania(nombeCampaniaVoto);
            
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
                votos = swADNETReciclado.Obtener_RVotos_O_Campania(nombeCampaniaVoto);
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
            votos = swADNETReciclado.Obtener_RVotos_O_Campania_Organizacion(campaniaVoto, nombreOrganizacionVoto);
            
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
                votos = swADNETReciclado.Obtener_RVotos_O_Campania_Organizacion(campaniaVoto, nombreOrganizacionVoto);
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
            total = swADNETReciclado.Obtener_RVoto_O_Donacion_Total(nombreCampaniaVoto);
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
                total = swADNETReciclado.Obtener_RVoto_O_Donacion_Total(nombreCampaniaVoto);
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
            erVoto = swADNETReciclado.Obtener_RVoto_O_Donacion_Maxima(nombreCampania);
           
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
                erVoto = swADNETReciclado.Obtener_RVoto_O_Donacion_Maxima(nombreCampania);
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
            organizacion = swADNETReciclado.Obtener_RVoto_O_Organizacion(nombreCampania);
            
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
                organizacion = swADNETReciclado.Obtener_RVoto_O_Organizacion(nombreCampania);
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
            erUsuarioNetvalle = swADNETReciclado.Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(sedeUsuarioNetValle, codigoUsuarioNetValle);
            
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
                erUsuarioNetvalle = swADNETReciclado.Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(sedeUsuarioNetValle, codigoUsuarioNetValle);
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
            erUsuarioNetvalle = swADNETReciclado.Obtener_RUsuarioNetvalle_O_Codigo(codigoUsuarioNetValle);
            
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
                erUsuarioNetvalle = swADNETReciclado.Obtener_RUsuarioNetvalle_O_Codigo(codigoUsuarioNetValle);
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
            erUsuarioNetvalle = swADNETReciclado.Obtener_RUsuarioNetvalle_O_Tarjeta(tarjetaUsuarioNetValle);
           
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
                erUsuarioNetvalle = swADNETReciclado.Obtener_RUsuarioNetvalle_O_Tarjeta(tarjetaUsuarioNetValle);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RUsuarioNetvalle_O_Tarjeta", CommEx.ToString(), CommEx.Message);
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
            swADNETReciclado.Insertar_RUsuarioNetvalle_y_RUsuario(roleUsuario,
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
                swADNETReciclado.Insertar_RUsuarioNetvalle_y_RUsuario(roleUsuario,
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
            erUsuario = swADNETReciclado.Obtener_RUsuario_O_Codigo(codigoUsuario);
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
                erUsuario = swADNETReciclado.Obtener_RUsuario_O_Codigo(codigoUsuario);
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
            lstErUsuario = swADNETReciclado.Obtener_RUsuarios_O_Top_Creditos(sedeUsuarioNetValle).ToList();
            
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
                lstErUsuario = swADNETReciclado.Obtener_RUsuarios_O_Top_Creditos(sedeUsuarioNetValle).ToList();
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
            lstErUsuario = swADNETReciclado.Obtener_RUsuarios_O_Sede(sedeUsuarioNetValle).ToList();
            
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
                lstErUsuario = swADNETReciclado.Obtener_RUsuarios_O_Sede(sedeUsuarioNetValle).ToList();
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
            swADNETReciclado.Actualizar_RUsuario_A_Creditos_Sede(codigoUsuarioNetValle);
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
                swADNETReciclado.Actualizar_RUsuario_A_Creditos_Sede(codigoUsuarioNetValle);
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
            swADNETReciclado.Actualizar_RUsuario_A_Creditos_Codigo(codigoUsuario, creditosUsuario);
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
                swADNETReciclado.Actualizar_RUsuario_A_Creditos_Codigo(codigoUsuario, creditosUsuario);
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
    public void Insertar_RContenedor_I(ERContenedor eRContenedor)
    {
        try
        {
            swADNETReciclado.Insertar_RContenedor_I(eRContenedor);
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
                swADNETReciclado.Insertar_RContenedor_I(eRContenedor);
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
            lstErContenedor = swADNETReciclado.Obtener_RContenedor_O_Codigo(codigoUsuario).ToList();
            
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
                lstErContenedor = swADNETReciclado.Obtener_RContenedor_O_Codigo(codigoUsuario).ToList();
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
    #endregion
}