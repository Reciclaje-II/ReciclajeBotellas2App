using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de ERCampaniaOrganizacion
/// </summary>
[DataContract]
public class ERCampaniaOrganizacion
{
    #region Atributos
    [DataMember]
    public string CampaniaCampaniaOrganizacion { get; set; }
    [DataMember]
    public string OrganizacionCampaniaOrganizacion { get; set; }
    [DataMember]
    public DateTime FechaRegistroCampaniaOrganizacion { get; set; }
    [DataMember]
    public string IdCampaniaOrganizacion { get; set; }
    [DataMember]
    public string EstadoCampaniaOrganizacion { get; set; }
    [DataMember]
    public DateTime FechaModificacionCampaniaOrganizacion { get; set; }
    #endregion
    public ERCampaniaOrganizacion()
    {
        CampaniaCampaniaOrganizacion = string.Empty;
        OrganizacionCampaniaOrganizacion = string.Empty;
        FechaRegistroCampaniaOrganizacion = DateTime.MinValue;
        IdCampaniaOrganizacion = string.Empty;
        EstadoCampaniaOrganizacion = string.Empty;
        FechaModificacionCampaniaOrganizacion = DateTime.MinValue;
    }
}