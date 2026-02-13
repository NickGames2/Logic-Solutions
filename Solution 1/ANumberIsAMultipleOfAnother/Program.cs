Console.Write("Ingrese el primer numero: ");
var numberString = Console.ReadLine();
var numberInt = int.Parse(numberString);
Console.Write("Ingrese el segundo numero: ");
var numberString2 = Console.ReadLine();
var numberInt2 = int.Parse(numberString2);

if (numberInt % numberInt2 == 0)
{
    Console.WriteLine($"El numero {numberInt}, es multiplo de {numberInt2}");
}
else
{
    Console.WriteLine($"El numero {numberInt}, no es multiplo de {numberInt2}");
}
