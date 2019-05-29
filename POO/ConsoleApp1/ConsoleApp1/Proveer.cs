using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Proveer
	{
		public void Surtir(List<Auto> lista)
		{
			if (lista.Count == 0 || lista==null)
			{
				Console.WriteLine("No hay autos.");
				Console.ReadKey();
				Console.Clear();
			}
			else
			{
			Inicio:
				Console.Clear();
				foreach (var item in lista)
				{
					Console.WriteLine("-----Proveedor-----");
					Console.WriteLine("Auto: " + item.Nombre + "\nID: " + item.Id + "\nCantidad: " + item.Cant);
					Console.WriteLine("-----------");
				}
				try
				{
					Console.WriteLine("Que auto quierer surtir(ingrese el id):");
					int asurtir = Convert.ToInt32(Console.ReadLine());
					if (asurtir < 0)
					{
						Console.WriteLine("Opcion invalida");
						goto Inicio;
					}
					else
					{
						if (asurtir > lista.Count)
						{
							Console.WriteLine("Opcion invalida");
							Console.ReadKey();
						}
						else
						{
							Console.WriteLine("Cuantos quiere autos agregar:");
							int surtir = Convert.ToInt32(Console.ReadLine());
							lista[asurtir].Cant = lista[asurtir].Cant + surtir;
							Console.WriteLine("***Autos Agregados***");
							Console.ReadKey();
						}
					}
				}
				catch (FormatException)
				{
					Console.WriteLine("Opcion invalida");
					Console.ReadKey();
					goto Inicio;
				}

				Console.Clear();
			}
		}
	}
}
