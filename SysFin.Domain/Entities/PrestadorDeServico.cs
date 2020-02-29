using SysFin.Services.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysFin.Domain.Entities
{
    public class PrestadorDeServico
    {

        public string Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }

        public IEnumerable<Fatura> Faturas { get; set; }
        public PrestadorDeServico(string nome, string descricao)
        {
            Id = GuidService.NovoGuid();
            Nome = nome;
            Descricao = descricao;
        }
    }
}
