using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SWADNETRecicladoReference;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISWLNReciclado" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface ISWLNReciclado
{
    #region RCampania
    [OperationContract]
    ERCampania Obtener_RCampania_O_Sede(string sedeCampania);
    [OperationContract]
    List<ERCampania> Obtener_RCampania_O(string sedeCampania);
    [OperationContract]
    ERCampania Obtener_RCampania_O_Sede_Campania(string nombreCampaniania, string SedeCampania);
    [OperationContract]
    void Insertar_RCampania_I(string nombreCampania, string descripcionCampania, DateTime fechaInicioCampania, DateTime fechaFinCampania, string sedeCampania);
    [OperationContract]
    void Actualizar_RCampania_A(string nombreCampania, string descripcionCampania, DateTime fechaInicioCampania, DateTime fechaFinCampania, string sedeCampania);
    [OperationContract]
    void Actualizar_RCampania_A_Estado(string nombreCampania);
    [OperationContract]
    void Actualizar_RCampania_A_Estado_Cancelado(string nombreCampania);
    #endregion
    #region RCampaniaOrganizacion
    [OperationContract]
    List<ERCampaniaOrganizacion> Obtener_RCampaniaOrganizacion_O_Campania(string campaniaCampaniaOrganizacion);
    [OperationContract]
    void Insertar_RCampaniaOrganizacion_I(string campaniaCampaniaOrganizacion, string organizacionCampaniaOrganizacion);
    #endregion
    #region ROrganizacion
    [OperationContract]
    EROrganizacion Obtener_ROrganizacion_O_Nombre(string nombre);
    [OperationContract]
    List<EROrganizacion> Obtener_ROrganizaciones_O();    
    [OperationContract]
    void Insertar_ROrganizacion_I(string nombre, string descripcion);
    [OperationContract]
    void Actualizar_ROrganizacion_A(string nombre, string descripcion);
    [OperationContract]
    void Eliminar_ROrganizacion_E_Nombre(string Nombre);
    #endregion
    #region RImagen
    [OperationContract]
    List<ERImagen> Obtener_RImagen_O_Organizacion(string organizacionImagen, byte tipoImagen);
    #endregion
    #region RVoto
    [OperationContract]
    void Insertar_RVoto_I(string codigoUsuario, string nombreCampania, string nombreOrganizacion, DateTime fechaRegistroVoto, string donacionVoto, string estadoVoto);
    [OperationContract]
    void Actualizar_RVoto_A(string codigoUsuario, string nombreCampania, string nombreOrganizacion, DateTime fechaRegistroVoto, string donacionVoto, string estadoVoto );
    [OperationContract]
    ERVoto Obtener_RVoto_O_Codigo_Campania(string campaniaVoto, string nombreOrganizacionVoto);
    [OperationContract]
    int Obtener_RVotos_O_Campania(string nombeCampaniaVoto);
    [OperationContract]
    int Obtener_RVotos_O_Campania_Organizacion(string campaniaVoto, string nombreOrganizacionVoto);
    [OperationContract]
    int Obtener_RVoto_O_Donacion_Total(string nombreCampaniaVoto);
    [OperationContract]
    ERVoto Obtener_RVoto_O_Donacion_Maxima(string nombreCampania);
    [OperationContract]
    string Obtener_RVoto_O_Organizacion(string nombreCampania);
    #endregion
    #region RUsuarioNetValle
    [OperationContract]
    ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(string sedeUnivalleNetValle, string codigoUsuarioNetValle);
    [OperationContract]
    ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Codigo_Pass_Rol(string Codigo, string Passs, string Rol);
    [OperationContract]
    ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Tarjeta(string tarjetaUsuarioNetValle);
    #endregion
    #region RUsuario
    [OperationContract]
    ERUsuario Obtener_RUsuario_O_Codigo(string codigoUsuario);
    [OperationContract]
    List<ERUsuario> Obtener_RUsuarios_O_Top_Creditos(string sedeUsuarioNetValle);
    [OperationContract]
    List<ERUsuario> Obtener_RUsuarios_O_Sede(string sedeUsuarioNetValle);
    [OperationContract]
    void Actualizar_RUsuario_A_Creditos_Sede(string codigoUsuarioNetValle);
    [OperationContract]
    void Actualizar_RUsuario_A_Creditos_Codigo(string Codigo, string Creditos);
    #endregion
    #region RContenedor
    [OperationContract]
    void Insertar_RContenedor_I(string codigoUsuario, byte maquinaContenedor, string gramosContenedor, DateTime fechaRegistroContenedor);
    [OperationContract]
    List<ERContenedor> Obtener_RContenedor_O_Codigo(string codigoUsuario);
    #endregion
    //COMPLEJAS
    #region EUsuarioCompleja
    [OperationContract]
    List<EUsuarioCompleja> Obtener_EUsuarioCompleja_O_Sede(string Sede);
    #endregion
    #region ECampaniaFinalizadaCompleja
    [OperationContract]
    ECampaniaFinalizadaCompleja Obtener_ECampaniaFinalizadaCompleja_O_Campania(string Campania, string Sede);
    #endregion

    //Añadidas
    [OperationContract]
    string Descifrado(string Texto, string Tipo);
    [OperationContract]
    string Cifrar_Cadena(string TextoACifrar);
    [OperationContract]
    Tuple<EEmpleado, EMensajeError> Obtener_Empleado_Id_Emp_SedeAcademica(string IdEmp, string Sede);
    [OperationContract]
    Tuple<byte[], EMensajeError> Obtener_EmpleadoFotografia(string IdEmp, string Sede);
}
