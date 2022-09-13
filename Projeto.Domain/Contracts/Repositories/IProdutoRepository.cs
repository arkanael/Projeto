using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Domain.Contracts.Repositories
{
    public interface IProdutoRepository
    {
        Task Insert(Produto produto );
        Task Update(Produto produto );
        Task Delete(Produto produto );
        Task<List<Produto>> GetAllAsync();
        Task<Produto> GetByNome(string nome);
        Task<Produto> GetByIdAsync(Guid id);
        Task<List<Produto>> GetBy(Expression<Func<Produto, bool>> expression);
    }
}
