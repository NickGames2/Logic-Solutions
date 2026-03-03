Console.Write("Ingrese el peso de la mercancia: ");
var mercancyString = Console.ReadLine();
int mercancyInt = int.Parse(mercancyString);

Console.Write("Valor de la mercancia: ");
var VolummecancyString = Console.ReadLine();
int VolummercancyInt = int.Parse(VolummecancyString);

int Feextra = mercancyInt - 200;
int Fee1 = 20000;
int Fee2 = 25000;
int Fee3 = 30000;
int Fee4 = 35000;

bool monday = true;
bool Payment = true;


if (mercancyInt < 100)
{
    Console.WriteLine($"La tarifa de venta es  {Fee1}");
}
 if (mercancyInt > 100 && mercancyInt < 150)
{
    Console.WriteLine($"La tarifa de venta es  {Fee2}");
}
 if (mercancyInt > 150 && mercancyInt <= 200)
{
    Console.WriteLine($"La tarifa de venta es  {Fee3}");
}
  if (mercancyInt > 200)
{
    Console.WriteLine($"La tarifa es de {Fee4 + (Feextra / 10) * 2000}");
}


