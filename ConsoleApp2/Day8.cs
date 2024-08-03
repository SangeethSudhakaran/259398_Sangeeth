using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Day8
    {
        //Day8
        //Example1 Fields and Properties
        public void Day8Example1_FieldsAndProperties()
        {
            FieldsAndProperties fieldsAndProperties = new FieldsAndProperties();
            Console.WriteLine(fieldsAndProperties.ItemDiscount);
        }


        //Day8
        //Example1 ClassLibrary
        public void Day8Example2_ClassLibrary()
        {
            CalcClient calcClient = new CalcClient();
            calcClient.Sum(1, 3);
        }

        public class FieldsAndProperties
        {
            private string _itemDiscount = "10%";
            public string ItemDiscount { get { return _itemDiscount; } set { _itemDiscount = value; } }

        }
    }
}
