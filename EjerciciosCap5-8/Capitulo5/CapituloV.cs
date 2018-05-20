using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosCap5_8.Capitulo5
{
    public class CapituloV
    {
        public CapituloV()
        {

        }


        public static int Factorial()
        {
            int num = 0, res = 1;
            Console.Write("Digite Numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
                return num;

            for (int i = 1; i <= num; ++i)
                res *= i;

            Console.WriteLine("El Factorial de {0} es {1} ", num, res);
            Console.WriteLine();
            return num;
        }

        public static void NumeroLetra()
        {
            int num = 0;

            Console.WriteLine(">> Mostramos En Letra Un Numero Digitado del 1-10");
            Console.WriteLine("Digite Un Numero Dentro Del Rango");
            num = Convert.ToInt32(Console.ReadLine());

            switch(num)
            {
                case 0:
                    Console.Write("Cero");
                    break;
                case 1:
                    Console.Write("Uno");
                    break;
                case 2:
                    Console.Write("Dos");
                    break;
                case 3:
                    Console.Write("Tres");
                    break;
                case 4:
                    Console.Write("Cuatro");
                    break;
                case 5:
                    Console.Write("Cinco");
                    break;
                case 6:
                    Console.Write("Seis");
                    break;
                case 7:
                    Console.Write("Siete");
                    break;
                case 8:
                    Console.Write("Ocho");
                    break;
                case 9:
                    Console.Write("Nueve");
                    break;
                case 10:
                    Console.Write("Diez");
                    break;
                case 11:
                    Console.Write("Once");
                    break;
                default:
                    Console.WriteLine("Favor Digital Dentro del Rango!!");
                    break;
            }
        }
    }
}
