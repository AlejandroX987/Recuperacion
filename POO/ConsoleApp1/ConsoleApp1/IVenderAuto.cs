using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public interface IVenderAuto// intefaz con el metodo vender
	{
		void Vender(List<Auto> lista, List<Auto> vendidos);
		
	}
}
