using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Bolao_Lotofacil.Views
{ 
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            Detail = new Home();
        }

        private void btnHome_Clicked(object sender, EventArgs e)
        {
            Detail = new Home();
            IsPresented = false;
        }

        private void btnRegister_Clicked(object sender, EventArgs e)
        {
            Detail = new Register();
            IsPresented = false;
        }

        private void btnAbout_Clicked(object sender, EventArgs e)
        {
            Detail = new About();
            IsPresented = false;
        }
    }
}
