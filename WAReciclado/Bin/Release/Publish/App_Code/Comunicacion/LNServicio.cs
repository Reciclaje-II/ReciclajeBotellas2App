using System;
using System.Collections.Generic;
using SWLNReciclado;
using System.Linq;
using System.Data.SqlClient;
using System.ServiceModel;

/// <summary>
/// Descripción breve de LNServicio
/// </summary>
public class LNServicio
{
    #region Propiedades
    public string NombreClase
    {
        get { return GetType().Name; }
    }
    #endregion

    #region Variables miembro
    private SWLNRecicladoClient swlnReciclado;
    #endregion

    #region Constructor
    public LNServicio()
    {
        swlnReciclado = new SWLNRecicladoClient();
    }

    private EDefecto ConstruirDefecto(TTipoDefecto tipoDefecto, string metodo, string excepcion, string mensaje, string stackTrace)
    {
        EDefecto eDefecto = new EDefecto
        {
            TipoDefecto = tipoDefecto,
            Servicio = SDatosGlobales.NOMBRE_APLICACION,
            Clase = NombreClase,
            Metodo = metodo,
            Mensaje = mensaje,
            Excepcion = excepcion,
        };

        return eDefecto;
    }

    private EDefecto ConstruirDefecto(TTipoDefecto tipoDefecto, string metodo, string excepcion, string mensaje)
    {
        EDefecto eDefecto = new EDefecto
        {
            TipoDefecto = tipoDefecto,
            Servicio = SDatosGlobales.NOMBRE_APLICACION,
            Clase = NombreClase,
            Metodo = metodo,
            Mensaje = mensaje,
            Excepcion = excepcion
        };

        return eDefecto;
    }

    private EDefecto ConstruirDefecto(FaultException<EDefecto> ex)
    {
        EDefecto eDefecto = new EDefecto
        {
            TipoDefecto = ex.Detail.TipoDefecto,
            Servicio = ex.Detail.Servicio,
            Clase = ex.Detail.Clase,
            Metodo = ex.Detail.Metodo,
            Excepcion = ex.Detail.Excepcion,
            Mensaje = ex.Detail.Mensaje,
        };
        return eDefecto;
    }
    #endregion

    #region Metodos publicos

    #region ERCampania
    public ERCampania Obtener_RCampania_O_Sede(string sedeCampania)
    {
        ERCampania erCampania = new ERCampania();
        try
        {
            erCampania = swlnReciclado.Obtener_RCampania_O_Sede(sedeCampania);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RCampania_O_Sede", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    erCampania = sWLNServicioClient.Obtener_RCampania_O_Sede(sedeCampania);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RCampania_O_Sede", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_RCampania_O_Sede", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RCampania_O_Sede", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return erCampania;
    }

    public List<ERCampania> Obtener_RCampania_O(string SedeCampania)
    {
        List<ERCampania> lstErCampania = new List<ERCampania>();
        try
        {
            lstErCampania = swlnReciclado.Obtener_RCampania_O(SedeCampania).ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RCampania_O", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    lstErCampania = sWLNServicioClient.Obtener_RCampania_O(SedeCampania).ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RCampania_O", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_RCampania_O", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RCampania_O", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return lstErCampania;
    }

    public void Insertar_RCampania_I(string NombreCampania, string DescripcionCampania, DateTime FechaInicioCampania, DateTime FechaFinCampania, string SedeCampania)
    {
        try
        {
            swlnReciclado.Insertar_RCampania_I(NombreCampania, DescripcionCampania, FechaInicioCampania, FechaFinCampania, SedeCampania);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_RCampania_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    sWLNServicioClient.Insertar_RCampania_I(NombreCampania, DescripcionCampania, FechaInicioCampania, FechaFinCampania, SedeCampania);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_RCampania_I", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Insertar_RCampania_I", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_RCampania_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }

    public void Actualizar_RCampania_A(string NombreCampania, string DescripcionCampania, DateTime FechaInicioCampania, DateTime FechaFinCampania, string SedeCampania)
    {
        try
        {
            swlnReciclado.Actualizar_RCampania_A(NombreCampania, DescripcionCampania, FechaInicioCampania, FechaFinCampania, SedeCampania);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_RCampania_A", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    sWLNServicioClient.Actualizar_RCampania_A(NombreCampania, DescripcionCampania, FechaInicioCampania, FechaFinCampania, SedeCampania);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_RCampania_A", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Actualizar_RCampania_A", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_RCampania_A", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }

    public void Actualizar_RCampania_A_Estado(string NombreCampania)
    {
        try
        {
            swlnReciclado.Actualizar_RCampania_A_Estado(NombreCampania);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_RCampania_A_Estado", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    sWLNServicioClient.Actualizar_RCampania_A_Estado(NombreCampania);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_RCampania_A_Estado", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Actualizar_RCampania_A_Estado", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_RCampania_A_Estado", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }

    public void Actualizar_RCampania_A_Estado_Cancelado(string NombreCampania)
    {
        try
        {
            swlnReciclado.Actualizar_RCampania_A_Estado_Cancelado(NombreCampania);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_RCampania_A_Estado_Cancelado", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    sWLNServicioClient.Actualizar_RCampania_A_Estado_Cancelado(NombreCampania);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_RCampania_A_Estado_Cancelado", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Actualizar_RCampania_A_Estado_Cancelado", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_RCampania_A_Estado_Cancelado", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    #endregion

    #region ERCampaniaOrganizacion
    public List<ERCampaniaOrganizacion> Obtener_RCampaniaOrganizacion_O_Campania(string CampaniaCampaniaOrganizacion)/*01*/
    {
        List<ERCampaniaOrganizacion> lstErCampania = new List<ERCampaniaOrganizacion>();
        try
        {
            lstErCampania = swlnReciclado.Obtener_RCampaniaOrganizacion_O_Campania(CampaniaCampaniaOrganizacion).ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RCampaniaOrganizacion_O_Campania", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    lstErCampania = sWLNServicioClient.Obtener_RCampaniaOrganizacion_O_Campania(CampaniaCampaniaOrganizacion).ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RCampaniaOrganizacion_O_Campania", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_RCampaniaOrganizacion_O_Campania", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RCampaniaOrganizacion_O_Campania", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return lstErCampania;
    }
    public ERCampania Obtener_RCampania_O_Sede_Campania(string NombreCampania, string SedeCampania)
    {
        ERCampania erCampania = new ERCampania();
        try
        {
            erCampania = swlnReciclado.Obtener_RCampania_O_Sede_Campania(NombreCampania, SedeCampania);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RCampania_O_Sede_Campania", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    erCampania = sWLNServicioClient.Obtener_RCampania_O_Sede_Campania(NombreCampania, SedeCampania);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RCampania_O_Sede_Campania", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_RCampania_O_Sede_Campania", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RCampania_O_Sede_Campania", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return erCampania;
    }

    public void Insertar_RCampaniaOrganizacion_I(string CampaniaCampaniaOrganizacion, string OrganizacionCampaniaOrganizacion)
    {
        try
        {
            swlnReciclado.Insertar_RCampaniaOrganizacion_I(CampaniaCampaniaOrganizacion, OrganizacionCampaniaOrganizacion);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_RCampaniaOrganizacion_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    sWLNServicioClient.Insertar_RCampaniaOrganizacion_I(CampaniaCampaniaOrganizacion, OrganizacionCampaniaOrganizacion);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_RCampaniaOrganizacion_I", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Insertar_RCampaniaOrganizacion_I", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_RCampaniaOrganizacion_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    #endregion

    #region EROrganizacion
    public EROrganizacion Obtener_ROrganizacion_O_Nombre(string nombre)
    {
        EROrganizacion erOganizacion = new EROrganizacion();
        try
        {
            erOganizacion = swlnReciclado.Obtener_ROrganizacion_O_Nombre(nombre);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_ROrganizacion_O_Nombre", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    erOganizacion = sWLNServicioClient.Obtener_ROrganizacion_O_Nombre(nombre);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_ROrganizacion_O_Nombre", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_ROrganizacion_O_Nombre", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_ROrganizacion_O_Nombre", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return erOganizacion;
   
    }
    public List<EROrganizacion> Obtener_ROrganizaciones_O()
    {
        List<EROrganizacion> lstErOrganizacion = new List<EROrganizacion>();
        try
        {
            lstErOrganizacion = swlnReciclado.Obtener_ROrganizaciones_O().ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_ROrganizaciones_O", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    lstErOrganizacion = sWLNServicioClient.Obtener_ROrganizaciones_O().ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_ROrganizaciones_O", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_ROrganizaciones_O", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_ROrganizaciones_O", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return lstErOrganizacion;
    }
    public void Insertar_ROrganizacion_I(string nombreOrganizacion, string descripcionOrganizacion)
    {
        try
        {
            swlnReciclado.Insertar_ROrganizacion_I(nombreOrganizacion, descripcionOrganizacion);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_ROrganizacion_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    sWLNServicioClient.Insertar_ROrganizacion_I(nombreOrganizacion, descripcionOrganizacion);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_ROrganizacion_I", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Insertar_ROrganizacion_I", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_ROrganizacion_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    public void Actualizar_ROrganizacion_A(string nombreOrganizacion, string descripcionOrganizacion)
    {
        try
        {
            swlnReciclado.Actualizar_ROrganizacion_A(nombreOrganizacion, descripcionOrganizacion);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_ROrganizacion_A", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    sWLNServicioClient.Actualizar_ROrganizacion_A(nombreOrganizacion, descripcionOrganizacion);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_ROrganizacion_A", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Actualizar_ROrganizacion_A", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_ROrganizacion_A", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    public void Eliminar_ROrganizacion_E_Nombre(string nombreOrganizacion)
    {
        try
        {
            swlnReciclado.Eliminar_ROrganizacion_E_Nombre(nombreOrganizacion);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Eliminar_ROrganizacion_E_Nombre", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    sWLNServicioClient.Eliminar_ROrganizacion_E_Nombre(nombreOrganizacion);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Eliminar_ROrganizacion_E_Nombre", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Eliminar_ROrganizacion_E_Nombre", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Eliminar_ROrganizacion_E_Nombre", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    #endregion

    #region ERImagen
    public List<ERImagen> Obtener_RImagen_O_Organizacion(string organizacionImagen, byte tipoImagen)
    {
        List<ERImagen> lstErImagen = new List<ERImagen>();
        try
        {
            lstErImagen = swlnReciclado.Obtener_RImagen_O_Organizacion(organizacionImagen, tipoImagen).ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RImagen_O_Organizacion", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    lstErImagen = sWLNServicioClient.Obtener_RImagen_O_Organizacion(organizacionImagen, tipoImagen).ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RImagen_O_Organizacion", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_RImagen_O_Organizacion", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RImagen_O_Organizacion", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return lstErImagen;
    }
    #endregion

    #region ERVoto
    public void Insertar_RVoto_I(string codigoUsuario, string nombreCampania, string nombreOrganizacion, DateTime fechaRegistroVoto, string donacionVoto, string estadoVoto)
    {
        try
        {
            swlnReciclado.Insertar_RVoto_I(codigoUsuario, nombreCampania, nombreOrganizacion, fechaRegistroVoto, donacionVoto, estadoVoto);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_RVoto_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    sWLNServicioClient.Insertar_RVoto_I(codigoUsuario, nombreCampania, nombreOrganizacion, fechaRegistroVoto, donacionVoto, estadoVoto);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_RVoto_I", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Insertar_RVoto_I", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_RVoto_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    public void Actualizar_RVoto_A(string codigoUsuario, string nombreCampaniaVoto, string organizacionVoto, DateTime fechaRegistroVoto, string donacionVoto, string EstadoVoto)
    {
        try
        {
            swlnReciclado.Actualizar_RVoto_A(codigoUsuario, nombreCampaniaVoto, organizacionVoto, fechaRegistroVoto, donacionVoto, EstadoVoto);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_RVoto_A", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    sWLNServicioClient.Actualizar_RVoto_A(codigoUsuario, nombreCampaniaVoto, organizacionVoto, fechaRegistroVoto, donacionVoto, EstadoVoto );
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_RVoto_A", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Actualizar_RVoto_A", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_RVoto_A", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    public ERVoto Obtener_RVoto_O_Codigo_Campania(string codigoUsuario, string nombreCampania)
    {
        ERVoto erVoto = new ERVoto();
        try
        {
            erVoto = swlnReciclado.Obtener_RVoto_O_Codigo_Campania(codigoUsuario, nombreCampania);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RVoto_O_Codigo_Campania", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    erVoto = sWLNServicioClient.Obtener_RVoto_O_Codigo_Campania(codigoUsuario, nombreCampania);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RVoto_O_Codigo_Campania", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_RVoto_O_Codigo_Campania", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RVoto_O_Codigo_Campania", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return erVoto;
    }
    public int Obtener_RVotos_O_Campania(string nombeCampaniaVoto)
    {
        int votos = 0;
        try
        {
            votos = swlnReciclado.Obtener_RVotos_O_Campania(nombeCampaniaVoto);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RVotos_O_Campania", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    votos = sWLNServicioClient.Obtener_RVotos_O_Campania(nombeCampaniaVoto);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RVotos_O_Campania", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_RVotos_O_Campania", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RVotos_O_Campania", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return votos;
    }
    public int Obtener_RVotos_O_Campania_Organizacion(string campaniaVoto, string nombreOrganizacionVoto)
    {
        int votos = 0;
        try
        {
            votos = swlnReciclado.Obtener_RVotos_O_Campania_Organizacion(campaniaVoto, nombreOrganizacionVoto);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RVotos_O_Campania_Organizacion", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    votos = sWLNServicioClient.Obtener_RVotos_O_Campania_Organizacion(campaniaVoto, nombreOrganizacionVoto);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RVotos_O_Campania_Organizacion", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_RVotos_O_Campania_Organizacion", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RVotos_O_Campania_Organizacion", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return votos;
    }
    public int Obtener_RVoto_O_Donacion_Total(string nombreCampaniaVoto)
    {
        int total = 0;
        try
        {
            total = swlnReciclado.Obtener_RVoto_O_Donacion_Total(nombreCampaniaVoto);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RVoto_O_Donacion_Total", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    total = sWLNServicioClient.Obtener_RVoto_O_Donacion_Total(nombreCampaniaVoto);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RVoto_O_Donacion_Total", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_RVoto_O_Donacion_Total", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RVoto_O_Donacion_Total", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return total;
    }
    public ERVoto Obtener_RVoto_O_Donacion_Maxima(string nombreCampania)
    {
        ERVoto erVoto = new ERVoto();
        try
        {
            erVoto = swlnReciclado.Obtener_RVoto_O_Donacion_Maxima(nombreCampania);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RVoto_O_Donacion_Maxima", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    erVoto = sWLNServicioClient.Obtener_RVoto_O_Donacion_Maxima(nombreCampania);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RVoto_O_Donacion_Maxima", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_RVoto_O_Donacion_Maxima", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RVoto_O_Donacion_Maxima", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        
        return erVoto;
    }
    public string Obtener_RVoto_O_Organizacion(string nombreCampania)
    {
        string organizacion = string.Empty;
        try
        {
            organizacion = swlnReciclado.Obtener_RVoto_O_Organizacion(nombreCampania);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RVoto_O_Organizacion", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    organizacion = sWLNServicioClient.Obtener_RVoto_O_Organizacion(nombreCampania);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RVoto_O_Organizacion", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_RVoto_O_Organizacion", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RVoto_O_Organizacion", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return organizacion;
      
    }
    #endregion

    #region ERUsuarioNetValle
    public ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(string Sede, string Codigo)
    {
        ERUsuarioNetvalle erUsuarioNetvalle = new ERUsuarioNetvalle();
        try
        {
            erUsuarioNetvalle = swlnReciclado.Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(Sede, Codigo);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    erUsuarioNetvalle = sWLNServicioClient.Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(Sede, Codigo);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return erUsuarioNetvalle;
    }

    public ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Tarjeta(string Tarjeta)
    {
        ERUsuarioNetvalle erUsuarioNetvalle = new ERUsuarioNetvalle();
        try
        {
            erUsuarioNetvalle = swlnReciclado.Obtener_RUsuarioNetvalle_O_Tarjeta(Tarjeta);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RUsuarioNetvalle_O_Tarjeta", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    erUsuarioNetvalle = sWLNServicioClient.Obtener_RUsuarioNetvalle_O_Tarjeta(Tarjeta);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RUsuarioNetvalle_O_Tarjeta", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_RUsuarioNetvalle_O_Tarjeta", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RUsuarioNetvalle_O_Tarjeta", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return erUsuarioNetvalle;
    }


    public ERUsuarioNetvalle RUsuarioNetvalle_RUsuaro_I(string Tarjeta)
    {
        ERUsuarioNetvalle erUsuarioNetvalle = new ERUsuarioNetvalle();
        try
        {
            erUsuarioNetvalle = swlnReciclado.RUsuarioNetvalle_RUsuaro_I(Tarjeta);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "RUsuarioNetvalle_RUsuaro_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    erUsuarioNetvalle = sWLNServicioClient.RUsuarioNetvalle_RUsuaro_I(Tarjeta);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "RUsuarioNetvalle_RUsuaro_I", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "RUsuarioNetvalle_RUsuaro_I", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "RUsuarioNetvalle_RUsuaro_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return erUsuarioNetvalle;
    }
    #endregion

    #region ERUsuario
    public ERUsuario Obtener_RUsuario_O_Codigo(string Codigo)
    {
        ERUsuario erUsuario = new ERUsuario();
        try
        {
            erUsuario = swlnReciclado.Obtener_RUsuario_O_Codigo(Codigo);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RUsuario_O_Codigo", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    erUsuario = sWLNServicioClient.Obtener_RUsuario_O_Codigo(Codigo);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RUsuario_O_Codigo", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_RUsuario_O_Codigo", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RUsuario_O_Codigo", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return erUsuario;
    }
    public List<ERUsuario> Obtener_RUsuarios_O_Top_Creditos(string sede)
    {
        List<ERUsuario> lstErUsuario = new List<ERUsuario>();
        try
        {
            lstErUsuario = swlnReciclado.Obtener_RUsuarios_O_Top_Creditos(sede).ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RUsuarios_O_Top_Creditos", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    lstErUsuario = sWLNServicioClient.Obtener_RUsuarios_O_Top_Creditos(sede).ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RUsuarios_O_Top_Creditos", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_RUsuarios_O_Top_Creditos", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RUsuarios_O_Top_Creditos", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return lstErUsuario;
    }

    public List<ERUsuario> Obtener_RUsuarios_O_Sede(string sede)
    {
        List<ERUsuario> lstErUsuario = new List<ERUsuario>();

        try
        {
            lstErUsuario = swlnReciclado.Obtener_RUsuarios_O_Sede(sede).ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RUsuarios_O_Sede", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    lstErUsuario = sWLNServicioClient.Obtener_RUsuarios_O_Top_Creditos(sede).ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RUsuarios_O_Sede", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_RUsuarios_O_Sede", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RUsuarios_O_Sede", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        
        return lstErUsuario;
    }

    public void Actualizar_RUsuario_A_Creditos_Sede(string Codigo)
    {
        try
        {
            swlnReciclado.Actualizar_RUsuario_A_Creditos_Sede(Codigo);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_RUsuario_A_Creditos_Sede", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    sWLNServicioClient.Actualizar_RUsuario_A_Creditos_Sede(Codigo);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_RUsuario_A_Creditos_Sede", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Actualizar_RUsuario_A_Creditos_Sede", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_RUsuario_A_Creditos_Sede", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }

    public void Actualizar_RUsuario_A_Creditos_Codigo(string Codigo, string Creditos)
    {
        try
        {
            swlnReciclado.Actualizar_RUsuario_A_Creditos_Codigo(Codigo, Creditos);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_RUsuario_A_Creditos_Codigo", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    sWLNServicioClient.Actualizar_RUsuario_A_Creditos_Codigo(Codigo, Creditos);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_RUsuario_A_Creditos_Codigo", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Actualizar_RUsuario_A_Creditos_Codigo", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_RUsuario_A_Creditos_Codigo", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    public List<EUsuarioCompleja> Obtener_EUsuarioCompleja_O_Sede(string Sede)
    {
        List<EUsuarioCompleja> lstEUsuarioCompleja = new List<EUsuarioCompleja>();
        try
        {
            lstEUsuarioCompleja = swlnReciclado.Obtener_EUsuarioCompleja_O_Sede(Sede).ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_EUsuarioCompleja_O_Sede", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    lstEUsuarioCompleja = sWLNServicioClient.Obtener_EUsuarioCompleja_O_Sede(Sede).ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_EUsuarioCompleja_O_Sede", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_EUsuarioCompleja_O_Sede", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_EUsuarioCompleja_O_Sede", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return lstEUsuarioCompleja;
    }
    #endregion

    #region ERContenedor
    public void Insertar_RContenedor_I(string codigoUsuario, byte maquinaContenedor, string gramosContenedor, DateTime fechaRegistroContenedor)
    {
        try
        {
            swlnReciclado.Insertar_RContenedor_I(codigoUsuario, maquinaContenedor, gramosContenedor, fechaRegistroContenedor);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_RContenedor_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    sWLNServicioClient.Insertar_RContenedor_I(codigoUsuario, maquinaContenedor, gramosContenedor, fechaRegistroContenedor);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_RContenedor_I", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Insertar_RContenedor_I", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_RContenedor_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    public List<ERContenedor> Obtener_RContenedor_O_Codigo(string codigoUsuario)
    {
        List<ERContenedor> lstErContenedor = new List<ERContenedor>();
        try
        {
            lstErContenedor = swlnReciclado.Obtener_RContenedor_O_Codigo(codigoUsuario).ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RContenedor_O_Codigo", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    lstErContenedor = sWLNServicioClient.Obtener_RContenedor_O_Codigo(codigoUsuario).ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RContenedor_O_Codigo", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_RContenedor_O_Codigo", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_RContenedor_O_Codigo", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        
        return lstErContenedor;
     
    }

    public ECampaniaFinalizadaCompleja Obtener_ECampaniaFinalizadaCompleja_O_Campania(string Campania, string Sede)
    {
        ECampaniaFinalizadaCompleja eCampaniaFinalizadaCompleja = new ECampaniaFinalizadaCompleja();
        try
        {
            eCampaniaFinalizadaCompleja = swlnReciclado.Obtener_ECampaniaFinalizadaCompleja_O_Campania(Campania, Sede);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_ECampaniaFinalizadaCompleja_O_Campania", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    eCampaniaFinalizadaCompleja = sWLNServicioClient.Obtener_ECampaniaFinalizadaCompleja_O_Campania(Campania, Sede);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_ECampaniaFinalizadaCompleja_O_Campania", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_ECampaniaFinalizadaCompleja_O_Campania", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_ECampaniaFinalizadaCompleja_O_Campania", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return eCampaniaFinalizadaCompleja;
    }

    #endregion

    #region Cifrado y descifrado
    public string Descifrar_Cadena(string Texto, string Tipo)
    {
        string textoDescifrado = string.Empty;
        try
        {
            using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
            {
                textoDescifrado = sWLNServicioClient.Descifrado(Texto, Tipo);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Descifrar_Cadena", ex.Source, ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    textoDescifrado = sWLNServicioClient.Descifrado(Texto, Tipo);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Descifrar_Cadena", communicationException.ToString(), communicationException.Message, communicationException.StackTrace);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Descifrar_Cadena", ex.Source, ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return textoDescifrado;
    }

    public string Cifrar_Cadena(string TextoACifrar)
    {
        string textoCifrado = string.Empty;

        try
        {
            using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
            {
                textoCifrado = sWLNServicioClient.Cifrar_Cadena(TextoACifrar);
                //textoCifrado = sWLNServicioClient.Adicionar_VSolicitud()
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Cifrar_Cadena", ex.Source, ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    textoCifrado = sWLNServicioClient.Cifrar_Cadena(TextoACifrar);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Cifrar_Cadena", communicationException.ToString(), communicationException.Message, communicationException.StackTrace);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Cifrar_Cadena", ex.Source, ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return textoCifrado;
    }
    #endregion

    #region EEmpleado
    public Tuple<EEmpleado, EMensajeError> Obtener_Empleado_Id_Emp_SedeAcademica(string Id_Emp, string SedeAcademica)
    {
        Tuple<EEmpleado, EMensajeError> result;
        try
        {
            using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
            {
                result = sWLNServicioClient.Obtener_Empleado_Id_Emp_SedeAcademica(Id_Emp, SedeAcademica);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_Empleado_Id_Emp_SedeAcademica", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    result = sWLNServicioClient.Obtener_Empleado_Id_Emp_SedeAcademica(Id_Emp, SedeAcademica);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_Empleado_Id_Emp_SedeAcademica", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_Empleado_Id_Emp_SedeAcademica", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_Empleado_Id_Emp_SedeAcademica", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return result;
    }

    public Tuple<byte[], EMensajeError> Obtener_EmpleadoFotografia(string Id_Emp, string SedeAcademica)
    {
        Tuple<byte[], EMensajeError> result;
        try
        {
            using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
            {
                result = sWLNServicioClient.Obtener_EmpleadoFotografia(Id_Emp, SedeAcademica);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_EmpleadoFotografia", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNRecicladoClient sWLNServicioClient = new SWLNRecicladoClient())
                {
                    result = sWLNServicioClient.Obtener_EmpleadoFotografia(Id_Emp, SedeAcademica);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_EmpleadoFotografia", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_EmpleadoFotografia", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_EmpleadoFotografia", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return result;
    }

    #endregion

    #endregion
}