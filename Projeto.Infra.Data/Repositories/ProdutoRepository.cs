using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Infra.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        public Task Insert(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Task Update(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Task<List<Produto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Produto> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Produto>> GetBy(Expression<Func<Produto, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
