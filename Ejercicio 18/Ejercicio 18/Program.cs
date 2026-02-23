int numeros = 0;
int mayor = int.MinValue;
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Ingrese su {i}° número: ");
    Console.WriteLine("");
    numeros = int.Parse(Console.ReadLine());
    Console.WriteLine("");
    if (numeros>mayor)
    {
        mayor=numeros;
    }
}
Console.WriteLine($"{mayor}");



