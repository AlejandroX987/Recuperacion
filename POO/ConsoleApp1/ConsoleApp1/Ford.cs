using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Ford:Auto// se utiliza la herencia de la clase auto
	{

		public void Agregar(List<Auto> lista)
		{

			Console.WriteLine("Cuantos autos quiere agregar:");
			int numautos = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
			for (int i = 0; i < numautos; i++)// se agregan los autos dependidendo cuantos autos eligio
			{
				Ford ford = new Ford();// se instancia la el objeto y se guardan sus atributos

                Console.WriteLine("----Agregar Autos----");
                ford.Id = i;
				Console.WriteLine("Ingrese la Marca:");
				ford.Marca = Console.ReadLine();
                Console.WriteLine("Ingrese el Modelo:");
                ford.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el Color:");
				ford.Color = Console.ReadLine();
				Console.WriteLine("Ingrese el año del Auto:");
				ford.Anio = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Ingrese el Precio:");
				ford.Precio = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Ingrese la renta por Dia:");
				ford.Cantidad = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Ingrese la cantidad de autos:");
				ford.Cant = Convert.ToInt32(Console.ReadLine());

				lista.Add(ford);// se agrega a la lista el objeto
				Console.Clear();

			}
	

			
		}

		public void Mostrar(List<Auto> lista)
		{
            Console.Clear();
			foreach (var item in lista)// muestra todos los autos con sus propiedades
			{
				Console.WriteLine("-----Mostrar Autos-----");
				Console.WriteLine("Id: " + item.Id + "\nModelo: " + item.Nombre + "\nMarca: " + item.Marca + "\nColor: " + item.Color + "\nAño: " + item.Anio + "\nPrecio: " + item.Precio + "\nRenta por dias: " + item.Cantidad + "\nCantidad: " + item.Cant);

				
			}
			
			Console.ReadKey();
			Console.Clear();
		}
	}
}
