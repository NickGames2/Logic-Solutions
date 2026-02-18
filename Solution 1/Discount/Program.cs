Console.Write("Numero de escritorios: ");
var unitsString = Console.ReadLine();
int units = int.Parse(unitsString);

double discount1 = (double)0.10;
double discount2 = (double)0.20;
double discount3 = (double)0.40;

int valueUnity = (int)650000;
int price1 = (int)((units * valueUnity) - (units * valueUnity * discount1));
int price2 = (int)((units * valueUnity) - (units * valueUnity * discount2));
int price3 = (int)((units * valueUnity) - (units * valueUnity * discount3));

if (units < 5)
{
    Console.WriteLine($"El valor a pagar es: {price1}");
}

else if (units >= 5 && units < 10)
{
    Console.WriteLine($"El valor a pagar es: {price2}");
}

else if (units >= 10)
{
    Console.WriteLine($"El valor a pagar es: {price3}");
}


