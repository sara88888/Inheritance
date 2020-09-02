namespace Veiculo
{
    using System.Windows.Forms;

    public class Veiculo
    {
        #region Propriedades

        public string Matricula { get; set; }
        
        #endregion


        #region Construtores

        public Veiculo(string matricula)
        {
            Matricula = matricula;
        }

        #endregion

        #region Métodos
        public void Apresentar()
        {
            MessageBox.Show("Veículo "+Matricula+" saiu do stand");
        }

        #endregion
    }
}

