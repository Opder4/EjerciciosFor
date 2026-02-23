int numero = 0;
for (int i = 1; i <= 3; i++)
{
    Console.WriteLine($"Ingrese su {i}° número : ");
    Console.WriteLine("");
    numero= int.Parse(Console.ReadLine()) + numero;
    Console.WriteLine("");
}
Console.WriteLine($"El total es {numero}");