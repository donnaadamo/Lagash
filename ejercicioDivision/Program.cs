using System;

namespace ejercicioDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int cociente = 0;
            int resto = 0;
            int x = 20;
            int y = 4;
            
            if (x != 0 && y != 0){
                Console.WriteLine("Cociente: " + Dividir(x, y) + " resto: " + resto);
            }else{
                Console.WriteLine("Error: Uno o ambos parametros son 0");
            }

            int Dividir(int dividendo, int divisor){
                resto = dividendo - divisor;
                cociente ++;
                if (resto<divisor){
                    return cociente;
                }else{
                    return Dividir(resto, divisor);
                }            
            }
        }
    }
}
