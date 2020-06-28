using CompLab.Models.Collections;

namespace CompLab.Models.Entities
{
    public class Room
    {
        public string Num { get; set; }
        public ComputerList Computers { get; set; }
    }
}
