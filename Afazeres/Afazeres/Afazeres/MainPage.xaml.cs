using Afazeres.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace Afazeres
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Todo> _taskList = new ObservableCollection<Todo>();
        Color _color;
        public MainPage()
        {
            InitializeComponent();
            lvTask.ItemsSource = _taskList;

            
        }

        private void AddNewTask(Object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(taskName.Text))
            {
                DisplayAlert("Atenção!", "Digite uma tarefa", "Ok");
            }
            else if (picker.SelectedIndex < 0)
            {
                DisplayAlert("Atenção!", "Escolha uma prioridade", "Ok");
            }
            else
            {
                int _index = picker.SelectedIndex;

                switch (_index)
                {
                    case 0:
                        _color = Color.Green;
                        break;
                    case 1:
                        _color = Color.Yellow;
                        break;
                    case 2:
                        _color = Color.Red;
                        break;
                }

                Todo todo = new Todo()
                {
                    name = taskName.Text,
                    priority = _color

                };

                _taskList.Add(todo);
            }
            
        }

        private void OnCheckedChanged(Object sender, EventArgs e)
        {
            Todo todo = (Todo)((CheckBox)sender).BindingContext;
            _taskList.Remove(todo);
        }


    }
}
