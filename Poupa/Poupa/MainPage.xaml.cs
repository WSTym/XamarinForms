using System;
using System.ComponentModel;
using System.Globalization;
using Xamarin.Forms;

namespace Poupa
{
    
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

       
       private void OnCalculateIncome(object sender, EventArgs e)
        {
            if (Method.SelectedIndex < 0)
            {
                DisplayAlert("Alerta!", "Escolha um método", "Ok");
            }
            else if (string.IsNullOrEmpty(Value.Text))
            {
                DisplayAlert("Alerta!", "Insira um valor", "Ok");
            }
            else
            {
                int _month = (int)Month.Value;
                float _value = float.Parse(Value.Text);
                float _yearInterest = .05f / 12f;

                switch (Method.SelectedIndex)
                    {
                        case 0:
                            LblResult.Text = CalculateIncome(_month, .0028f, _value);                    
                            break;
                        case 1:
                            LblResult.Text = CalculateIncome(_month, .0038f, _value);
                            break;
                        case 2:
                            LblResult.Text = CalculateIncome(_month, _yearInterest, _value);
                            break;
                    }
            }
            
        }

        private string CalculateIncome(int month, float interest, float value)
        {
            var _compoundInterest = value;

            for (int i = 0; i < month; i++)
            {
                _compoundInterest += value * interest;
            }
            return _compoundInterest.ToString("C", new CultureInfo("pt-BR").NumberFormat);
        }
    }
}
