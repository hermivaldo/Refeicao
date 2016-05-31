using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteApp.DATA;
using Xamarin.Forms;

namespace TesteApp
{
    public partial class LayoutInicial : ContentPage
    {
        public ObservableCollection<Refeicao> refeicoes { get; set; }

        public RefeicaoDAO Dao;

        public LayoutInicial (ObservableCollection<Refeicao> refeicoes, RefeicaoDAO dao)
        {
            this.refeicoes = refeicoes;
            this.Dao = dao;
            InitializeComponent();
        }

        public void SalvaRefeicao(Object sender,  EventArgs e)
        {
            Refeicao refeicao = new Refeicao();

            refeicao.Descricao = txtRefeicao.Text;
            refeicao.Calorias = (int) stpcalorias.Value;

            this.refeicoes.Add(refeicao);
            this.Dao.Salvar(refeicao);

            DisplayAlert("Salvar Refeição", txtRefeicao.Text + " " +  lblCalorias.Text + " Calorias", "OK");
        }

        public void AtualizaContador(Object sender, EventArgs e)
        {
            lblCalorias.Text = stpcalorias.Value.ToString();
        }

        public void MostraLista(Object sender, EventArgs e)
        {
            ListaRefeicoes tela =  new ListaRefeicoes(this.refeicoes);
            Navigation.PushAsync(tela);
        }

    }
}
