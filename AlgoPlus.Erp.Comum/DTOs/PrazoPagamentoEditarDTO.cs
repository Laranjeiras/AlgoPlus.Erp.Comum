using System;

namespace AlgoPlus.Erp.Comum.DTOs
{
    public class PrazoPagamentoEditarDTO
    {
        public Guid Id { get; set; }
        public Guid? IdFormaPagamento { get; set; }
        public string Descricao { get; set; }
        public string Prazos { get; set; }
        public bool Ativo { get; set; }
    }
}
