using System;

namespace AlgoPlus.Erp.Comum.Modelos
{
    public record FormaPagamentoModelo
    {
        public Guid IdFormaPagamento { get; init; }
        public string Descricao { get; init; }
        public int TipoPgtoNFe { get; init; }
        public bool Ativo { get; init; }
    }
}
