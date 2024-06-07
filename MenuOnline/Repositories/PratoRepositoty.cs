using MenuOnline.Context;
using MenuOnline.Models;
using MenuOnline.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MenuOnline.Repositories
{
    public class PratoRepositoty : IPratoRepository
    {
        private readonly AppDbContext _context;
        public PratoRepositoty(AppDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Prato> Pratos => _context.Pratos.Include(c => c.Categoria);

        public Prato GetPratoById(int PratoId)
        {
            return _context.Pratos.FirstOrDefault(l => l.PratoId == PratoId);
        }
    }
}


