using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Models.Services
{
    static class WeatherAPI
    {
        private static HttpClient client = new HttpClient();
        private static HttpRequestMessage httpRequest = null!;
        private const string key = "563b406e7b1a2a0e78c1e7666d8a99d5";
        private static Uri uri = null!;
        public static string result = null!;
        public static async void GetWeatherAsync2(string city)
        {
            uri = new Uri($"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={key}&units=metric");
            httpRequest = new HttpRequestMessage(HttpMethod.Get, uri);
            HttpResponseMessage httpResponse = client.Send(httpRequest);
            string s = await httpResponse.Content.ReadAsStringAsync();
            result = httpResponse.IsSuccessStatusCode ? s : "";
        }
    }
}
