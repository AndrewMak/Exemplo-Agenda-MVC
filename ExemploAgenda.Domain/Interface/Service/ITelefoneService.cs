using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAgenda.Domain.Interface.Service
{
    public interface ITelefoneService
    {
        void Adicionar(Pessoa pessoa);
        void Atualizar(Pessoa pessoa);
        Pessoa ObterPorId(int pessoaid);
        Pessoa ObterPorNome(string nome);
    }
}
