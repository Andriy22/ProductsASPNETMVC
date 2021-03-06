﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Product
    {
        public Product()
        {
            properties = new List<Properties>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Desk { get; set; }
        public string URL { get; set; }

        virtual public IEnumerable<Properties> properties { get; set; }
    }
}
