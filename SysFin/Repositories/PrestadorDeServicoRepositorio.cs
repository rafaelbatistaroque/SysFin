using Microsoft.EntityFrameworkCore;
using SysFin.Data.BD;
using SysFin.Data.Repositories.Interfaces;
using SysFin.Domain.Entities;
using SysFin.Services.Services;
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


        public async Task AdicionarPrestadorNoBD(PrestadorDeServico prestador)
        {
            prestador.Id = GuidService.NovoGuid();
            BD.Add(prestador);
            await BD.SaveChangesAsync();
        }

        public async Task AtualizarAlunoNoBD(PrestadorDeServico prestadorAtualizado)
        {
            var prestadorLocalizado = await ObterPrestadorPorIdNoBD(prestadorAtualizado.Id);
            if(prestadorLocalizado != null)
            {
                BD.Entry(prestadorLocalizado).CurrentValues.SetValues(prestadorAtualizado);
                await BD.SaveChangesAsync();
                return;
            }
            throw new Exception();
        }

        public async Task DeletarPrestadorNoBD(PrestadorDeServico prestador)
        {
            var prestadorLocalizado = await BD.PrestadoresDeServico.FindAsync(prestador.Id);
            if(prestadorLocalizado != null)
            {
                BD.Remove(prestador);
                await BD.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<PrestadorDeServico>> ObterListaDePrestadoresNoBD()
        {
            return await BD.PrestadoresDeServico.ToListAsync();
        }

        public async Task<PrestadorDeServico> ObterPrestadorPorIdNoBD(string id)
        {
            return await BD.PrestadoresDeServico.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
    }
}
