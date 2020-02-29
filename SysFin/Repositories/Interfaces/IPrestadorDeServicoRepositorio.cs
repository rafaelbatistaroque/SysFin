using SysFin.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SysFin.Data.Repositories.Interfaces
{
    public interface IPrestadorDeServicoRepositorio
    {
        Task<IEnumerable<PrestadorDeServico>> ObterListaDePrestadoresNoBD();
        Task<PrestadorDeServico> ObterPrestadorPorIdNoBD(string id);
        Task AdicionarPrestadorNoBD(PrestadorDeServico prestador);
        Task DeletarPrestadorNoBD(PrestadorDeServico prestador);
        Task AtualizarAlunoNoBD(PrestadorDeServico prestador);
    }
}
