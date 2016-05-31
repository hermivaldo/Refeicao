using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TesteApp
{
    public partial class ListaRefeicoes : ContentPage
    {
        public ObservableCollection<Refeicao> refeicoes { get; set; }

        public ListaRefeicoes(ObservableCollection<Refeicao> refeicoes )
        {
            BindingContext = this;
            this.refeicoes = refeicoes;
            InitializeComponent();
        }

        public async void AcaoItem(object sender, ItemTappedEventArgs e)
        {
            var resposta = await DisplayAlert("Remover item", "Deseja remover o item?", "Sim", "Não");

            if (resposta)
            {
                refeicoes.Remove((Refeicao)e.Item);
            }
            
        }

    }
}
