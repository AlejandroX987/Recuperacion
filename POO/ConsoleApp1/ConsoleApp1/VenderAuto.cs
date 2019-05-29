using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class VenderAuto:IVenderAuto// se utiliza el metodo
	{
		public void Vender(List<Auto> lista,List<Auto> vendidos)
		{
            Console.Clear();
            Console.WriteLine("-----Comprar Auto-----");
			foreach (var item in lista)// muestra todos los autos de la lista
			{
				Console.WriteLine("--------------------------------");
				Console.WriteLine("ID: " + item.Id + "\nModelo: "+item.Marca +"\nAuto: " + item.Nombre + "\nPrecio: " + item.Precio+"\nAño: "+ item.Anio+ "\nColor: "+ item.Color);
				Console.WriteLine("--------------------------------");
			}
		Inicio:
			try
			{

				Console.WriteLine("Que auto desea comprar (ingrese al id): ");// se selecciona el id del cuanto que se desee comprar
				int comprar = Convert.ToInt32(Console.ReadLine());
				if (lista[comprar].Cant == 0)
				{
					Console.WriteLine("No hay autos");
					Console.ReadKey();
					Console.Clear();				}
				else
				{

					
					Console.WriteLine("El auto cuesta: " + lista[comprar].Precio);// se nuestra el precio del auto seleccionado
					Console.WriteLine("Esta seguro:\n1)Si\n2)No");
					int seguro = Convert.ToInt32(Console.ReadLine());// se prueba si de verdad lo quiere comprar
					if (seguro == 1)
					{
						Console.Clear();
						Ford vendido = new Ford();
						Console.WriteLine("Ingrese su nombre: ");
						vendido.Nombrecliente = Console.ReadLine();
						lista[comprar].Cant = lista[comprar].Cant - 1;
						Console.WriteLine("--------Auto Comprado--------");
						Console.WriteLine("ID: " + lista[comprar].Id + "\nModelo: " + lista[comprar].Marca + "\nAuto: " + lista[comprar].Nombre + "\nPrecio: " + lista[comprar].Precio + "\nAño: " + lista[comprar].Anio + "\nColor: " + lista[comprar].Color);

						Console.WriteLine("-----------------------------");
						vendido.Id = lista[comprar].Id;
						vendido.Marca = lista[comprar].Marca;
						vendido.Precio = lista[comprar].Precio;
						vendidos.Add(vendido);// el auto que se compra se agrega a la lista vendido, donde se guardaran todos los autos vendidos
						Console.ReadKey();
						Console.Clear();

					}
					else
					{
						Console.WriteLine("No compraste nada");// se muestra el mensaje si la opcion es no.
						Console.ReadKey();
						Console.Clear();
					}
				}
			}
			catch (FormatException)
			{

				Console.WriteLine("Error");// error si la opcion seleccionada es invalida
				goto Inicio;
			}

		}
		
	}
}
