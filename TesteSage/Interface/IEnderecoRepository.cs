using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteSage.Domain;

namespace TesteSage.Interface
{
    public interface IEnderecoRepository : ITesteSageRepository<Endereco>
    {
        Task<List<Endereco>> SelectEnderecoByPessoa(int idPessoa);
    }
}
