using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1Estructura_AgendaConsola
{
    class Agenda
    {

        //Objects
        List<Contacto> contactos;
        //Builder
        public Agenda()
        {
            //Contacto = new Contacto();
            contactos = new List<Contacto>();
            
        }

        //Create constact
        public void CreateContact(int total)
        {
            if (contactos.Count() < total)
            {
                Contacto contacto = new Contacto();

                Console.WriteLine("Escriba el nombre del contacto: ");
                contacto.Nombre = Console.ReadLine().ToString();

                Console.WriteLine("Escriba La direccion del contacto: ");
                contacto.Direccion = Console.ReadLine().ToString();

                Console.WriteLine("Escriba el codigo postal del contacto: ");
                contacto.Codigo_postal = Console.ReadLine().ToString();

                Console.WriteLine("Escriba el telefono del contacto: ");
                contacto.Telefono = Console.ReadLine().ToString();
                contactos.Add(contacto); Console.WriteLine("Datos saved"); Console.ReadKey();
            }
            else { Console.WriteLine("Sobresalio de la cantidad total de contactos que puesdes tener, cantidad total actual: " + total.ToString());
                Console.WriteLine();
                Console.ReadKey(); }
        }

        //View contacts
        public void ViewContact()
        {
            int contador = 0;
            foreach (var item in contactos)
            {
                contador++;
                Console.WriteLine("Contacto #" + contador.ToString());
                Console.WriteLine("Nombre del contacto: " + item.Nombre);
                Console.WriteLine("Direccion del contacto: " + item.Direccion);
                Console.WriteLine("Postal del contacto: " + item.Codigo_postal);
                Console.WriteLine("Telefono del contacto: " + item.Telefono);
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        //Search for...name and phone
        public void searchContact(string valor)
        {
            Console.WriteLine();
            foreach (var item in contactos)
            {
                if (item.Nombre.Equals(valor) || item.Telefono.Equals(valor))
                {
                    Console.WriteLine("Nombre del contacto: " + item.Nombre);
                    Console.WriteLine("Direccion del contacto: " + item.Direccion);
                    Console.WriteLine("Postal del contacto: " + item.Codigo_postal);
                    Console.WriteLine("Telefono del contacto: " + item.Telefono);
                    Console.WriteLine();
                    Console.ReadLine();
                }
            }
        }

        //Detele a contact
        public void EliminarContacto(string valor)
        {
            Console.WriteLine();
            foreach (var item in contactos)
            {
                if (item.Nombre.Equals(valor))
                {
                    item.Telefono = "";
                    Console.WriteLine("Se ha eliminado el telefono del contacto: " +item.Nombre); Console.ReadKey();
                }
            }
        }

        public void UpdateContacto(string valor, string valor2)
        {
            Console.WriteLine();
            foreach (var item in contactos)
            {
                if (item.Nombre.Equals(valor))
                {
                    item.Telefono = valor2;
                    Console.WriteLine("Se ha actualizado el telefono del contacto: " + item.Nombre); Console.ReadKey();
                }
            }
        }
    }
}
