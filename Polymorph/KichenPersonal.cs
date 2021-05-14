using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorph
{
     abstract class KichenPersonal : RestaurantPersonal
    {
        protected  KichenPersonal(string name) : base(name)
        {
        }

        public virtual void Cooking()
        {
            Console.Write("{0} is cooking a ");
        }
        public abstract void SharpeningKnifes();
        

        
    }
}
