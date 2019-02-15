using System;

namespace Dog
{
    class Dog
    {
        public string name;

        public string owner;

        public int age;

        public enum Gender
        { 
        Male,
        Female
        };

        public Gender gender;

        //Constructor for the Dog
        public Dog(string newName, string newOwner, int newAge, Gender newGender)
        {
            name = newName;

            owner = newOwner;

            age = newAge;

            gender = newGender;
        }

        //Bark Method
        public void bark(int b)     //b for number of barks 
        { 

            for (int i = 0; i < b; i++)     //loop to display woof 'b' many times
            {
                Console.Write("Woof!");

            }

            Console.WriteLine();
        }

        //to get gender 
        public static string getGender(Gender gender)
        {

            if (gender == Gender.Male)
            {

                return "His";

            }

            return "Her";
        }

        //Get Tag function
        public string getTag()
        {
            //Finds out if it's his or hers and stores possessive gender to hisOrhers

            string hisOrhers = getGender(gender).ToString();
       
            string heOrShe;

            //checks if the variable is his or hers and assigns he or she to the new phrase

            if (hisOrhers == "His")
            {
                heOrShe = "he";
            }

            else
            {
                heOrShe = "she";
            }

            // returns the phrase
            if (age > 1)
            {
                return "If lost, call " + owner + ". " + hisOrhers + " name is " + name + " and " + heOrShe + " is " + age + " years old.";
            }
            else
                return "If lost, call " + owner + ". " + hisOrhers + " name is " + name + " and " + heOrShe + " is " + age + " year old.";
        }


        //main function 
        static void Main(string[] args)
        {
            Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);

            puppy.bark(3);  

            Console.WriteLine("\n");

            Console.WriteLine(puppy.getTag());

            Console.WriteLine("\n");

            Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female);

            myDog.bark(1);

            Console.WriteLine("\n");

            Console.WriteLine(myDog.getTag());

            Console.WriteLine("\n");

        }
    }
}
