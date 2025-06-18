//Pregunta 1: Calculo con validacion doble
//Pide al usuario dos numeros. Si ambos son mayores a 10,
//muestra la suma, la resta y el producto
//de ambos.
//Si uno de los dos es menor o igual a 10, muestra:
//"No se permiten numeros menores o iguales a 10."

using System.Diagnostics.CodeAnalysis;

internal class Ejercicio01
{
    private static void Main01(string[] args)
    {
        const int numMin = 10;
        Console.Write("ingrese el primero numero: ");
        int numero01 = int.Parse(Console.ReadLine());

        Console.Write("ingrese el segundo numero: ");
        int numero02 = int.Parse(Console.ReadLine());

        if (numero01 > numMin && numero02 > numMin)
        {
            int suma = numero01 + numero02;
            int resta = numero01 - numero02;
            int multi = numero01 * numero02;

            Console.Write($"la suma es {suma} " +
                $"la resta es {resta} " +
                $"la multiplicación es {multi} ");
        }
        else
        {
            Console.Write("no se permiten numeros menores o iguales a 10");
        }
    }
}