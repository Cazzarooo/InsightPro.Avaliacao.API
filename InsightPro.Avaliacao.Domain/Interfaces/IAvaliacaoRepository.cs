using InsightPro.Avaliacao.Domain.Entities;

namespace InsightPro.Avaliacao.Domain.Interfaces
{

    public interface IAvaliacaoRepository
    {
        IEnumerable<AvaliacaoEntity> ObterTodos();
        AvaliacaoEntity? ObterPorId(int id);
        AvaliacaoEntity? SalvarDados(AvaliacaoEntity entity);

        AvaliacaoEntity? EditarDados(AvaliacaoEntity entity);
        AvaliacaoEntity? DeletarDados(int id);

    }
}