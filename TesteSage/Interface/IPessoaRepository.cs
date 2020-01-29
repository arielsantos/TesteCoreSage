using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteSage.Domain;

namespace TesteSage.Interface
{
    public interface IPessoaRepository : ITesteSageRepository<Pessoa>
    {
    }
}
