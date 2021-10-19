using System;

namespace ConstantC
{
    class ConstanCExersie
    {

        //EMUTABLE 
        //constant fields 
        
        const double pi = 3.1415;
        const int weeks = 52;
        const int days = 365;

        //create a constant of a type string with your birthday as its value


        /*
        string myBirthDay = "30";
        string myBirthMonth = "08";
        string myBirthYear = "1992";
        
        VS
        */
        /*
        public string myBirthDay = "30";
        public string myBirthMonth = "08";
        public string myBirthYear = "1992";
        */
    
        const string myBirthDay = "30";
        const string myBirthMonth = "08";
        const string myBirthYear = "1992";

        const string birthday = "30.08.1992";
      



        static void Main(string[] args)
        {
            /*
            string myBirthDay = "30";
            string myBirthMonth = "08";
            string myBirthYear = "1992";
            */
            Console.WriteLine($"Here is your birthday example A {myBirthDay},{myBirthMonth} ,{myBirthYear} ");
            Console.WriteLine($"Here is your birthday example B {birthday}");
        }
    }
}
