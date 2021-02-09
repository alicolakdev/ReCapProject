﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CarDTO
    {
        public int CarId { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public int ModelYear { get; set; }
    }
}
