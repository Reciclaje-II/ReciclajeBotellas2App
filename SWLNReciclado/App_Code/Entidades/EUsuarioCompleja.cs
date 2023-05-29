﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EUsuarioCompleja
/// </summary>
[DataContract]
public class EUsuarioCompleja
{
    [DataMember]
    public string NombreCompleto { get; set; }
    [DataMember]
    public int Creditos { get; set; }
    public EUsuarioCompleja()
    {
        NombreCompleto = string.Empty;
        Creditos = 0;
    }
}