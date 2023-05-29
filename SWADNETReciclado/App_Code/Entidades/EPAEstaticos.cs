using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

/// <summary>
/// Summary Variables estaticas de Procedimientos Almacenados
/// </summary>
//public enum Estado { CANCELADA, FINALIZADA, ACTIVA, VALIDO }
public class EPAEstaticos
{
    static public string EstadoActiva = "AC";
    static public string EstadoCancelada = "CA";
    static public string EstadoFinalizada = "FI";
    static public string EstadoValido = "VA";
    static public DateTime FechaModificacion = DateTime.Now;
    static public DateTime FechaRegistro = DateTime.Now;
    static public double DonacionVoto = 0;

    public EPAEstaticos()
    {

    }
}