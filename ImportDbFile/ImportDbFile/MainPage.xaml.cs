using System.ComponentModel;
using System.IO;

using Xamarin.Forms;

namespace ImportDbFile
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage(string dbFilePath)
        {
            InitializeComponent();

            // DB 파일 유무에 따른 표시
            this.pathLabel.Text = "PATH : " + dbFilePath;
            this.pathExistLabel.Text = "EXIST : " + File.Exists(dbFilePath).ToString();
        }
    }
}
