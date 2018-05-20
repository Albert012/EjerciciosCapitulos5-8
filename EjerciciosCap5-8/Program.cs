using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosCap5_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            int opc;
            
            do { 
                Console.WriteLine(">> Bienvenidos a los ejercicios de los Capitulos del 5-8 <<");
                Console.WriteLine("0) Salir \n\n1) Ejercicio #4 Cap 5 \n2) Ejercicio #5 Cap 5 \n\n3) Ejercicio #1 Cap 6 \n4) Ejercicio #2 Cap 6 \n5) Ejercicio #3 Cap 6 \n6) Ejercicio #4 Cap 6 \n7) Ejercicio #5 Cap 6 \n\n8) Ejercicio #1 Cap 7 \n9) Ejercicio #2 Cap 7 \n10) Ejercicio #5 Cap 7 \n\n11) Ejercicio #3 Cap 8 \n12) Ejercicio #5 Cap 8");
                Console.Write("\nQue Desea: ");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 0:
                        break;
                    case 1://Ejercicio #4 Cap 5
                        Capitulo5.CapituloV.Factorial();
                        break;
                    case 2://Ejercicio #5 Cap 5
                        Capitulo5.CapituloV.NumeroLetra();
                        break;
                    case 3://Ejercicio #1 Cap 6

                        break;
                    case 4://Ejercicio #2 Cap 6

                        break;
                    case 5://Ejercicio #3 Cap 6

                        break;
                    case 6://Ejercicio #4  Cap 6

                        break;
                    case 7://Ejercicio #5 Cap 6

                        break;
                    case 8://Ejercicio #1 Cap 7
                        Capitulo7.CapituloVII.CalcularPromMaxMin();
                        break;
                    case 9://Ejercicio #2 Cap 7
                        Capitulo7.CapituloVII.Diccionario();
                        break;
                    case 10://Ejercicio #5 Cap 7
                        Capitulo7.CapituloVII.Agenda();
                        break;
                    case 11://Ejercicio #3 Cap 8                        
                        Capitulo8.CapituloVIII.Fecha();
                        break;
                    case 12://Ejercicio #5 Cap 8
                        Capitulo8.CapituloVIII.Cadenas();
                        break;
                    default:
                        Console.Write("Opcion Invalida");
                        break;
                }
                Console.WriteLine();

            } while (opc != 0);
        }
    }
}
