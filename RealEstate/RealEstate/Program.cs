using System;

namespace RealEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            RealEstate.propertyListing listing = new RealEstate.propertyListing();
            listing.CreateListing();
            Console.Clear();
            listing.ShowProperty();
            System.Console.ReadKey();
        }
    }
}
