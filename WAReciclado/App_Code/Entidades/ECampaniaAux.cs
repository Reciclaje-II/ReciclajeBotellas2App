using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ECampaniaAux
/// </summary>
public class ECampaniaAux
{
    public string NombreOrganizacion { get; set; }

    public ECampaniaAux(string organizacion)
    {
        NombreOrganizacion = organizacion;
    }
}