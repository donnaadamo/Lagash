using System;
using System.Collections.Generic;

namespace ejercicio_2_POO_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            FIFO<int> listanueva = new FIFO<int>();

            bool menu = true;
            int operacion;
            int item;

            while(menu){
                Console.WriteLine("Ingresar operación: 1. Add item 2. Get item 3. Delete item 4. Show the number of item 5. Show min and max item 6. Find an item 7. Print all item 8. Exit ");
                operacion = int.Parse(Console.ReadLine());
                switch (operacion){
                    case 1:
                        Console.WriteLine("Ingrese elemento a agregar: ");
                        item = int.Parse(Console.ReadLine());
                        listanueva.Agregar(item);
                        Console.WriteLine("Elemento agregado.");
                        Console.WriteLine("Aprete cualquier botón para continuar.");
                        break;
                    case 2:
                        Console.WriteLine("Primer elemento: " + listanueva.Obtener());
                        Console.WriteLine("Aprete cualquier botón para continuar.");
                        break; 
                    case 3:
                        Console.WriteLine("Ingrese elemento a eliminar: ");
                        item = int.Parse(Console.ReadLine());
                        listanueva.Eliminar(item);
                        Console.WriteLine("Elemento eliminado.");
                        Console.WriteLine("Apretar cualquier botón para continuar.");
                        break;
                    case 4:
                        Console.WriteLine("Ingrese elemento para mostrar su indice: ");
                        item = int.Parse(Console.ReadLine());
                        Console.WriteLine("Indice del elemento: " + listanueva.Mostrar(item));
                        Console.WriteLine("Apretar cualquier botón para continuar.");
                        break;
                    case 5:
                        listanueva.MinMax();
                        Console.WriteLine("Apretar cualquier botón para continuar.");
                        break;
                    case 6:
                        Console.WriteLine("Ingrese elemento para verificar si existe en la lista: ");
                        item = int.Parse(Console.ReadLine());
                        Console.WriteLine(listanueva.Encontrar(item));
                        Console.WriteLine("Apretar cualquier botón para continuar.");
                        break;
                    case 7:
                        Console.WriteLine("Lista de elementos: ");
                        listanueva.Imprimir();
                        Console.WriteLine("Apretar cualquier botón para continuar.");
                        break;
                    case 8:
                    menu = false;
                    break;
                }
            }
        }
    }
}
