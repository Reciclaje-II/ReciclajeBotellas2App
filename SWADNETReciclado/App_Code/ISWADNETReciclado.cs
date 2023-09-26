using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISWADNETReciclado" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface ISWADNETReciclado
{
    #region Tabla : RVoto
    [OperationContract]
    void Insertar_RVoto_I(ERVoto eRVoto);
    [OperationContract]
    void Actualizar_RVoto_A(ERVoto eRVoto);
    [OperationContract]
    ERVoto Obtener_RVoto_O_Codigo_Campania(string codigoUsuario, string nombreCampania);
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
    #region Tabla : RUsuarioNetvalle
    [OperationContract]
    ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(string sedeUsuarioNetvalle, string codigoUsuarioNetvalle);
    [OperationContract]
    ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Codigo(string codigoUsuarioNetvalle);
    [OperationContract]
    ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Tarjeta(string tarjetaUsuarioNetvalle);
    [OperationContract]
    void Insertar_RUsuarioNetvalle_y_RUsuario(string roleUsuario,string codigoUsuarioNetvalle, string nombresUsuarioNetvalle,string apellidosUsuarioNetvalle, string cargoUsuarioNetvalle, string tarjetaUsuarioNetvalle, string sedeUsuarioNetvalle);
    #endregion
    #region Tabla : RCampania
    [OperationContract]
    ERCampania Obtener_RCampania_O_Sede(string sedeCampania);
    [OperationContract]
    List<ERCampania> Obtener_RCampania_O();
    [OperationContract]
    void Insertar_RCampania_I(ERCampania eRCampania);
    [OperationContract]
    void Actualizar_RCampania_A(ERCampania eRCampania);
    [OperationContract]
    void Actualizar_RCampania_A_Estado(string nombreCampania);
    [OperationContract]
    void Actualizar_RCampania_A_Estado_Cancelado(string nombreCampania);
    #endregion
    #region Tabla : RCampaniaOrganizacion
    [OperationContract]
    void Insertar_RCampaniaOrganizacion_I(ERCampaniaOrganizacion eRCampaniaOrganizacion);
    [OperationContract]
    List<ERCampaniaOrganizacion> Obtener_RCampaniaOrganizacion_O_Campania(string campaniaCampaniaOrganizacion);
    #endregion
    #region Tabla : ROrganizacion
    [OperationContract]
    void Insertar_ROrganizacion_I(EROrganizacion eROrganizacion);
    [OperationContract]
    void Actualizar_ROrganizacion_A(EROrganizacion eROrganizacion);
    [OperationContract]
    EROrganizacion Obtener_ROrganizacion_O_Nombre(string nombreOrganizacion);
    [OperationContract]
    List<EROrganizacion> Obtener_ROrganizaciones_O();
    [OperationContract]
    void Eliminar_ROrganizacion_E_Nombre(string nombreOrganizacion);
    #endregion
    #region Tabla : RImagen
    [OperationContract]
    void Insertar_RImagen_I(ERImagen eRImagen);
    [OperationContract]
    List<ERImagen> Obtener_RImagen_O_Organizacion(string organizacionImagen, byte tipoImagen);
    #endregion
    #region Tabla: RUsuario
    [OperationContract]
    ERUsuario Obtener_RUsuario_O_Codigo(string codigoUsuario);
    [OperationContract]
    List<ERUsuario> Obtener_RUsuarios_O_Top_Creditos(string sedeUsuarioNetvalle);
    [OperationContract]
    List<ERUsuario> Obtener_RUsuarios_O_Sede(string sedeUsuarioNetvalle);
    [OperationContract]
    void Actualizar_RUsuario_A_Creditos_Sede(string codigoUsuarioNetvalle);
    [OperationContract]
    void Actualizar_RUsuario_A_Creditos_Codigo(string codigoUsuario, string creditoUsuario);
    #endregion
    #region Tabla: RContenedor
    [OperationContract]
    void Insertar_RContenedor_I(ERContenedor eRContenedor);
    [OperationContract]
    List<ERContenedor> Obtener_RContenedor_O_Codigo(string codigoUsuario);
    #endregion
}
