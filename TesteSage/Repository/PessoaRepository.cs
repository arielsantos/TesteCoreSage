using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteSage.Interface;

namespace TesteSage.Repository
{
    public class PessoaRepository : TesteSageRepository<Domain.Pessoa>, IPessoaRepository
    {
        private readonly TesteSageContext context;
        public PessoaRepository(TesteSageContext context) : base(context)
        {
            this.context = context;
        }
      

    }
}

