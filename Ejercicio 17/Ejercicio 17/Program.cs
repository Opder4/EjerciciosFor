int numeros = 0;

for (int i = 1; i<=5; i++)
{
    Console.WriteLine($"Ingrese el {i}° número: ");
    Console.WriteLine("");
    numeros = int.Parse(Console.ReadLine());
    Console.WriteLine("");
}
int cantidadpar = 0;
for (int z=1; z<=5; z++)
{
    if (numeros%2==0)
    {
        cantidadpar = z;
    }
}
Console.WriteLine($"la cantidad que son pares son: {cantidadpar}");