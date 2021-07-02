using System;

namespace AlgoPlus.Erp.Comum.Modelos
{
    public class PrazoPagamentoModelo
    {
        protected PrazoPagamentoModelo()
        {
        }

        public PrazoPagamentoModelo(Guid id, Guid? idFormaPagamento, string descricao, string prazo, bool ativo)
        {
            if (DefinirPrazo(prazo) == false)
                throw new ArgumentException("Prazo inválido");
            IdPrazoPagamento = id;
            IdFormaPagamento = idFormaPagamento;
            Descricao = descricao;
            Ativo = ativo;
        }

        public Guid IdPrazoPagamento { get; protected set; }
        public Guid? IdFormaPagamento { get; protected set; }
        public string Descricao { get; protected set; }
        public string Prazo { get; protected set; }
        public bool Ativo { get; protected set; }

        public int Parcelas => CalcularParcelas();

        private int CalcularParcelas()
        {
            try
            {
                if (string.IsNullOrEmpty(Prazo))
                    return 0;
                return Prazo.Split(";").Length;
            }
            catch
            {
                return 0;
            }
        }

        public bool DefinirPrazo(string prazo)
        {
            try
            {
                if (string.IsNullOrEmpty(prazo))
                    return false;

                var ultimo = prazo.Substring(prazo.Length - 1, 1);

                if(ultimo == ";")
                    prazo = prazo.Remove(prazo.Length - 1);

                var parcelas = prazo.Split(";");

                foreach (var parcela in parcelas)
                    Int32.Parse(parcela);
                Prazo = prazo;
                return true;

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
