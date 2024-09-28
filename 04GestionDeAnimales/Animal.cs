using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04GestionDeAnimales
{
    abstract internal class Animal
    {
        abstract public String Nombre { get; set; }
        abstract public Edad Edad { get; set; }

        abstract public void emitirSonido();

    }
}
