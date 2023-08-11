using System;
using System.Collections.Generic;

namespace snake.Models
{
    public partial class User
    {
        public User()
        {
            UserGames = new HashSet<UserGame>();
            UserItems = new HashSet<UserItem>();
        }

        public int UserId { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int IsAdmin { get; set; }
        public int? Money { get; set; }
        public int? NumberOfAdvertisement { get; set; }

        public virtual ICollection<UserGame> UserGames { get; set; }
        public virtual ICollection<UserItem> UserItems { get; set; }
    }
}
