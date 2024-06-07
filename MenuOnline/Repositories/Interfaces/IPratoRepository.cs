using MenuOnline.Models;

namespace MenuOnline.Repositories.Interfaces
{
    public interface IPratoRepository
    {
        IEnumerable<Prato> Pratos { get; }
        Prato GetPratoById(int PratoId);
    }
}
