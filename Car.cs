using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop6
{
    internal class Car
    {
        private String brand;
        private int year;
        private float name;

        public Car(String brand, int year, float name)
        {
            this.brand = brand;
            this.year = year;   
            this.name = name;  
        }

        public String toString()
        {
            return $"Brand: {this.brand}, Year: {this.year}, name: {this.name}";
        }

    }
}
