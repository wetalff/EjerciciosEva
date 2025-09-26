using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

//Sistema de Registro de Usuarios
//• Crea una lista global que almacene nombres de usuarios registrados.
//• Métodos con variables locales deben permitir:
//✓ Registrar un nuevo usuario.
//✓ Validar si un usuario ya existe.
//✓ Mostrar todos los usuarios.

class Program
{
    //  Lista global que almacenará los nombres de usuarios
    static List<string> usuarios = new List<string>();

    static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.WriteLine("\n=== Sistema de Registro de Usuarios ===");
            Console.WriteLine("1. Registrar nuevo usuario");
            Console.WriteLine("2. Validar si un usuario existe");
            Console.WriteLine("3. Mostrar todos los usuarios");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            // Leer opción ingresada por el usuario
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    RegistrarUsuario();
                    break;
                case 2:
                    ValidarUsuario();
                    break;
                case 3:
                    MostrarUsuarios();
                    break;
                case 4:
                    Console.WriteLine("Saliendo del sistema...");
                    break;
                default:
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                    break;
            }

        } while (opcion != 4);
    }

    //  Método para registrar un nuevo usuario
    static void RegistrarUsuario()
    {
        Console.Write("Ingrese el nombre del nuevo usuario: ");
        string nombre = Console.ReadLine();

        // Validamos si ya existe
        if (usuarios.Contains(nombre))
        {
            Console.WriteLine("El usuario ya está registrado.");
        }
        else
        {
            usuarios.Add(nombre);
            Console.WriteLine("Usuario registrado exitosamente.");
        }
    }

    //  Método para validar si un usuario existe
    static void ValidarUsuario()
    {
        Console.Write("Ingrese el nombre a validar: ");
        string nombre = Console.ReadLine();

        if (usuarios.Contains(nombre))
        {
            Console.WriteLine("El usuario existe en el sistema.");
        }
        else
        {
            Console.WriteLine("El usuario NO existe.");
        }
    }

    //  Método para mostrar todos los usuarios registrados
    static void MostrarUsuarios()
    {
        if (usuarios.Count == 0)
        {
            Console.WriteLine(" No hay usuarios registrados.");
        }
        else
        {
            Console.WriteLine("\n=== Lista de Usuarios Registrados ===");
            foreach (string u in usuarios)
            {
                Console.WriteLine("- " + u);
            }
        }
    }



   


}