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
    public string OrganizacionCampania { get; set; }
    [DataMember]
    public int RecaudacionCampania { get; set; }
    [DataMember]
    public string MejorDonadorCampania { get; set; }
    [DataMember]
    public int DonacionCampania { get; set; }
    public ECampaniaFinalizadaCompleja()
    {
        OrganizacionCampania = string.Empty;
        RecaudacionCampania = 0;
        MejorDonadorCampania = string.Empty;
        DonacionCampania = 0;
    }

}