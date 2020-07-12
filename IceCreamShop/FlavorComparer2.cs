using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace IceCreamShop
{
    public class FlavorComparer2 : IComparer<Flavor>
    {
        public int Compare(Flavor x, Flavor y)
        {
            if (x.Allergens.Count < y.Allergens.Count)
            {
                return -1;
            } 

            else if (x.Allergens.Count == y.Allergens.Count)
            {
                return 0;
            }

            else 
            {
                return 1;
            }
        }
    }
}
