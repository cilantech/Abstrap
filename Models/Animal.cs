using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstrap.Models;

public class Animal
{
    protected int Id { get; set; }

    protected string Nombre { get; set; }
    protected string Especie { get; set; }

    public Animal(int id, string nombre, string especie)
    {
        Id = id;
        Nombre = nombre;
        Especie = especie;
    }

    protected void saludar(){
        Console.WriteLine($"Hola, soy {Nombre}");    }

}
