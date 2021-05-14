using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorph
{
    public class RestaurantPersonal
    {
        private string name;
        public virtual string Name 
        { 
            get
            {
                return name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Pleas enter a name");
                }
                name = value;
            }
        }
        public RestaurantPersonal(string name)
        {
            this.Name = name;
        }
        public virtual void WorkInPosition()
        {
            Console.WriteLine($"{Name} is working in restaurant");
        }
    }
}
