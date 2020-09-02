namespace Veiculo
{
    using System;

    public class Automovel:Veiculo
    {
        #region propriedades

        //public string Matricula { get; set; }
        public decimal Quilometragem { get; set; }
        public decimal Deposito { get; set; }
        public decimal Capacidade { get; set; }
        public decimal Ltsaoscem { get; set; }
        public decimal Andakm { get; set; }

        #endregion

        #region Construtores
        //o construtor por parâmetros pode ter muitos menos parâmetros do q os atributos
        //mas qd se instancia só se coloca os parâmetros entre parêntesis

        public Automovel(string matricula, decimal capac, decimal ltscem, decimal kmtotal, decimal gasolina):base(matricula)
        {
            //Matricula = matricula;
            Capacidade = capac;
            Ltsaoscem = ltscem;
            Quilometragem = kmtotal;
            Andakm = 0.0m;
            Deposito = gasolina;
        }

        #endregion

        #region Métodos

        public void Atualizar (decimal percorreukm)
        {
            Quilometragem += percorreukm;
            Deposito -= Math.Round(percorreukm * (Ltsaoscem / 100));
        }

        public bool IsReserva ()
        {
            bool isReserva = false;
            if (Deposito <= 10)
                isReserva = true;
            return isReserva;
        }

        public decimal Qtcustou (decimal precolt, decimal percorreukm)
        {
            decimal valortotal = percorreukm * (Ltsaoscem / 100) * precolt;
            return valortotal;
        }

        public decimal QtcustouKm (decimal precolt, decimal percorreukm)
        {
            decimal valorkm = (Ltsaoscem / 100) * precolt;
            return valorkm;
        }//o q gastou por cada Km q andou

        public bool Cheio ()
        {
            Deposito += 1;
            if (Deposito < Capacidade)
                return false;
            else
                return true;  
        }

        public decimal CalculaKm()
        {
            decimal qtdKm = (Deposito * 100) / Ltsaoscem;
            return qtdKm;
        }
        #endregion
    }
}
