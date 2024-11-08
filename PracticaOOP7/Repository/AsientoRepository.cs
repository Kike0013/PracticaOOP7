using PracticaOOP7.Entities;
using PracticaOOP7.Interfaces;
using PracticaOOP7.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOOP7.Repository
{
    public class AsientoRepository : Repository<Asiento>, IAsientoRepository
    {
        public AsientoRepository(EjemploContext context) : base(context) { }
    }
}
