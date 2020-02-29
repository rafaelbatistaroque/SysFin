using System.Collections.Generic;

namespace SysFin.Domain.Entities
{
    public class PrestadorDeServico
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public IEnumerable<Fatura> Faturas { get; set; }
    }
}
