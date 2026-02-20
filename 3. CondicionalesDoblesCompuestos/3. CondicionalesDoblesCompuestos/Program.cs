using System;
using System.Runtime.ConstrainedExecution;

namespace _3.CondicionalesDoblesCompuestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos. De lo contrario mostrar el mensaje “Persona exenta de impuestos”.*/
            string nombre = "";
            float sueldo = 0;
            Console.WriteLine("Ingrese el nombre del usuario");
            nombre=Console.ReadLine();
            Console.WriteLine("Ingrese el valor del sueldo");
            sueldo= Single.Parse( Console.ReadLine() );

            if (sueldo>=3000)
            {
                //Si la condición es Verdadera
                Console.WriteLine($"La persona {nombre}, debe abonar impuestos");
            }
            else
            {
                //Si la condición es Falsa
                Console.WriteLine("La persona está exenta de impuestos");
            }
        }
    }
}
