using CompLab.Models.Collections;
using System;

namespace CompLab.Models.Entities
{
    public class Computer
    {
        public Guid Id { get; set; }
        public decimal Price { get; set; }
        public Computer Next { get; set; }

        
    }
}
