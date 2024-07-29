using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstrap.Models
{
    public abstract class Ciudadano
    {
        public abstract string  Tipodocumento { get; set; }

        public abstract int Documento { get; set; }

        public  Ciudadano( string tipodocumento, int documento)
        {
            Tipodocumento = tipodocumento;
            Documento = documento;
        }

        public abstract void MostrarDocumento();
    }
}