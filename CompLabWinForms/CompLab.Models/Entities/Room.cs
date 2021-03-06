﻿using CompLab.Models.Collections;

namespace CompLab.Models.Entities
{
    public class Room
    {
        public string Num { get; set; }
        public ComputerList Computers { get; set; } = new ComputerList();
        public decimal ComputersSumPrice { get 
            {
                var sum = 0M;
                foreach (Computer computer in Computers)
                    sum += computer.Price;
                return sum;
            } 
        }
    }
}
