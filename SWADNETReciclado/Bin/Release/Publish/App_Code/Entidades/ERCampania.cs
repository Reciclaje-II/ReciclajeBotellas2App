using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;


/// <summary>
/// Descripción breve de ERCampania
/// </summary>
[DataContract]
public class ERCampania
{
    #region Atributos
    [DataMember]
    public string Nombre { get; set; }
    [DataMember]
    public string Descripcion { get; set; }
    [DataMember]
    public DateTime FechaInicio { get; set; }
    [DataMember]
    public DateTime FechaFin { get; set; }
    [DataMember]
    public string Estado { get; set; }
    [DataMember]
    public string Sede { get; set; }
    [DataMember]
    public DateTime FechaCreacion { get; set; }
    [DataMember]
    public DateTime FechaActualizacion { get; set; }
    #endregion

    public ERCampania()
    {
        Nombre = string.Empty;
        Descripcion = string.Empty;
        FechaInicio = DateTime.MinValue;
        FechaFin = DateTime.MinValue;
        Estado = string.Empty;
        Sede = string.Empty;
        FechaCreacion = DateTime.MinValue;
        FechaActualizacion = DateTime.MinValue;
    }



}