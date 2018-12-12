﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVA_Class_Demo
{
    class DrinksMachine
    {
        public DrinksMachine (string loc, string make, string model)
        {
            this.Location = loc;
            this.Make = make;
            this.Model = model;
        }

        // The following statements declare a private member variables
        private string _location;

        private string _make;

        private string _model;

        public string Location { get => _location; set => _location = value; }
        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }

        // The following statements declare a public methods
        public void MakeCappuccino()
        {
            Console.WriteLine("Cappuccino is made.");
        }

        public void MakeExpresso()
        {
            // the method logic goes here
        }
    }
}
