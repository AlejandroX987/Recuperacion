using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

	class Program
	{
		static List<Auto> lista = new List<Auto>();
        static List<Auto> vendidos = new List<Auto>();
		static List<Auto> rentados = new List<Auto>();

		static void Main(string[] args)
		{
		Inicio:// etiqueta
			Menu menu = new Menu(lista,vendidos,rentados);// se instancia la clase y en la clase menu es un constructor, no ocupa llamar al metodo.
			
			goto Inicio;// se regresa a la etiqueta.
		}
	}
}
