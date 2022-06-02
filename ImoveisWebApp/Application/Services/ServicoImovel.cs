using ImoveisWebApp.Application.Interfaces;
using ImoveisWebApp.Models;

namespace ImoveisWebApp.Application.Services
{
    public class ServicoImovel : IServicoImovel
    {
        public async Task AlterarImovelPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> CadastrarImovelAsync(Imovel imovel)
        {
            throw new NotImplementedException();
        }

        public async Task<Imovel> ObterImovelPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Imovel>> ObterTodosOsImoveisAsync()
        {
            throw new NotImplementedException();
        }

        public async Task RemoverImovelPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}