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
    ERVoto Obtener_RVoto_O_Codigo_Campania(string CodigoUsuario, string NombreCampania);
    [OperationContract]
    int Obtener_RVotos_O_Campania(string NombreCampania);
    [OperationContract]
    int Obtener_RVotos_O_Campania_Organizacion(string NombreCampania, string Organizacion);
    [OperationContract]
    int Obtener_RVoto_O_Donacion_Total(string NombreCampania);
    [OperationContract]
    ERVoto Obtener_RVoto_O_Donacion_Maxima(string NombreCampania);
    [OperationContract]
    string Obtener_RVoto_O_Organizacion(string NombreCampania);
    #endregion
    #region Tabla : RUsuarioNetvalle
    [OperationContract]
    ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Top_Sede_Codigo(string Sede, string Codigo);
    [OperationContract]
    ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Codigo(string Codigo);
    [OperationContract]
    ERUsuarioNetvalle Obtener_RUsuarioNetvalle_O_Tarjeta(string Tarjeta);
    #endregion
    #region Tabla : RCampania
    [OperationContract]
    ERCampania Obtener_RCampania_O_Sede(string Sede);
    [OperationContract]
    List<ERCampania> Obtener_RCampania_O();
    [OperationContract]
    void Insertar_RCampania_I(ERCampania eRCampania);
    [OperationContract]
    void Actualizar_RCampania_A(ERCampania eRCampania);
    [OperationContract]
    void Actualizar_RCampania_A_Estado(string Nombre);
    [OperationContract]
    void Actualizar_RCampania_A_Estado_Cancelado(string Nombre);
    #endregion
    #region Tabla : RCampaniaOrganizacion
    [OperationContract]
    void Insertar_RCampaniaOrganizacion_I(ERCampaniaOrganizacion eRCampaniaOrganizacion);
    [OperationContract]
    List<ERCampaniaOrganizacion> Obtener_RCampaniaOrganizacion_O_Campania(string Campania);
    #endregion
    #region Tabla : ROrganizacion
    [OperationContract]
    void Insertar_ROrganizacion_I(EROrganizacion eROrganizacion);
    [OperationContract]
    void Actualizar_ROrganizacion_A(EROrganizacion eROrganizacion);
    [OperationContract]
    EROrganizacion Obtener_ROrganizacion_O_Nombre(string Nombre);
    [OperationContract]
    List<EROrganizacion> Obtener_ROrganizaciones_O();
    [OperationContract]
    void Eliminar_ROrganizacion_E_Nombre(string Nombre);
    #endregion
    #region Tabla : RImagen
    [OperationContract]
    void Insertar_RImagen_I(ERImagen eRImagen);
    [OperationContract]
    List<ERImagen> Obtener_RImagen_O_Organizacion(string OrganizacionImagen, byte TipoImagen);
    #endregion
    #region Tabla: RUsuario
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
    #region Tabla: RContenedor
    [OperationContract]
    void Insertar_RContenedor_I(ERContenedor eRContenedor);
    [OperationContract]
    List<ERContenedor> Obtener_RContenedor_O_Codigo(string Codigo);
    #endregion
}
