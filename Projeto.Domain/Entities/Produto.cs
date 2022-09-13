using Projeto.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Domain.Entities
{
    public class Produto
    {
        public List<string> validations = new List<string>();

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime? DataAtualizacao { get; private set; }

        public bool Register(string nome)
        {
            
            if(StringValidations.QuantidateMaximaCaracters(nome, 10))
                validations.Add("O nome do produto não pode ter mais que 10 caracteres.");

            if (validations.Count > 0)
                return false;

            Id = Guid.NewGuid();
            Nome = nome;
            DataCadastro = DateTime.Now;
            DataAtualizacao = null;

           

            return true;
        }

        public void Update(string nome, Guid id)
        {
            if (nome.Length > 10)
                throw new Exception("O nome do produto não pode ter mais que 10 caracteres");

            Id = id;
            Nome = nome;
            DataAtualizacao = DateTime.Now;
        }

    }
}
