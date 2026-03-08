Console.Write("Ingrese el número a descomponer: ");

if (int.TryParse(Console.ReadLine(), out int n))
{
    int original = n;
    string factoresFormateados = "";
    int divisor = 2;

    Console.WriteLine("\nProceso de descomposición:");
    Console.WriteLine("--------------------------");

    while (n > 1)
    {
        if (n % divisor == 0)
        {
            Console.WriteLine($"{n,5} | {divisor}");

            factoresFormateados += (factoresFormateados == "" ? "" : " x ") + divisor;

            n /= divisor;
        }
        else
        {
            divisor++;
        }
    }

    Console.WriteLine($"{1,5} |");
    Console.WriteLine("--------------------------");

    Console.WriteLine($"\nResultado: {original} = {factoresFormateados}");
}
else
{
    Console.WriteLine("Entrada no válida.");
}

Console.WriteLine("\nPresione cualquier tecla para salir...");
Console.ReadKey();