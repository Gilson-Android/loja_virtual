using LojaVirtual.Entidade;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.Repositorio
{
    public class Repositorios
    {
        private readonly EfDbContext _context = new EfDbContext();
        public IEnumerable<Produto> Produto
        {
            get { return _context.Produto; }
        }

        public IEnumerable<Grupo> Grupo
        {
            get { return _context.Grupo; }
        }

    }
}
