using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Weather.Commands;
using Weather.Views;

namespace Weather.ViewModels
{
    class MessageViewModel : ObservableObject
    {
        public MessageViewModel()
        {
            OkCommand = new RelayCommand(Ok);
        }

        static private string errorMessage = null!;
        public string ErrorMessage
        {
            get => errorMessage;
            set
            {
                SetValue(ref errorMessage, value);
                if (value != string.Empty) new Error().Show();
            }
        }

        static private string message = null!;
        public string Message
        {
            get => message;
            set
            {
                SetValue(ref message, value);
                if (value != string.Empty) new Note().ShowDialog();
            }
        }

        public RelayCommand OkCommand { get; }
        private void Ok(object obj)
        {
            (obj as Window)!.Close();
        }



    }
}
