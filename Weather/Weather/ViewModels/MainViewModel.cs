using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Models;

namespace Weather.ViewModels
{
    static class MainViewModel
    {
        public static MessageViewModel MessageViewModel = new MessageViewModel();
        public static PlayersBase players = new PlayersBase();
        public static Player player = null!;
    }
}
