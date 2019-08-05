using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1Estructura_AgendaConsola
{
    class Menu
    {
        int totalContacto = 0;
        string bandera1;
        string bandera2 = "s";
        string bandera3;
        Agenda agenda;

        //Builser
        public Menu()
        {
            agenda = new Agenda();
        }

        public void pedirTotal()
        {
            try
            {
                Console.WriteLine("ITLA-Create by: Angel Maria Perez (Khahory) - Mi organizacion: GermaAf"); Console.WriteLine();
                Console.WriteLine("Por favor diganos de cuantos contactos sera la agenda");
                totalContacto = int.Parse(Console.ReadLine());
                Console.WriteLine("Gracias - precione ENTER to continue"); Console.ReadLine();
                mostrarMenuMain();
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrucio un error, por favor digite un numero"); Console.ReadKey();
                pedirTotal();
            }
        }

        public void mostrarMenuMain()
        {
            Console.WriteLine("Bienvenido a su nueva agenda, por favor digite el numero de la actividad que desea hacer");
            Console.WriteLine();
            Console.WriteLine("1 - Guardar un contacto");
            Console.WriteLine("2 - Ver mis contactos");
            Console.WriteLine("3 - Buscar entre mis contactos");
            Console.WriteLine("4 - Eliminar telefono de un cotacto");
            Console.WriteLine("5 - Actualizar telefono de un cotacto");
            Console.WriteLine("Cualquier tecla otra tecla para salir");
            bandera1 = Console.ReadLine(); Console.WriteLine();

            switch (bandera1)
            {
                case "1":
                    do
                    {
                        agenda.CreateContact(totalContacto);
                        Console.WriteLine("Deseas agregar a otro contacto a tu agenda ?  S o N");
                        bandera2 = Console.ReadLine();
                    } while (bandera2.Equals("s"));
                    mostrarMenuMain();
                    break;

                case "2":
                    agenda.ViewContact();
                    mostrarMenuMain();
                    break;

                case "3":
                    mostarNenuBuscar();
                    break;

                case "4":
                    MostrarMenuEliminarContacto();
                    break;

                case "5":
                    MostrarMenuUpdate();
                    break;
            }
        }

        //Menu Search
        public void mostarNenuBuscar()
        {
            Console.WriteLine("Por cual metodo te gustaria buscar a tu contacto ? Selecciona escribiendo el numero correspondiente");
            Console.WriteLine("1 - Buscar por el nombre");
            Console.WriteLine("2 - Buscar por el telefono");
            Console.WriteLine("3 - Cancelar y volver al menu principal");
            bandera3 = Console.ReadLine(); Console.WriteLine();
            switch (bandera3)
            {
                case "1":
                    Console.WriteLine("Digita el nombre del contacto que quieres buscar");
                    agenda.searchContact(Console.ReadLine());
                    Console.WriteLine("Precione ENTER to continue");
                    Console.ReadKey();
                    mostarNenuBuscar();
                    break;

                case "2":
                    Console.WriteLine("Digita el telefono del contacto que quieres buscar");
                    agenda.searchContact(Console.ReadLine());
                    Console.WriteLine("Precione ENTER to continue");
                    Console.ReadKey();
                    mostarNenuBuscar();
                    break;

                default:
                    mostrarMenuMain();
                    break;
            }
            Console.WriteLine();
        }

        //Menu delete
        public void MostrarMenuEliminarContacto()
        {
            Console.WriteLine("Digite el nombre del contacto al cual le desea eliminar el telefono");
            agenda.EliminarContacto(Console.ReadLine());
            Console.WriteLine("Listo -- ENTER to continue");
            Console.ReadKey();
            mostrarMenuMain();
        }

        public void MostrarMenuUpdate()
        {
            Console.WriteLine("Digite el nombre del contacto al cual le desea actualizar el telefono");
            var x = Console.ReadLine();
            Console.WriteLine("Digite el nuevo numero");
            var y = Console.ReadLine();
            agenda.UpdateContacto(x, y);
            Console.WriteLine("Listo -- ENTER to continue");
            Console.ReadKey();
            mostrarMenuMain();
        }
    }
}
