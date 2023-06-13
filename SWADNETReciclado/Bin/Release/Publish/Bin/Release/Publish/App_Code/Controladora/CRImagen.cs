using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CRImagen
/// </summary>
public class CRImagen
{
    #region Metodos privados
    private ADRImagen adRImagen;
    #endregion
    #region Metodos publicos
    public CRImagen()
    {
        adRImagen = new ADRImagen();
    }

    public void Insertar_RImagen_I(ERImagen eRImagen)
    {
        adRImagen.Insertar_RImagen_I(eRImagen);
    }

    public List<ERImagen> Obtener_RImagen_O_Organizacion(string Organizacion, byte Tipo)
    {
        ERImagen eRImagen;
        List<ERImagen> lstERImagen = new List<ERImagen>();
        DTORImagen dtoRImagen = adRImagen.Obtener_RImagen_O_Organizacion(Organizacion, Tipo);
        foreach (DTORImagen.RImagenRow drRImagen in dtoRImagen.RImagen.Rows)
        {
            eRImagen = new ERImagen();
            eRImagen.Nombre = drRImagen.Nombre.TrimEnd();
            eRImagen.Organizacion = drRImagen.Organizacion.TrimEnd();
            eRImagen.Tipo = drRImagen.Tipo;
            lstERImagen.Add(eRImagen);
        }
        return lstERImagen;
    }


    #endregion
}