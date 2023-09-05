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
            Console.WriteLine("The human's name is " + aHuman.getfName());
            aHuman.setfName("Andrew");
            Console.WriteLine("The human's new name is " + aHuman.getfName());
            Human bHuman = new Human();
            Console.WriteLine("The human's name is " + bHuman.getfName());
            bHuman.setfName("Jason");
            Console.WriteLine("The human's new name is " + bHuman.getfName());
            Console.ReadKey();
        }
    }

    class Human
    {
        // Instance variables for objects created from this class
        string fName = "dave"; // All instance objects will, by default, have the name "Dave"
        string surname;
        char gender;
        int age;
        double height;
        // Default constructor. This constructor has no parameters.
        public Human() 
        { 

        }

        // This is a setter-method for full name which will enable users of the program to change the full name of that particular object
        public void setfName(string fName)
        {
            this.fName = fName;
        }

        // This is a getter method which will return the value stored against that particular instance variable
        public string getfName()
        {
            return fName;
        }
    } 
}
