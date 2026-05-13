using CarrinhodeCompras.Models;

namespace CarrinhodeCompras.Repository.Contract
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> ObterTodasCategorias();
    }
}
