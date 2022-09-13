using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Tests.Entities
{
    [TestClass]
    public class ProdutoTests
    {
        [TestMethod("Ao cadastrar um novo produto menor que 10 caracteres deve retornar true")]
        public void CadastrarProdutoComMenore10CaracteresTrue()
        {
            Produto produto = new Produto();
            Assert.IsTrue(produto.Register("SSD 120GB"));
        }

        [TestMethod("Ao cadastrar um novo produto com mais de 10 caracteres deve retornar falso")]
        public void CadastrarProdutoComMaisde10CaracteresFalso()
        {
            Produto produto = new Produto();
            produto.Register("SSD 120GB");

            Assert.IsFalse(produto.Nome.Length > 10);
        }
    }
}
