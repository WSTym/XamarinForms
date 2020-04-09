using Bolao_Lotofacil.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bolao_Lotofacil
{
    public partial class App : Application
    {
        public static string DbName;
        public static string DbPath;

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
        public App(string dbPath, string dbName)
        {
            DbName = dbName;
            DbPath = dbPath;
            InitializeComponent();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
