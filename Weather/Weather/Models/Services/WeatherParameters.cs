using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.ViewModels;

namespace Weather.Models.Services
{
    public record Clouds(int all);
    public record Coord(double lon, double lat);
    public record Main(double temp, double feels_like, double temp_min, double temp_max, int pressure, int humidity, int sea_level, int grnd_level);
    public record Sys(string country)
    {
        private string sunrise1 = default!;
        private string sunset1 = default!;
        public string sunrise
        {
            set { sunrise1 = (new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(int.Parse(value)).ToLocalTime()).ToShortTimeString(); }
            get { return sunrise1; }
        }
        public string sunset
        {
            set { sunset1 = (new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(int.Parse(value)).ToLocalTime()).ToShortTimeString(); }
            get { return sunset1; }
        }
    }
    public record Weather(int id, string main, string description)
    {
        private string icon1 = default!;
        public string icon
        {
            set
            {
                icon1 = value switch
                {
                    "01n" => "Icon2.png",
                    "02d" => "Icon11.png",
                    "02n" => "Icon1.png",
                    "03d" or "03n" => "Icon10.png",
                    "04d" or "04n" => "Icon15.png",
                    "09d" or "09n" => "Icon7.png",
                    "10d" or "10n" => "Icon8.png",
                    "11d" or "11n" => "Icon9.png",
                    "13d" or "13n" => "Icon5.png",
                    _ => "Icon12.png"
                };

            }
            get { return $"/Views/Resources/{icon1}"; }
        }
    }
    public record Wind(double speed, int deg, double gust);
    public class WeatherParameters : ObservableObject
    {
        private Coord coord = null!;
        private List<Weather> weather = null!;
        private string @base = default!;
        private Main main = null!;
        private int visibility;
        private Wind wind = null!;
        private Clouds clouds = null!;
        private int dt;
        private Sys sys = null!;
        private int timezone;
        private int id;
        private string name = default!;
        private int cod;

        public Coord Coord { get => coord; set => SetValue(ref coord, value); }
        public List<Weather> Weather { get => weather; set => SetValue(ref weather, value); }
        public string @Base { get => @base; set => SetValue(ref @base, value); }
        public Main Main { get => main; set => SetValue(ref main, value); }
        public int Visibility { get => visibility; set => SetValue(ref visibility, value); }
        public Wind Wind { get => wind; set => SetValue(ref wind, value); }
        public Clouds Clouds { get => clouds; set => SetValue(ref clouds, value); }
        public int Dt { get => dt; set => SetValue(ref dt, value); }
        public Sys Sys { get => sys; set => SetValue(ref sys, value); }
        public int Timezone { get => timezone; set => SetValue(ref timezone, value); }
        public int Id { get => id; set => SetValue(ref id, value); }
        public string Name { get => name; set => SetValue(ref name, value); }
        public int Cod { get => cod; set => SetValue(ref cod, value); }
    }
}
