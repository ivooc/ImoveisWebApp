using ImoveisWebApp.Models;

namespace ImoveisWebApp.Application.Interfaces
{
    public interface IServicoImovel
    {
        Task<IEnumerable<Imovel>> ObterTodosOsImoveisAsync();

        Task<Imovel> ObterImovelPorIdAsync(int id);

        Task<int> CadastrarImovelAsync(Imovel imovel);

        Task AlterarImovelPorIdAsync(int id);

        Task RemoverImovelPorIdAsync(int id);
    }
}