using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    class Papeleta
	{
		public string nombre { get; set; } = "Papeleta eficiente";
		public int monto1 { get; set; } = 100;
		public int monto2 { get; set; } = 200;
		public int monto3 { get; set; } = 500;
		public virtual void papeleta(string nombree, int monto11, int monto22, int monto33){
			nombre = nombree;
			monto1 = monto11;
			monto2 = monto22;
			monto3 = monto33;
		}
	}
}
