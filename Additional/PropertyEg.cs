﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional
{
    class DEllLaptop
    {
        //Properties : to access the private variables of the class
        //read-only property
        public string Laptopname{ get; private set; }  //get:fetch:set:setting the data
       public string ram { get; set; }

        internal DEllLaptop(string Laptopname,string ram)
        {
            this.Laptopname = Laptopname;
            this.ram = ram;
        }
    }
    class Student
    {
        static void Main()
        {
            DEllLaptop d = new DEllLaptop("Inspiron13", "8GB");
            //d.Laptopname="xxxxx";  //read only information
            Console.WriteLine("Name : {0}", d.Laptopname);
            d.ram = "16GB";
            Console.WriteLine("Ram : {0}", d.ram);

            Console.Read();
        }
    }
    class PropertyEg
    {

    }
}
