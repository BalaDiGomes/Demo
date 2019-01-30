using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App1.Service.Model;
using App1.Service;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Button.Clicked += SearchCEP;

        }
        private void SearchCEP(object sender,EventArgs args)
        {
            string cep = Cep.Text.Trim();
            Address add = ViaCEPService.SearchAddressViaCEP(cep);
            Result.Text = string.Format("Endereço: {2} de {3} {0},{1} ", add.localidade,add.uf,add.logradouro,add.bairro);
             
        }
    }
}
