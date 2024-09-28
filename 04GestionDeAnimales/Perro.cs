using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04GestionDeAnimales
{
    internal class Perro : Animal
    {
        Boolean pastor;
        public Perro(String Nombre, Edad Edad, bool pastor)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.pastor = pastor;
        }
        public override String emitirSonido()
        {
            return "Guau";
        }
        public override string informacion()
        {
            if (pastor)
            {
                return "Tipo: perro" + base.informacion() + ", pastor: Si";
            }else
            {
                return "Tipo: perro" + base.informacion() + ", pastor: No";
            }
        }
        

    }
}
