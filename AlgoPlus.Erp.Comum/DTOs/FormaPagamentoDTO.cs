using System;

namespace AlgoPlus.Erp.Comum.DTOs
{
    public class FormaPagamentoDTO
    {
        public Guid IdFormaPagamento { get; set; }
        public string Descricao { get; set; }
        public int TipoPgtoNFe { get; set; }
        public int TipoIntegracao { get; set; }
        public bool Ativo { get; set; }
        public bool Duplicata { get; set; }
    }
}
