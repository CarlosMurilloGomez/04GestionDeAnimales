using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _04GestionDeAnimales
{
    internal class MenuGestorAnimales
    {
        private GestorAnimales gestor = new GestorAnimales();
        public void iniciar()
        {
            int opcion = 0;
            while (opcion != 5)
            {
                Console.WriteLine("********************************************");
                Console.WriteLine("Selecciona una de las siguientes opciones: ");
                Console.WriteLine("1. Añadir animal a la lista");
                Console.WriteLine("2. Mostrar informacion de los animales almacenados");
                Console.WriteLine("3. Buscar animal por nombre");
                Console.WriteLine("4. Eliminar animal de la lista");
                Console.WriteLine("5. Salir");
                Console.WriteLine("********************************************");
                bool valido;
                do
                {
                    valido = int.TryParse(Console.ReadLine(), out opcion);
                    if (!valido) Console.WriteLine("Opcion no válida");
                }while (!valido);
                switch (opcion)
                {
                    case 1: if (!gestor.añadirAnimal(pedirDatos())) Console.WriteLine("Ya existe un animal con ese nombre"); ; break;
                    case 2: gestor.mostrarInformacion(); break;
                    case 3:
                        {
                            Console.WriteLine("Escribe el nombre del animal:");
                            string nombre = Console.ReadLine();
                            if (gestor.buscarAnimal(nombre) == null) Console.WriteLine("No existe ningun animal con ese nombre");
                            else
                            {
                                Console.WriteLine(gestor.buscarAnimal(nombre).informacion());
                            }
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Escribe el nombre del animal:");
                            string nombre = Console.ReadLine();
                            if (!gestor.eliminarAnimal(nombre)) Console.WriteLine("No existe ningun animal con ese nombre");
                        } break;
                    case 5: Console.WriteLine("Saliendo..."); break;
                    default: Console.WriteLine("Opcion no valida"); break;
                }
            }
        }
        private Animal pedirDatos()
        {
            Console.WriteLine("Selecciona el tipo de animal que vas a añadir: ");
            Console.WriteLine("1. Perro");
            Console.WriteLine("2. Caballo");
            Console.WriteLine("3. Vaca");
            int tipo = 0;
            bool valido;
            do
            {
                valido = int.TryParse(Console.ReadLine(), out tipo);
                if (tipo != 1 && tipo != 2 && tipo != 3) valido = false;
                if (!valido) Console.WriteLine("Tipo no válido");
            } while (!valido);
            Console.WriteLine("Escribe el nombre del animal que vas a añadir: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Selecciona la edad del animal que vas a añadir: ");
            Console.WriteLine("1. Joven");
            Console.WriteLine("2. Adulto");
            Console.WriteLine("3. Viejo");
            Edad edad;
            int opcionEdad = 0;
            do
            {
                valido = int.TryParse(Console.ReadLine(), out opcionEdad);
                if (opcionEdad != 1 && opcionEdad != 2 && opcionEdad != 3) valido = false;
                if (!valido) Console.WriteLine("Edad no válida");
            } while (!valido);
            switch (opcionEdad)
            {
                case 1: edad = Edad.joven; break;
                case 2: edad = Edad.adulto; break;
                default: edad = Edad.viejo; break;
            }
            switch (tipo)
            {
                case 1:
                    {
                        bool pastor;
                        Console.WriteLine("¿Es un perro pastor?");
                        Console.WriteLine("1. Si");
                        Console.WriteLine("2. No");
                        int opcionPastor = 0;
                        do
                        {
                            valido = int.TryParse(Console.ReadLine(), out opcionPastor);
                            if (opcionPastor != 1 && opcionPastor != 2) valido = false;
                            if (!valido) Console.WriteLine("Respuesta no válida");
                        } while (!valido);
                        if (opcionPastor == 1) pastor = true;
                        else pastor = false;
                        return new Perro(nombre, edad, pastor);
                    }
                    
                case 2:
                    {
                        Console.WriteLine("Introduce su velocidad máxima(km/h): ");
                        int velocidadMax;
                        do
                        {
                            valido = int.TryParse(Console.ReadLine(), out velocidadMax);
                            if (!valido) Console.WriteLine("Velocidad no válida");
                        } while (!valido);

                        return new Caballo(nombre, edad, velocidadMax);
                    }
                    
                default: {
                        Console.WriteLine("Introduce su produccion diaria de leche(L): ");
                        int produccion;
                        do
                        {
                            valido = int.TryParse(Console.ReadLine(), out produccion);
                            if (!valido) Console.WriteLine("Velocidad no válida");
                        } while (!valido);

                        return new Vaca(nombre, edad, produccion);
                    } 
            }

        }
    }
}
