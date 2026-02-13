using System.ComponentModel.Design;

Console.Write("Ingrese el nombre: ");
var NameString = Console.ReadLine();

Console.Write("Ingrese el numero de horas trabajadas: ");
var hoursString = Console.ReadLine();
int hourInt = int.Parse(hoursString);

Console.Write("Ingrese el pago por horas trabajadas: ");
var payhourString = Console.ReadLine();
int payhourInt = int.Parse(payhourString);

Console.Write("Ingrese el salario minimo: ");
var salaryString = Console.ReadLine();
int salaryInt = int.Parse(salaryString);

if (hourInt * payhourInt >= salaryInt)
{
    Console.WriteLine($"Nombre:{NameString}");
    Console.WriteLine($"Salario mensual es : {hourInt * payhourInt}");
}

else
{
    Console.WriteLine($"Nombre:{NameString}");
}

