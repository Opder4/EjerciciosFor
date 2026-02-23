int numeros = 0;
int cantidad = 0;

for (int i = 1; i<=5; i++)
{
    Console.WriteLine($"Ingrese el {i}° número: ");
    Console.WriteLine("");
    numeros = int.Parse(Console.ReadLine());
    Console.WriteLine("");
    if (numeros%2==0)
    {
        cantidad = cantidad + 1;
    }
}
Console.WriteLine($"la cantidad de números pares son {cantidad}");