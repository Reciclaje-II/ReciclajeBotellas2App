using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

/// <summary>
/// Descripción breve de ERUsuarioNetvalle
/// </summary>
[DataContract]
public class ERUsuarioNetvalle
{
    #region Atributos
    [DataMember]
    public string Codigo { get; set; }
    [DataMember]
    public string Nombres { get; set; }
    [DataMember]
    public string Apellidos { get; set; }
    [DataMember]
    public string Cargo { get; set; }
    [DataMember]
    public string Tarjeta { get; set; }
    [DataMember]
    public string Sede { get; set; }
    #endregion
    public ERUsuarioNetvalle()
    {
        Codigo = string.Empty;
        Nombres = string.Empty;
        Apellidos = string.Empty;
        Cargo = string.Empty;
        Tarjeta = string.Empty;
        Sede = string.Empty;
    }
}