using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using Weather.Commands;
using Weather.Models.Services;
using Weather.Models;
using Weather.Views;

namespace Weather.ViewModels
{
    class RegistrationViewModel : ObservableObject
    {
        public RegistrationViewModel()
        {
            AddPlayerCommand = new RelayCommand(AddPlayer);
            SignInCommand = new RelayCommand(SignIn);
        }

        private void checkBoxes(string l, string p1, string p2)
        {
            MainViewModel.MessageViewModel.ErrorMessage =
                (string.IsNullOrEmpty(l) || string.IsNullOrEmpty(p1) || string.IsNullOrEmpty(p2)) ? "All fields must be filled" :
                (p1 != p2) ? "Password and confirmation password must be the same" :
                MainViewModel.players.PlayersCollection.Where(p => p.Login == l).Any() ? "This username is already registered" :
                (!Regex.IsMatch(l, @"^\w{4,12}$")) ? "Username must be 4-14 characters long and consist of (a-Z 0-9 _)" :
                (!Regex.IsMatch(p1, @"^(?=\w+?[a-z])(?=\w+?[A-Z])(?=\w+?\d)\w{6,20}$")) ? "Password must be 4-14 characters long and have at least one number and letter in lower case and upper case" : string.Empty;
        }



        public RelayCommand AddPlayerCommand { get; }
        public RelayCommand SignInCommand { get; }
        private void AddPlayer(object obj)
        {
            var values = (object[])obj;

            string login = (values[0] as TextBox)!.Text.ToString();
            string password = (values[1] as PasswordBox)!.Password;
            string passwordConfirmation = (values[2] as PasswordBox)!.Password;

            checkBoxes(login, password, passwordConfirmation);

            if (MainViewModel.MessageViewModel.ErrorMessage == string.Empty)
            {
                MainViewModel.player = new Player();
                MainViewModel.player.Login = login;
                MainViewModel.player.Password = Encryption.HashPassword(password);

                MainViewModel.players.PlayersCollection.Add(MainViewModel.player);
                MainViewModel.players.writePlayersToFile();

                MainViewModel.MessageViewModel.Message =
                    "Hello dear customer. This application is designed to view the current weather in " +
                    "any city in the world. You can quickly find the city you need and see many characteristics." +
                    " You can also select the city you want to constantly monitor and its weather will be shown to you " +
                    "immediately upon authorization. Thank you for your attention.";
                new MainMenu().Show();
                (values[3] as Window)!.Close();
            }

        }

        private void SignIn(object obj)
        {
            new SignIn().Show();
            (obj as Window)!.Close();
        }
    }
}
