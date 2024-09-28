using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04GestionDeAnimales
{
    internal class GestorAnimales
    {
        private ArrayList listaAnimales = new ArrayList();

        public bool añadirAnimal(Animal animalNuevo)
        {
            if (buscarAnimal(animalNuevo.Nombre) == null)
            {
                listaAnimales.Add(animalNuevo);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void mostrarInformacion()
        {
            foreach (Animal animal in listaAnimales)
            {
                Console.WriteLine(animal.informacion());
            }
        }
        public Animal buscarAnimal(string nombre)
        {
            Animal animalBuscado = null;
            foreach (Animal animal in listaAnimales)
            {
                if (animal.Nombre == nombre)
                {
                    animalBuscado = animal;
                }
            }
            
            return animalBuscado;
        }
        public bool eliminarAnimal(string nombre)
        {
            if (buscarAnimal(nombre) != null)
            {
                listaAnimales.Remove(buscarAnimal(nombre));
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
