using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPractice
{
    public class Car
    {
        //Decalre properties and variables 
        // variable for the Make property
        private string _make;
        // declare the Make property
        public string Make 
        {
            get 
            {
                return _make;
            }
        set 
        {
            _make = value.ToUpper();
        }
        }

        //shorthand version of a property
        //code snippet: prop  <Double Tab>
        public string Model { get; set;}
        
        //Step 2. Declare Constructor 
            public Car(string make, string model)
            {
                //set the property
            this.Make = make;
                this.Model = model;
            }
        public Car()
        {
        this.Model = "Didlely";
            this.Make = "Dooo";
        }

        //Step Tree Methods and Functions
        public void Honk()
        {
        Console.WriteLine("BEEP BEEP");
            Console.Beep();
            Console.Beep();
        }
        public string GetInfo()
        {
        return this.Make + " " + this.Model;
        }
    
    

    }
}
