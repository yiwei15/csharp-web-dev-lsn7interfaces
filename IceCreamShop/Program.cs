using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;


        // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
        //  field.

        // To sort availableFlavors, Create a new FlavorComparer object

        FlavorComparer comparer1 = new FlavorComparer();

            availableFlavors.Sort(comparer1);
            //availableFlavors.Sort(new FlavorComparer());

            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.


            ConeComparer comparer2 = new ConeComparer();
            availableCones.Sort(comparer2);


            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.

            Console.WriteLine("Flavors: ");
            foreach (Flavor f in availableFlavors)
            {
                Console.WriteLine(f.Name);
            }

            Console.WriteLine("Cones: ");
            foreach (Cone c in availableCones)
            {
                Console.WriteLine(c.Name + ": " + c.Cost);
            }


            //Below is bonus:
            //Console.WriteLine("*****Bonus*****");

            //availableFlavors.Sort(new FlavorComparer2());

            //Console.WriteLine("Flovors by number of allergens:");
            //foreach (Flavor f in availableFlavors)
            //{
            //    Console.WriteLine(f.Name +": ");
            //    foreach (String allergen in f.Allergens)
            //    {
            //        Console.WriteLine(allergen);
            //    }
            //}
        }
    }
}