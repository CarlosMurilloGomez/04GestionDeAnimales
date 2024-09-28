﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04GestionDeAnimales
{
    abstract internal class Animal
    {
        public String Nombre { get; set; }
        public Edad Edad { get; set; }

        abstract public String emitirSonido();

        public virtual String informacion()
        {
            return ", nombre: " + Nombre + ", edad: " + Edad + ", sonido: " + emitirSonido();
        }
    }
}
