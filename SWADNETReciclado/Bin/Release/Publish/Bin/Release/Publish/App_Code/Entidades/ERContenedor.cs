using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de ERContenedor
/// </summary>
public class ERContenedor
{

    #region Atributos
    [DataMember]
    public string Codigo { get; set; }
    [DataMember]
    public byte IdMaquina { get; set; }
    [DataMember]
    public string Gramos { get; set; }
    [DataMember]
    public DateTime Fecha { get; set; }
    #endregion
    public ERContenedor()
    {
        Codigo = string.Empty;
        IdMaquina = byte.MinValue;
        Gramos = string.Empty;
        Fecha = DateTime.MinValue;
    }
}