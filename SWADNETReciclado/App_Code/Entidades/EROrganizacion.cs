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
    [Required(ErrorMessage ="Campo obligatorio")]
    [RegularExpression("[A-Za-z]*", ErrorMessage ="Solo se permite letras")]
    public string Nombre { get; set; }
    [DataMember]
    [Required(ErrorMessage = "Campo obligatorio")]
    [RegularExpression("[A-Za-z]*", ErrorMessage = "Solo se permite letras")]
    public string Descripcion { get; set; }
    [DataMember]
    public string Estado { get; set; }
    [DataMember]
    [Required(ErrorMessage = "Campo obligatorio")]
    public DateTime FechaCreacion { get; set; }
    [DataMember]
    [Required(ErrorMessage = "Campo obligatorio")]
    public DateTime FechaActualizacion { get; set; }
    #endregion

    public EROrganizacion()
    {
        Nombre = string.Empty;
        Descripcion = string.Empty;
        Estado = string.Empty;
        FechaCreacion = DateTime.MinValue;
        FechaActualizacion = DateTime.MinValue;
    }

}