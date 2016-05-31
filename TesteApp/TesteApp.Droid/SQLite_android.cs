using SQLite.Net;
using TesteApp.DATA;
using Xamarin.Forms;
using TesteApp.Droid;
using Android.OS;
using System.IO;

[assembly: Dependency(typeof(SQLite_android))]
namespace TesteApp.Droid
{
    public class SQLite_android : ISqlite
    {
        public SQLiteConnection GetConnection()
        {
            string applicationFolderPath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "CanFindLocation");

            // Create the folder path.
            System.IO.Directory.CreateDirectory(applicationFolderPath);

            string databaseFileName = System.IO.Path.Combine(applicationFolderPath, "CanFindLocation.db");

            return new SQLiteConnection(new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid(), databaseFileName);
        }
    }
}