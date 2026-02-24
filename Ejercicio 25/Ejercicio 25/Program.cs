Console.WriteLine("Ingrese un número: ");
Console.WriteLine("");
int numero=int.Parse(Console.ReadLine());
string salida = "";
for (int i=1;  i<=numero; i++)
{
    salida = salida + "*";
    Console.WriteLine(salida);
}
