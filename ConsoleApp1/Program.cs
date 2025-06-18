//BONUS: Calculadora de sueldo
//Pide al usuario:
//-Su nombre
//- Horas trabajadas
//- Pago por hora
//Calcula el sueldo bruto (horas * pago).
//Si el sueldo bruto es mayor a 2000, descuéntale 10 por ciento de impuestos.
//Muestra: "[Nombre], tu sueldo neto es: S/. XXXX.XX"

const int maxSueldoBruto = 2000;
const double porcent = 0.10;

Console.Write("ingrese su nombre: ");
string nombre = Console.ReadLine() ?? string.Empty;

Console.Write("ingrese sus horas trabajadas: ");
double horas = double.Parse(Console.ReadLine());

Console.Write("ingrese su pago por horas: ");
double pagoHoras = double.Parse(Console.ReadLine());

double sueldo = horas * pagoHoras;

static string Message(string nombre, double neto) => $"{nombre}, tu sueldo neto es de S/. {neto}";

if (sueldo > maxSueldoBruto)
{
    double neto = sueldo - (sueldo * porcent);
    Console.Write(Message(nombre, neto));
}
else
    Console.Write(Message(nombre, sueldo));