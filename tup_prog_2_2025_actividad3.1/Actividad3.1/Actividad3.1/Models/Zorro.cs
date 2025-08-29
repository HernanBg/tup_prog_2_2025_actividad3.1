using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3._1.Models
{
    public class Zorro:Animal
    {
        Granja suGranja;

        static Random azar = new Random();

        public Zorro(Granja granja)
        {
            this.suGranja = granja;
        }

        public bool TieneHambre()
        {
            return azar.Next(0, 1) == 1;
        }

        public Ave EligeAve()
        {
            Ave elegida = null;

            if (suGranja != null)
            {
                List<Ave> presas = suGranja.VerAvesVivas();

                if (presas != null && presas.Count > 0)
                {
                    int idx = azar.Next(0, presas.Count);
                    elegida = presas[idx];
                }

                if (elegida != null)
                    acciones.Add("El zorro ha elegido una presa.");
                else
                    acciones.Add("El zorro no ha encontrado presas.");

            }
            return elegida;
        }

        public void Come(Ave ave)
        {
            if (ave != null && ave.TieneHambre())
            {
                ave.EstaViva = false;
                acciones.Add($"El zorro ha comido a {ave.GetType().Name}.");
            }
            else
            {
                acciones.Add("El zorro no ha podido comer, la presa no está disponible o no tiene hambre.");
            }
        }

        public override List<string> CorreRutinas()
        {
            Ave ave = EligeAve();
            if (ave != null)
            {
                Come(ave);
            }
            return acciones;
        }
    }
}
