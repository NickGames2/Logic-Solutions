Console.Write("Ingrese el primer numero: ");
var numberString = Console.ReadLine();
int numberInt = int.Parse(numberString);
Console.Write("Ingrese el segundo numero: ");
var numberString2 = Console.ReadLine();
int numberInt2 = int.Parse(numberString2);
Console.Write("Ingrese el  tercer numero: ");
var numberString3 = Console.ReadLine();
int numberInt3 = int.Parse(numberString3);

if (numberInt > numberInt2 && numberInt > numberInt3)
{
    Console.WriteLine($"El numero {numberInt} es el mayor");
}
 else if (numberInt < numberInt2 && numberInt2 > numberInt3)
{
    Console.WriteLine($"El numero {numberInt2} es el mayor");
}

else{ 
    Console.WriteLine($"El numero {numberInt3} es el mayor"); 
}

if (numberInt > numberInt2 && numberInt < numberInt3)
{
        Console.WriteLine($"El numero {numberInt} es el del medio");
}
 else if (numberInt2 > numberInt && numberInt2 < numberInt3)
{
        Console.WriteLine($"El numero {numberInt2} es el del medio");
}
else{
    Console.WriteLine($"El numero {numberInt3} es el del medio");
}

if (numberInt < numberInt2 && numberInt < numberInt3)
{
    Console.WriteLine($"El numero {numberInt} es el menor");
}

else if (numberInt2 < numberInt && numberInt2 < numberInt3)
{
    Console.WriteLine($"El numero {numberInt2} es el menor");
}

else
{
    Console.WriteLine($"El numero {numberInt3} es el menor");
}