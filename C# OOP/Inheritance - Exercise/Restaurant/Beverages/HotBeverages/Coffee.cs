﻿namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        public Coffee(string name, double caffeine)
            : base(name, CoffeePrice, CoffeeMilliliters)
        {
            Caffeine = caffeine;
        }

        const double CoffeeMilliliters = 50;
        const decimal CoffeePrice = 3.5m;
        public double Caffeine { get; set; }
    }
}
