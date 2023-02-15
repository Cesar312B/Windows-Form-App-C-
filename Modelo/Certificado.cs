using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nativo.Modelo
{
    public class Certificado
    {
        public int id { get; set; }
        public string PACI_COD { get; set; }

        public string FECHA { get; set; }

        public string ENFERMEDAD { get; set; }
        public string DESCRIPCION { get; set; }
        public string RECOMENDACION { get; set; }

    }
}
