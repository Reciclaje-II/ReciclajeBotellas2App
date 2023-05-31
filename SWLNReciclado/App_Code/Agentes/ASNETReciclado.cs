using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Web;
using SWADNETRecicladoReference;

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
    public ERCampania Obtener_RCampania_O_Sede(string Sede)
    {
        ERCampania erCampania = new ERCampania();
        try
        {
            erCampania = swADNETReciclado.Obtener_RCampania_O_Sede(Sede);
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
                erCampania = swADNETReciclado.Obtener_RCampania_O_Sede(Sede);
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

    public void Actualizar_RCampania_A_Estado(string NombreOrganizacion)
    {
        try
        {
            swADNETReciclado.Actualizar_RCampania_A_Estado(NombreOrganizacion);
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
                swADNETReciclado.Actualizar_RCampania_A_Estado(NombreOrganizacion);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_RCampania_A_Estado", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }

    public void Actualizar_RCampania_A_Estado_Cancelado(string NombreOrganizacion)
    {
        try
        {
            swADNETReciclado.Actualizar_RCampania_A_Estado_Cancelado(NombreOrganizacion);
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
                swADNETReciclado.Actualizar_RCampania_A_Estado_Cancelado(NombreOrganizacion);
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
    public List<ERCampaniaOrganizacion> Obtener_RCampaniaOrganizacion_O_Campania(string Campania)
    {
        List<ERCampaniaOrganizacion> lstErCampania = new List<ERCampaniaOrganizacion>();
        try
        {
            lstErCampania = swADNETReciclado.Obtener_RCampaniaOrganizacion_O_Campania(Campania).ToList();
            
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
                lstErCampania = swADNETReciclado.Obtener_RCampaniaOrganizacion_O_Campania(Campania).ToList();
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
    public EROrganizacion Obtener_ROrganizacion_O_Nombre(string NombreOrganizacion)
    {
        EROrganizacion erOganizacion = new EROrganizacion();
        try
        {
            erOganizacion = swADNETReciclado.Obtener_ROrganizacion_O_Nombre(NombreOrganizacion);
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
                erOganizacion = swADNETReciclado.Obtener_ROrganizacion_O_Nombre(NombreOrganizacion);
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
    public void Eliminar_ROrganizacion_E_Nombre(string NombreOrganizacion)
    {
        try
        {
            swADNETReciclado.Eliminar_ROrganizacion_E_Nombre(NombreOrganizacion);
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
                swADNETReciclado.Eliminar_ROrganizacion_E_Nombre(NombreOrganizacion);
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
    public List<ERImagen> Obtener_RImagen_O_Organizacion(string Organizacion, byte Tipo)
    {
        List<ERImagen> lstErImagen = new List<ERImagen>();
        try
        {
            lstErImagen = swADNETReciclado.Obtener_RImagen_O_Organizacion(Organizacion, Tipo).ToList();
           
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
                lstErImagen = swADNETReciclado.Obtener_RImagen_O_Organizacion(Organizacion, Tipo).ToList();
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
    public ERVoto Obtener_RVoto_O_Codigo_Campania(string Codigo, string Campania)
    {
        ERVoto erVoto = new ERVoto();
        try
        {
            erVoto = swADNETReciclado.Obtener_RVoto_O_Codigo_Campania(Codigo, Campania);
            
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
                erVoto = swADNETReciclado.Obtener_RVoto_O_Codigo_Campania(Codigo, Campania);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RVoto_O_Codigo_Campania", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return erVoto;
    }
    public int Obtener_RVotos_O_Campania(string Campania)
    {
        int votos = 0;
        try
        {
            votos = swADNETReciclado.Obtener_RVotos_O_Campania(Campania);
            
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
                votos = swADNETReciclado.Obtener_RVotos_O_Campania(Campania);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RVotos_O_Campania", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return votos;
    }
    public int Obtener_RVotos_O_Campania_Organizacion(string Campania, string Organizacion)
    {
        int votos = 0;
        try
        {
            votos = swADNETReciclado.Obtener_RVotos_O_Campania_Organizacion(Campania, Organizacion);
            
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
                votos = swADNETReciclado.Obtener_RVotos_O_Campania_Organizacion(Campania, Organizacion);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RVotos_O_Campania_Organizacion", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return votos;
    }
    public int Obtener_RVoto_O_Donacion_Total(string Campania)
    {
        int total = 0;
        try
        {
            total = swADNETReciclado.Obtener_RVoto_O_Donacion_Total(Campania);
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
                total = swADNETReciclado.Obtener_RVoto_O_Donacion_Total(Campania);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RVoto_O_Donacion_Total", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return total;
    }
    public ERVoto Obtener_RVoto_O_Donacion_Maxima(string Campania)
    {
        ERVoto erVoto = new ERVoto();
        try
        {
            erVoto = swADNETReciclado.Obtener_RVoto_O_Donacion_Maxima(Campania);
           
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
                erVoto = swADNETReciclado.Obtener_RVoto_O_Donacion_Maxima(Campania);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RVoto_O_Donacion_Maxima", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return erVoto;
    }
    public string Obtener_RVoto_O_Organizacion(string Campania)
    {
        string organizacion = string.Empty;
        try
        {
            organizacion = swADNETReciclado.Obtener_RVoto_O_Organizacion(Campania);
            
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
                organizacion = swADNETReciclado.Obtener_RVoto_O_Organizacion(Campania);
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
    public ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(string Sede, string Codigo)
    {
        ERUsuarioNetvalle erUsuarioNetvalle = new ERUsuarioNetvalle();
        try
        {
            erUsuarioNetvalle = swADNETReciclado.Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(Sede, Codigo);
            
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
                erUsuarioNetvalle = swADNETReciclado.Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(Sede, Codigo);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return erUsuarioNetvalle;
    }

    public ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Codigo(string Codigo)
    {
        ERUsuarioNetvalle erUsuarioNetvalle = new ERUsuarioNetvalle();
        try
        {
            erUsuarioNetvalle = swADNETReciclado.Obtener_RUsuarioNetvalle_O_Codigo(Codigo);
            
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
                erUsuarioNetvalle = swADNETReciclado.Obtener_RUsuarioNetvalle_O_Codigo(Codigo);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RUsuarioNetvalle_O_Codigo", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return erUsuarioNetvalle;
    }
    public ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Tarjeta(string Tarjeta)
    {
        ERUsuarioNetvalle erUsuarioNetvalle = new ERUsuarioNetvalle();
        try
        {
            erUsuarioNetvalle = swADNETReciclado.Obtener_RUsuarioNetvalle_O_Tarjeta(Tarjeta);
           
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
                erUsuarioNetvalle = swADNETReciclado.Obtener_RUsuarioNetvalle_O_Tarjeta(Tarjeta);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RUsuarioNetvalle_O_Tarjeta", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return erUsuarioNetvalle;
    }
    #endregion
    #region RUsuario
    public ERUsuario Obtener_RUsuario_O_Codigo(string Codigo)
    {
        ERUsuario erUsuario = new ERUsuario();
        try
        {
            erUsuario = swADNETReciclado.Obtener_RUsuario_O_Codigo(Codigo);
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
                erUsuario = swADNETReciclado.Obtener_RUsuario_O_Codigo(Codigo);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RUsuario_O_Codigo", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }


        }
        return erUsuario;
    }
    public List<ERUsuario> Obtener_RUsuarios_O_Top_Creditos(string sede)
    {
        List<ERUsuario> lstErUsuario = new List<ERUsuario>();
        try
        {
            lstErUsuario = swADNETReciclado.Obtener_RUsuarios_O_Top_Creditos(sede).ToList();
            
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
                lstErUsuario = swADNETReciclado.Obtener_RUsuarios_O_Top_Creditos(sede).ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RUsuarios_O_Top_Creditos", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return lstErUsuario;
    }

    public List<ERUsuario> Obtener_RUsuarios_O_Sede(string sede)
    {
        List<ERUsuario> lstErUsuario = new List<ERUsuario>();
        try
        {
            lstErUsuario = swADNETReciclado.Obtener_RUsuarios_O_Sede(sede).ToList();
            
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
                lstErUsuario = swADNETReciclado.Obtener_RUsuarios_O_Sede(sede).ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RUsuarios_O_Sede", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return lstErUsuario;
    }

    public void Actualizar_RUsuario_A_Creditos_Sede(string Campania, string Codigo)
    {
        try
        {
            swADNETReciclado.Actualizar_RUsuario_A_Creditos_Sede(Campania, Codigo);
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
                swADNETReciclado.Actualizar_RUsuario_A_Creditos_Sede(Campania, Codigo);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_RUsuario_A_Creditos_Sede", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }

    public void Actualizar_RUsuario_A_Creditos_Codigo(string Codigo, string Creditos)
    {
        try
        {
            swADNETReciclado.Actualizar_RUsuario_A_Creditos_Codigo(Codigo, Creditos);
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
                swADNETReciclado.Actualizar_RUsuario_A_Creditos_Codigo(Codigo, Creditos);
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
    public List<ERContenedor> Obtener_RContenedor_O_Codigo(string Codigo)
    {
        List<ERContenedor> lstErContenedor = new List<ERContenedor>();
        try
        {
            lstErContenedor = swADNETReciclado.Obtener_RContenedor_O_Codigo(Codigo).ToList();
            
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
                lstErContenedor = swADNETReciclado.Obtener_RContenedor_O_Codigo(Codigo).ToList();
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