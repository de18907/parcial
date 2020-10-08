using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    class Configuracion
	{
		public void configuracion()
		{
			Menu mymenu = new Menu();
			Papeleta papeleta1 = new Papeleta1();
			Papeleta papeleta2 = new Papeleta2();
			Papeleta papeleta3 = new Papeleta3();
			Console.WriteLine("Configuracion");
			Console.WriteLine("---------------------------");
			Console.WriteLine("");
			Console.WriteLine("Elige una opcion:");
			Console.WriteLine("1- eficiente papeleta 100, 200, 500");
			Console.WriteLine("2- Papeleta de 200 y 1000");
			Console.WriteLine("3- Papeleta de 100 y 500");
			Console.WriteLine("4- Volver al menu");
			int opcion = int.Parse(Console.ReadLine());
			switch (opcion)
			{
				case 1:
					Console.Clear();
					papeleta1.papeleta("Papeleta eficiente", 100, 200, 500);
					break;
				case 2:
					Console.Clear();
					papeleta2.papeleta("Papeleta 2", 100, 500, 0);
					break;
				case 3:
					Console.Clear();
					papeleta3.papeleta("Papeleta 1", 200, 1000, 0);
					break;
				case 4:
					Console.Clear();
					mymenu.menu();
					break;
				default:
					Console.Clear();
					Console.WriteLine("Algo salio mal vuelve a intentarlo escriba una de las dos opciones 1 o 2.");
					Console.WriteLine("Preciona enter para continuar.");
					Console.ReadKey();
					Console.Clear();
					configuracion();
					break;
			}
		}
	}
}
