using InsightPro.Avaliacao.Domain.Entities;

namespace InsightPro.Avaliacao.Domain.Interfaces
{
    public interface IAvaliacaoApplicationService
    {
        IEnumerable<AvaliacaoEntity> ObterTodasAvaliacoes();
        AvaliacaoEntity? ObterAvaliacaoPorId(int id);
        AvaliacaoEntity? SalvarDadosAvaliacao(AvaliacaoEntity entity);

        AvaliacaoEntity? EditarDadosAvaliacao(AvaliacaoEntity entity);
        AvaliacaoEntity? DeletarDadosAvaliacao(int id);

    }
}