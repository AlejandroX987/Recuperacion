using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Operacion
    {
        public void Ventas(List<Auto> vendidos,List<Auto> rentados)
        {
		
            if (vendidos.Count==0 && rentados.Count==0)// s evalua si la lista esta vacia
            {
                Console.WriteLine("No hay ventas.");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
				Inicio:
				try
				{
					Console.WriteLine("Que desea hacer. \n1)Guardar Ventas y rentas \n2)Ver Ventas y rentas");// se pregunta que desea hacer, se usa StreamWriter y StreamReader
					int opventas = Convert.ToInt32(Console.ReadLine());
					switch (opventas)
					{
						case 1:
							using (StreamWriter outputFile = new StreamWriter("E:\\Alexapp\\ConsoleApp1\\Ventas.text"))// se guarda en la direccion seleccionada
							{
								foreach (var item in vendidos)
								{
									outputFile.WriteLine("Cliente:"+item.Nombrecliente+"  Id: " + item.Id + "  Marca: " + item.Marca + "  Precio: " + item.Precio);// propiedades que se guardan
								}

							}
							using (StreamWriter outputFile = new StreamWriter("E:\\Alexapp\\ConsoleApp1\\Rentas.text"))// se guarda en la direccion seleccionada
							{
								foreach (var item in rentados)
								{
									outputFile.WriteLine("Cliente: "+item.Nombrecliente+"  Id: " + item.Id + "  Marca: " + item.Marca + "  Precio: " + item.Cantidad);// propiedades que se guardan
								}
								Console.WriteLine("Se guardaron las Ventas y rentas.");
								Console.ReadKey();
								Console.Clear();
							}

							break;

						case 2:
							using (StreamReader outpuFie = new StreamReader("E:\\Alexapp\\ConsoleApp1\\Ventas.text"))// se muestran las ventas que estan en la direccion
							{
								Console.Clear();
								Console.WriteLine("-----Autos-----");
								Console.WriteLine("1)Ver ventas \n2)Ver rentas");
								int deci = Convert.ToInt32(Console.ReadLine());
								if (deci==1)
								{
									foreach (var item in vendidos)
									{
										Console.WriteLine("------Autos Vendidos------");
										Console.WriteLine("Cliente:" + item.Nombrecliente+"\nId: " + item.Id + "\nMarca: " + item.Marca + "\nPrecio: " + item.Precio);// propiedqades que se muetran.

									}
									Console.ReadKey();
									Console.Clear();
								}
								 else if(deci==2)
								{
									foreach (var item in rentados)
									{
										Console.WriteLine("------Autos Rentados------");
										Console.WriteLine("Cliente: " + item.Nombrecliente + "\nId: " + item.Id + "\nMarca: " + item.Marca + "\nPrecio: " + item.Cantidad);// propiedqades que se muetran.

									}
									Console.ReadKey();
									Console.Clear();

								}


							}

							break;

						default:
							break;
					}

				}
				catch (FormatException)
				{

					Console.WriteLine("Opcion invalida.");// captura si la opcion es invalida.
					Console.ReadKey();
					Console.Clear();
					goto Inicio;
				}

            }

        }
    }
}
