using Microsoft.EntityFrameworkCore;
using SysFin.Data.BD;
using SysFin.Data.Repositories.Interfaces;
using SysFin.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SysFin.Data.Repositories
{
    class PrestadorDeServicoRepositorio : IPrestadorDeServicoRepositorio
    {
        public SysFinDataContext BD { get; }
        public PrestadorDeServicoRepositorio(SysFinDataContext _context)
        {
            BD = _context;
        }


        public Task AdicionarPrestadorNoBD(PrestadorDeServico prestador)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarAlunoNoBD(PrestadorDeServico prestador)
        {
            throw new NotImplementedException();
        }

        public Task DeletarPrestadorNoBD(PrestadorDeServico prestador)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PrestadorDeServico>> ObterListaDePrestadoresNoBD()
        {
            return await BD.PrestadoresDeServico.ToListAsync();
        }

        public Task<PrestadorDeServico> ObterPrestadorPorIdNoBD(string id)
        {
            throw new NotImplementedException();
        }
    }
}
