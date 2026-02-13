Console.Write("Ingrese el primer numero: ");
var numberString = Console.ReadLine();
int numberInt = int.Parse(numberString);

if (numberInt % 4 == 0 && numberInt % 100 != 0)
{
    Console.WriteLine($"El año {numberInt} es biciesto");
}
else  if (numberInt % 100 == 0 && numberInt % 400 == 0)
{
    Console.WriteLine($"El año {numberInt} es biciesto");
}
else
{
    Console.WriteLine($"El año {numberInt} no es biciesto");
}
