using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SysFin.Data.Repositories.Interfaces;
using SysFin.Domain.Entities;

namespace SysFin.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class PrestadorDeServicoController : ControllerBase
    {
        public IPrestadorDeServicoRepositorio Repositorio { get; }
        public PrestadorDeServicoController(IPrestadorDeServicoRepositorio rep)
        {
            Repositorio = rep;
        }

        [HttpGet]
        public async Task<IEnumerable<PrestadorDeServico>> ListaDePrestadorDeServico()
        {
            return await Repositorio.ObterListaDePrestadoresNoBD();
        }
        
    }
}