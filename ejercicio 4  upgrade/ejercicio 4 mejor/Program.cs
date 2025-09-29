using System;
using System.Collections.Generic; // Necesario para usar List<T>

class Program
{
    // Lista global donde guardaremos todas las notas de los estudiantes
    static List<double> notas = new List<double>();

    static void Main(string[] args)
    {
        int opcion = 0;
        do
        {
            // Menú para el usuario
            Console.WriteLine("\n--- GESTIÓN DE NOTAS DE ESTUDIANTES ---");
            Console.WriteLine("1. Agregar una nota");
            Console.WriteLine("2. Calcular promedio de notas");
            Console.WriteLine("3. Mostrar nota más alta y más baja");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");

            // Aquí usamos try-catch para evitar que el programa se caiga
            try
            {
                opcion = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Debes ingresar un número válido.");
                opcion = 0; // fuerza repetir el menú
            }

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
                    if (opcion != 0) // no volver a mostrar error en caso de catch
                        Console.WriteLine("Opción no válida, intenta de nuevo.");
                    break;
            }

        } while (opcion != 4); // Se repite hasta que el usuario elija salir
    }

    // Método para agregar una nota a la lista
    static void AgregarNota()
    {
        Console.Write("Ingresa la nota del estudiante (ejemplo: 85.5): ");
        try
        {
            double nuevaNota = double.Parse(Console.ReadLine()); // Convertimos lo ingresado a número decimal
            notas.Add(nuevaNota); // Guardamos la nota en la lista global
            Console.WriteLine("Nota agregada correctamente.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingresa un número válido para la nota.");
        }
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
        if (notas.Count == 0) // Validamos si la lista está vacía
        {
            Console.WriteLine("No hay notas registradas.");
            return;
        }

        // Aquí usamos ref para obtener nota alta y nota baja desde otro método
        double notaAlta = 0;
        double notaBaja = 0;

        ObtenerNotasAltaYBaja(ref notaAlta, ref notaBaja);

        Console.WriteLine($"La nota más alta es: {notaAlta}");
        Console.WriteLine($"La nota más baja es: {notaBaja}");
    }

    // Método auxiliar que calcula nota más alta y más baja usando ref
    // ref permite que el método modifique las variables que se pasan
    static void ObtenerNotasAltaYBaja(ref double notaAlta, ref double notaBaja)
    {
        notaAlta = double.MinValue; // Inicializamos en valores extremos
        notaBaja = double.MaxValue;

        foreach (double nota in notas)
        {
            if (nota > notaAlta)
                notaAlta = nota;
            if (nota < notaBaja)
                notaBaja = nota;
        }
    }
}

