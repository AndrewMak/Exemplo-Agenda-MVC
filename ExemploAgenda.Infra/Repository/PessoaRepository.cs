using ExemploAgenda.Domain.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploAgenda.Domain.Models;

namespace ExemploAgenda.Infra.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        public void Adicionar(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public Pessoa ObterPorId(int pessoaid)
        {
            throw new NotImplementedException();
        }

        public Pessoa ObterPorNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
