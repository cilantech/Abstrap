using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstrap.Models;

public class Perro : Animal
{



    //estas son las propeidades del padre
    public override int Id { get; set; }

    public override string Nombre { get; set; }
    public override string Especie { get; set; }

// propiedades mias hijo

    public bool EsCriollo { get; set; }

    public Perro(int id, string nombre, string especie, bool esCriollo) : base(id, nombre, especie)
    {
        EsCriollo = esCriollo;
    }

    public string GetNombre()
    {
        return Nombre;
    }

    public override void saludar()
    {
        Console.WriteLine($"Hola me llamo {Nombre}");
    }

    public virtual void comer(){
        Console.WriteLine($"{Nombre} esta comiendo");
    }

}
