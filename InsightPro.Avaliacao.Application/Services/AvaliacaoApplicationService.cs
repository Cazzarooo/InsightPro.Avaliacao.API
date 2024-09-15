using InsightPro.Avaliacao.Domain.Entities;
using InsightPro.Avaliacao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightPro.Avaliacao.Application.Services
{
    public class AvaliacaoApplicationService : IAvaliacaoApplicationService
    {
        private readonly IAvaliacaoRepository _avaliacaoRepository;

        public AvaliacaoApplicationService(IAvaliacaoRepository avaliacaoRepository)
        {
            _avaliacaoRepository = avaliacaoRepository;
        }
        public AvaliacaoEntity? DeletarDadosAvaliacao(int id)
        {
            return _avaliacaoRepository.DeletarDados(id);
        }

        public AvaliacaoEntity? EditarDadosAvaliacao(AvaliacaoEntity entity)
        {
            return _avaliacaoRepository.EditarDados(entity);
        }

        public AvaliacaoEntity? ObterAvaliacaoPorId(int id)
        {
            return _avaliacaoRepository.ObterPorId(id);
        }

        public IEnumerable<AvaliacaoEntity> ObterTodasAvaliacoes()
        {
            return _avaliacaoRepository.ObterTodos();
        }

        public AvaliacaoEntity? SalvarDadosAvaliacao(AvaliacaoEntity entity)
        {
            return _avaliacaoRepository.SalvarDados(entity);
        }
    }
}
 