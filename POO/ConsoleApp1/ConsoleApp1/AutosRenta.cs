using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class AutosRenta : Rentar// aqui se usa la clase abstracta y se utilizan sus atributos
	{
		public  void Rentar(List<Auto>lista,List<Auto> rentados)

		{
            Console.Clear();
			Inicio:
            Console.WriteLine("-----Rentar Autos-----");
			foreach (var item in lista)// este foreach muestra todos los autos agregados en la lista
			{
				Console.WriteLine("--------------------------------");
				Console.WriteLine("Auto: " + item.Nombre + "\nID: " + item.Id);// se muestra el nombre y el id del auto
				Console.WriteLine("--------------------------------");
			}
			try
			{
				Console.WriteLine("Que auto desea rentar (digite el id)");
				rentard = Convert.ToInt32(Console.ReadLine());// se guarda el id para rentar el auto correspopndiente del id
				if (lista[rentard].Cant==0)
				{
					Console.WriteLine("No hay mas autos.");
					Console.ReadKey();
					Console.Clear();
					
					
				}
				else
				{
					if (rentard > lista.Count)
					{
						Console.WriteLine("Opcion Invalida");
					}
					else
					{
						Console.Clear();
						Ford rentado = new Ford();
						Console.WriteLine("Ingrese su nombre: ");
						rentado.Nombrecliente = Console.ReadLine();
						Console.WriteLine("Marca: " + lista[rentard].Marca + "\nAño: " + lista[rentard].Anio + "\nPrecio: " + lista[rentard].Cantidad);// se muestra el auto que selecciono
						Console.WriteLine("Cuantos dias quiere rentarlo:");// pregunta cuantos dias quiere rentarlo
						dias = Convert.ToInt32(Console.ReadLine());
						total = lista[rentard].Cantidad * dias;//calcula el total
						lista[rentard].Cant = lista[rentard].Cant - 1;
						Console.Clear();
						Console.WriteLine("----------Auto Rentado---------");// se muestra el auto rentado con unas caracteristicas
						Console.WriteLine("Marca: " + lista[rentard].Marca);
						Console.WriteLine("Renta por dia: " + lista[rentard].Cantidad);
						Console.WriteLine("Dias rentados: " + dias);
						Console.WriteLine("Pago total: " + total);
						Console.WriteLine("-------------------------------");
						rentado.Id = lista[rentard].Id;
						rentado.Marca = lista[rentard].Marca;
						rentado.Cantidad = lista[rentard].Cantidad;
						rentados.Add(rentado);

					}
				}


			}
			catch(FormatException)
			{
				Console.WriteLine("Opcion invalida");
				goto Inicio;
			}
			Console.ReadKey();
			Console.Clear();

		}
	}
}
