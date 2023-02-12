using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.ViewModels;

namespace Weather.Models
{
    class PlayersBase : ObservableObject
    {
        public List<Player> PlayersCollection { get; set; } = null!;

        public PlayersBase()
        {
            getPlayers();
        }
        public void getPlayers()
        {
            string jsonReader = "";
            if (File.Exists("Players.json")) jsonReader = File.ReadAllText("Players.json");
            else File.Create("Players.json");
            PlayersCollection = (jsonReader != string.Empty ? System.Text.Json.JsonSerializer.Deserialize<List<Player>>(jsonReader) : new List<Player>())!;
        }
        public void writePlayersToFile()
        {
            string jsonWriter = PlayersCollection?.Count > 0 ? System.Text.Json.JsonSerializer.Serialize(PlayersCollection) : string.Empty;
            File.WriteAllTextAsync("Players.json", jsonWriter);
        }

    }
}
