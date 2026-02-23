Console.WriteLine("Ingrese la cantidad de ventas que ha tenido: ");
Console.WriteLine("");
int cantidadventas=int.Parse(Console.ReadLine());
double totalventas = 0;
for (int i=1; i<=cantidadventas; i++)
{
    Console.WriteLine("");
    Console.WriteLine($"Ingrese el monto de la {i}° venta: ");
    Console.WriteLine("");
    double ventas = double.Parse(Console.ReadLine());
    totalventas = totalventas + ventas;
}
Console.WriteLine("");
Console.WriteLine($"El total de las ventas es de Q{totalventas}");
