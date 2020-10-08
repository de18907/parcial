using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    class Papeleta2 : Papeleta
	{
		public override void papeleta(string nombre, int monto1, int monto2, int monto3)
		{
			Menu mymenu = new Menu();
			Papeleta papeleta = new Papeleta();
			papeleta.nombre = nombre;
			papeleta.monto1 = monto1;
			papeleta.monto2 = monto2;
			papeleta.monto3 = monto3;
			Console.WriteLine("Configuraste " + "para papeletas de " + papeleta.monto1 + "" + "y de " + papeleta.monto2);
			Console.WriteLine("---------------------------------------------------------------------------------------");
			mymenu.menu();
		}
	}
}
