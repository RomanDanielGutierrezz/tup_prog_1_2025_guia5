using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuestadores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int contTotal = 0, contEncuestaA = 0, contEncuestaB = 0, contEncuestaC = 0, contEncuestaD = 0, cantDEncuestas = 0;
            double acumuladorA = 0, acumuladorB = 0, acumuladorC = 0, acumuladorD = 0;
            bool centinela = true;

            while (centinela == true)
            {
                Console.WriteLine("Ingrese el nombre del encuestador");
                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingrese la cantidad de encuestas realizadas por el encuestador");
                cantDEncuestas = int.Parse(Console.ReadLine());
                Console.WriteLine();
                for (int i = 1; i <= cantDEncuestas; i++)
                {
                    Console.WriteLine("Ingrese el tipo de transporte que utiliza");
                    Console.WriteLine("Bicicleta (a), Motocicleta (b), Automovil (c), Transporte publico (d)");
                    char orden = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    switch (char.ToLower(orden))
                    {
                        case 'a':
                            contEncuestaA++;
                            Console.WriteLine("Distancia aproximada que recorre con este vehiculo ( Km )");
                            double distanciaA = Convert.ToDouble(Console.ReadLine());
                            acumuladorA += distanciaA;
                            break;
                        case 'b':
                            contEncuestaB++;
                            Console.WriteLine("Distancia aproximada que recorre con este vehiculo ( Km )");
                            double distanciaB = Convert.ToDouble(Console.ReadLine());
                            acumuladorB += distanciaB;
                            break;
                        case 'c':
                            contEncuestaC++;
                            Console.WriteLine("Distancia aproximada que recorre con este vehiculo ( Km )");
                            double distanciaC = Convert.ToDouble(Console.ReadLine());
                            acumuladorC += distanciaC;
                            break;
                        case 'd':
                            contEncuestaD++;
                            Console.WriteLine("Distancia aproximada que recorre con este vehiculo ( Km )");
                            double distanciaD = Convert.ToDouble(Console.ReadLine());
                            acumuladorD += distanciaD;
                            break;
                    }
                }
                Console.WriteLine("¿Desea continuar? (s/n)");
                char respuesta = Console.ReadKey().KeyChar;
                if (char.ToLower(respuesta) == 'n')
                {
                    centinela = false;
                }
                else
                {
                    centinela = true;
                }
            }

            contTotal = contEncuestaA + contEncuestaB + contEncuestaC + contEncuestaD;
            Console.WriteLine($"Se realizaron un total de {contTotal} encuestas");
            Console.WriteLine("La distribucion es la siguiente:");
            Console.WriteLine($"Bicicleta {contEncuestaA} que equivale a un {(contEncuestaA * 100) / contTotal}% de las encuestas");
            Console.WriteLine($"Motocicleta {contEncuestaB} que equivale a un {(contEncuestaB * 100) / contTotal}% de las encuestas");
            Console.WriteLine($"Automovil {contEncuestaC} que equivale a un {(contEncuestaC * 100) / contTotal}% de las encuestas");
            Console.WriteLine($"Transporte publico {contEncuestaD} que equivale a un {(contEncuestaD * 100) / contTotal}% de las encuestas");

        }
    }
}
