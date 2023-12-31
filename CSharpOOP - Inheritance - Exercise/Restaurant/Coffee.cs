﻿namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const decimal CoffeePrice = 3.50M;
        private const double CoffeMilliliters = 50;
        public Coffee(string name, double caffeine) 
            : base(name, CoffeePrice, CoffeMilliliters)
        {
            Caffeine = caffeine;
        }

        public double Caffeine { get; set; }
        
    }
}
