using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClass
{
    public class Product
    {
        int productcode;
        string productname;
        double productprice;

        public int ProductCode
        {
            set { productcode = value; }
            get { return productcode; }
        }
        public string Productname
        {
            set { productname = value; }
            get { return productname; }
        }
        public double ProductPrice
        {
            set { productprice = value; }
            get { return productprice; }
        }
        public string putdata()
        {
            return $" date is{productcode}-{productname}-{productname}.";
        }
    }
}
