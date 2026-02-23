int numeros = 0;
int menor = int.MaxValue;
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Ingrese su {i}° número: ");
    Console.WriteLine("");
    numeros = int.Parse(Console.ReadLine());
    Console.WriteLine("");
    if (numeros < menor)
    {
        menor = numeros;
    }
}
Console.WriteLine($"{menor}");