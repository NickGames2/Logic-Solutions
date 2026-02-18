Console.Write("Numero de creditos: ");
var creditsString = Console.ReadLine();
int creditsInt = int.Parse(creditsString);

Console.Write("Valor del credito: ");
var valueString = Console.ReadLine();
int valueInt = int.Parse(valueString);

Console.Write("Estrato del estudiante: ");
var strateString = Console.ReadLine();
int strateInt = int.Parse(strateString);

double discount1 = (double)0.80;
double discount2 = (double)0.50;
double discount3 = (double)0.30;

int tuitionPrice1 = (int)((creditsInt * valueInt) - (creditsInt * valueInt * discount1));
int tuitionPrice2 = (int)((creditsInt * valueInt) - (creditsInt * valueInt * discount2));
int tuitionPrice3 = (int)((creditsInt * valueInt) - (creditsInt * valueInt * discount3));

int ExtraCredits = creditsInt - 20;
int Creditmax = (int)((20 * valueInt) + (ExtraCredits * valueInt * 2));

int tuitionPrice4 = (int)(Creditmax * discount1);
int tuitionPrice5 = (int)(Creditmax * discount2);
int tuitionPrice6 = (int)(Creditmax * discount3);

int Subside1 = 200000;
int Subside2 = 100000;


if (creditsInt <= 20) { 


    if (strateInt == 1)
    {
        Console.WriteLine($"Costo de matirucula: {tuitionPrice1}");
    }

    if (strateInt == 2)
    {
        Console.WriteLine($"Costo de matirucula: {tuitionPrice2}");
    }
    
    if (strateInt == 3)
    {
    Console.WriteLine($"Costo de matirucula: {tuitionPrice2}");
    }
}

if (creditsInt > 20)
{
    if(strateInt == 1)
    {
        Console.WriteLine($"Costo de matirucula: {tuitionPrice4}");
    }

    if(strateInt == 2)
    {
        Console.WriteLine($"Costo de matirucula: {tuitionPrice5}");
    }
    
    if(strateInt == 3)
    {
        Console.WriteLine($"Costo de matirucula: {tuitionPrice6}");
    } 
}
 if (strateInt == 1)
{
    Console.WriteLine($"Su subsidio es de: {Subside1}");
}
else if (strateInt == 2)
{
    Console.WriteLine($"Su subsidio es de: {Subside2}");
}
