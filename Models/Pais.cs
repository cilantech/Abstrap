using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstrap.Models;

    public static class Pais
    {
        public static string Nombre { get; set; }

        public static int Poblacion { get; set; } 

        public static int Area {get; set;}

        static Pais(){

            Nombre= "iran";
            Poblacion= 88000000;
            Area = 1648000;
        }


        public static void densidadPoblacional(){

            Console.WriteLine($"El pais {Nombre} tiene una densidad de poblacion de {Poblacion/Area} personas por KM2");

        }
    }
