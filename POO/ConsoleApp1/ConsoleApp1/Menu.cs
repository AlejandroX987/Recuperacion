using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Menu
	{
		public Menu(List<Auto> lista, List<Auto> vendidos,List<Auto> rentados)
		{
		Inicio:
			try// prueba que la opcion seleccionada sea correcta
			{

				Console.Clear();
				Console.WriteLine("---Bienvenido a Mis Autos---");
				Console.WriteLine("1)Agregar Auto\n2)Mostrar Autos \n3)Rentar Auto \n4)Vender Auto \n5)Guardar y Ver Ventas \n6)Proveedor \n7)Salir");
                Console.WriteLine("----------------------------");
				int menu = Convert.ToInt32(Console.ReadLine());// la respuesta se guarda en la variable menu.

				Ford ford = new Ford();// se instancian todos los objetos antes de entrar al switch
				AutosRenta autosrenta = new AutosRenta();
				VenderAuto venderAuto = new VenderAuto();
                Operacion operacion = new Operacion();
				Proveer proveer = new Proveer();
				
				switch (menu)
				{
					case 1:
						ford.Agregar(lista);// se llama al metodo agregar del objeto ford, pasando la lista
						break;

					case 2:
						if (lista == null || lista.Count() == 0)// se evalua si la lista esta vacia o no, en caso de que este vacia se regegresa y muestra en mensaje
						{
							Console.WriteLine("No hay autos que mostrar.");
							Console.ReadKey();
							Console.Clear();
							goto Inicio;
						}
						else
						{ 
							ford.Mostrar(lista);// si la lista no esta vacia se llama al metodo mostrar, de igual manera pasando la lista
						}
						break;

					case 3:
						if (lista == null || lista.Count () ==0)// se evalua para saber si no esta vacia, y se muestra el mensaje
						{
							Console.WriteLine("No hay autos que rentar.");
							Console.ReadKey();
							Console.Clear();
							goto Inicio;
						}
						else
						{
							autosrenta.Rentar(lista,rentados);// se llama al metodo rentar con la lista como parametro
						}

						break;

					case 4:
						if (lista == null || lista.Count() == 0)//evalua si la lista esta vacia, sino muestra el mensaje
						{
							Console.WriteLine("No hay autos que vender.");
							Console.ReadKey();
							Console.Clear();
							goto Inicio;
						}
						else
						{
							venderAuto.Vender(lista, vendidos);// se llama al metodo vender del objeto venderauto y se pasan dos lista, la lista general de los autos introducidos y la otra donde se guardaran los autos vendidos
						}
						break;

                    case 5:
                        if (rentados.Count == 0 && vendidos.Count == 0)// si en la opcion anterior no hay autos vendidos(lista vacia), se mostrara el mensaje
                        {
                            Console.WriteLine("No hay ventas registradas.");
                            Console.ReadKey();
                            Console.Clear();
                            goto Inicio;
                        }
                        else
                        {
                            operacion.Ventas(vendidos,rentados);// si tienen objetos en la lista se llama el metodo ventas, pasando la lista vendidos.
                        }
                        break;

					case 6:
						proveer.Surtir(lista);
						break;

					case 7:
						Environment.Exit(1);// la opcion cierra el programa 
						break;


					default:
						break;
				}
			}
			catch (FormatException)
			{
				Console.WriteLine("Opcion Invalida");// esto se da si se introduce una opcion invalida
				goto Inicio;
			}

		}
	}
}
