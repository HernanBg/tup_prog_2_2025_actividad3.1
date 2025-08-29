using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3._1.Models
{
    abstract public class Animal
    {
        protected List<string> acciones = new List<string>();
        abstract public List<string> CorreRutinas();
    }
}
