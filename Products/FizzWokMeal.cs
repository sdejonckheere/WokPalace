﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokPalace.Products
{
    class FizzWokMeal : Meal
    {
        public override void prepare()
        {
            System.Diagnostics.Debug.WriteLine("Preparing Fizz Wok");
        }

        public override void deliver()
        {
            System.Diagnostics.Debug.WriteLine("Delivering Fizz Wok");
        }

        public override int calculatePrice()
        {
            return 5;
        }
    }
}
