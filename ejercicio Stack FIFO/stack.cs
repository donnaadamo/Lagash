using System;
using System.Collections.Generic;

namespace ejercicio_2_POO_Max
{
    class FIFO<T>{
        List <T> lista = new List<T>();

        public void Agregar(T item){
            lista.Add(item);
        }

        public T Obtener(){
            T num = lista[0];
            lista.RemoveAt(0);
            return num;
        }

        public void Eliminar(T item){
            lista.Remove(item);
        }

        public int Mostrar(T contenido){
            return lista.FindIndex(x => x.Equals(contenido));
        }

        public void MinMax(){
            int max = lista.Count-1;
            Console.WriteLine("El minimo es: " + lista[0] + "\nel maximo es: " + max);
        }

        public bool Encontrar(T contenido){
            T itemlista = lista.Find(x => x.Equals(contenido));
            if (itemlista.Equals(contenido)){
                return true;
            }else{
                return false;
            }
        }

        public void Imprimir(){
            foreach (T contenido in lista){
                Console.WriteLine(contenido);
            }
        }
    }
}