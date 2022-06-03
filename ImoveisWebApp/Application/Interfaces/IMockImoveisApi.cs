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
        Task<Imovel> CadastrarImovelAsync([Body] Imovel imovel);

        [Put("v1/imoveis/{id}")]
        Task<Imovel> AlterarImovelPorIdAsync([Path] int id, [Body] Imovel imovel);

        [Delete("v1/imoveis/{id}")]
        Task<Imovel> RemoverImovelPorIdAsync([Path] int id);
    }
}