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

    public List<ERImagen> Obtener_RImagen_O_Organizacion(string organizacionImagen, byte tipoImagen)
    {
        ERImagen eRImagen;
        List<ERImagen> lstERImagen = new List<ERImagen>();
        DTORImagen dtoRImagen = adRImagen.Obtener_RImagen_O_Organizacion(organizacionImagen, tipoImagen);
        foreach (DTORImagen.RImagenRow drRImagen in dtoRImagen.RImagen.Rows)
        {
            eRImagen = new ERImagen();
            eRImagen.NombreImagen = drRImagen.NombreImagen.TrimEnd();
            eRImagen.OrganizacionImagen = drRImagen.OrganizacionImagen.TrimEnd();
            eRImagen.TipoImagen = drRImagen.TipoImagen;
            eRImagen.FechaRegistroImagen= drRImagen.FechaRegistroImagen;
            eRImagen.FechaModificacionImagen = drRImagen.FechaModificacionImagen;
            eRImagen.EstadoImagen = drRImagen.EstadoImagen;
            lstERImagen.Add(eRImagen);
        }
        return lstERImagen;
    }


    #endregion
}