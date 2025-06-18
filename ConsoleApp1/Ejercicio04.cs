//Pregunta 4: Verificacion compuesta
//Pide el nombre, edad y pais.
//Si el pais es "Peru" y la edad mayor o igual a 18:
//"[Nombre], puedes votar en Peru."
//Si el pais no es Peru:
//"Este sistema solo admite peruanos."
//Si la edad es menor a 18:
//"Debes ser mayor de edad para votar."

internal class Ejercicio04
{
    private static void Main04(string[] args)
    {
        Console.Write("ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("ingrese su pais: ");
        string pais = Console.ReadLine().ToLower();


        if (pais == "peru")
        {
            Console.Write("ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.Write($"{nombre} puede votar");
            }
            else
            {
                Console.Write("no puede votar por ser menor de edad");
            }
        }
        else
        {
            Console.Write("solo pueden votar peruanos");
        }
    }
}