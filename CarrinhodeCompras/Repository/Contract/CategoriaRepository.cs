using CarrinhodeCompras.Models;

namespace CarrinhodeCompras.Repository.Contract
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly string _conexaoMySQL;
        public CategoriaRepository(IConfiguration conf)
        {
            _conexaoMySQL = conf.GetConnectionString("ConexaoMySQL");
        }
        public IEnumerable<Categoria> ObterTodasCategorias()
        {
            throw new NotImplementedException();
        }
    }
}
