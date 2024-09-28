using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04GestionDeAnimales
{
    internal class Vaca :Animal
    {
        int produccionDiaria;
        public Vaca(string Nombre, Edad Edad, int produccionDiaria)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.produccionDiaria = produccionDiaria;
        }
        public override string emitirSonido()
        {
            return "Muuuu";
        }
        public override string informacion()
        {
            return "Tipo: vaca" + base.informacion() + ", produccion diaria de leche: " + produccionDiaria + "L";
        }
    }
}
