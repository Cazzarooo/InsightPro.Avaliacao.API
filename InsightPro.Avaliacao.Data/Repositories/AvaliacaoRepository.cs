using InsightPro.Avaliacao.Data.AppData;
using InsightPro.Avaliacao.Domain.Entities;
using InsightPro.Avaliacao.Domain.Interfaces;

namespace InsightPro.Avaliacao.Data.Repositories
{
    public class AvaliacaoRepository : IAvaliacaoRepository
    {
        private readonly ApplicationContext _context;

        public AvaliacaoRepository(ApplicationContext context)
        {
            _context = context;
        }

        public AvaliacaoEntity? DeletarDados(int id)
        {
            var avaliacao = _context.Avaliacao.Find(id);

            if (avaliacao is not null)
            {
                _context.Avaliacao.Remove(avaliacao);
                _context.SaveChanges();

                return avaliacao;
            }

            return null;
        }

        public AvaliacaoEntity? EditarDados(AvaliacaoEntity entity)
        {
            var avaliacao = _context.Avaliacao.Find(entity.Id);

            if (avaliacao is not null)
            {

                avaliacao.Comentario = entity.Comentario;
                avaliacao.Nota = entity.Nota;

                _context.Avaliacao.Update(avaliacao);
                _context.SaveChanges();

                return avaliacao;
            }

            return null;
        }

        public AvaliacaoEntity? ObterPorId(int id)
        {
            var avaliacao = _context.Avaliacao.Find(id);

            if (avaliacao is not null)
            {
                return avaliacao;
            }

            return null;
        }

        public IEnumerable<AvaliacaoEntity> ObterTodos()
        {
            var avaliacoes = _context.Avaliacao.ToList();

            return avaliacoes;
        }

        public AvaliacaoEntity? SalvarDados(AvaliacaoEntity entity)
        {
            _context.Avaliacao.Add(entity);
            _context.SaveChanges();

            return entity;
        } 
    }
    
}
