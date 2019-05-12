using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER_Valverde
{
    public class Empleado : Persona
    {
        public void Agregar()
        {
            Empleado empleado = new Empleado();
            List<Empleado> lista = new List<Empleado>();
            Console.WriteLine("Cuantas personas desea ingresar?");
            int pers = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < pers; i++)
            {
                Console.WriteLine("ingrese el id:");
                empleado.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese el nombre:");
                empleado.Nombre = Convert.ToString(Console.ReadLine());

                lista.Add(empleado);

            }
            Console.WriteLine(lista.);



        }

        public void Mostrar(List<Empleado> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("Id: " + item.Id + " " + "\nNombre: " + item.Nombre);
                Console.WriteLine("--------------------------");
            }
            Console.ReadKey();
        }
    }
}
