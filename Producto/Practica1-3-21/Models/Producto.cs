using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1_3_21.Models
{
    public class Producto
    {
        public int codigo { get; set; }
        
        public string nombre { get; set; }

        public double precio { get; set; }
        public string moneda { get; set; }

        public string foto { get; set; }
    }
}
