using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

/// <summary>
/// Descripción breve de ERVoto
/// </summary>
[DataContract]
public class ERVoto
{
    #region Atributos
    [DataMember]
    public string Codigo { get; set; }
    [DataMember]
    public string Campania { get; set; }
    [DataMember]
    public string Organizacion { get; set; }
    [DataMember]
    public DateTime Fecha { get; set; }
    [DataMember]
    public string Donacion { get; set; }
    [DataMember]
    public string Estado { get; set; }
    [DataMember]
    public DateTime FechaActualizacion { get; set; }
    #endregion
    public ERVoto()
    {
        Codigo = string.Empty;
        Campania = string.Empty;
        Organizacion = string.Empty;
        Fecha = DateTime.MinValue;
        Donacion = string.Empty;
        Estado = string.Empty;
        FechaActualizacion = DateTime.MinValue;
    }
}