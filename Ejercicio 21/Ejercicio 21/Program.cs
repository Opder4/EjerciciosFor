Console.WriteLine("Ingrese la cantidad de numeros que quiera: ");
Console.WriteLine("");
int numero = int.Parse(Console.ReadLine());
int cantidad = 0;
int numeros = 0;
for (int i = 1; i <= numero; i++)
{
    Console.WriteLine("");
    Console.WriteLine($"Ingrese su {i}° número: ");
    Console.WriteLine("");
    numeros = int.Parse(Console.ReadLine());
    Console.WriteLine("");
    if (numeros < 0)
    {
        cantidad = cantidad + 1;
    }
}

Console.WriteLine($"Los cantidad de números negativos son {cantidad}");