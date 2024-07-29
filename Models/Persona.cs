using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstrap.Models;

public class Persona : Ciudadano
{
    public string NombreP { get; set; }

    public override string Tipodocumento { get; set; }

    public override int Documento { get; set; }


    public Persona(string tipodocumento, int documento,string nombreP): base(tipodocumento,documento)
    {
        NombreP = nombreP;
    }

    public override void MostrarDocumento()
    {
        Console.WriteLine($"Documento: {Tipodocumento} - {Documento}");
    }
}


