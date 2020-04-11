using Bolao_Lotofacil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bolao_Lotofacil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnSave_Clicked(object sender, EventArgs e)
        {
            string _numbers = string.Format(num01.Text + "," + num02.Text + "," + num03.Text + "," + num04.Text + "," + num05.Text + "," + num06.Text + "," + num07.Text + "," 
                + num08.Text + "," + num09.Text + "," + num10.Text + "," + num11.Text + "," + num12.Text + "," + num13.Text + "," + num14.Text + "," + num15.Text);

            Bet bet = new Bet();
            bet.Numbers = _numbers;

        }
    }
}