using System;

class Program
{
    // Variable global para el último resultado calculado
    static double ultimoResultado = 0;

    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.WriteLine("\n=== Calculadora Científica Básica ===");
            Console.WriteLine("Último resultado: " + ultimoResultado);
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Potencia");
            Console.WriteLine("6. Raíz cuadrada");
            Console.WriteLine("7. Salir");
            Console.Write("Seleccione una opción: ");

            try
            {
                opcion = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Debe ingresar un número válido.");
                opcion = 0;
            }

            double a = 0, b = 0;
            switch (opcion)
            {
                case 1:
                    PedirDosNumeros(ref a, ref b);
                    Sumar(ref a, ref b);
                    break;
                case 2:
                    PedirDosNumeros(ref a, ref b);
                    Restar(ref a, ref b);
                    break;
                case 3:
                    PedirDosNumeros(ref a, ref b);
                    Multiplicar(ref a, ref b);
                    break;
                case 4:
                    PedirDosNumeros(ref a, ref b);
                    Dividir(ref a, ref b);
                    break;
                case 5:
                    PedirDosNumeros(ref a, ref b);
                    Potencia(ref a, ref b);
                    break;
                case 6:
                    PedirUnNumero(ref a);
                    RaizCuadrada(ref a);
                    break;
                case 7:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (opcion != 7);
    }

    static void PedirDosNumeros(ref double x, ref double y)
    {
        x = LeerNumero("Ingrese el primer número: ");
        y = LeerNumero("Ingrese el segundo número: ");
    }

    static void PedirUnNumero(ref double x)
    {
        x = LeerNumero("Ingrese el número: ");
    }

    static double LeerNumero(string mensaje)
    {
        double valor = 0;
        bool valido = false;
        do
        {
            try
            {
                Console.Write(mensaje);
                valor = double.Parse(Console.ReadLine());
                valido = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato inválido. Intente de nuevo.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        } while (!valido);
        return valor;
    }

    static void Sumar(ref double x, ref double y)
    {
        double resultado = x + y;
        ultimoResultado = resultado;
        Console.WriteLine($"Resultado: {resultado}");
    }

    static void Restar(ref double x, ref double y)
    {
        double resultado = x - y;
        ultimoResultado = resultado;
        Console.WriteLine($"Resultado: {resultado}");
    }

    static void Multiplicar(ref double x, ref double y)
    {
        double resultado = x * y;
        ultimoResultado = resultado;
        Console.WriteLine($"Resultado: {resultado}");
    }

    static void Dividir(ref double x, ref double y)
    {
        try
        {
            if (y == 0)
                throw new DivideByZeroException("No se puede dividir por cero.");
            double resultado = x / y;
            ultimoResultado = resultado;
            Console.WriteLine($"Resultado: {resultado}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void Potencia(ref double x, ref double y)
    {
        double resultado = Math.Pow(x, y);
        ultimoResultado = resultado;
        Console.WriteLine($"Resultado: {resultado}");
    }

    static void RaizCuadrada(ref double x)
    {
        try
        {
            if (x < 0)
                throw new ArgumentException("No se puede calcular la raíz cuadrada de un número negativo.");
            double resultado = Math.Sqrt(x);
            ultimoResultado = resultado;
            Console.WriteLine($"Resultado: {resultado}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}