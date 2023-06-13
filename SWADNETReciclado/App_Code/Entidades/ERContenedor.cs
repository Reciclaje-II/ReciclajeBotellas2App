using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de ERContenedor
/// </summary>
[DataContract]
public class ERContenedor
{

    #region Atributos
    [DataMember]
    public string CodigoUsuario { get; set; }
    [DataMember]
    public byte IdMaquinaContenedor { get; set; }
    [DataMember]
    public string GramosContenedor { get; set; }
    [DataMember]
    public DateTime FechaRegistroContenedor { get; set; }
    [DataMember]
    public char EstadoContenedor { get; set; }
    [DataMember]
    public DateTime FechaModificacionContenedor { get; set; }
    #endregion
    public ERContenedor()
    {
        CodigoUsuario = string.Empty;
        IdMaquinaContenedor = byte.MinValue;
        GramosContenedor = string.Empty;
        FechaRegistroContenedor = DateTime.MinValue;
        
    }
}