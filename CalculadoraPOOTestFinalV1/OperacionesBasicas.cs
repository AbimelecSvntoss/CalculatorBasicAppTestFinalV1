using CalculadoraPOOTestFinalV1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalculadoraPOOTestFinalV1;

public class Suma : Operacion
{
    public Suma() => Nombre = "Suma";
    public override double Calcular(double n1, double n2) => n1 + n2;
    public static void MetodoSumar()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Title = "Menú de Suma";

        Console.Clear();

        Console.WriteLine("< Menú de Suma >");
        Console.WriteLine();
        Console.Write("Ingrese el primer número: ");
        double n1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double n2 = int.Parse(Console.ReadLine());

        double resultado = n1 + n2;
        Console.WriteLine();
        Console.WriteLine($"El resultado de la suma es: {resultado}");
        Console.WriteLine();
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
    }
}

public class Resta : Operacion
{
    public Resta() => Nombre = "Resta";
    public override double Calcular(double n1, double n2) => n1 - n2;
    public static void MetodoRestar()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Title = "Menú de Resta";

        Console.Clear();

        Console.WriteLine("< Menú de Resta >");
        Console.WriteLine();
        Console.Write("Ingrese el primer número: ");
        double n1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double n2 = int.Parse(Console.ReadLine());

        double resultado = n1 - n2;
        Console.WriteLine();
        Console.WriteLine($"El resultado de la resta es: {resultado}");
        Console.WriteLine();
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
    }
}

public class Division : Operacion
{
    public Division() => Nombre = "División";
    public override double Calcular(double n1, double n2) => n1 / n2;

    public override string Validar(double n1, double n2)
    {
        if (n2 == 0) return "Error: No se puede dividir entre cero.";
        return "";
    }

    public static void MetodoDividir()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Title = "Menú de División";

        Console.Clear();

        Console.WriteLine("< Menú de División >");
        Console.WriteLine();
        Console.Write("Ingrese el primer número: ");
        string input1 = Console.ReadLine();

        Console.Write("Ingrese el segundo número: ");
        string input2 = Console.ReadLine();

        if (!double.TryParse(input1, out double n1) || !double.TryParse(input2, out double n2))
        {
            Console.WriteLine("Entrada no válida. Introduzca números válidos.");
            Console.ReadKey();
            return;
        }

        var oper = new Division();
        string error = oper.Validar(n1, n2);
        if (!string.IsNullOrEmpty(error))
        {
            Console.WriteLine(error);
            Console.ReadKey();
            return;
        }

        double resultado = oper.Calcular(n1, n2);
        Console.WriteLine();
        Console.WriteLine($"El resultado de la división es: {resultado}");
        Console.WriteLine();
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
    }
}

public class RaizCuadrada : Operacion
{
    public RaizCuadrada() => Nombre = "Raíz Cuadrada";
    public override double Calcular(double n1, double n2) => Math.Sqrt(n1);

    public override string Validar(double n1, double n2)
    {
        if (n1 < 0) return "Error: No hay raíz de números negativos.";
        return "";
    }

    public static void MetodoRaizCuadrada()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Title = "Menú de Raíz Cuadrada";

        Console.Clear();

        Console.WriteLine("< Menú de Raíz Cuadrada >");
        Console.WriteLine();
        Console.Write("Ingrese un número: ");
        string input = Console.ReadLine();
        if (!double.TryParse(input, out double n1))
        {
            Console.WriteLine("Entrada no válida. Introduzca un número válido.");
            Console.ReadKey();
            return;
        }
        var oper = new RaizCuadrada();
        string error = oper.Validar(n1, 0);
        if (!string.IsNullOrEmpty(error))
        {
            Console.WriteLine(error);
            Console.ReadKey();
            return;
        }
        double resultado = oper.Calcular(n1, 0);
        Console.WriteLine();
        Console.WriteLine($"El resultado de la raíz cuadrada es: {resultado}");
        Console.WriteLine();
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
    }
}
public class Multiplicacion : Operacion
{
    public Multiplicacion() => Nombre = "Multiplicación";
    public override double Calcular(double n1, double n2) => n1 * n2;

    public static void MetodoMultiplicacion()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Title = "Menú de Multiplicación";

        Console.Clear();

        Console.WriteLine("< Menú de Multiplicación >");
        Console.WriteLine();
        Console.Write("Ingrese el primer número: ");
        string input1 = Console.ReadLine();

        Console.Write("Ingrese el segundo número: ");
        string input2 = Console.ReadLine();

        if (!double.TryParse(input1, out double n1) || !double.TryParse(input2, out double n2))
        {
            Console.WriteLine("Entrada no válida. Introduzca números válidos.");
            Console.ReadKey();
            return;
        }

        var oper = new Multiplicacion();
        double resultado = oper.Calcular(n1, n2);
        Console.WriteLine();
        Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
        Console.WriteLine();
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
    }

    internal static void MetodoMultiplicar()
    {
        // Wrapper para mantener compatibilidad con el Main que llama a MetodoMultiplicar()
        MetodoMultiplicacion();
    }
}