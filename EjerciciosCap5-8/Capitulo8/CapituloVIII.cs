using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosCap5_8.Capitulo8
{
    public class CapituloVIII
    {
        public CapituloVIII()
        {

        }

        public static void Fecha()
        {
            Console.WriteLine(">> Mostramos La Fecha y Hora con Formato AM PM <<");
            Console.WriteLine(string.Format("{0:hh:mm:ss tt}", DateTime.Now));
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }

        public static void Cadenas()
        {
            string[] cadena = { "Computadora", "Zoologico", "Abanico", "Laptop", "Tecnologia" };

            Console.WriteLine(" >>>> Palabras Desorganizadas <<<<");
            foreach (string a in cadena) 
            Console.WriteLine(a);

            cadena = Organizar(cadena);

            Console.WriteLine(">>>>> Palabras Ordenadas <<<<");
            foreach (string s in cadena) 
            Console.WriteLine(s);

        }

        private static string[] Organizar(string[] Cadena)
        {
            return (from c in Cadena orderby c select c).ToArray<string>();
        }
     
    }
}
