int numero = 0;

    for (int i=1; i<=5; i++)
{
    Console.WriteLine($"Ingrese el {i}° número: ");
    Console.WriteLine("");
    numero=int.Parse(Console.ReadLine());
    Console.WriteLine("");
}
int cantidad = 0;
    for (int z=1; z<=5; z++)
{
    if (numero>10)
    {
        cantidad = z;
    }
}
Console.WriteLine($"Los que cumplen son mayor a 10 son: {cantidad}");


