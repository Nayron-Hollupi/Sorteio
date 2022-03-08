using System;

namespace Sorteio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int i, reserva,k, valor;
            int[] numero = new int[20];

            for (i = 0; i < numero.Length; i++)
            {
                valor = aleatorio.Next(1, 20);
            
                numero[i] = valor;

                //Ordenacao 
               
                    for (k = i; k > 0; k--)
                    {
                        if (numero[k] < numero[k - 1])
                        {
                            reserva = numero[k - 1];
                            numero[k - 1] = numero[k];
                            numero[k] = reserva;
                        }

                    }
                
            }
                      
           
         
            for (i = 0; i < numero.Length; i++)
            {
                Console.WriteLine(" {0}" ,numero[i]);

            }

            }
    }
}
