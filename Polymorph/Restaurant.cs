using System;
using System.Collections.Generic;

namespace Polymorph
{
    class Restaurant
    {
        static void Main(string[] args)
        {
            var personal = new List<RestaurantPersonal>();
            personal.Add(new RestaurantPersonal("Gosho"));
            personal.Add(new Chef("Pesho"));
            personal.Add(new PastryChef("Ivan"));

            foreach (var person in personal)
            {
                person.WorkInPosition();
            }

            var kichenPersonal = new List<KichenPersonal>();
            kichenPersonal.Add(new Chef("Maria"));
            kichenPersonal.Add(new PastryChef("Geri"));
            foreach (var person in kichenPersonal)
            {
                person.Cooking();
                person.SharpeningKnifes();
            }
        }
    }
}
