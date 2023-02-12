using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.ViewModels;

namespace Weather.Models
{
    public class Player : ObservableObject
    {
        private string login = default!;
        private string password = default!;
        private string notedCity = "Kyiv";
        public string Login
        {
            get => login;
            set => SetValue(ref login, value);
        }
        public string Password
        {
            get => password;
            set => SetValue(ref password, value);
        }
        public string NotedCity
        {
            get => notedCity;
            set => SetValue(ref notedCity, value);
        }

    }
}
