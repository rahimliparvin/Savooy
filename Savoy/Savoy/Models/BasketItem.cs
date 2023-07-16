﻿namespace Savoy.Models
{
    public class BasketItem:BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public AppUser AppUser { get; set; }
        public string AppUserId { get; set; }

        public int Count { get; set; }
    }
}
