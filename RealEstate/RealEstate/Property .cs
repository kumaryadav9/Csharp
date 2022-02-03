using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstate
{
    public enum propertycondition
    {
        unknown,
        excellent,
        good,
        needsrepair,
        bedshape
    }
    public class property
    {
        private string propNbr;
        private propertycondition cond;
        private int beds;
        private float baths;
        private int yr;
        private decimal val;

        public property()
        {

        }
        public string propertyNumber
        {
            get { return propNbr; }
            set
            {
                if (propNbr == "")
                    propNbr = "N/A";
                else
                    propNbr = value;
            }
        }
        public propertycondition Condition
        {
            get { return cond; }
            set { cond = value; }
        }
        public int Bedrooms
        {
            get
            {
                if (beds <= 1)
                    return 1;
                else
                    return beds;
            }
            set { beds = value; }
        }
        public float Bathrooms
        {
            get { return baths; }
            set { baths = value; }
        }
        public int yearBuilt
        {
            get { return yr; }
            set { yr = value; }
        }
        public decimal value
        {
            get { return val; }
            set { val = value; }
        }

    }
   
}