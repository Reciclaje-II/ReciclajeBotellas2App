using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

/// <summary>
/// Descripción breve de ERUsuario
/// </summary>
[DataContract]
public class ERUsuario
{
    #region Atributos
    [DataMember]
    public string Codigo { get; set; }
    [DataMember]
    public string Creditos { get; set; }
    [DataMember]
    public string Rol { get; set; }
    #endregion

    public ERUsuario()
    {
        Codigo = string.Empty;
        Creditos = string.Empty;
        Rol = string.Empty;
    }
}