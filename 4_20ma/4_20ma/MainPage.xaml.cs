using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _4_20ma
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(min.Text) || string.IsNullOrEmpty(max.Text) || string.IsNullOrEmpty(currentValue.Text))
            {
                DisplayAlert("Atenção!", "Todos os campos devem ser preenchidos", "Ok");
            }
            else
            {
                float _min = float.Parse(min.Text);
                float _max = float.Parse(max.Text);
                float _currentValue = float.Parse(currentValue.Text);
                float _formula = ((_currentValue * 6.25f) - 25) * ((_max - _min) / 100) +_min;
                result.Text = Math.Round(_formula, 2).ToString();
           }                    
        }
    }
}
