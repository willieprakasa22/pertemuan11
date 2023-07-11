using System;
namespace Abstract
{
    public class LasetJet : PrinterWindows
    {
        public string name { get; set; }
        public string dimention { get; set; }

        public LasetJet(string name, string dimention)
        {
            this.name = name;
            this.dimention = dimention;
        }

        public void print()
        {
            Console.WriteLine("{0} display dimention : {1}", this.name, this.dimention);
        }

        public void show()
        {
            Console.WriteLine("{0} printer printing....", this.name);
        }
    }
}

