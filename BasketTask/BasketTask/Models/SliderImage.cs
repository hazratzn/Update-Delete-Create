﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketTask.Models
{
    public class SliderImage
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public bool IsMain { get; set; }
        public Slider Slider { get; set; }
        public int SliderId { get; set; }
    }
}
