using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributesDemo
{
    [Info("1",Name ="Rakesh",Loc ="Mumbai")]
   public class Products
    {


    }

    [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    sealed class InfoAttribute : Attribute
    {
        // See the attribute guidelines at 
        //  http://go.microsoft.com/fwlink/?LinkId=85236
        readonly string positionalString;

        // This is a positional argument
        public InfoAttribute(string positionalString)
        {
            this.positionalString = positionalString;
            this.Loc = Loc;
            // TODO: Implement code here

            //throw new NotImplementedException();
        }

        public string PositionalString
        {
            get { return positionalString; }
        }

        // This is a named argument
        public int NamedInt { get; set; }


        public string Name { get; set; }
        public string Loc { get; set; }
    }
}
