using SWADNETRecicladoReference;
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
    public ERCampania Obtener_RCampania_O_Sede(string Sede)
    {
        CReciclado cReciclado = new CReciclado();
        ERCampania erCampania = new ERCampania();
        erCampania = cReciclado.Obtener_RCampania_O_Sede(Sede);
        return erCampania;
    }

    public List<ERCampania> Obtener_RCampania_O(string Sede)
    {
        CReciclado cReciclado = new CReciclado();
        List<ERCampania> lstErCampania = new List<ERCampania>();
        lstErCampania = cReciclado.Obtener_RCampania_O(Sede);
        return lstErCampania;
    }
    public ERCampania Obtener_RCampania_O_Sede_Campania(string Campania, string Sede)
    {
        CReciclado cReciclado = new CReciclado();
        ERCampania erCampania = new ERCampania();
        erCampania = cReciclado.Obtener_RCampania_O_Sede_Campania(Campania, Sede);
        return erCampania;
    }

    public void Insertar_RCampania_I(string nombre, string descripcion, DateTime fechaInicio, DateTime fechaFin, string sede)
    {
        CReciclado cReciclado = new CReciclado();
        cReciclado.Insertar_RCampania_I(nombre, descripcion, fechaInicio, fechaFin, sede);
    }
    public void Actualizar_RCampania_A(string nombre, string descripcion, DateTime fechaInicio, DateTime fechaFin, string sede)
    {
        CReciclado cReciclado = new CReciclado();
        cReciclado.Actualizar_RCampania_A(nombre, descripcion, fechaInicio, fechaFin, sede);        
    }
    public void Actualizar_RCampania_A_Estado(string Nombre)
    {
        CReciclado cReciclado = new CReciclado();
        cReciclado.Actualizar_RCampania_A_Estado(Nombre);
    }
    public void Actualizar_RCampania_A_Estado_Cancelado(string Nombre)
    {
        CReciclado cReciclado = new CReciclado();
        cReciclado.Actualizar_RCampania_A_Estado_Cancelado(Nombre);
    }
    #endregion
    #region RCampaniaOrganizacion
    public List<ERCampaniaOrganizacion> Obtener_RCampaniaOrganizacion_O_Campania(string Campania)
    {
        CReciclado cReciclado = new CReciclado();
        List<ERCampaniaOrganizacion> lstErCampaniaOrganizacion = new List<ERCampaniaOrganizacion>();
        lstErCampaniaOrganizacion = cReciclado.Obtener_RCampaniaOrganizacion_O_Campania(Campania);
        return lstErCampaniaOrganizacion;
    }
    public void Insertar_RCampaniaOrganizacion_I(string Campania, string Organizacion)
    {
        CReciclado cReciclado = new CReciclado();
        cReciclado.Insertar_RCampaniaOrganizacion_I(Campania, Organizacion);
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
    public List<ERImagen> Obtener_RImagen_O_Organizacion(string Organizacion, byte Tipo)
    {
        CReciclado cReciclado = new CReciclado();
        List<ERImagen> lstErImagen = new List<ERImagen>();
        lstErImagen = cReciclado.Obtener_RImagen_O_Organizacion(Organizacion, Tipo);
        return lstErImagen;
    }   
    #endregion
    #region RVoto
    public void Insertar_RVoto_I(string Codigo, string Campania, string Organizacion, DateTime Fecha, string Donacion, string Estado)
    {
        CReciclado cReciclado = new CReciclado();
        cReciclado.Insertar_RVoto_I(Codigo, Campania, Organizacion, Fecha, Donacion, Estado);
    }

    public void Actualizar_RVoto_A(string Codigo, string Campania, string Organizacion, DateTime Fecha, string Donacion, string Estado)
    {
        CReciclado cReciclado = new CReciclado();
        cReciclado.Actualizar_RVoto_A(Codigo, Campania, Organizacion, Fecha, Donacion, Estado);
    }
    public ERVoto Obtener_RVoto_O_Codigo_Campania(string Codigo, string Campania)
    {
        CReciclado cReciclado = new CReciclado();
        ERVoto erVoto = new ERVoto();
        erVoto = cReciclado.Obtener_RVoto_O_Codigo_Campania(Codigo, Campania);
        return erVoto;
    }

    public int Obtener_RVotos_O_Campania(string Campania)
    {
        CReciclado cReciclado = new CReciclado();
        int votos = 0;
        votos = cReciclado.Obtener_RVotos_O_Campania(Campania);
        return votos;
    }
    public int Obtener_RVotos_O_Campania_Organizacion(string Campania, string Organizacion)
    {
        CReciclado cReciclado = new CReciclado();
        int votos = 0;
        votos = cReciclado.Obtener_RVotos_O_Campania_Organizacion(Campania, Organizacion);
        return votos;
    }
    public int Obtener_RVoto_O_Donacion_Total(string Campania)
    {
        CReciclado cReciclado = new CReciclado();
        int votos = 0;
        votos = cReciclado.Obtener_RVoto_O_Donacion_Total(Campania);
        return votos;
    }

    public ERVoto Obtener_RVoto_O_Donacion_Maxima(string Campania)
    {
        CReciclado cReciclado = new CReciclado();
        ERVoto erVoto = new ERVoto();
        erVoto = cReciclado.Obtener_RVoto_O_Donacion_Maxima(Campania);
        return erVoto;
    }

    public string Obtener_RVoto_O_Organizacion(string Campania)
    {
        CReciclado cReciclado = new CReciclado();
        string organizacion = string.Empty;
        organizacion = cReciclado.Obtener_RVoto_O_Organizacion(Campania);
        return organizacion;
    }
    #endregion
    #region RUsuarioNetValle
    public ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(string Sede, string Codigo)
    {
        CReciclado cReciclado = new CReciclado();
        ERUsuarioNetvalle erUsuarioNetvalle = new ERUsuarioNetvalle();
        erUsuarioNetvalle = cReciclado.Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(Sede, Codigo);
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
    public ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Tarjeta(string Tarjeta)
    {
        CReciclado cReciclado = new CReciclado();
        ERUsuarioNetvalle erUsuarioNetvalle = new ERUsuarioNetvalle();
        erUsuarioNetvalle = cReciclado.Obtener_RUsuarioNetvalle_O_Tarjeta(Tarjeta);
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

    public void Actualizar_RUsuario_A_Creditos_Sede(string Campania, string Codigo)
    {
        CReciclado cReciclado = new CReciclado();
        cReciclado.Actualizar_RUsuario_A_Creditos_Sede(Campania, Codigo);
    }
    public void Actualizar_RUsuario_A_Creditos_Codigo(string Codigo, string Creditos)
    {
        CReciclado cReciclado = new CReciclado();
        cReciclado.Actualizar_RUsuario_A_Creditos_Codigo(Codigo, Creditos);
    }
    #endregion
    #region RContenedor
    public void Insertar_RContenedor_I(string Codigo, byte IdMaquina, string Gramos, DateTime Fecha)
    {
        CReciclado cReciclado = new CReciclado();
        cReciclado.Insertar_RContenedor_I(Codigo, IdMaquina, Gramos, Fecha);
    }
    public List<ERContenedor> Obtener_RContenedor_O_Codigo(string Codigo)
    {
        CReciclado cReciclado = new CReciclado();
        List<ERContenedor> lstErContenedor = new List<ERContenedor>();
        lstErContenedor = cReciclado.Obtener_RContenedor_O_Codigo(Codigo);
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
}
