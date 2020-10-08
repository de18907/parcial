using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    class Retirar : Papeleta
	{
		public void retirar()
		{
			Menu mymenu = new Menu();
			Papeleta papeleta = new Papeleta();
			Console.WriteLine("Retiro");
			Console.WriteLine("---------------------------");
			Console.WriteLine("");
			Console.WriteLine("Elige una opcion:");
			Console.WriteLine("1- Retirar");
			Console.WriteLine("2- Volver a menu");
			int opcion = int.Parse(Console.ReadLine());
			switch (opcion)
			{
				case 1:
					Console.Clear();
					Console.WriteLine("Pon el monto que deseo retirar:");
					int retira = int.Parse(Console.ReadLine());
					if (papeleta.monto1 == 100 && papeleta.monto2 == 200 && papeleta.monto3 == 500)
                    {
						int cien, doscientos, quiniento;
                        if (retira % 100 == 0)
                        {
							cien = retira / 100;
							retira = retira % 100;
							doscientos = retira / 200;
							retira = retira % 200;
							quiniento = retira / 500;
							retira = retira % 500;
							Console.WriteLine("El monto en billetes de cien es......." + cien);
							Console.WriteLine("El monto en billetes de cien es......." + doscientos);
							Console.WriteLine("El monto en billetes de cien es......." + quiniento);
							Console.WriteLine("---------------------------");
							Console.WriteLine("Precione enter para continuar");
							Console.ReadKey();
							Console.Clear();
							Console.WriteLine("Si quieres segui retirando escriba 1");
							Console.WriteLine("---------------------------");
							Console.WriteLine("");
							retirar();
						}
                        else
                        {
							Console.WriteLine("monto no valido");
						}
					}
					if (papeleta.monto1 == 200 && papeleta.monto2 == 1000)
					{
						int doscientos, mil;
						if (retira % 100 == 0)
						{
							doscientos = retira / 200;
							retira = retira % 200;
							mil = retira / 1000;
							retira = retira % 1000;
							Console.WriteLine("El monto en billetes de cien es......." + doscientos);
							Console.WriteLine("El monto en billetes de cien es......." + mil);
							Console.WriteLine("---------------------------");
							Console.WriteLine("Precione enter para continuar");
							Console.ReadKey();
							Console.Clear();
							Console.WriteLine("Si quieres segui retirando escriba 1");
							Console.WriteLine("---------------------------");
							Console.WriteLine("");
							retirar();
						}
						else
						{
							Console.WriteLine("monto no valido");
						}
					}
					if (papeleta.monto1 == 100 && papeleta.monto2 == 500)
					{
						int cien, quiniento;
						if (retira % 100 == 0)
						{
							cien = retira / 100;
							retira = retira % 100;
							quiniento = retira / 500;
							retira = retira % 500;
							Console.WriteLine("El monto en billetes de cien es......." + cien);
							Console.WriteLine("El monto en billetes de cien es......." + quiniento);
							Console.WriteLine("---------------------------");
							Console.WriteLine("Precione enter para continuar");
							Console.ReadKey();
							Console.Clear();
							Console.WriteLine("Si quieres segui retirando escriba 1");
							Console.WriteLine("---------------------------");
							Console.WriteLine("");
							retirar();
						}
						else
						{
							Console.WriteLine("monto no valido");
						}
					}
					break;
				case 2:
					Console.Clear();
					mymenu.menu();
					break;
				default:
					Console.Clear();
					Console.WriteLine("Algo salio mal vuelve a intentarlo escriba una de las dos opciones 1 o 2.");
					retirar();
					break;
			}
		}
		public void retirar2()
		{
			Console.WriteLine("Desea poner otro monto o terminar la transacion?");
			Console.WriteLine("1- Poner otro monto");
			Console.WriteLine("2- terminar la transacion");
			int opcion12 = int.Parse(Console.ReadLine());
			switch (opcion12)
			{
				case 1:
					// editar monto
					break;
				case 2:
					// Las especificaciones de lo que se entrega (eje 4 papeleta de $*)
					break;
				default:
					Console.Clear();
					Console.WriteLine("Algo salio mal vuelve a intentarlo escriba una de las dos opciones 1 o 2");
					retirar();
					break;
			}
		}
	}
}
