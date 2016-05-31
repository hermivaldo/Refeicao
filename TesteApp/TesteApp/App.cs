using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TesteApp
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new HomeTabbledPage();  //new NavigationPage(new LayoutInicial(new ObservableCollection<Refeicao>()));//
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
