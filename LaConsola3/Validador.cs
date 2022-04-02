using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaConsola3
{
     public class Validador
    {
        
        public static void Tecla(string mensaje)
        {
            string opcion = mensaje;
            ConsoleKeyInfo cki;
            Console.TreatControlCAsInput = true;

            Console.Clear();

            do
            {

                Console.WriteLine("\nPresione cualquier variación de CTRL o ALT o SHIFT + tecla de Consola.");
                Console.WriteLine(opcion);

                cki = Console.ReadKey();
                Console.Clear();
                Console.WriteLine("\nUsted Presiono: ");
                if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
                if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
                if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
                Console.WriteLine(cki.Key.ToString());

                
            } while (cki.Key != ConsoleKey.X);

            if (cki.Key == ConsoleKey.End)
            {
                Console.Clear();
                Console.WriteLine("Usted presionó la tecla " + "*" + "End" + "*" + " para salir. Hasta Luego");
            }
        }

        

        


    }
}
