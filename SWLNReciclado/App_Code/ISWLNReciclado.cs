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
    ERCampania Obtener_RCampania_O_Sede(string Sede);
    [OperationContract]
    List<ERCampania> Obtener_RCampania_O(string Sede);
    [OperationContract]
    ERCampania Obtener_RCampania_O_Sede_Campania(string Campania, string Sede);
    [OperationContract]
    void Insertar_RCampania_I(string nombre, string descripcion, DateTime fechaInicio, DateTime fechaFin, string sede);
    [OperationContract]
    void Actualizar_RCampania_A(string nombre, string descripcion, DateTime fechaInicio, DateTime fechaFin, string sede);
    [OperationContract]
    void Actualizar_RCampania_A_Estado(string Nombre);
    [OperationContract]
    void Actualizar_RCampania_A_Estado_Cancelado(string Nombre);
    #endregion
    #region RCampaniaOrganizacion
    [OperationContract]
    List<ERCampaniaOrganizacion> Obtener_RCampaniaOrganizacion_O_Campania(string Campania);
    [OperationContract]
    void Insertar_RCampaniaOrganizacion_I(string Campania, string Organizacion);
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
    List<ERImagen> Obtener_RImagen_O_Organizacion(string OrganizacionImagen, byte TipoImagen);
    #endregion
    #region RVoto
    [OperationContract]
    void Insertar_RVoto_I(string CodigoUsuario, string NombreCampania, string NombreOrganizacion, DateTime FechaRegistroVoto, string DonacionVoto, string EstadoVoto, DateTime FechaModificacionVoto);
    [OperationContract]
    void Actualizar_RVoto_A(string CodigoUsuario, string NombreCampania, string NombreOrganizacion, DateTime FechaRegistroVoto, string DonacionVoto, string EstadoVoto, DateTime FechaModificacionVoto);
    [OperationContract]
    ERVoto Obtener_RVoto_O_Codigo_Campania(string CodigoUsuario, string NombreCampania);
    [OperationContract]
    int Obtener_RVotos_O_Campania(string CampaniaVoto);
    [OperationContract]
    int Obtener_RVotos_O_Campania_Organizacion(string CampaniaCampaniaOrganizacion, string OrganizacionCampaniaOrganizacion);
    [OperationContract]
    int Obtener_RVoto_O_Donacion_Total(string CampaniaVoto);
    [OperationContract]
    ERVoto Obtener_RVoto_O_Donacion_Maxima(string NombreCampania);
    [OperationContract]
    string Obtener_RVoto_O_Organizacion(string NombreCampania);
    #endregion
    #region RUsuarioNetValle
    [OperationContract]
    ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(string Sede, string Codigo);
    [OperationContract]
    ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Codigo_Pass_Rol(string Codigo, string Passs, string Rol);
    [OperationContract]
    ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Tarjeta(string Tarjeta);
    #endregion
    #region RUsuario
    [OperationContract]
    ERUsuario Obtener_RUsuario_O_Codigo(string Codigo);
    [OperationContract]
    List<ERUsuario> Obtener_RUsuarios_O_Top_Creditos(string Sede);
    [OperationContract]
    List<ERUsuario> Obtener_RUsuarios_O_Sede(string Sede);
    [OperationContract]
    void Actualizar_RUsuario_A_Creditos_Sede(string Campania, string Codigo);
    [OperationContract]
    void Actualizar_RUsuario_A_Creditos_Codigo(string Codigo, string Creditos);
    #endregion
    #region RContenedor
    [OperationContract]
    void Insertar_RContenedor_I(string Codigo, byte IdMaquina, string Gramos, DateTime Fecha);
    [OperationContract]
    List<ERContenedor> Obtener_RContenedor_O_Codigo(string Codigo);
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
