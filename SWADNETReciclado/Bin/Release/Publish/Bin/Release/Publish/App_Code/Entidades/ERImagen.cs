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
    public string Nombre { get; set; }
    [DataMember]
    public byte Tipo { get; set; }
    [DataMember]
    public string Organizacion { get; set; }

    #endregion

    public ERImagen()
    {
        Nombre = string.Empty;
        Tipo = 0;
        Organizacion = string.Empty;
    }
}