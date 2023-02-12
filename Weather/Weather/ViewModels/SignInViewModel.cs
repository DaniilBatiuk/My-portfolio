using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using Weather.Commands;
using Weather.Models.Services;
using Weather.Views;

namespace Weather.ViewModels
{
    class SignInViewModel : ObservableObject
    {
        public SignInViewModel()
        {
            SingInCommand = new RelayCommand(SingIn);
            CreateAccountCommand = new RelayCommand(CreateAccount);
        }

        private void checkBoxes(string l, string p1)
        {
            MainViewModel.MessageViewModel.ErrorMessage =
                (string.IsNullOrEmpty(l) || string.IsNullOrEmpty(p1)) ? "All fields must be filled" :
                !MainViewModel.players.PlayersCollection.Where(p => p.Login == l).Any() ? "This username is not registered" :
                !Encryption.VerifyHashedPassword(MainViewModel.players.PlayersCollection.Where(p => p.Login == l).Select(p => p.Password).First(), p1) ? "Wrong password" : string.Empty;
        }

        public RelayCommand SingInCommand { get; }
        public RelayCommand CreateAccountCommand { get; }

        private void SingIn(object obj)
        {
            var values = (object[])obj;
            string login = (values[0] as TextBox)!.Text.ToString();
            string password = (values[1] as PasswordBox)!.Password;
            checkBoxes(login, password);
            if (MainViewModel.MessageViewModel.ErrorMessage == string.Empty)
            {
                MainViewModel.player = MainViewModel.players.PlayersCollection.Where(p => p.Login == login).First();
                new MainMenu().Show();
                (values[2] as Window)!.Close();
            }

        }

        private void CreateAccount(object obj)
        {
            new MainWindow().Show();
            (obj as Window)!.Close();

        }
    }
}
