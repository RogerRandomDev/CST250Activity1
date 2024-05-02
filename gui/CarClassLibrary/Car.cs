using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public string Color { get; set; }
        public int Year { get; set; }

        public Car(string make,string model,decimal price,string color,int year)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.Color = color;
            this.Year = year;
        }
        public Car()
        {
            this.Make = "Nothing yet";
            this.Model = "Nothing yet";
            this.Price = 0;
            this.Color = "Unknown";
            this.Year = 0000;
        }

        public string getMake()
        {
            return this.Make;
        }

        public void setMake(string newName)
        {
            this.Make = newName;
        }


        public string Display
        {
            get
            {
                return String.Format("{0} {1} ${2} {3} {4}", Make, Model, Price,Color,Year);
            }
        }
    }
}
