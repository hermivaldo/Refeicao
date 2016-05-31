using System.Collections.ObjectModel;
using TesteApp.DATA;
using Xamarin.Forms;


namespace TesteApp
{
    public class HomeTabbledPage : TabbedPage
    {
        public HomeTabbledPage()
        {
            ObservableCollection<Refeicao> refeicoes = new ObservableCollection<Refeicao>();
            SQLite.Net.SQLiteConnection con = DependencyService.Get<ISqlite>().GetConnection();

            RefeicaoDAO dao = new RefeicaoDAO(con);
            this.Children.Add(new LayoutInicial (refeicoes, dao));
            this.Children.Add(new ListaRefeicoes (refeicoes));
        }
    }
}
