using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3._1.Models
{
    public  class Perro : Animal
    {
        public Perro()
        {
        }

        public string Ladra()
        {
            return "Guau Guau";
        }

        public override List<string> CorreRutinas()
        {
            string ladrido = Ladra();
            return new List<string> { ladrido };
        }
    }
}
