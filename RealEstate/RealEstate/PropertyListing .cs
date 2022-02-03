using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstate
{
    public enum propertyType
    {
        unknown,
        SingleFamily,
        Townhouse,
        Condominium
    }
    public class propertyListing
    {
        private property prop;
        private propertyType tp;


        public property Listproperty
        {
            get { return prop; }
            set { prop = value; }
        }
        public propertyType Type
        {
            get { return tp; }
            set { tp = value; }
        }
        public propertyListing()
        {
            prop = new property();
        }
        public void CreateListing()
        {
            Console.WriteLine(" =//= Altair Realtors =//=");
            Console.WriteLine("-=- Property Creation -=-");

            Console.WriteLine("\nTypes of Properties");
            Console.WriteLine("1. Single Family");
            Console.WriteLine("2. Townhouse");
            Console.WriteLine("3. Condonium");
            Console.WriteLine("4. Don't Know");
            Console.Write("Enter Type of Property: ");
            int propType = int.Parse(Console.ReadLine());

            Console.Write("\nEnter Property #: ");
            Listproperty.propertyNumber = Console.ReadLine();
            Console.WriteLine("\nProperties Conditions");
            Console.WriteLine("1. Excellent");
            Console.WriteLine("2. Good (may need minor repair)");
            Console.WriteLine("3. Needs Repair");
            Console.Write("4. In Bad Shape (property needs ");
            Console.WriteLine("major repair or rebuild)");
            Console.Write("Enter Property Condition: ");
            int condition = int.Parse(Console.ReadLine());
            if (condition == 1)
                Listproperty.Condition = propertycondition.excellent;
            else if (condition == 2)
                Listproperty.Condition = propertycondition.good;
            else if (condition == 3)
                Listproperty.Condition =
                propertycondition.needsrepair;
            else if (condition == 4)
                Listproperty.Condition = propertycondition.bedshape;

            else
                Listproperty.Condition = propertycondition.unknown;

            switch ((propertyType)propType)
            {
                case propertyType.SingleFamily:
                    Type = propertyType.SingleFamily;
                    break;

                case propertyType.Townhouse:
                    Type = propertyType.Townhouse;
                    break;

                case propertyType.Condominium:
                    Type = propertyType.Condominium;
                    break;

                default:
                    Type = propertyType.unknown;
                    break;
            }

            Console.Write("\nHow many bedrooms? ");
            Listproperty.Bedrooms = int.Parse(Console.ReadLine());
            Console.Write("How many bathrooms? ");
            Listproperty.Bathrooms = float.Parse(Console.ReadLine());
            Console.Write("Year built: ");
            Listproperty.yearBuilt = int.Parse(Console.ReadLine());
            Console.Write("Property Value: ");
            Listproperty.value = decimal.Parse(Console.ReadLine());
        }

        public void ShowProperty()
        {
            Console.WriteLine("==================================");
            Console.WriteLine(" =//=//= Altair Realtors =//=//=");
            Console.WriteLine("-=-=-=- Properties Listing -=-=-=-");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Property #: {0}", Listproperty.propertyNumber);
            Console.WriteLine("Property Type: {0}", Type);

            switch (Type)
            {
                case propertyType.SingleFamily:
                case propertyType.Townhouse:
                    Type = propertyType.SingleFamily;
                    break;

                case propertyType.Condominium:
                    break;
            }

            Console.WriteLine("Condition: {0}", Listproperty.Condition);
            Console.WriteLine("Bedrooms: {0}", Listproperty.Bedrooms);
            Console.WriteLine("Bathrooms: {0}", Listproperty.Bathrooms);
            Console.WriteLine("Year Built: {0}", Listproperty.yearBuilt);
            Console.WriteLine("Market Value: {0:C}", Listproperty.value);
            Console.WriteLine("=====================================");

        }

    }
}

