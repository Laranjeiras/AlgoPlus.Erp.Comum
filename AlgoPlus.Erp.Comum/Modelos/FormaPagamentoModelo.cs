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
<<<<<<< HEAD
        public bool Duplicata { get; init; }
=======
<<<<<<< HEAD
=======
        public bool Duplicata { get; init; }
>>>>>>> 75f0a6785b56515ae8c4ceb7e52f363f6681a165
>>>>>>> 58c3cc7477366db137005ec13e6c32bb06160a13
=======
=======
        public bool Duplicata { get; init; }
>>>>>>> 75f0a6785b56515ae8c4ceb7e52f363f6681a165
>>>>>>> 58c3cc7477366db137005ec13e6c32bb06160a13
    }
}
