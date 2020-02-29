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
    //TODO: Adicionar IactionResult para tratar badRequests
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PrestadorDeServicoController : ControllerBase
    {
        public IPrestadorDeServicoRepositorio Repositorio { get; }
        public PrestadorDeServicoController(IPrestadorDeServicoRepositorio rep)
        {
            Repositorio = rep;
        }

        //GET: api/v1/PrestadorDeServico
        [HttpGet]
        public async Task<IEnumerable<PrestadorDeServico>> ObterListaDePrestadorDeServico()
        {
            return await Repositorio.ObterListaDePrestadoresNoBD();
        }

        //POST: api/v1/PrestadorDeServico
        [HttpPost]
        public async Task AdicionarPrestadorDeServico(PrestadorDeServico prestador)
        {
            await Repositorio.AdicionarPrestadorNoBD(prestador);
        }
        //GET: api/v1/PrestadorDeServico/2KKL...
        [HttpGet("{id}")]
        public async Task<PrestadorDeServico> ObterPrestadorDeServicoPorId(string id)
        {
            return await Repositorio.ObterPrestadorPorIdNoBD(id);
        }
        //DELETE: api/v1/PrestadorDeServico/2KKL...
        [HttpDelete("{id}")]
        public async Task DeletarPrestadorDeServico(PrestadorDeServico prestador)
        {
            await Repositorio.DeletarPrestadorNoBD(prestador);
        }
        //PUT: api/v1/PrestadorDeServico/2KKL...
        [HttpPut("{id}")]
        public async Task AtualizarPrestadorDeServico(string id, PrestadorDeServico prestadorAtualizado)
        {
            prestadorAtualizado.Id = id;
            await Repositorio.AtualizarAlunoNoBD(prestadorAtualizado);
        }

    }
}