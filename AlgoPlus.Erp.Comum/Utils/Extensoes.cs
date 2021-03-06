using AlgoPlus.Erp.Comum.DTOs;
using AlgoPlus.Erp.Comum.Modelos;

namespace AlgoPlus.Erp.Comum.Utils
{
    public static class Extensao
    {
        public static PrazoPagamentoEditarDTO MapearParaDTO(this PrazoPagamentoModelo prazo)
        {
            return new PrazoPagamentoEditarDTO
            {
                Ativo = prazo.Ativo,
                Descricao = prazo.Descricao,
                IdFormaPagamento = prazo.IdFormaPagamento,
                IdPrazoPagamento = prazo.IdPrazoPagamento,
                Prazo = prazo.Prazo,
                Parcelas = prazo.Parcelas
            };
        }

        public static FormaPagamentoDTO MapearParaDTO(this FormaPagamentoModelo forma)
        {
            return new FormaPagamentoDTO
            {
                Ativo = forma.Ativo,
                Descricao = forma.Descricao,
                Duplicata = forma.Duplicata,
                IdFormaPagamento = forma.IdFormaPagamento,
                TipoIntegracao = forma.TipoIntegracao,
                TipoPgtoNFe = forma.TipoPgtoNFe
            };
        }
    }
}
