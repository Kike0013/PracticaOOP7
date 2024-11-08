using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaOOP7.Interfaces;
using PracticaOOP7.Context;
using PracticaOOP7.Base;
using PracticaOOP7.Entities;

namespace PracticaOOP7.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly EjemploContext _context;

        public Repository(EjemploContext context)
        {
            _context = context;
        }

        public void Agregar(T entity)
        {
            // Aquí podríamos realizar la lógica para agregar la entidad al contexto simulado
            if (typeof(T) == typeof(Asiento))
            {
                _context.Asientos.Add(entity as Asiento);
            }
        }

        public void Actualizar(T entity)
        {
            // Implementación para actualizar la entidad
        }

        public T ObtenerPorId(int id)
        {
            if (typeof(T) == typeof(Asiento))
            {
                return _context.Asientos.FirstOrDefault(a => a.Asientold == id) as T;
            }
            return null;
        }

        public void Remover(T entity)
        {
            if (typeof(T) == typeof(Asiento))
            {
                _context.Asientos.Remove(entity as Asiento);
            }
        }

        public List<T> TraerTodos()
        {
            if (typeof(T) == typeof(Asiento))
            {
                return _context.Asientos.Cast<T>().ToList();
            }
            return new List<T>();
        }
    }
}
