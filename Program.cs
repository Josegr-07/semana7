using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CASO_SEMA7
{
    internal class Program
    {
        static int Max =100;
        static string[] nombres = new string[Max];
        static double[] notas = new double[Max];
        public static void Titulo()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("Sistema de Gestion de notas");
            Console.WriteLine("******************************");
        }
        static public void Registrar_estudiante()
        {
            Console.WriteLine("Registro de estudiante nuevo: ");
            if (notas.Length == 0)
            { 
                Console.WriteLine("No hay espacio para registrar mas estudiantes");
                return;
            }
            Console.Write("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();
            double nota;
            while (true)
            {
                Console.Write("Ingrese la nota del estudiante [0-20]: ");
                nota=double.Parse(Console.ReadLine());
                if (nota >= 0 && nota <= 20)
                {
                    break;
                }
                    Console.WriteLine("Error, volver a ingresar la nota [0-20]");
            }
            nombres[contador] = nombre;
            notas[contador] = nota;
            contador++;
            Console.WriteLine("Estudiante registrado correctamente");
        }
        static public void Buscar_estudiante()
        {
            Console.WriteLine("Lista de estudiantes registrados: ");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"Nombre: {nombres[i]}, Nota: {notas[i]}");
            }
        }
    }
}