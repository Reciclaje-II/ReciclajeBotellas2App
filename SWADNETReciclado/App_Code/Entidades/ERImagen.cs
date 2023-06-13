using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de ERImagen
/// </summary>
[DataContract]
public class ERImagen
{
    #region Atributos
    [DataMember]
    public string NombreImagen { get; set; }
    [DataMember]
    public byte TipoImagen { get; set; }
    [DataMember]
    public string OrganizacionImagen { get; set; }
    [DataMember]
    public DateTime FechaRegistroImagen { get; set; }
    [DataMember]
    public DateTime FechaModificacionImagen { get; set; }
    [DataMember]
    public string EstadoImagen { get; set; }
    

    #endregion

    public ERImagen()
    {
        NombreImagen = string.Empty;
        TipoImagen = 0;
        OrganizacionImagen = string.Empty;
        FechaRegistroImagen = DateTime.MinValue;
        FechaModificacionImagen = DateTime.MinValue;
        EstadoImagen = string.Empty;
    }
}