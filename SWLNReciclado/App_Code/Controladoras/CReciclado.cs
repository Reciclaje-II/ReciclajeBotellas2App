using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using SWADNETRecicladoReference;

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
    public ERCampania Obtener_RCampania_O_Sede(string Sede)
    {
        ERCampania erCampania = new ERCampania();
        try
        {
            erCampania = asNetReciclado.Obtener_RCampania_O_Sede(Sede);
            
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
                erCampania = asNetReciclado.Obtener_RCampania_O_Sede(Sede);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RCampania_O_Sede", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return erCampania;
    }
    public ERCampania Obtener_RCampania_O_Sede_Campania(string Campania, string Sede)
    {
        ERCampania erCampania = new ERCampania();
        try
        {
            erCampania = asNetReciclado.Obtener_RCampania_O().Find(campania => campania.Nombre == Campania && campania.Sede.ToUpper() == Sede.ToUpper());
           
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
                erCampania = asNetReciclado.Obtener_RCampania_O().Find(campania => campania.Nombre == Campania && campania.Sede.ToUpper() == Sede.ToUpper());
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RCampania_O_Sede_Campania", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return erCampania;
    }
    public List<ERCampania> Obtener_RCampania_O(string Sede)
    {
        List<ERCampania> lstErCampania = new List<ERCampania>();
        try
        {
            lstErCampania = asNetReciclado.Obtener_RCampania_O().Where(campania => campania.Sede.ToUpper() == Sede.ToUpper()).ToList();
            
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
                lstErCampania = asNetReciclado.Obtener_RCampania_O().Where(campania => campania.Sede.ToUpper() == Sede.ToUpper()).ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RCampania_O", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return lstErCampania;
    }
    public void Insertar_RCampania_I(string nombre, string descripcion, DateTime fechaInicio, DateTime fechaFin, string sede)
    {
        ERCampania eRCampania = new ERCampania();
        try
        {
            eRCampania.Nombre = nombre;
            eRCampania.Descripcion = descripcion;
            eRCampania.FechaInicio = fechaInicio;
            eRCampania.FechaFin = fechaFin;
            eRCampania.Sede = sede;
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
    public void Actualizar_RCampania_A(string nombre, string descripcion, DateTime fechaInicio, DateTime fechaFin, string sede)
    {
        ERCampania eRCampania = new ERCampania();
        try
        {
            eRCampania.Nombre = nombre;
            eRCampania.Descripcion = descripcion;
            eRCampania.FechaInicio = fechaInicio;
            eRCampania.FechaFin = fechaFin;
            eRCampania.Sede = sede;
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
    public void Actualizar_RCampania_A_Estado(string Nombre)
    {
        try
        {
            asNetReciclado.Actualizar_RCampania_A_Estado(Nombre);
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
                asNetReciclado.Actualizar_RCampania_A_Estado(Nombre);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_RCampania_A_Estado", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }
    public void Actualizar_RCampania_A_Estado_Cancelado(string Nombre)
    {
        try
        {
            asNetReciclado.Actualizar_RCampania_A_Estado_Cancelado(Nombre);
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
                asNetReciclado.Actualizar_RCampania_A_Estado_Cancelado(Nombre);
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
            lstErCampania = asNetReciclado.Obtener_RCampaniaOrganizacion_O_Campania(Campania);
            
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
                lstErCampania = asNetReciclado.Obtener_RCampaniaOrganizacion_O_Campania(Campania);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RCampaniaOrganizacion_O_Campania", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return lstErCampania;
    }
    public void Insertar_RCampaniaOrganizacion_I(string Campania, string Organizacion)
    {
        ERCampaniaOrganizacion eRCampaniaOrganizacion = new ERCampaniaOrganizacion();
        try
        {
            eRCampaniaOrganizacion.Campania = Campania;
            eRCampaniaOrganizacion.Organizacion = Organizacion;
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
    public void Insertar_ROrganizacion_I(string nombre, string descripcion)
    {
        EROrganizacion eROrganizacion = new EROrganizacion();       
        try
        {
            eROrganizacion.Nombre = nombre;
            eROrganizacion.Descripcion = descripcion;
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
    public void Actualizar_ROrganizacion_A(string nombre, string descripcion)
    {
        EROrganizacion eROrganizacion = new EROrganizacion();
        try
        {
            eROrganizacion.Nombre = nombre;
            eROrganizacion.Descripcion = descripcion;
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
    public List<ERImagen> Obtener_RImagen_O_Organizacion(string Organizacion, byte Tipo)
    {
        List<ERImagen> lstErImagen = new List<ERImagen>();
        try
        {
            lstErImagen = asNetReciclado.Obtener_RImagen_O_Organizacion(Organizacion, Tipo);
           
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
                lstErImagen = asNetReciclado.Obtener_RImagen_O_Organizacion(Organizacion, Tipo);
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
    public void Insertar_RVoto_I(string Codigo, string Campania, string Organizacion, DateTime Fecha, string Donacion, string Estado)
    {
        ERVoto eRVoto = new ERVoto();        
        try
        {
            eRVoto.Codigo = Codigo;
            eRVoto.Campania = Campania;
            eRVoto.Organizacion = Organizacion;
            eRVoto.Fecha = Fecha;
            eRVoto.Donacion = Donacion;
            eRVoto.Estado = Estado;
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
    public void Actualizar_RVoto_A(string Codigo, string Campania, string Organizacion, DateTime Fecha, string Donacion, string Estado)
    {
        ERVoto eRVoto = new ERVoto();
        try
        {
            eRVoto.Codigo = Codigo;
            eRVoto.Campania = Campania;
            eRVoto.Organizacion = Organizacion;
            eRVoto.Fecha = Fecha;
            eRVoto.Donacion = Donacion;
            eRVoto.Estado = Estado;
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
    public ERVoto Obtener_RVoto_O_Codigo_Campania(string Codigo, string Campania)
    {
        ERVoto erVoto = new ERVoto();
        try
        {
            erVoto = asNetReciclado.Obtener_RVoto_O_Codigo_Campania(Codigo, Campania);
            
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
                erVoto = asNetReciclado.Obtener_RVoto_O_Codigo_Campania(Codigo, Campania);
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
            votos = asNetReciclado.Obtener_RVotos_O_Campania(Campania);
            
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
                votos = asNetReciclado.Obtener_RVotos_O_Campania(Campania);
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
            votos = asNetReciclado.Obtener_RVotos_O_Campania_Organizacion(Campania, Organizacion);
           
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
                votos = asNetReciclado.Obtener_RVotos_O_Campania_Organizacion(Campania, Organizacion);
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
            total = asNetReciclado.Obtener_RVoto_O_Donacion_Total(Campania);
            
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
                total = asNetReciclado.Obtener_RVoto_O_Donacion_Total(Campania);
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
            erVoto = asNetReciclado.Obtener_RVoto_O_Donacion_Maxima(Campania);
            
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
                erVoto = asNetReciclado.Obtener_RVoto_O_Donacion_Maxima(Campania);
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
            organizacion = asNetReciclado.Obtener_RVoto_O_Organizacion(Campania);
           
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
                organizacion = asNetReciclado.Obtener_RVoto_O_Organizacion(Campania);
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
            erUsuarioNetvalle = asNetReciclado.Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(Sede, Codigo);
            
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
                erUsuarioNetvalle = asNetReciclado.Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(Sede, Codigo);
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
            erUsuarioNetvalle = asNetReciclado.Obtener_RUsuarioNetvalle_O_Codigo(Codigo);
            
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
                erUsuarioNetvalle = asNetReciclado.Obtener_RUsuarioNetvalle_O_Codigo(Codigo);
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
            erUsuarioNetvalle = asNetReciclado.Obtener_RUsuarioNetvalle_O_Tarjeta(Tarjeta);
            
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
                erUsuarioNetvalle = asNetReciclado.Obtener_RUsuarioNetvalle_O_Tarjeta(Tarjeta);
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
            erUsuario = asNetReciclado.Obtener_RUsuario_O_Codigo(Codigo);
            
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
                erUsuario = asNetReciclado.Obtener_RUsuario_O_Codigo(Codigo);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RUsuario_O_Codigo", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return erUsuario;
    }
    public List<ERUsuario> Obtener_RUsuarios_O_Top_Creditos(string Sede)
    {
        List<ERUsuario> lstErUsuario = new List<ERUsuario>();
        try
        {
            lstErUsuario = asNetReciclado.Obtener_RUsuarios_O_Top_Creditos(Sede);
            
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
                lstErUsuario = asNetReciclado.Obtener_RUsuarios_O_Top_Creditos(Sede);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RUsuarios_O_Top_Creditos", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return lstErUsuario;
    }

    public List<ERUsuario> Obtener_RUsuarios_O_Sede(string Sede)
    {
        List<ERUsuario> lstErUsuario = new List<ERUsuario>();
        try
        {
            lstErUsuario = asNetReciclado.Obtener_RUsuarios_O_Sede(Sede);

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
                lstErUsuario = asNetReciclado.Obtener_RUsuarios_O_Sede(Sede);
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
            asNetReciclado.Actualizar_RUsuario_A_Creditos_Sede(Campania, Codigo);
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
                asNetReciclado.Actualizar_RUsuario_A_Creditos_Sede(Campania, Codigo);
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
            asNetReciclado.Actualizar_RUsuario_A_Creditos_Codigo(Codigo, Creditos);
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
                asNetReciclado.Actualizar_RUsuario_A_Creditos_Codigo(Codigo, Creditos);
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
    public void Insertar_RContenedor_I(string Codigo, byte IdMaquina, string Gramos, DateTime Fecha)
    {
        ERContenedor eRContenedor = new ERContenedor();
        try
        {
            eRContenedor.Codigo = Codigo;
            eRContenedor.IdMaquina = IdMaquina;
            eRContenedor.Gramos = Gramos;
            eRContenedor.Fecha = Fecha;
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
                eRContenedor.Codigo = Codigo;
                eRContenedor.IdMaquina = IdMaquina;
                eRContenedor.Gramos = Gramos;
                eRContenedor.Fecha = Fecha;
                asNetReciclado.Insertar_RContenedor_I(eRContenedor);
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
            lstErContenedor = asNetReciclado.Obtener_RContenedor_O_Codigo(Codigo);
            
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
                lstErContenedor = asNetReciclado.Obtener_RContenedor_O_Codigo(Codigo);
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
    public List<EUsuarioCompleja> Obtener_EUsuarioCompleja_O_Sede(string Sede)
    {
        List<EUsuarioCompleja> lstEUsuarioCompleja = new List<EUsuarioCompleja>();
        List<ERUsuario> lstRUsuario = new List<ERUsuario>();
        ERUsuarioNetvalle erUsuarioNetvalle;
        EUsuarioCompleja eUsuarioCompleja;
        try
        {
            lstRUsuario = asNetReciclado.Obtener_RUsuarios_O_Top_Creditos(Sede);
            foreach (ERUsuario erUsuario in lstRUsuario)
            {
                eUsuarioCompleja = new EUsuarioCompleja();
                erUsuarioNetvalle = new ERUsuarioNetvalle();
                erUsuarioNetvalle = asNetReciclado.Obtener_RUsuarioNetvalle_O_Codigo(erUsuario.Codigo);                
                eUsuarioCompleja.NombreCompleto = erUsuarioNetvalle.Nombres + " " + erUsuarioNetvalle.Apellidos;
                eUsuarioCompleja.Creditos = int.Parse(erUsuario.Creditos);
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
                lstRUsuario = asNetReciclado.Obtener_RUsuarios_O_Top_Creditos(Sede);
                foreach (ERUsuario erUsuario in lstRUsuario)
                {
                    eUsuarioCompleja = new EUsuarioCompleja();
                    erUsuarioNetvalle = new ERUsuarioNetvalle();
                    erUsuarioNetvalle = asNetReciclado.Obtener_RUsuarioNetvalle_O_Codigo(erUsuario.Codigo);
                    eUsuarioCompleja.NombreCompleto = erUsuarioNetvalle.Nombres + " " + erUsuarioNetvalle.Apellidos;
                    eUsuarioCompleja.Creditos = int.Parse(erUsuario.Creditos);
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
    public ECampaniaFinalizadaCompleja Obtener_ECampaniaFinalizadaCompleja_O_Campania(string Campania, string Sede)
    {
        ECampaniaFinalizadaCompleja eCampaniaFinalizadaCompleja = new ECampaniaFinalizadaCompleja();
        ERUsuarioNetvalle erUsuarioNetvalle;
        ERVoto eRVoto;
        try
        {
            eRVoto = asNetReciclado.Obtener_RVoto_O_Donacion_Maxima(Campania);
            erUsuarioNetvalle = asNetReciclado.Obtener_RUsuarioNetvalle_O_Codigo(eRVoto.Codigo);
            eCampaniaFinalizadaCompleja.MejorDonador = erUsuarioNetvalle.Nombres + " " + erUsuarioNetvalle.Apellidos;
            eCampaniaFinalizadaCompleja.Donacion = int.Parse(eRVoto.Donacion);
            eCampaniaFinalizadaCompleja.Organizacion = asNetReciclado.Obtener_RVoto_O_Organizacion(Campania);
            eCampaniaFinalizadaCompleja.Recaudacion = asNetReciclado.Obtener_RVoto_O_Donacion_Total(Campania);
            
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
                eRVoto = asNetReciclado.Obtener_RVoto_O_Donacion_Maxima(Campania);
                erUsuarioNetvalle = asNetReciclado.Obtener_RUsuarioNetvalle_O_Codigo(eRVoto.Codigo);
                eCampaniaFinalizadaCompleja.MejorDonador = erUsuarioNetvalle.Nombres + " " + erUsuarioNetvalle.Apellidos;
                eCampaniaFinalizadaCompleja.Donacion = int.Parse(eRVoto.Donacion);
                eCampaniaFinalizadaCompleja.Organizacion = asNetReciclado.Obtener_RVoto_O_Organizacion(Campania);
                eCampaniaFinalizadaCompleja.Recaudacion = asNetReciclado.Obtener_RVoto_O_Donacion_Total(Campania);
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
    #endregion
}