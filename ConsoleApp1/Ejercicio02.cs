//Pregunta 2: Calculadora logica simple
//Pide al usuario tres cosas:
//1.Primer numero
//2. Segundo numero
//3. Un operador: +, -, *, /
//Segun el operador ingresado, haz la operacion correspondiente y muestra el resultado.
//Ejemplo:
//Ingresa primer numero: 10
//Ingresa segundo numero: 5
//Ingresa operador: *
//Resultado: 50


internal class Ejercicio02
{
    private static void Main02(string[] args)
    {
        Console.Write("ingrese el primero numero: ");
        int numero01 = int.Parse(Console.ReadLine());

        Console.Write("ingrese el segundo numero: ");
        int numero02 = int.Parse(Console.ReadLine());

        Console.Write("ingrese un operador : ");
        string operador = Console.ReadLine();

        if (operador == "+")
        {
            int suma = numero01 + numero02;
            Console.Write($"la suma es {suma} ");
        }
        else if (operador == "-")
        {
            int resta = numero01 - numero02;
            Console.Write($"la resta es {resta} ");
        }
        else if (operador == "*")
        {
            int multi = numero01 * numero02;
            Console.Write($"la multiplicacion es {multi} ");
        }
        else if (operador == "/")
        {
            int divi = numero01 / numero02;
            Console.Write($"la division es {divi} ");
        }
        else
        {
            Console.Write("coloque un operador valido");
        }
    }
}