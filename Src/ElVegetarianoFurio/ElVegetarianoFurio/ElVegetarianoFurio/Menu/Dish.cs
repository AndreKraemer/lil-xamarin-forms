﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ElVegetarianoFurio.Menu
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        public ImageSource Image => ImageSource.FromResource($"ElVegetarianoFurio.Images.Dishes.{Id}.jpg");
    }
}
