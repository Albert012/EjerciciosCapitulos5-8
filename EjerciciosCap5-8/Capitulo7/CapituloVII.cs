using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosCap5_8.Capitulo7
{
    public class CapituloVII
    {
        public CapituloVII()
        {

        }

        public static void CalcularPromMaxMin()
        {
            int num = 0, Acum = 0;
            

            Console.WriteLine(">> Calcular Promedio, Calificacion Maxima y Minima de un Estudiante <<");
            Console.Write("Cuantas Calificaciones Tienes El Alumno: ");
            num = Convert.ToInt32(Console.ReadLine());
            int[] Calif = new int[num];

            for (int i = 0; i < Calif.Length; ++i)
            {
                Console.Write("Ingrese Calificacion Del Alumno: ");
                Calif[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int x = 0; x < Calif.Length; ++x)
            {
                Console.WriteLine("Calificacion {0}: {1}", x, Calif[x]);
                Acum += Calif[x];
            }

            Console.WriteLine("La Sumatoria es: {0}", Acum);
            Console.WriteLine("El Promedio del Alumno es: {0}", Acum / Calif.Length);

            Array.Sort(Calif);
            Console.WriteLine("Su Califacion Minima Fue De: {0}", Calif[0]);
            Array.Reverse(Calif);
            Console.WriteLine("Su Califacion Maxima Fue De: {0}", Calif[0]);


        }
           

        public static void Diccionario()
        {    
            Hashtable hashtable = GetHashtable();
            Console.WriteLine(">> Diccionario Hashtable <<");
            Console.WriteLine("Digite Una Palabra A Buscar ");
            string buscar = Console.ReadLine();
            
            Console.WriteLine(hashtable.ContainsKey(buscar));

        }

        private static Hashtable GetHashtable()
        {

            Hashtable hashtable = new Hashtable();
            hashtable.Add("Nombre", "Palabra o conjunto de palabras con las que se  distinguen los seres vivos ");
            hashtable.Add("Lenguaje", "Capacidad propia del ser humano para expresar pensamientos.");
            hashtable.Add("Numero", "Concepto matemático que expresa una cantidad con relación a la unidad de cómputo");
            return hashtable;
        }

        public static void Agenda()
        {
            Queue Agenda = new Queue();

            string Tel = string.Empty, nombre = string.Empty;
            int Lista = 1;

            Console.WriteLine(">> Agenda Queue <<");
            
            while(Lista == 1)
            {
                Console.WriteLine("Digite El Nombre Del Contacto: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Digite Numero De Telefono: ");
                Tel = Console.ReadLine();

                Agenda.Enqueue(Tel);

                Console.WriteLine("Ingrese 0 Si No Agregara Mas Contactos, Sino Ingrese 1");
                Lista = Convert.ToInt32(Console.ReadLine());
            }

            while (Agenda.Count > 0)
                Console.WriteLine("Nombre: {0} >> Numero: {1}", Agenda.Dequeue(), Agenda.Dequeue());

        }

    }
}
