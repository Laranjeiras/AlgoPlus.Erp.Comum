using System;

namespace AlgoPlus.Erp.Comum.Modelos
{
    public class PrazoPagamentoModelo
    {
        public PrazoPagamentoModelo(Guid id, Guid? idFormaPagamento, string descricao, string prazos, bool ativo)
        {
            IdPrazoPagamento = id;
            IdFormaPagamento = idFormaPagamento;
            Descricao = descricao;
            Prazos = prazos;
            Ativo = ativo;
        }

        public Guid IdPrazoPagamento { get; protected set; }
        public Guid? IdFormaPagamento { get; protected set; }
        public string Descricao { get; protected set; }
        public string Prazos { get; protected set; }
        public bool Ativo { get; protected set; }

        public int Parcelas => CalcularParcelas();

        private int CalcularParcelas()
        {
            try
            {
                if (string.IsNullOrEmpty(Prazos))
                    return 0;
                return Prazos.Split(";").Length;
            }
            catch
            {
                return 0;
            }
        }
    }
}
