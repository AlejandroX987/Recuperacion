using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER_Valverde
{
    public class Menu
    {
        public Menu()
        {
            Empleado empleado = new Empleado();
            Inicio:

            Console.WriteLine("Que desea hacer?");
            Console.WriteLine("1)Agregar \n2)Mostrar");
            int menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:

                    empleado.Agregar();

                    break;

                case 2:
                    empleado.Mostrar(lista);

                    break;
                default:
                    break;
            }
            goto Inicio;
        }
    }
}
