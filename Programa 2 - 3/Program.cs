using System;
using System.Timers;

class Calificaciones
{
    static void Main(string[] args)
    {
        decimal nota1 = Numero("Ingrese la primera nota: ");
        decimal nota2 = Numero("Ingrese la segunda nota: ");
        decimal nota3 = Numero("Ingrese la tercera nota: ");

        decimal promedio = (nota1 + nota2 + nota3) / 3;

        if (promedio >= 7)
        {
            Console.WriteLine("\n" + "El promedio es: " + promedio);
            Console.WriteLine("Promocionado");
        }
        else
        {
            Console.WriteLine("\n" + "El promedio es: " + promedio);
            Console.WriteLine("No Promocionado");
        }

    }

    static int Numero(string mensaje)
    {
        int num;
        bool esValido;

        do
        {
            Console.WriteLine(mensaje);
            esValido = int.TryParse(Console.ReadLine(), out num);

            if (!esValido)
            {
                Console.WriteLine("\n" + "El valor ingresado no es válido." + "\n" + "Por favor, ingrese un número." + "\n");
            }
        } while (!esValido);

        return num;
    }
}