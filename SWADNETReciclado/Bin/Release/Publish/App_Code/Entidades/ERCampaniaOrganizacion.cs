using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de ERCampaniaOrganizacion
/// </summary>
/// [DataContract]
public class ERCampaniaOrganizacion
{
    #region Atributos
    [DataMember]
    public string Campania { get; set; }
    [DataMember]
    public string Organizacion { get; set; }
    [DataMember]
    public DateTime FechaCreacion { get; set; }
    #endregion
    public ERCampaniaOrganizacion()
    {
        Campania = string.Empty;
        Organizacion = string.Empty;
        FechaCreacion = DateTime.MinValue;
    }
}