using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteSage.Domain;
using TesteSage.Interface;

namespace TesteSage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaRepository repository;

        public PessoaController(IPessoaRepository repository)
        {
            this.repository = repository;
        }


        /// <summary>
        /// Retorna lista com todas as pessoas.
        /// </summary>
        [HttpGet]
        public Task<List<Pessoa>> Get()
        {          
            var resultado = repository.FindAll();
            return resultado;
        }

    }
}