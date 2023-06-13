using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;


/// <summary>
/// Descripción breve de EROrganizacion
/// </summary>
[DataContract]
public class EROrganizacion
{
    #region Atributos
    [DataMember]
    [Required(ErrorMessage = "Campo obligatorio")]
    [RegularExpression("[A-Za-z]*", ErrorMessage = "Solo se permite letras")]
    public string NombreOrganizacion { get; set; }
    [DataMember]
    [Required(ErrorMessage = "Campo obligatorio")]
    [RegularExpression("[A-Za-z]*", ErrorMessage = "Solo se permite letras")]
    public string DescripcionOrganizacion { get; set; }
    [DataMember]
    public string EstadoOrganizacion { get; set; }
    [DataMember]
    [Required(ErrorMessage = "Campo obligatorio")]
    public DateTime FechaRegistroOrganizacion { get; set; }
    [DataMember]
    [Required(ErrorMessage = "Campo obligatorio")]
    public DateTime FechaModificacionOrganizacion { get; set; }
    #endregion

    public EROrganizacion()
    {
        NombreOrganizacion = string.Empty;
        DescripcionOrganizacion = string.Empty;
        EstadoOrganizacion = string.Empty;
        FechaRegistroOrganizacion = DateTime.MinValue;
        FechaModificacionOrganizacion = DateTime.MinValue;
    }

}