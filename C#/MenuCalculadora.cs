using System;
namespace Calculadora
{
	Class Program
	{
		///<summary>
		///Muestra el menu de la aplicacion
		///</summary>
		static void MostrarMenu() //Funcion
		{
			Console.WriteLine("Que queres hacer?");
			Console.WriteLine();
			Console.WriteLine("1- Sumar dos numeros");
			Console.WriteLine("2- Multiplicar dos numeros");
			Console.WriteLine("0-Salir");
		}
		static void Main (string[]args)
		{
			Console.WriteLine("Bienvenido a la Calculadora");
			MostrarMenu(); //Llamado a la funcion 
			
			int opcion = int.Parse(Console.ReadLine());
			while(opcion!=0){
				switch(opcion)
				{
					case 1:
					//Sumar todo
					break;
					case 2:
					//Multiplicar
					break;
					default:
					Console.WriteLine("Opcion invalida");
					MostrarMenu();
					opcion = int.Parse(Console.ReadLine());
					break;
				}
			}
			Console.WriteLine("Fin");
			Console.ReadKey();
		}
	}
}
