using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04GestionDeAnimales
{
    internal class Caballo : Animal
    {
        int velocidadMax;
        public Caballo(string Nombre, Edad Edad, int velocidadMax)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.velocidadMax = velocidadMax;
        }
        public override string emitirSonido()
        {
            return "Hiiiii";
        }
        public override string informacion()
        {
            return "Tipo: caballo" + base.informacion() + ", velocidad máx.: " + velocidadMax + "km/h";
        }
    }
}
