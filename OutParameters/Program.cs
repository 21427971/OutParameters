using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Msimango KSI
namespace OutParameters
{
    class Program
    {

        //The method returns a boolean and accepts a string and a variable that has been declared of type int as input.
        static void Main(string[] args)
        {
            string ageAsString = "102";
            string nameAsString = "Granny";
            //public static bool TryParse (string s, out int result);

            int ageAsInt;
            bool outcome;
            /*Let’s parse another string ageAsString to an integer.

            First, define:
            an int named ageAsInt
            a bool named outcome*/
                        outcome = Int32.TryParse(ageAsString, out ageAsInt);

            Console.WriteLine(outcome);//Print outcome and ageAsInt to the console.
            Console.WriteLine(ageAsInt);//Print outcome and ageAsInt to the console.

            int nameAsInt;
            bool outcome2;
            /*Repeat the process with nameAsString:

 Define:

 an int named nameAsInt
 a bool named outcome2
 Use Int32.TryParse() to convert nameAsString:

 nameAsInt should be used as the out argument
 outcome2 should capture the returned value
 Print the returned value and the out variable to the console.*/
            outcome2 = Int32.TryParse(nameAsString, out nameAsInt);
            Console.WriteLine(outcome2);
            Console.WriteLine(nameAsInt);

        }
    }
}
