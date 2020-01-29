using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteSage.Domain;
using TesteSage.Interface;

namespace TesteSage.Repository
{
    public class EnderecoRepository : TesteSageRepository<Endereco>, IEnderecoRepository
    {
        private readonly TesteSageContext context;
        public EnderecoRepository(TesteSageContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<List<Endereco>> SelectEnderecoByPessoa(int idCliente)
        {
            return await this.context.Endereco.AsNoTracking().Where(a => a.PessoaId == idCliente).ToListAsync();
        }
    
    }
}
