using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorph
{
    class PastryChef : Chef
    {
        public PastryChef(string name) : base(name)
        {
        }

        public override string Name { get => base.Name; set => base.Name = value; }
        public override void Cooking()
        {
            Console.WriteLine("{0} has cooked a nice dessert", Name);
        }
        public override void WorkInPosition()
        {            
            Console.Write($"{Name} is working in restaurantas as a pastry chef");
        }

    }
}
