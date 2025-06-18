//BONUS: Calculadora de sueldo
//Pide al usuario:
//-Su nombre
//- Horas trabajadas
//- Pago por hora
//Calcula el sueldo bruto (horas * pago).
//Si el sueldo bruto es mayor a 2000, descuéntale 10 por ciento de impuestos.
//Muestra: "[Nombre], tu sueldo neto es: S/. XXXX.XX"

Console.Write("ingrese su nombre: ");
string nombre = Console.ReadLine();

Console.Write("ingrese sus horas trabajadas: ");
int horas = int.Parse(Console.ReadLine());

Console.Write("ingrese su pago por horas: ");
double pagoHoras = double.Parse(Console.ReadLine());

double sueldo = horas * pagoHoras;

if(sueldo > 2000)
{
    double des = (sueldo * 10)/100 ;
    double neto = sueldo - des;
    Console.Write($"{nombre}, tu sueldo neto es de S/. {neto}");
}
else
{
    
    Console.Write($"{nombre}, tu sueldo neto es de S/. {sueldo}");

}