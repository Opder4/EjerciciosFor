using System.Timers;

Console.WriteLine("Ingresa la cantidad total de notas de notas a ingresar: ");
Console.WriteLine("");
int cantidadnotas = int.Parse(Console.ReadLine());
double totalnotas = 0;
double notafinal = 0;
int x = 0;
for (int i = 1; i <= cantidadnotas; i++)
{
    Console.WriteLine("");
    Console.WriteLine($"Ingrese la {i}° nota: ");
    Console.WriteLine("");
    notafinal = double.Parse(Console.ReadLine());
    totalnotas = totalnotas + notafinal;
    x = i;
}
if ((totalnotas / x) >= 61)
{
    Console.WriteLine("");
    Console.WriteLine($"El promedio final es de {totalnotas / x}");
    Console.WriteLine("");
    Console.WriteLine("El alumno está Aprobado");
}
else
{
    Console.WriteLine("");
    Console.WriteLine($"El promedio final es de {totalnotas / x}");
    Console.WriteLine("");
    Console.WriteLine("El alumno está Desaprobado");
}