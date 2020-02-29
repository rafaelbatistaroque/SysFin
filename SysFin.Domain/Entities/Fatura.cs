using SysFin.Services.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysFin.Domain.Entities
{
    public class Fatura
    {

        public string Id { get; private set; }
        public DateTime DataChegada { get; private set; }
        public DateTime DataVencimento { get; private set; }
        public DateTime MesReferencia { get; private set; }
        public decimal Valor { get; private set; }
        public string Observacao { get; private set; }

        public PrestadorDeServico Prestador { get; set; }
 
        public Fatura(DateTime dataChegada, DateTime dataVencimento, DateTime mesReferencia, decimal valor, string observacao)
        {
            Id = GuidService.NovoGuid();
            DataChegada = dataChegada;
            DataVencimento = dataVencimento;
            MesReferencia = mesReferencia;
            Valor = valor;
            Observacao = observacao;
        }
    }
}
