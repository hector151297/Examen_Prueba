//Pregunta 5: Nota promedio con calificacion
//Pide tres notas entre 0 y 20. Calcula el promedio.
//Segun el promedio, muestra:
//-18 a 20 -> Excelente
//- 14 a 17 -> Aprobado
//- 11 a 13 -> Regular
//- 0 a 10 -> Reprobado

internal class Ejercicio05
{
    private static void Main05(string[] args)
    {
        Console.Write("ingrese el primero numero: ");
        int numero01 = int.Parse(Console.ReadLine());

        Console.Write("ingrese el segundo numero: ");
        int numero02 = int.Parse(Console.ReadLine());

        Console.Write("ingrese el tercer numero: ");
        int numero03 = int.Parse(Console.ReadLine());

        double prom = (numero01 + numero02 + numero03) / 3;


        if (prom >= 18 && prom <= 20 && numero01 >= 0 && numero01 <= 20 && numero02 >= 0 && numero02 <= 20 && numero03 >= 0 && numero03 <= 20)
        {
            Console.Write($"{prom} Excelente");
        }
        else if (prom >= 14 && prom <= 17 && numero01 <= 20 && numero02 >= 0 && numero02 <= 20 && numero03 >= 0 && numero03 <= 20)
        {
            Console.Write($"{prom} Aprobado");
        }
        else if (prom >= 11 && prom <= 13 && numero01 <= 20 && numero02 >= 0 && numero02 <= 20 && numero03 >= 0 && numero03 <= 20)
        {
            Console.Write($"{prom} Regular");
        }
        else if (prom >= 0 && prom <= 10 && numero01 <= 20 && numero02 >= 0 && numero02 <= 20 && numero03 >= 0 && numero03 <= 20)
        {
            Console.Write($"{prom} Reprobado");
        }
        else
        {
            Console.Write("ingrese una nota valida");
        }
    }
}