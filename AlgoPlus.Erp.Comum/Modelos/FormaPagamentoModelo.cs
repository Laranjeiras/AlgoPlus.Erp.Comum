using System;

namespace AlgoPlus.Erp.Comum.Modelos
{
    public record FormaPagamentoModelo
    {
        public Guid IdFormaPagamento { get; init; }
        public string Descricao { get; init; }
        public int TipoPgtoNFe { get; init; }
        public int TipoIntegracao { get; init; }
        public bool Ativo { get; init; }
<<<<<<< HEAD
=======
        public bool Duplicata { get; init; }
>>>>>>> 75f0a6785b56515ae8c4ceb7e52f363f6681a165
    }
}
