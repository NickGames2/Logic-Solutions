Console.Write("Ingrese el número a descomponer: ");

if (int.TryParse(Console.ReadLine(), out int n))
{
    int original = n;
    string factoresFormateados = "";
    int divisor = 2;

    Console.WriteLine("\nProceso de descomposición:");
    Console.WriteLine("--------------------------");

    // Este bucle se repite hasta que el número llega a 1
    while (n > 1)
    {
        if (n % divisor == 0)
        {
            // Muestra la fila actual: Número | Divisor
            Console.WriteLine($"{n,5} | {divisor}");

            // Guarda el factor para el mensaje final
            factoresFormateados += (factoresFormateados == "" ? "" : " x ") + divisor;

            // Divide el número para seguir descomponiendo
            n /= divisor;
        }
        else
        {
            // Si no es divisible por el actual, probamos con el que sigue (3, 4, 5...)
            divisor++;
        }
    }

    // Al final siempre queda el 1 en la columna de la izquierda
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