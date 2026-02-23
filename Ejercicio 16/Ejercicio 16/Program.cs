int numero = 0;
int cantidad = 0;

    for (int i=1; i<=5; i++)
{
    Console.WriteLine($"Ingrese el {i}° número: ");
    Console.WriteLine("");
    numero=int.Parse(Console.ReadLine());
    Console.WriteLine("");
    if (numero>10)
    {
        cantidad = cantidad + 1;
    }
}
Console.WriteLine($"La cantidad de números que son mayores que 10 son {cantidad}");


