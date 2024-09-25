using gerenciamentoapirest.Data;
using gerenciamentoapirest.Models;
using Microsoft.EntityFrameworkCore;

namespace gerenciamentoapirest.Repositories
{
    public interface ITarefaRepository : IRepository<Tarefa> {
        Task<Tarefa> GetByEmailAsync(string email);
    }
    
    public class TarefaRepository : Repository<Tarefa, ApiDbContext>, ITarefaRepository
    {
        public TarefaRepository(ApiDbContext context) : base(context) { }

        public Task<Tarefa> GetByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }
    }
}
