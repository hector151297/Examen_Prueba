//Pregunta 3: Operacion oculta
//Pide tres numeros al usuario.
//Si el primero es par, suma los tres.
//Si es impar, multiplica el segundo por el tercero.
//Muestra el resultado final.

internal class Ejercicio03
{
    private static void Main03(string[] args)
    {
        Console.Write("ingrese el primero numero: ");
        int numero01 = int.Parse(Console.ReadLine());

        Console.Write("ingrese el segundo numero: ");
        int numero02 = int.Parse(Console.ReadLine());

        Console.Write("ingrese el tercer numero: ");
        int numero03 = int.Parse(Console.ReadLine());


        if (numero01 % 2 == 0)
        {
            int suma = numero01 + numero02 + numero03;
            Console.Write($"la suma es {suma} ");
        }
        else
        {
            int multi = numero02 * numero03;
            Console.Write($"la multiplicación es {multi} ");
        }

    }
}