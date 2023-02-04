using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nativo.Modelo
{
    public class Paciente
    {
        public string PACI_COD { get; set; }
        public string PACI_NOM { get; set; }

        public string PACI_NACI { get; set; }
      
        public byte[] PACI_FOTO { get; set; }

        public byte[] PACI_FOTO_ORTO { get; set; }
        public byte[] PACI_FOTO2 { get; set; }
        public string PACI_SEXO { get; set; }

        public string PACI_DIR { get; set; }

        public string PACI_LOCAL { get; set; }

        public string PACI_TELEF { get; set; }
        public string PACI_ENT { get; set; }

        public string PACI_PROF { get; set; }

        
        public string PACI_COMEN { get; set; }
        public string PACI_HIST { get; set; }

        public string PACI_REPRE { get; set; }

        public byte[] PACI_FOTO_ORTO2 { get; set; }

        public string DNI { get; set; }

    }
}
