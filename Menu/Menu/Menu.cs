using System;

namespace Menu
{
    class Menu
    {
        static void Main(string[] args){Menu mymenu = new Menu(); mymenu.menu();}
		public void menu()
		{
			Retirar myretirar = new Retirar();
			Configuracion myconfiguracion = new Configuracion();
			Console.WriteLine("Menu de transacciones");
			Console.WriteLine("---------------------------");
			Console.WriteLine("");
			Console.WriteLine("Elige una opcion:");
			Console.WriteLine("1- Configurar el modo de dispensacion");
			Console.WriteLine("2- Retirar");
			int opcion = int.Parse(Console.ReadLine());
			switch (opcion)
			{
				case 1:
					Console.Clear();
					myconfiguracion.configuracion();
					break;
				case 2:
					Console.Clear();
					myretirar.retirar();
					break;
				default:
					Console.Clear();
					Console.WriteLine("Algo salio mal vuelve a intentarlo escriba una de las dos opciones 1 o 2.");
					Console.WriteLine("Preciona enter para continuar.");
					Console.ReadKey();
					Console.Clear();
					menu();
					break;
			}
		}
	}
}