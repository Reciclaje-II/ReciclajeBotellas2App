using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de ECampaniaFinalizadaCompleja
/// </summary>
[DataContract]
public class ECampaniaFinalizadaCompleja
{
    [DataMember]
    public string Organizacion { get; set; }
    [DataMember]
    public int Recaudacion { get; set; }
    [DataMember]
    public string MejorDonador { get; set; }
    [DataMember]
    public int Donacion { get; set; }
    public ECampaniaFinalizadaCompleja()
    {
        Organizacion = string.Empty;
        Recaudacion = 0;
        MejorDonador = string.Empty;
        Donacion = 0;
    }
}