using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Código de la branch URL
            Console.WriteLine("Escriba su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escriba su carrera");
            string carrera = Console.ReadLine();
            if (carrera == "sistemas")
            {
                Console.WriteLine("Estás en la mejor carrera del mundo");
                Console.WriteLine("¿Dónde estudias?");
                string universidad = Console.ReadLine();
                if (universidad == "URL")
                {
                    Console.WriteLine("¡Y en la mejor universidad! :D");
                    Console.WriteLine("¡Felicidades!");
                }
            }
            else
            {
                Console.WriteLine("¿Por qué no estudias sistemas? :( [1] muy difícil [2] no me gusta programar");
                int respuesta = Convert.ToInt16(Console.ReadLine());
                if (respuesta == 1 || respuesta == 2)
                {
                    Console.WriteLine("¡No puedes con el reto!");
                }                
            }
            Console.ReadKey(); // Pausa final
        }
    }
}
