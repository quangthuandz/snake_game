using System;
using System.Collections.Generic;

namespace snake.Models
{
    public partial class UserItem
    {
        public int UserItemId { get; set; }
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public int? Quatity { get; set; }

        public virtual Item Item { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
