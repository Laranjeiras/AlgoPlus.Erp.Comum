using System;

namespace AlgoPlus.Erp.Comum.Modelos
{
    public record FormaPagamentoModelo
    {
        public Guid Id { get; init; }
        public string Descricao { get; init; }
        public int IdPgtoNFe { get; init; }
    }
}
