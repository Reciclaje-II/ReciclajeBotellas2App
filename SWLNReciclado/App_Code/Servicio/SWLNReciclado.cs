using SWADNETReciclado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "SWLNReciclado" en el código, en svc y en el archivo de configuración a la vez.
public class SWLNReciclado : ISWLNReciclado
{
    #region RCampania
    public ERCampania Obtener_RCampania_O_Sede(string sedeCampania)
    {
        CReciclado cReciclado = new CReciclado();
        ERCampania erCampania = new ERCampania();
        erCampania = cReciclado.Obtener_RCampania_O_Sede(sedeCampania);
        return erCampania;
    }

    public List<ERCampania> Obtener_RCampania_O(string sedeCampania)
    {
        CReciclado cReciclado = new CReciclado();
        List<ERCampania> lstErCampania = new List<ERCampania>();
        lstErCampania = cReciclado.Obtener_RCampania_O(sedeCampania);
        return lstErCampania;
    }
    public ERCampania Obtener_RCampania_O_Sede_Campania(string nombreCampania, string sedeCampania)
    {
        CReciclado cReciclado = new CReciclado();
        ERCampania erCampania = new ERCampania();
        erCampania = cReciclado.Obtener_RCampania_O_Sede_Campania(nombreCampania, sedeCampania);
        return erCampania;
    }

    public void Insertar_RCampania_I(string nombreCampania, string descripcionCampania, DateTime fechaInicioCampania, DateTime fechaFinCampania, string sedeCampania)
    {
        CReciclado cReciclado = new CReciclado();
        cReciclado.Insertar_RCampania_I(nombreCampania, descripcionCampania, fechaInicioCampania, fechaFinCampania, sedeCampania);
    }
    public void Actualizar_RCampania_A(string nombreCampania, string descripcionCampania, DateTime fechaInicioCampania, DateTime fechaFinCampania, string sedeCampania)
    {
        CReciclado cReciclado = new CReciclado();
        cReciclado.Actualizar_RCampania_A(nombreCampania, descripcionCampania, fechaInicioCampania, fechaFinCampania, sedeCampania);        
    }
    public void Actualizar_RCampania_A_Estado(string nombreCampania)
    {
        CReciclado cReciclado = new CReciclado();
        cReciclado.Actualizar_RCampania_A_Estado(nombreCampania);
    }
    public void Actualizar_RCampania_A_Estado_Cancelado(string nombreCampania)
    {
        CReciclado cReciclado = new CReciclado();
        cReciclado.Actualizar_RCampania_A_Estado_Cancelado(nombreCampania);
    }
    #endregion
    #region RCampaniaOrganizacion
    public List<ERCampaniaOrganizacion> Obtener_RCampaniaOrganizacion_O_Campania(string nombreCampania)
    {
        CReciclado cReciclado = new CReciclado();
        List<ERCampaniaOrganizacion> lstErCampaniaOrganizacion = new List<ERCampaniaOrganizacion>();
        lstErCampaniaOrganizacion = cReciclado.Obtener_RCampaniaOrganizacion_O_Campania(nombreCampania);
        return lstErCampaniaOrganizacion;
    }
    public void Insertar_RCampaniaOrganizacion_I(string campaniaCampaniaOrganizacion, string organizacionCampaniaOrganizacion)
    {
        CReciclado cReciclado = new CReciclado();
        cReciclado.Insertar_RCampaniaOrganizacion_I(campaniaCampaniaOrganizacion, organizacionCampaniaOrganizacion);
    }
    #endregion
    #region ROrganizacion
    public EROrganizacion Obtener_ROrganizacion_O_Nombre(string nombre)
    {
        CReciclado cReciclado = new CReciclado();
        EROrganizacion erOrganizacion = new EROrganizacion();
        erOrganizacion = cReciclado.Obtener_ROrganizacion_O_Nombre(nombre);
        return erOrganizacion;
    }
    public List<EROrganizacion> Obtener_ROrganizaciones_O()
    {
        CReciclado cReciclado = new CReciclado();
        List<EROrganizacion> lstErOrganizacion = new List<EROrganizacion>();
        lstErOrganizacion = cReciclado.Obtener_ROrganizaciones_O();
        return lstErOrganizacion;
    }
    public void Insertar_ROrganizacion_I(string nombre, string descripcion)
    {
        CReciclado cReciclado = new CReciclado();
        cReciclado.Insertar_ROrganizacion_I(nombre, descripcion);
    }
    public void Actualizar_ROrganizacion_A(string nombre, string descripcion)
    {
        CReciclado cReciclado = new CReciclado();
        cReciclado.Actualizar_ROrganizacion_A(nombre, descripcion);
    }
    public void Eliminar_ROrganizacion_E_Nombre(string Nombre)
    {
        CReciclado cReciclado = new CReciclado();
        cReciclado.Eliminar_ROrganizacion_E_Nombre(Nombre);
    }
    #endregion
    #region RImagen
    public List<ERImagen> Obtener_RImagen_O_Organizacion(string organizacionImagen, byte tipoImagen)
    {
        CReciclado cReciclado = new CReciclado();
        List<ERImagen> lstErImagen = new List<ERImagen>();
        lstErImagen = cReciclado.Obtener_RImagen_O_Organizacion(organizacionImagen, tipoImagen);
        return lstErImagen;
    }   
    #endregion
    #region RVoto
    public void Insertar_RVoto_I(string codigoUsuario, string nombreCampania, string nombreOrganizacion, DateTime fechaRegistroVoto, string donacionVoto, string estadoVoto)
    {
        CReciclado cReciclado = new CReciclado();
        cReciclado.Insertar_RVoto_I(codigoUsuario, nombreCampania, nombreOrganizacion, fechaRegistroVoto, donacionVoto,estadoVoto);
    }

    public void Actualizar_RVoto_A(string codigoUsuario, string nombreCampania, string nombreOrganizacion, DateTime fechaRegistroVoto, string donacionVoto, string estadoVoto)
    {
        CReciclado cReciclado = new CReciclado();
        cReciclado.Actualizar_RVoto_A(codigoUsuario, nombreCampania, nombreOrganizacion, fechaRegistroVoto, donacionVoto, estadoVoto);
    }
    public ERVoto Obtener_RVoto_O_Codigo_Campania(string codigoUsuario, string nombreCampania)
    {
        CReciclado cReciclado = new CReciclado();
        ERVoto erVoto = new ERVoto();
        erVoto = cReciclado.Obtener_RVoto_O_Codigo_Campania(codigoUsuario, nombreCampania);
        return erVoto;
    }

    public int Obtener_RVotos_O_Campania(string nombeCampaniaVoto)
    {
        CReciclado cReciclado = new CReciclado();
        int votos = 0;
        votos = cReciclado.Obtener_RVotos_O_Campania(nombeCampaniaVoto);
        return votos;
    }
    public int Obtener_RVotos_O_Campania_Organizacion(string campaniaVoto, string nombreOrganizacionVoto)
    {
        CReciclado cReciclado = new CReciclado();
        int votos = 0;
        votos = cReciclado.Obtener_RVotos_O_Campania_Organizacion(campaniaVoto, nombreOrganizacionVoto);
        return votos;
    }
    public int Obtener_RVoto_O_Donacion_Total(string nombreCampaniaVoto)
    {
        CReciclado cReciclado = new CReciclado();
        int votos = 0;
        votos = cReciclado.Obtener_RVoto_O_Donacion_Total(nombreCampaniaVoto);
        return votos;
    }

    public ERVoto Obtener_RVoto_O_Donacion_Maxima(string nombreCampania)
    {
        CReciclado cReciclado = new CReciclado();
        ERVoto erVoto = new ERVoto();
        erVoto = cReciclado.Obtener_RVoto_O_Donacion_Maxima(nombreCampania);
        return erVoto;
    }

    public string Obtener_RVoto_O_Organizacion(string nombreCampania)
    {
        CReciclado cReciclado = new CReciclado();
        string organizacion = string.Empty;
        organizacion = cReciclado.Obtener_RVoto_O_Organizacion(nombreCampania);
        return organizacion;
    }
    #endregion
    #region RUsuarioNetValle
    public ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(string sedeUsuarioNetvalle, string codigoUsuarioNetvalle)
    {
        CReciclado cReciclado = new CReciclado();
        ERUsuarioNetvalle erUsuarioNetvalle = new ERUsuarioNetvalle();
        erUsuarioNetvalle = cReciclado.Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(sedeUsuarioNetvalle, codigoUsuarioNetvalle);
        return erUsuarioNetvalle;
    }

    public ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Codigo_Pass_Rol(string Codigo, string Passs, string Rol)
    {
        CReciclado cReciclado = new CReciclado();
        ERUsuarioNetvalle erUsuarioNetvalle = new ERUsuarioNetvalle();
        erUsuarioNetvalle = cReciclado.Obtener_RUsuarioNetvalle_O_Codigo(Codigo);
        return erUsuarioNetvalle;
    }

    public ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Codigo(string Codigo, string passs, string rol)
    {
        CReciclado cReciclado = new CReciclado();
        ERUsuarioNetvalle erUsuarioNetvalle = new ERUsuarioNetvalle();
        erUsuarioNetvalle = cReciclado.Obtener_RUsuarioNetvalle_O_Codigo(Codigo);
        return erUsuarioNetvalle;
    }
    public ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Tarjeta(string tarjetaUsuarioNetvalle)
    {
        CReciclado cReciclado = new CReciclado();
        ERUsuarioNetvalle erUsuarioNetvalle = new ERUsuarioNetvalle();
        erUsuarioNetvalle = cReciclado.Obtener_RUsuarioNetvalle_O_Tarjeta(tarjetaUsuarioNetvalle);
        return erUsuarioNetvalle;
    }
    public void Insertar_RUsuarioNetvalle_y_RUsuario(string roleUsuario, string codigoUsuarioNetvalle, string nombresUsuarioNetvalle, string apellidosUsuarioNetvalle, string cargoUsuarioNetvalle, string tarjetaUsuarioNetvalle, string sedeUsuarioNetvalle)
    {
        CReciclado cReciclado = new CReciclado();
        cReciclado.Insertar_RUsuarioNetvalle_y_RUsuario(roleUsuario,
        codigoUsuarioNetvalle,
        nombresUsuarioNetvalle,
        apellidosUsuarioNetvalle,
        cargoUsuarioNetvalle,
        tarjetaUsuarioNetvalle,
        sedeUsuarioNetvalle);
    }

    public ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Tarjeta_NetValle(string tarjetaUsuarioNetValle)
    {
        CReciclado cReciclado = new CReciclado();
        ERUsuarioNetvalle erUsuarioNetvalle = new ERUsuarioNetvalle();
        erUsuarioNetvalle = cReciclado.Obtener_RUsuarioNetvalle_O_Tarjeta_NetValle(tarjetaUsuarioNetValle);
        return erUsuarioNetvalle;
    }
    #endregion
    #region RUsuario
    public ERUsuario Obtener_RUsuario_O_Codigo(string Codigo)
    {
        CReciclado cReciclado = new CReciclado();
        ERUsuario erUsuario = new ERUsuario();
        erUsuario = cReciclado.Obtener_RUsuario_O_Codigo(Codigo);
        return erUsuario;
    }

    public List<ERUsuario> Obtener_RUsuarios_O_Top_Creditos(string Sede)
    {
        CReciclado cReciclado = new CReciclado();
        List<ERUsuario> lstErUsuario = new List<ERUsuario>();
        lstErUsuario = cReciclado.Obtener_RUsuarios_O_Top_Creditos(Sede);
        return lstErUsuario;
    }

    public List<ERUsuario> Obtener_RUsuarios_O_Sede(string Sede)
    {
        CReciclado cReciclado = new CReciclado();
        List<ERUsuario> lstErUsuario = new List<ERUsuario>();
        lstErUsuario = cReciclado.Obtener_RUsuarios_O_Sede(Sede);
        return lstErUsuario;
    }

    public void Actualizar_RUsuario_A_Creditos_Sede(string Codigo)
    {
        CReciclado cReciclado = new CReciclado();
        cReciclado.Actualizar_RUsuario_A_Creditos_Sede(Codigo);
    }
    public void Actualizar_RUsuario_A_Creditos_Codigo(string Codigo, string Creditos)
    {
        CReciclado cReciclado = new CReciclado();
        cReciclado.Actualizar_RUsuario_A_Creditos_Codigo(Codigo, Creditos);
    }
    #endregion
    #region RContenedor
    public void Insertar_RContenedor_I(string codigoUsuario, byte maquinaContenedor, string gramosContenedor, DateTime fechaRegistroContenedor)
    {
        CReciclado cReciclado = new CReciclado();
        cReciclado.Insertar_RContenedor_I(codigoUsuario, maquinaContenedor, gramosContenedor, fechaRegistroContenedor);
    }
    public List<ERContenedor> Obtener_RContenedor_O_Codigo(string codigoUsuario)
    {
        CReciclado cReciclado = new CReciclado();
        List<ERContenedor> lstErContenedor = new List<ERContenedor>();
        lstErContenedor = cReciclado.Obtener_RContenedor_O_Codigo(codigoUsuario);
        return lstErContenedor;
    }
    #endregion
    //COMPLEJAS
    #region EUsuarioCompleja
    public List<EUsuarioCompleja> Obtener_EUsuarioCompleja_O_Sede(string Sede)
    {
        CReciclado cReciclado = new CReciclado();
        List<EUsuarioCompleja> lstEUsuarioCompleja = new List<EUsuarioCompleja>();
        lstEUsuarioCompleja = cReciclado.Obtener_EUsuarioCompleja_O_Sede(Sede);
        return lstEUsuarioCompleja;
    }
    #endregion
    #region ECampaniaFinalizadaCompleja
    public ECampaniaFinalizadaCompleja Obtener_ECampaniaFinalizadaCompleja_O_Campania(string Campania, string Sede)
    {
        CReciclado cReciclado = new CReciclado();
        ECampaniaFinalizadaCompleja eCampaniaFinalizadaCompleja = new ECampaniaFinalizadaCompleja();
        eCampaniaFinalizadaCompleja = cReciclado.Obtener_ECampaniaFinalizadaCompleja_O_Campania(Campania, Sede);
        return eCampaniaFinalizadaCompleja;
    }
    
    #endregion

    //Añadidas
    public string Descifrado(string Texto, string Tipo)
    {
        return "";
    }
    public string Cifrar_Cadena(string TextoACifrar)
    {
        return "";
    }
    public Tuple<EEmpleado, EMensajeError> Obtener_Empleado_Id_Emp_SedeAcademica(string Id_Emp, string SedeAcademica)
    {
        Tuple<EEmpleado, EMensajeError> result;
        result = null;
        return result;
    }
    public Tuple<byte[], EMensajeError> Obtener_EmpleadoFotografia(string Id_Emp, string SedeAcademica)
    {
        Tuple<byte[], EMensajeError> result;
        result = null;
        return result;
    }

    public ERUsuarioNetvalle RUsuarioNetvalle_RUsuaro_I(string tarjeta)
    {
        CReciclado cReciclado = new CReciclado();
        return cReciclado.RUsuarioNetvalle_RUsuaro_I(tarjeta);
    }

   
}
