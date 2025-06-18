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
        const string suma = "+";
        const string resta = "-";
        const string multiplicacion = "*";
        const string division = "/";

        Console.Write("ingrese el primero numero: ");
        double numero01 = double.Parse(Console.ReadLine());

        Console.Write("ingrese el segundo numero: ");
        double numero02 = double.Parse(Console.ReadLine());

        Console.Write("ingrese un operador : ");
        string operador = Console.ReadLine();

        if (operador == suma)
        {
            double sum = numero01 + numero02;
            Console.Write($"la suma es {sum} ");
        }
        else if (operador == resta)
        {
            double rest = numero01 - numero02;
            Console.Write($"la resta es {rest} ");
        }
        else if (operador == multiplicacion)
        {
            double multi = numero01 * numero02;
            Console.Write($"la multiplicacion es {multi} ");
        }
        else if (operador == division)
        {
            double divi = numero01 / numero02;
            Console.Write($"la division es {divi} ");
        }
        else
        {
            Console.Write("coloque un operador valido");
        }

    }
}