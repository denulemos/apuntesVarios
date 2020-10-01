using System;
namespace Menu
{
class Program
{
static void MostrarMenu() //Funcion
{
Console.WriteLine(“Seleccione qué hacer”);
Console.WriteLine(“1-Opcion 2”);
Console.WriteLine(“2-Opción 2”);
}

static void Main(String[]args)
{
Console.WriteLine(“Bienvenido!”):
MostrarMenu() //Llamado a funcion
int opcion =int.Parse(Console.ReadLine());
{
switch (opcion)
{
case 1:
break;
case 2:
break;
default:
Console.WriteLine(“Inválido”);
break;
}
}
Console.ReadKey();
}}
