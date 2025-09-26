using System;

class Program
{
    // Variable global donde se guarda el último resultado
    static double ultimoResultado = 0;

    static void Main(string[] args)
    {
        int opcion = -1; // Guardará la opción que elija el usuario

        // Repetimos hasta que el usuario elija salir (opción 0)
        while (opcion != 0)
        {
            // Menú de opciones
            Console.WriteLine("\n=== CALCULADORA CIENTÍFICA BÁSICA ===");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Potencia");
            Console.WriteLine("6. Raíz cuadrada");
            Console.WriteLine("7. Ver último resultado");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");

            // Leemos lo que escribe el usuario
            opcion = int.Parse(Console.ReadLine());

            // Variables locales para guardar números
            double num1, num2;

            // ---- Opción 1: Suma ----
            if (opcion == 1)
            {
                Console.Write("Número 1: ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("Número 2: ");
                num2 = double.Parse(Console.ReadLine());

                ultimoResultado = num1 + num2; // Calcula y guarda en la variable global
                Console.WriteLine("Resultado: " + ultimoResultado);
            }
            // ---- Opción 2: Resta ----
            else if (opcion == 2)
            {
                Console.Write("Número 1: ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("Número 2: ");
                num2 = double.Parse(Console.ReadLine());

                ultimoResultado = num1 - num2;
                Console.WriteLine("Resultado: " + ultimoResultado);
            }
            // ---- Opción 3: Multiplicación ----
            else if (opcion == 3)
            {
                Console.Write("Número 1: ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("Número 2: ");
                num2 = double.Parse(Console.ReadLine());

                ultimoResultado = num1 * num2;
                Console.WriteLine("Resultado: " + ultimoResultado);
            }
            // ---- Opción 4: División ----
            else if (opcion == 4)
            {
                Console.Write("Número 1: ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("Número 2: ");
                num2 = double.Parse(Console.ReadLine());

                if (num2 == 0) // Validar que no divida entre 0
                {
                    Console.WriteLine("Error: No se puede dividir entre 0");
                }
                else
                {
                    ultimoResultado = num1 / num2;
                    Console.WriteLine("Resultado: " + ultimoResultado);
                }
            }
            // ---- Opción 5: Potencia ----
            else if (opcion == 5)
            {
                Console.Write("Base: ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("Exponente: ");
                num2 = double.Parse(Console.ReadLine());

                ultimoResultado = Math.Pow(num1, num2); // función de potencia
                Console.WriteLine("Resultado: " + ultimoResultado);
            }
            // ---- Opción 6: Raíz cuadrada ----
            else if (opcion == 6)
            {
                Console.Write("Número: ");
                num1 = double.Parse(Console.ReadLine());

                if (num1 < 0) // Validamos que no sea negativo
                {
                    Console.WriteLine("Error: No se puede raíz cuadrada de número negativo");
                }
                else
                {
                    ultimoResultado = Math.Sqrt(num1); // función de raíz cuadrada
                    Console.WriteLine("Resultado: " + ultimoResultado);
                }
            }
            // ---- Opción 7: Mostrar último resultado ----
            else if (opcion == 7)
            {
                Console.WriteLine("Último resultado guardado: " + ultimoResultado);
            }
            // ---- Opción 0: Salir ----
            else if (opcion == 0)
            {
                Console.WriteLine("Saliendo de la calculadora...");
            }
            // ---- Si se elige algo inválido ----
            else
            {
                Console.WriteLine("Opción inválida, intenta de nuevo.");
            }
        }
    }
}
