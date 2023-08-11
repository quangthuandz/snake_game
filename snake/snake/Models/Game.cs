using System;
using System.Collections.Generic;

namespace snake.Models
{
    public partial class Game
    {
        public Game()
        {
            UserGames = new HashSet<UserGame>();
        }

        public int GameId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<UserGame> UserGames { get; set; }
    }
}
