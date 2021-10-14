using System;

namespace ClassLibraryStore
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Car()
        {
            Make = "Nothing yet";
            Model = "Nothing yet";
            Price = 0.00M;
        }

        public Car(string make, string model, decimal price)
        {
            Make = make;
            Model = model;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Make} {Model} R${Price}";
        }
    }
}
