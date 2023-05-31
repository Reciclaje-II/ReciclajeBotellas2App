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

    public ERVoto Obtener_RVoto_O_Codigo_Campania(string Codigo, string Campania)
    {
        CRVoto cRVoto = new CRVoto();
        ERVoto eRVoto = new ERVoto();
        eRVoto = cRVoto.Obtener_RVoto_O_Codigo_Campania(Codigo, Campania);
        return eRVoto;
    }

    public int Obtener_RVotos_O_Campania(string Campania)
    {
        CRVoto cRVoto = new CRVoto();
        return cRVoto.Obtener_RVotos_O_Campania(Campania);
    }

    public int Obtener_RVotos_O_Campania_Organizacion(string Campania, string Organizacion)
    {
        CRVoto cRVoto = new CRVoto();
        return cRVoto.Obtener_RVotos_O_Campania_Organizacion(Campania,Organizacion);
    }

    public int Obtener_RVoto_O_Donacion_Total(string Campania)
    {
        CRVoto cRVoto = new CRVoto();
        return cRVoto.Obtener_RVoto_O_Donacion_Total(Campania);
    }

    public ERVoto Obtener_RVoto_O_Donacion_Maxima(string Campania)
    {
        CRVoto cRVoto = new CRVoto();
        ERVoto eRVoto = new ERVoto();
        eRVoto = cRVoto.Obtener_RVoto_O_Donacion_Maxima(Campania);
        return eRVoto;
    }

    public string Obtener_RVoto_O_Organizacion(string Campania)
    {
        CRVoto cRVoto = new CRVoto();
        return cRVoto.Obtener_RVoto_O_Organizacion(Campania);
    }
    #endregion
    #region Tabla: RUsuarioNetvalle
    public ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(string Sede,string Codigo)
    {
        CRUsuarioNetvalle cRUsuarioNetvalle = new CRUsuarioNetvalle();
        ERUsuarioNetvalle eRUsuarioNetvalle = new ERUsuarioNetvalle();
        eRUsuarioNetvalle = cRUsuarioNetvalle.Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(Sede,Codigo);
        return eRUsuarioNetvalle;
    }

    public ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Codigo(string Codigo)
    {
        CRUsuarioNetvalle cRUsuarioNetvalle = new CRUsuarioNetvalle();
        ERUsuarioNetvalle eRUsuarioNetvalle = new ERUsuarioNetvalle();
        eRUsuarioNetvalle = cRUsuarioNetvalle.Obtener_RUsuarioNetvalle_O_Codigo(Codigo);
        return eRUsuarioNetvalle;
    }

    public ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Tarjeta(string Tarjeta)
    {
        CRUsuarioNetvalle cRUsuarioNetvalle = new CRUsuarioNetvalle();
        ERUsuarioNetvalle eRUsuarioNetvalle = new ERUsuarioNetvalle();
        eRUsuarioNetvalle = cRUsuarioNetvalle.Obtener_RUsuarioNetvalle_O_Tarjeta(Tarjeta);
        return eRUsuarioNetvalle;
    }
    #endregion
    #region Tabla : RCampania
    public ERCampania Obtener_RCampania_O_Sede(string Sede)
    {
        CRCampania cRCampania = new CRCampania();
        ERCampania eRCampania = new ERCampania();
        eRCampania = cRCampania.Obtener_RCampania_O_Sede(Sede);
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

    public void Actualizar_RCampania_A_Estado(string Nombre)
    {
        CRCampania cRCampania = new CRCampania();
        cRCampania.Actualizar_RCampania_A_Estado(Nombre);
    }

    public void Actualizar_RCampania_A_Estado_Cancelado(string Nombre)
    {
        CRCampania cRCampania = new CRCampania();
        cRCampania.Actualizar_RCampania_A_Estado_Cancelado(Nombre);
    }
    #endregion
    #region Tabla : RCampaniaOrganizacion
    public void Insertar_RCampaniaOrganizacion_I(ERCampaniaOrganizacion eRCampaniaOrganizacion)
    {
        CRCampaniaOrganizacion cRCampaniaOrganizacion = new CRCampaniaOrganizacion();
        cRCampaniaOrganizacion.Insertar_RCampaniaOrganizacion_I(eRCampaniaOrganizacion);
    }

    public List<ERCampaniaOrganizacion> Obtener_RCampaniaOrganizacion_O_Campania(string Campania)
    {
        CRCampaniaOrganizacion cRCampaniaOrganizacion = new CRCampaniaOrganizacion();
        List<ERCampaniaOrganizacion> lstRCampaniaOrganizacion = new List<ERCampaniaOrganizacion>();
        lstRCampaniaOrganizacion = cRCampaniaOrganizacion.Obtener_RCampaniaOrganizacion_O_Campania(Campania);
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

    public EROrganizacion Obtener_ROrganizacion_O_Nombre(string NombreOrganizacion)
    {
        CROrganizacion cROrganizacion = new CROrganizacion();
        EROrganizacion eROrganizacion = new EROrganizacion();
        eROrganizacion = cROrganizacion.Obtener_ROrganizacion_O_Nombre(NombreOrganizacion);
        return eROrganizacion;
    }

    public List<EROrganizacion> Obtener_ROrganizaciones_O()
    {
        CROrganizacion cROrganizacion = new CROrganizacion();
        List<EROrganizacion> lstEROrganizaciones = new List<EROrganizacion>();
        lstEROrganizaciones = cROrganizacion.Obtener_ROrganizaciones_O();
        return lstEROrganizaciones;
    }

    public void Eliminar_ROrganizacion_E_Nombre(string NombreOrganizacion)
    {
        CROrganizacion cROrganizacion = new CROrganizacion();
        cROrganizacion.Eliminar_ROrganizacion_E_Nombre(NombreOrganizacion);
    }
    #endregion
    #region Tabla : RImagen
    public void Insertar_RImagen_I(ERImagen eRImagen)
    {
        CRImagen cRImagen = new CRImagen();
        cRImagen.Insertar_RImagen_I(eRImagen);
    }

    public List<ERImagen> Obtener_RImagen_O_Organizacion(string Organizacion, byte Tipo)
    {
        CRImagen cRImagen = new CRImagen();
        List<ERImagen> lstRImagen = new List<ERImagen>();
        lstRImagen = cRImagen.Obtener_RImagen_O_Organizacion(Organizacion, Tipo);
        return lstRImagen;
    }
    #endregion
    #region Tabla : RUsuario
    public ERUsuario Obtener_RUsuario_O_Codigo(string Codigo)
    {
        CRUsuario cRUsuario = new CRUsuario();
        ERUsuario eRUsuario = new ERUsuario();
        eRUsuario = cRUsuario.Obtener_RUsuario_O_Codigo(Codigo);
        return eRUsuario;
    }

    public List<ERUsuario> Obtener_RUsuarios_O_Top_Creditos(string Sede)
    {
        CRUsuario cRUsuario = new CRUsuario();
        List<ERUsuario> lsteRUsuario = new List<ERUsuario>();
        lsteRUsuario = cRUsuario.Obtener_RUsuarios_O_Top_Creditos(Sede);
        return lsteRUsuario;
    }

    public List<ERUsuario> Obtener_RUsuarios_O_Sede(string Sede)
    {
        CRUsuario cRUsuario = new CRUsuario();
        List<ERUsuario> lsteRUsuario = new List<ERUsuario>();
        lsteRUsuario = cRUsuario.Obtener_RUsuarios_O_Sede(Sede);
        return lsteRUsuario;
    }

    public void Actualizar_RUsuario_A_Creditos_Sede(string Campania, string Codigo)
    {
        CRUsuario cRUsuario = new CRUsuario();
        cRUsuario.Actualizar_RUsuario_A_Creditos_Sede(Campania, Codigo);
    }

    public void Actualizar_RUsuario_A_Creditos_Codigo(string Codigo, string Creditos)
    {
        CRUsuario cRUsuario = new CRUsuario();
        cRUsuario.Actualizar_RUsuario_A_Creditos_Codigo(Codigo, Creditos);
    }
    #endregion
    #region Tabla : RContenedor
    public void Insertar_RContenedor_I(ERContenedor eRContenedor)
    {
        CRContenedor cRContenedor = new CRContenedor();
        cRContenedor.Insertar_RContenedor_I(eRContenedor);
    }
    public List<ERContenedor> Obtener_RContenedor_O_Codigo(string Codigo)
    {
        CRContenedor cRContenedor = new CRContenedor();
        List<ERContenedor> lsteRContenedor = new List<ERContenedor>();
        lsteRContenedor = cRContenedor.Obtener_RContenedor_O_Codigo(Codigo);
        return lsteRContenedor;
    }
    #endregion
}
