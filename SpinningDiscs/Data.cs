using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public class Data
    {
        public string Name { get; set; }
        public double Size { get; set; }
        public Data(string name, double size)
        {
            Name = name;
            Size = size;
        }
        public override string ToString()
        {
            return "Name: " + Name + "\n" + "Size: " + Size + " GB" + "\n";
        }
    }
}
