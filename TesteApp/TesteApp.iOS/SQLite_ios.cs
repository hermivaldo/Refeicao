using System;
using SQLite.Net;
using TesteApp.DATA;
using System.IO;
using TesteApp.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_ios))]
namespace TesteApp.iOS
{
    public class SQLite_ios : ISqlite
    {
        public SQLiteConnection GetConnection()
        {
            var fileName = "Refeicoes.db3";
            var documentos = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            var enderecoDB = Path.Combine(documentos, "..", "Library", fileName);

            return new SQLiteConnection(new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS(), enderecoDB);
        }
    }
}
