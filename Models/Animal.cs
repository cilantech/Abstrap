using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstrap.Models;

public class Animal
{
    public int Id { get; set; }

    public string Nombre { get; set; }
    public string Especie { get; set; }

    public Animal(int id, string nombre, string especie)
    {
        Id = id;
        Nombre = nombre;
        Especie = especie;
    }

    public void saludar(){
        Console.WriteLine($"Hola, soy {Nombre}");    }

}
