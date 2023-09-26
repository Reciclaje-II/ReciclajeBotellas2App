using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "SWADNETReciclado" en el código, en svc y en el archivo de configuración a la vez.
public class SWADNETReciclado : ISWADNETReciclado
{
    #region Tabla : RVoto
    public void Insertar_RVoto_I(ERVoto eRVoto)
    {
        CRVoto cRVoto = new CRVoto();
        cRVoto.Insertar_RVoto_I(eRVoto);
    }

    public void Actualizar_RVoto_A(ERVoto eRVoto)
    {
        CRVoto cRVoto = new CRVoto();
        cRVoto.Actualizar_RVoto_A(eRVoto);
    }

    public ERVoto Obtener_RVoto_O_Codigo_Campania(string codigoUsuario, string nombreCampania)
    {
        CRVoto cRVoto = new CRVoto();
        ERVoto eRVoto = new ERVoto();
        eRVoto = cRVoto.Obtener_RVoto_O_Codigo_Campania(codigoUsuario, nombreCampania);
        return eRVoto;
    }

    public int Obtener_RVotos_O_Campania(string nombeCampaniaVoto)
    {
        CRVoto cRVoto = new CRVoto();
        return cRVoto.Obtener_RVotos_O_Campania(nombeCampaniaVoto);
    }

    public int Obtener_RVotos_O_Campania_Organizacion(string campaniaVoto, string nombreOrganizacionVoto)
    {
        CRVoto cRVoto = new CRVoto();
        return cRVoto.Obtener_RVotos_O_Campania_Organizacion(campaniaVoto,nombreOrganizacionVoto);
    }

    public int Obtener_RVoto_O_Donacion_Total(string nombreCampaniaVoto)
    {
        CRVoto cRVoto = new CRVoto();
        return cRVoto.Obtener_RVoto_O_Donacion_Total(nombreCampaniaVoto);
    }

    public ERVoto Obtener_RVoto_O_Donacion_Maxima(string nombreCampania)
    {
        CRVoto cRVoto = new CRVoto();
        ERVoto eRVoto = new ERVoto();
        eRVoto = cRVoto.Obtener_RVoto_O_Donacion_Maxima(nombreCampania);
        return eRVoto;
    }

    public string Obtener_RVoto_O_Organizacion(string nombreCampania)
    {
        CRVoto cRVoto = new CRVoto();
        return cRVoto.Obtener_RVoto_O_Organizacion(nombreCampania);
    }
    #endregion
    #region Tabla: RUsuarioNetvalle
    public ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(string sedeUsuarioNetvalle, string codigoUsuarioNetvalle)
    {
        CRUsuarioNetvalle cRUsuarioNetvalle = new CRUsuarioNetvalle();
        ERUsuarioNetvalle eRUsuarioNetvalle = new ERUsuarioNetvalle();
        eRUsuarioNetvalle = cRUsuarioNetvalle.Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(sedeUsuarioNetvalle, codigoUsuarioNetvalle);
        return eRUsuarioNetvalle;
    }

    public ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Codigo(string codigoUsuarioNetvalle)
    {
        CRUsuarioNetvalle cRUsuarioNetvalle = new CRUsuarioNetvalle();
        ERUsuarioNetvalle eRUsuarioNetvalle = new ERUsuarioNetvalle();
        eRUsuarioNetvalle = cRUsuarioNetvalle.Obtener_RUsuarioNetvalle_O_Codigo(codigoUsuarioNetvalle);
        return eRUsuarioNetvalle;
    }

    public ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Tarjeta(string tarjetaUsuarioNetvalle)
    {
        CRUsuarioNetvalle cRUsuarioNetvalle = new CRUsuarioNetvalle();
        ERUsuarioNetvalle eRUsuarioNetvalle = new ERUsuarioNetvalle();
        eRUsuarioNetvalle = cRUsuarioNetvalle.Obtener_RUsuarioNetvalle_O_Tarjeta(tarjetaUsuarioNetvalle);
        return eRUsuarioNetvalle;
    }
    public void Insertar_RUsuarioNetvalle_y_RUsuario(string roleUsuario, string codigoUsuarioNetvalle, string nombresUsuarioNetvalle, string apellidosUsuarioNetvalle, string cargoUsuarioNetvalle, string tarjetaUsuarioNetvalle, string sedeUsuarioNetvalle)
    {
        CRUsuarioNetvalle cRUsuarioNetvalle = new CRUsuarioNetvalle();
        cRUsuarioNetvalle.Insertar_RUsuarioNetvalle_y_RUsuario(roleUsuario,
        codigoUsuarioNetvalle,
        nombresUsuarioNetvalle,
        apellidosUsuarioNetvalle,
        cargoUsuarioNetvalle,
        tarjetaUsuarioNetvalle,
        sedeUsuarioNetvalle);
    }
    #endregion
    #region Tabla : RCampania
    public ERCampania Obtener_RCampania_O_Sede(string sedeCampania)
    {
        CRCampania cRCampania = new CRCampania();
        ERCampania eRCampania = new ERCampania();
        eRCampania = cRCampania.Obtener_RCampania_O_Sede(sedeCampania);
        return eRCampania;

    }

    public List<ERCampania> Obtener_RCampania_O()
    {
        CRCampania cRCampania = new CRCampania();
        List<ERCampania> lstRCampania = new List<ERCampania>();
        lstRCampania = cRCampania.Obtener_RCampania_O();
        return lstRCampania;
    }

    public void Insertar_RCampania_I(ERCampania eRCampania)
    {
        CRCampania cRCampania = new CRCampania();
        cRCampania.Insertar_RCampania_I(eRCampania);
    }

    public void Actualizar_RCampania_A(ERCampania eRCampania)
    {
        CRCampania cRCampania = new CRCampania();
        cRCampania.Actualizar_RCampania_A(eRCampania);
    }

    public void Actualizar_RCampania_A_Estado(string nombreCampania)
    {
        CRCampania cRCampania = new CRCampania();
        cRCampania.Actualizar_RCampania_A_Estado(nombreCampania);
    }

    public void Actualizar_RCampania_A_Estado_Cancelado(string nombreCampania)
    {
        CRCampania cRCampania = new CRCampania();
        cRCampania.Actualizar_RCampania_A_Estado_Cancelado(nombreCampania);
    }
    #endregion
    #region Tabla : RCampaniaOrganizacion
    public void Insertar_RCampaniaOrganizacion_I(ERCampaniaOrganizacion eRCampaniaOrganizacion)
    {
        CRCampaniaOrganizacion cRCampaniaOrganizacion = new CRCampaniaOrganizacion();
        cRCampaniaOrganizacion.Insertar_RCampaniaOrganizacion_I(eRCampaniaOrganizacion);
    }

    public List<ERCampaniaOrganizacion> Obtener_RCampaniaOrganizacion_O_Campania(string nombreCampania)
    {
        CRCampaniaOrganizacion cRCampaniaOrganizacion = new CRCampaniaOrganizacion();
        List<ERCampaniaOrganizacion> lstRCampaniaOrganizacion = new List<ERCampaniaOrganizacion>();
        lstRCampaniaOrganizacion = cRCampaniaOrganizacion.Obtener_RCampaniaOrganizacion_O_Campania(nombreCampania);
        return lstRCampaniaOrganizacion;
    }
    #endregion
    #region Tabla : ROrganizacion
    public void Insertar_ROrganizacion_I(EROrganizacion eROrganizacion)
    {
        CROrganizacion cROrganizacion = new CROrganizacion();
        cROrganizacion.Insertar_ROrganizacion_I(eROrganizacion);
    }

    public void Actualizar_ROrganizacion_A(EROrganizacion eROrganizacion)
    {
        CROrganizacion cROrganizacion = new CROrganizacion();
        cROrganizacion.Actualizar_ROrganizacion_A(eROrganizacion);
    }

    public EROrganizacion Obtener_ROrganizacion_O_Nombre(string nombreOrganizacion)
    {
        CROrganizacion cROrganizacion = new CROrganizacion();
        EROrganizacion eROrganizacion = new EROrganizacion();
        eROrganizacion = cROrganizacion.Obtener_ROrganizacion_O_Nombre(nombreOrganizacion);
        return eROrganizacion;
    }

    public List<EROrganizacion> Obtener_ROrganizaciones_O()
    {
        CROrganizacion cROrganizacion = new CROrganizacion();
        List<EROrganizacion> lstEROrganizaciones = new List<EROrganizacion>();
        lstEROrganizaciones = cROrganizacion.Obtener_ROrganizaciones_O();
        return lstEROrganizaciones;
    }

    public void Eliminar_ROrganizacion_E_Nombre(string nombreOrganizacion)
    {
        CROrganizacion cROrganizacion = new CROrganizacion();
        cROrganizacion.Eliminar_ROrganizacion_E_Nombre(nombreOrganizacion);
    }
    #endregion
    #region Tabla : RImagen
    public void Insertar_RImagen_I(ERImagen eRImagen)
    {
        CRImagen cRImagen = new CRImagen();
        cRImagen.Insertar_RImagen_I(eRImagen);
    }

    public List<ERImagen> Obtener_RImagen_O_Organizacion(string organizacionImagen, byte tipoImagen)
    {
        CRImagen cRImagen = new CRImagen();
        List<ERImagen> lstRImagen = new List<ERImagen>();
        lstRImagen = cRImagen.Obtener_RImagen_O_Organizacion(organizacionImagen, tipoImagen);
        return lstRImagen;
    }
    #endregion
    #region Tabla : RUsuario
    public ERUsuario Obtener_RUsuario_O_Codigo(string codigoUsuario)
    {
        CRUsuario cRUsuario = new CRUsuario();
        ERUsuario eRUsuario = new ERUsuario();
        eRUsuario = cRUsuario.Obtener_RUsuario_O_Codigo(codigoUsuario);
        return eRUsuario;
    }

    public List<ERUsuario> Obtener_RUsuarios_O_Top_Creditos(string sedeUsuarioNetvalle)
    {
        CRUsuario cRUsuario = new CRUsuario();
        List<ERUsuario> lsteRUsuario = new List<ERUsuario>();
        lsteRUsuario = cRUsuario.Obtener_RUsuarios_O_Top_Creditos(sedeUsuarioNetvalle);
        return lsteRUsuario;
    }

    public List<ERUsuario> Obtener_RUsuarios_O_Sede(string sedeUsuarioNetvalle)
    {
        CRUsuario cRUsuario = new CRUsuario();
        List<ERUsuario> lsteRUsuario = new List<ERUsuario>();
        lsteRUsuario = cRUsuario.Obtener_RUsuarios_O_Sede(sedeUsuarioNetvalle);
        return lsteRUsuario;
    }

    public void Actualizar_RUsuario_A_Creditos_Sede(string codigoUsuarioNetvalle)
    {
        CRUsuario cRUsuario = new CRUsuario();
        cRUsuario.Actualizar_RUsuario_A_Creditos_Sede(codigoUsuarioNetvalle);
    }

    public void Actualizar_RUsuario_A_Creditos_Codigo(string codigoUsuario, string creditosUsuario)
    {
        CRUsuario cRUsuario = new CRUsuario();
        cRUsuario.Actualizar_RUsuario_A_Creditos_Codigo(codigoUsuario, creditosUsuario);
    }
    #endregion
    #region Tabla : RContenedor
    public void Insertar_RContenedor_I(ERContenedor eRContenedor)
    {
        CRContenedor cRContenedor = new CRContenedor();
        cRContenedor.Insertar_RContenedor_I(eRContenedor);
    }
    public List<ERContenedor> Obtener_RContenedor_O_Codigo(string codigoUsuario)
    {
        CRContenedor cRContenedor = new CRContenedor();
        List<ERContenedor> lsteRContenedor = new List<ERContenedor>();
        lsteRContenedor = cRContenedor.Obtener_RContenedor_O_Codigo(codigoUsuario);
        return lsteRContenedor;
    }

 
    #endregion
}
