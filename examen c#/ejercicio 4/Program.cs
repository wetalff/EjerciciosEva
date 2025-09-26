using System;
using System.Collections.Generic; // Necesario para usar List<T>

class Program
{
    // Lista global donde guardaremos todas las notas de los estudiantes
    static List<double> notas = new List<double>();

    static void Main(string[] args)
    {
        int opcion;
        do
        {
            // Menú para el usuario
            Console.WriteLine("\n--- GESTIÓN DE NOTAS DE ESTUDIANTES ---");
            Console.WriteLine("1. Agregar una nota");
            Console.WriteLine("2. Calcular promedio de notas");
            Console.WriteLine("3. Mostrar nota más alta y más baja");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");

            // Convertimos lo que escribe el usuario a número entero
            opcion = int.Parse(Console.ReadLine());

            // Según la opción ingresada, llamamos al método correspondiente
            switch (opcion)
            {
                case 1:
                    AgregarNota();
                    break;
                case 2:
                    CalcularPromedio();
                    break;
                case 3:
                    MostrarNotaAltaYBaja();
                    break;
                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida, intenta de nuevo.");
                    break;
            }

        } while (opcion != 4); // Se repite hasta que el usuario elija salir
    }

    // Método para agregar una nota a la lista
    static void AgregarNota()
    {
        Console.Write("Ingresa la nota del estudiante (ejemplo: 85.5): ");
        double nuevaNota = double.Parse(Console.ReadLine()); // Convertimos lo ingresado a número decimal
        notas.Add(nuevaNota); // Guardamos la nota en la lista global
        Console.WriteLine("Nota agregada correctamente.");
    }

    // Método para calcular el promedio de las notas
    static void CalcularPromedio()
    {
        if (notas.Count == 0) // Validamos si la lista está vacía
        {
            Console.WriteLine("No hay notas registradas.");
            return;
        }

        double suma = 0; // Variable local para acumular la suma de las notas
        foreach (double nota in notas)
        {
            suma += nota; // Vamos sumando cada nota
        }

        double promedio = suma / notas.Count; // Calculamos el promedio
        Console.WriteLine($"El promedio de las notas es: {promedio:F2}");
    }

    // Método para mostrar la nota más alta y la más baja
    static void MostrarNotaAltaYBaja()
    {
        if (notas.Count == 0) // Validamos si la lista está vací+a
        {
            Console.WriteLine("No hay notas registradas.");
            return;
        }

        double notaAlta = double.MinValue; // Variable local para la nota más alta
        double notaBaja = double.MaxValue; // Variable local para la nota más baja

        foreach (double nota in notas)
        {
            if (nota > notaAlta)
                notaAlta = nota;
            if (nota < notaBaja)
                notaBaja = nota;
        }

        Console.WriteLine($"La nota más alta es: {notaAlta}");
        Console.WriteLine($"La nota más baja es: {notaBaja}");
    }
}

