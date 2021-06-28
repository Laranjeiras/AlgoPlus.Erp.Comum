using System;

namespace AlgoPlus.Erp.Comum.DTOs
{
    public class FormaPagamentoEditarDTO
    {
        public Guid IdFormaPagamento { get; set; }
        public string Descricao { get; set; }
        public int TipoPgtoNFe { get; set; }
        public bool Ativo { get; set; }
    }
}
