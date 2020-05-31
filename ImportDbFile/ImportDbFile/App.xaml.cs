using System;
using System.IO;

using Xamarin.Forms;

namespace ImportDbFile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            string dbFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "TEST.db");

            MainPage = new MainPage(dbFilePath);
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
