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
            //This is a constructor call. This creates a new instance (object) of the class human
            Human aHuman = new Human();//This triggers the default constructor method
            
            //This will call getName() instance getter method for the instance variable name
            Console.WriteLine("The human's name is " + aHuman.getName());
            
            //This will call the setName() and set the name tyo "Andrew" using setter method for the instance variable name
            aHuman.setName("Andrew");
            
            //This will call the getName() getter method which should show the name for this object (aHuman) changed to Andrew
            Console.WriteLine("The human's new name is " + aHuman.getName());
            
            //This will create a new human object- bHuman
            Human bHuman = new Human();
            Console.WriteLine("The human's name is " + bHuman.getName());
            bHuman.setName("Jason");
            Console.WriteLine("The human's new name is " + bHuman.getName());

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your gender?");
            char gender = Convert.ToChar(Console.ReadLine());
            int age;
            //This loop will ensure that the user enters an integer as an age before allowing them to proceed
            do
            {
                Console.WriteLine("What is your age?");
            }
            while (!Int32.TryParse(Console.ReadLine(), out age));

            //This will call the parameterised contructor initialising name, gender and age
            Human cHuman = new Human(name, gender, age);
            
            //The following two statements use placeholders to allow the insertion of variables into an output string
            Console.WriteLine("Your name is {0}. You are a {1}. You are {2} years of age", cHuman.getName(), cHuman.getGender(), cHuman.getAge());
            Console.WriteLine($"Your name is {cHuman.getName()}. You are a {cHuman.getGender()}. You are {cHuman.getAge()} years of age");

            bool moreWords = true;
            do
            {
                Console.WriteLine("Please enter the word spoken by your child?");
                aHuman.setSpokenWords(Console.ReadLine());
                Console.WriteLine("Would you like to add another word- enter \"y\" or \"n\"");
                if(Console.ReadLine().ToLower()=="n")
                {
                    moreWords = false;
                }
            }
            while (moreWords);

            List<string> kidsWords = new List<string>();
            kidsWords = aHuman.getSpokenWords();
            foreach (string word in kidsWords)
            {
                Console.WriteLine(word);
            }
            Console.ReadKey();
        }
    }
    class Human
    {
        //Instance variables
        //These are private by default unless an access modifiers is specified i.e. public 
        string name = "dave";
        char gender;
        int age;
        List<string> spokenWords = new List<string>();//This will create a list of string for each object

        //Default constructor
        public Human()
        {

        }

        //This constructor takes three parameters the order, type and number of which is significan
        public Human(string name, char gender, int age)
        {
            // this. refers to the instance variables of the same name as the variable being passed through the constructor call
            this.name = name;
            this.gender = gender;
            this.age = age;
        }

        //The following are GETTERs & SETTERs for instance variables name, gender and age.
        //These are public to ensure 
        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public void setGender(char gender)
        {
            this.gender=gender;
        }

        public char getGender()
        {
            return gender;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public int getAge()
        {
            return age;
        }
        public void setSpokenWords(string word)
        {
            //This will add words to the list of strings for each object
            spokenWords.Add(word);
        }

        //This will return the list of spoken words
        public List<string> getSpokenWords()
        {
            return spokenWords;
        }
            
    }
   
}
