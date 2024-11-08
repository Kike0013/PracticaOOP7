using PracticaOOP7.Context;
using PracticaOOP7.Entities;
using PracticaOOP7.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOOP7
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new EjemploContext();
            var asientoRepo = new AsientoRepository(context);

            Console.WriteLine("El código de la asignación ha sido refactorizado utilizando genéricos.\n");

            // Agregar nuevo asiento
            var asiento = new Asiento
            {
                Asientold = 1,
                Busld = 101,
                NumeroPiso = 1,
                NumeroAsiento = 20,
                FechaCreacion = DateTime.Now
            };
            asientoRepo.Agregar(asiento);

            // Obtener todos los asientos
            var asientos = asientoRepo.TraerTodos();
            Console.WriteLine("Asientos:");
            foreach (var a in asientos)
            {
                Console.WriteLine($"ID: {a.Asientold}, BusID: {a.Busld}, Piso: {a.NumeroPiso}, Asiento: {a.NumeroAsiento}");
            }

            Console.ReadKey();

        }
    }
}
