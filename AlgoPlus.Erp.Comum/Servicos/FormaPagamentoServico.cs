using AlgoPlus.Erp.Comum.DTOs;
using AlgoPlus.Erp.Comum.Modelos;
using AlgoPlus.Erp.Comum.Repositorios;
<<<<<<< HEAD
using AlgoPlus.Erp.Comum.Utils;
=======
<<<<<<< HEAD
using AutoMapper;
=======
using AlgoPlus.Erp.Comum.Utils;
>>>>>>> 75f0a6785b56515ae8c4ceb7e52f363f6681a165
>>>>>>> 58c3cc7477366db137005ec13e6c32bb06160a13
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgoPlus.Erp.Comum.Servicos
{
    public class FormaPagamentoServico : BaseServico
    {

<<<<<<< HEAD
        public FormaPagamentoServico(IUnitOfWorkComum uow) : base(uow)
=======
<<<<<<< HEAD
        public FormaPagamentoServico(IUnitOfWorkComum uow, IMapper mapper) : base(uow, mapper)
=======
        public FormaPagamentoServico(IUnitOfWorkComum uow) : base(uow)
>>>>>>> 75f0a6785b56515ae8c4ceb7e52f363f6681a165
>>>>>>> 58c3cc7477366db137005ec13e6c32bb06160a13
        {
        }

        #region Forma Pagamento
<<<<<<< HEAD
        public async Task SalvarAsync(FormaPagamentoDTO formaVm)
=======
<<<<<<< HEAD
        public async Task SalvarAsync(FormaPagamentoEditarDTO formaVm)
=======
        public async Task SalvarAsync(FormaPagamentoDTO formaVm)
>>>>>>> 75f0a6785b56515ae8c4ceb7e52f363f6681a165
>>>>>>> 58c3cc7477366db137005ec13e6c32bb06160a13
        {
            if (formaVm.TipoPgtoNFe <= 0)
                contract.AddNotification("IdPgtoNFe", "O campo IdPgtoNFe é de preenchimento obrigatório");
            if (string.IsNullOrEmpty(formaVm.Descricao))
                contract.AddNotification("Descricao", "O campo Descrição é de preenchimento obrigatório");

            var forma = new FormaPagamentoModelo
            {
                Ativo = formaVm.Ativo,
                Descricao = formaVm.Descricao,
                IdFormaPagamento = formaVm.IdFormaPagamento,
                TipoPgtoNFe = formaVm.TipoPgtoNFe,
<<<<<<< HEAD
                TipoIntegracao = formaVm.TipoIntegracao,
                Duplicata = formaVm.Duplicata
=======
<<<<<<< HEAD
                TipoIntegracao = 0
=======
                TipoIntegracao = formaVm.TipoIntegracao,
                Duplicata = formaVm.Duplicata
>>>>>>> 75f0a6785b56515ae8c4ceb7e52f363f6681a165
>>>>>>> 58c3cc7477366db137005ec13e6c32bb06160a13
            };

            await uow.FormasPagamento.SalvarAsync(forma);
        }

<<<<<<< HEAD
        public async Task<IList<FormaPagamentoDTO>> ObterFormasAsync()
=======
<<<<<<< HEAD
        public async Task<IList<FormaPagamentoModelo>> ObterFormasAsync()
>>>>>>> 58c3cc7477366db137005ec13e6c32bb06160a13
        {
            var formas = await uow.FormasPagamento.ObterFormasAsync();
            var dtos = formas.Select(x => x.MapearParaDTO()).ToList();
            return dtos;
        }

        public async Task<IList<FormaPagamentoDTO>> ObterFormasAtivasAsync()
        {
            var formas = await uow.FormasPagamento.ObterFormasAsync();
<<<<<<< HEAD
            var dtos = formas.Select(x => x.MapearParaDTO()).ToList();
            return dtos.Where(x => x.Ativo).ToList();
=======
            return formas.Where(x => x.Ativo).ToList();
=======
        public async Task<IList<FormaPagamentoDTO>> ObterFormasAsync()
        {
            var formas = await uow.FormasPagamento.ObterFormasAsync();
            var dtos = formas.Select(x => x.MapearParaDTO()).ToList();
            return dtos;
        }

        public async Task<IList<FormaPagamentoDTO>> ObterFormasAtivasAsync()
        {
            var formas = await uow.FormasPagamento.ObterFormasAsync();
            var dtos = formas.Select(x => x.MapearParaDTO()).ToList();
            return dtos.Where(x => x.Ativo).ToList();
>>>>>>> 75f0a6785b56515ae8c4ceb7e52f363f6681a165
>>>>>>> 58c3cc7477366db137005ec13e6c32bb06160a13
        }
        #endregion

        #region Prazo Pagamento
        public async Task<PrazoPagamentoEditarDTO> SalvarAsync(PrazoPagamentoEditarDTO prazoVm)
        {
            if (string.IsNullOrEmpty(prazoVm.Descricao))
                contract.AddNotification("Descricao", "O campo Descrição é de preenchimento obrigatório");

            if (string.IsNullOrEmpty(prazoVm.Prazo))
                contract.AddNotification("Prazo", "O campo Prazo(s) é de preenchimento obrigatório");

            if (!Contract.Valid)
                return null;
            try
            {
                var prazo = new PrazoPagamentoModelo(prazoVm.IdPrazoPagamento, prazoVm.IdFormaPagamento, prazoVm.Descricao, prazoVm.Prazo, prazoVm.Ativo);
                await uow.PrazosPagamento.SalvarAsync(prazo);
<<<<<<< HEAD
                return prazo.MapearParaDTO();

=======
<<<<<<< HEAD
                return new PrazoPagamentoEditarDTO
                {
                    Ativo = prazo.Ativo,
                    Descricao = prazo.Descricao,
                    IdFormaPagamento = prazo.IdFormaPagamento,
                    IdPrazoPagamento = prazo.IdPrazoPagamento,
                    Prazo = prazo.Prazo,
                    Parcelas = prazo.Parcelas
                };
=======
                return prazo.MapearParaDTO();

>>>>>>> 75f0a6785b56515ae8c4ceb7e52f363f6681a165
>>>>>>> 58c3cc7477366db137005ec13e6c32bb06160a13
            } 
            catch(ArgumentException ex)
            {
                contract.AddNotification("Prazo", ex.Message);
                return null;
            }
            catch
            {
                throw;
            }
        }

        public async Task<IList<PrazoPagamentoModelo>> ObterPrazosAtivosPorFormaAsync(Guid idFormaPagamento)
        {
            var prazos = await uow.PrazosPagamento.ObterPrazosAsync(idFormaPagamento);
            return prazos.Where(x => x.Ativo).ToList();
        }

        public async Task<IList<PrazoPagamentoModelo>> ObterPrazosPorFormaAsync(Guid idFormaPagamento)
        {
            var prazos = await uow.PrazosPagamento.ObterPrazosAsync(idFormaPagamento);
            return prazos.ToList();
        }

        public async Task ExcluirPrazoAsync(Guid idPrazoPagamento)
        {
            await uow.FormasPagamento.ExcluirAsync(idPrazoPagamento);
        }
        #endregion
    }
}
