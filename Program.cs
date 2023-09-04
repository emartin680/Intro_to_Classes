using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBJECTS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human aHuman = new Human();
            Console.WriteLine("The human's name is " + aHuman.getName());
            aHuman.setName("Andrew");
            Console.WriteLine("The human's new name is " + aHuman.getName());
            Human bHuman = new Human();
            Console.WriteLine("The human's name is " + bHuman.getName());
            bHuman.setName("Jason");
            Console.WriteLine("The human's new name is " + bHuman.getName());

            Console.ReadKey();
        }
    }

    class Human
    {
        //Instance variables
        string name = "dave";
        char gender;
        int age;
        //Default constructor
        public Human() 
        { 

        }

        //This is a setter-method for name
        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }



    }
   
}
