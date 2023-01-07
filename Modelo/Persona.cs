using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nativo.Modelo
{
    public class Persona
    {
        public int id { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Telefono { get; set; }

        public byte[] Image { get; set; }

     
    }
}
