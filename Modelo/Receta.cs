﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nativo.Modelo
{
    public class Receta
    {
        public int id { get; set; }
        public string PACI_COD { get; set; }

        public string MEDICAMENTO { get; set; }

        public string CANTIDADA { get; set; }


        public DateTime FECHA { get; set; }

        public string INSTRUCCIONES { get; set; }
    }
}
