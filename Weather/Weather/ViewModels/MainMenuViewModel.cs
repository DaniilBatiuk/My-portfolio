using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Weather.Commands;
using Weather.Models.Services;
using Weather.Views;

namespace Weather.ViewModels
{
    class MainMenuViewModel : ObservableObject
    {
        public MainMenuViewModel()
        {
            WeatherCommand = new RelayCommand(Weather);
            MoreInfoCommand = new RelayCommand(MoreInfo);
            BackCommand = new RelayCommand(Back);
            SelectCommand = new RelayCommand(Select);
        }

        static MainMenuViewModel()
        {
            WeatherAPI.GetWeatherAsync2(MainViewModel.player.NotedCity);
            weatherParameters = JsonConvert.DeserializeObject<WeatherParameters>(WeatherAPI.result)!;
        }

        public static WeatherParameters weatherParameters = new();
        public WeatherParameters WeatherParameters { get => weatherParameters; set => SetValue(ref weatherParameters, value); }

        public RelayCommand WeatherCommand { get; }
        public RelayCommand MoreInfoCommand { get; }
        public RelayCommand BackCommand { get; }
        public RelayCommand SelectCommand { get; }

        private void Weather(object obj)
        {
            if (obj.ToString()!.ToLower() == WeatherParameters.Name.ToLower())
            {
                return;
            }
            WeatherAPI.GetWeatherAsync2(obj.ToString()!);
            if (WeatherAPI.result != string.Empty && !int.TryParse(obj.ToString(), out _))
            {
                WeatherParameters = JsonConvert.DeserializeObject<WeatherParameters>(WeatherAPI.result)!;
                MainViewModel.MessageViewModel.ErrorMessage = string.Empty;
            }
            else
            {
                MainViewModel.MessageViewModel.ErrorMessage = "City name entered incorrectly";
            }
        }

        private void MoreInfo(object obj)
        {
            new MoreInfo().Show();
            (obj as Window)!.Close();
        }

        private void Back(object obj)
        {
            new MainMenu().Show();
            (obj as Window)!.Close();
        }

        private void Select(object obj)
        {
            if (obj.ToString()!.ToLower() != MainViewModel.player.NotedCity.ToLower()) Weather(obj);
            else MainViewModel.MessageViewModel.ErrorMessage = "This city has already been selected";
            if (MainViewModel.MessageViewModel.ErrorMessage == string.Empty)
            {
                MainViewModel.MessageViewModel.Message = "Your city has been selected. On the next boot, the selected city will immediately appear.";
                MainViewModel.player.NotedCity = obj.ToString()!;
                MainViewModel.players.writePlayersToFile();
            }
        }
    }
}
