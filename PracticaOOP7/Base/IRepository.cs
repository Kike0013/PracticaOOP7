﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOOP7.Base
{
    public interface IRepository<T> where T : class
    {
        void Agregar(T entity);
        void Actualizar(T entity);
        void Remover(T entity);
        List<T> TraerTodos();
        T ObtenerPorId(int id);
    }

}
