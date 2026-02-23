int numero = 0;
int x = 0;

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Ingrese el {i}° número: ");
    Console.WriteLine("");
    numero = int.Parse(Console.ReadLine()) + numero;
    Console.WriteLine("");
    x = i;
}
Console.WriteLine($"El promedio es {numero/x}");