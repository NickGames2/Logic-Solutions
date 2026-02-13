Console.Write("Ingrese el numero: ");
var numberString = Console.ReadLine();
int numberInt = int.Parse(numberString);

if (numberInt % 2 == 0) 
{
    Console.WriteLine ($"{numberInt},es par");
}

else 
{
    Console.WriteLine ($"{numberInt},es impar ");
}

