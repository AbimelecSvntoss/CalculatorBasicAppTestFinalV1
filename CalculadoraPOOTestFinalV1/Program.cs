using System.IO;
namespace CalculadoraPOOTestFinalV1;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Title = "App Calculadora | POO | TecNM Campus Monclova";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;

            Console.WriteLine("╔══════════════════════════════════╗");
            Console.WriteLine("║     < App Calculadora POO >      ║");
            Console.WriteLine("║                                  ║");
            Console.WriteLine("║ 1. Suma                          ║");
            Console.WriteLine("║ 2. Resta                         ║");
            Console.WriteLine("║ 3. División                      ║");
            Console.WriteLine("║ 4. Raíz Cuadrada                 ║");
            Console.WriteLine("║ 5. Multiplicación                ║");
            Console.WriteLine("║ 6. Potencia                      ║");
            Console.WriteLine("║ 0. Salir                         ║");
            Console.WriteLine("╚══════════════════════════════════╝");
            Console.WriteLine();
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1": // Suma
                    Console.Clear();
                    Suma.MetodoSumar();
                    break;
                case "2": // Resta
                    Console.Clear();
                    Resta.MetodoRestar();
                    break;
                case "3": // División
                    Console.Clear();
                    Division.MetodoDividir();
                    break;
                case "4": // Raíz Cuadrada
                    Console.Clear();
                    RaizCuadrada.MetodoRaizCuadrada();
                    break;
                case "5": // Multiplicación
                    Console.Clear();
                    Multiplicacion.MetodoMultiplicar();
                    break;
                case "6": // Potencia
                    Console.Clear();
                    Potencia.MetodoPotencia();
                    break;
                case "0":
                    return; // Salir de la aplicación
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }
}