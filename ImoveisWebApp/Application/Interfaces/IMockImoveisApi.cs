using ImoveisWebApp.Models;
using RestEase;

namespace ImoveisWebApp.Application.Interfaces
{
    public interface IMockImoveisApi
    {
        [Get("v1/imoveis")]
        Task<IEnumerable<Imovel>> ObterTodosOsImoveisAsync();

        [Get("v1/imoveis/{id}")]
        Task<Imovel> ObterImovelPorIdAsync([Path] int id);

        [Post("v1/imoveis")]
        Task<int> CadastrarImovelAsync([Body] Imovel imovel);

        [Put("v1/imoveis/{id}")]
        Task AlterarImovelPorIdAsync([Path] int id);

        [Delete("v1/imoveis/{id}")]
        Task RemoverImovelPorIdAsync([Path] int id);
    }
}