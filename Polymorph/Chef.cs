using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorph
{
    class Chef : KichenPersonal
    {
        public override string Name { get => base.Name; set => base.Name = value; }
        public override void Cooking()
        {
            base.Cooking();
            Console.WriteLine("delicious dish");
        }
        public sealed override void SharpeningKnifes()
        {
            Console.WriteLine("Chef has sharpened his knifes");
        }
        public override void WorkInPosition()
        {            
            Console.WriteLine( $"{Name} is working in restaurantas as a chef");
        }
        public Chef(string name):base(name)
        {

        }
    }
}
