using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaladBot
{
    public class Salad :  ISaladValidator
    {
        private int SaladsCreated = 0;
        public int MinimumToppingsNeeded = 6;
        public List<Topping> saladTopping = new List<Topping>()
        {
            new Topping("Romaine Lettece"),
            new Topping("Shredded Cheese"),
            new Topping("Sliced Tomato"),
            new Topping("Italian Dressing"),
            new Topping("Croutons"),
            new Topping("Black Pepper")
        };

        public void PrintSalad()
        {
            foreach (var topping in saladTopping)
            {
                Console.WriteLine("{0}", topping.Name);
            }
        }

        public void ValidateSaladCount()
        {
            if(saladTopping.Count < MinimumToppingsNeeded)
            {
                Console.WriteLine("Salad is looking a bit empty");
            }
            else
            {
                Console.WriteLine("Bon Appetit!");
            }
        }
    }
}
