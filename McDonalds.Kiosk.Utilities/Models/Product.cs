﻿namespace McDonalds.Kiosk.Core.Models
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
