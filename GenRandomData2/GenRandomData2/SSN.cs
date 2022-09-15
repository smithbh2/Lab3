using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//https://primepay.com/blog/how-determine-valid-social-security-number#:~:text=An%20invalid%20SSN%20is%20one,two%20digits%20as%20%E2%80%9C00.%E2%80%9D


namespace GenRandomData2
{
    internal class SSN
    {
        public string Number { get; init; }


        // constructor
        public SSN()
        {
            Number = GenerateInvalidSSN();
        }

        //Method to generate the SSN
        public string GenerateInvalidSSN()
        {
            // create a variable to store the value we will return
            string invalidSSN = String.Empty;
            Random random = new Random();

            // generate a random number from 900-999 and convert it to a string
            var nineHundredSeries = random.Next(900, 1000).ToString();
            var firstThreeArray = new string[] { "000", "666", nineHundredSeries };

            var firstThree = firstThreeArray[random.Next(3)];
            var secondTwo = "00";
            
            // special variable to randomize the last four digits of the SSN
            var lastFour = "";
            for (int i = 0; i < 4; i++)
            {
                lastFour += random.Next(0, 8).ToString();
            }

            invalidSSN = string.Concat(firstThree, secondTwo, lastFour);
            return invalidSSN;
        }

        //Method to correctly format the SSN
        public override string ToString()
        {
            string socialSecurityNumber = Number;
            socialSecurityNumber = socialSecurityNumber.Insert(3, "-");
            socialSecurityNumber = socialSecurityNumber.Insert(6, "-");
            return socialSecurityNumber;
        }
    }
}
