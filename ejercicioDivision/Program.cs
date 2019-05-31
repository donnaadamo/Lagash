using System;

namespace ejercicioDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int cociente = 0;
            int resto = 0;

            int Dividir(int dividendo, int divisor){
                if(dividendo != 0 && divisor != 0){
                resto = dividendo - divisor;
                cociente ++;
                if (resto<divisor){
                        int result = cociente;
                        cociente = 0;
                        return result;
                }else{
                    return Dividir(resto, divisor);
                }            
                }else{
                    resto = 0;
                    return 0;
                }
            }

                Console.WriteLine("Cociente: " + Dividir(9, 9) + " resto: " + resto);
                Console.WriteLine("Cociente: " + Dividir(9, 6) + " resto: " + resto);
                Console.WriteLine("Cociente: " + Dividir(9, 3) + " resto: " + resto);
                Console.WriteLine("Cociente: " + Dividir(9, 2) + " resto: " + resto);
                Console.WriteLine("Cociente: " + Dividir(0, 1) + " resto: " + resto);
                Console.WriteLine("Cociente: " + Dividir(9, 0) + " resto: " + resto);
            
        }
    }
}
