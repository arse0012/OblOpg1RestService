using System;
using System.Collections.Generic;
using System.Text;

namespace BikeLib
{
    public class Bike
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public int Gear { get; set; }

        public Bike()
        {

        }

        public Bike(int id, string color, double price, int gear)
        {
            Id = id;
            Color = color;
            Price = price;
            Gear = gear;
        }
    }
}
