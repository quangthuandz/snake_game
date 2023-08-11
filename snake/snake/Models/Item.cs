using System;
using System.Collections.Generic;

namespace snake.Models
{
    public partial class Item
    {
        public Item()
        {
            UserItems = new HashSet<UserItem>();
        }

        public int ItemId { get; set; }
        public string ItemName { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<UserItem> UserItems { get; set; }
    }
}
