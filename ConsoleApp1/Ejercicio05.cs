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
        const int minNota = 0;
        const int maxNota = 20;

        static bool EsValido(double numero) => numero >= minNota && numero <= maxNota;

        Console.Write("ingrese el primero numero: ");
        double numero01 = double.Parse(Console.ReadLine());

        Console.Write("ingrese el segundo numero: ");
        double numero02 = double.Parse(Console.ReadLine());

        Console.Write("ingrese el tercer numero: ");
        double numero03 = double.Parse(Console.ReadLine());

        double prom = Math.Round((numero01 + numero02 + numero03) / 3);

        if (EsValido(numero01) && EsValido(numero02) && EsValido(numero03))
        {

            if (prom >= 18 && prom <= 20)
            {
                Console.Write($"{prom} Excelente");
            }
            else if (prom >= 14 && prom <= 17)
            {
                Console.Write($"{prom} Aprobado");
            }
            else if (prom >= 11 && prom <= 13)
            {
                Console.Write($"{prom} Regular");
            }
            else if (prom >= 0 && prom <= 10)
            {
                Console.Write($"{prom} Reprobado");
            }
        }
        else
        {
            Console.Write("ingrese una nota valida");
        }

    }
}