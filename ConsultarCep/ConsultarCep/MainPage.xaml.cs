using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Consultarcep.Servico.Modelo;
using Consultarcep.Servico;


namespace ConsultarCep
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BOTAO.Clicked += BuscarCEP;
        }

        private void BuscarCEP(object sender, EventArgs args)
        {
            string cep = CEP.Text.Trim();
            Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);
            RESULTADO.Text = string.Format("Endereço: {0} {1}, {2} {3} {4}",
                end.Localidade, end.Uf, end.Logradouro, end.Bairro,
                end.Complemento);
        }
    }
}
