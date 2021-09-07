using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsLibrary
{
 public class Products
    {

        //Accept/Display
        //write/read--show
        //set/get--accessor + 
        //private/public/protected/internale/protected internal ----access specifier

        private int _prodid;//backing field to the property
        public int ProductID
        {
            //display the proerty value get block is called
            get { return _prodid; }
            //assigning value to a property set block is called
            set { _prodid = value; }
        }

        private string _prodname;

        public string ProductName
        {
            get { return _prodname; }
            set { _prodname = value; }
        }


        private float _price;

        public float UnitPrice
        {
            get { return _price; }
            set { _price = value; }
        }


        private int _suppid;

        public int SupplierID
        {
            get { return _suppid; }
            set { _suppid = value; }
        }




    }
}
