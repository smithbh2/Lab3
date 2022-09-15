using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenRandomData2
{
    internal class Person
    {
            
        private string[] arrayOfFirstNames = new string[] {"Amelia", "Jack", "Cain", "Sara", "Nando", "Bailey", "Addie","Hailey", "Morgan", "Jay" };
        //private Dependent[] dependents;

        public string FirstName { get; init; }
        public string LastName { get; init; }
        public DateTime BirthDate { get; init; }
        public SSN SSN { get; init; }
        public Phone Phone { get; init; }

        //Constructor to generate a person object
        public Person()
        {
            Random rand = new Random();
            FirstName = arrayOfFirstNames[rand.Next(arrayOfFirstNames.Length)];

            Array values = Enum.GetValues(typeof(LastName));
            Random random = new Random();
            LastName randomLastName = (LastName)values.GetValue(random.Next(values.Length));
            this.LastName = randomLastName.ToString();

            DateTime dateToday = DateTime.Now;

            int year = rand.Next(dateToday.Year - 81, dateToday.Year - 19);
            int month = rand.Next(1, 12);
            int day = rand.Next(1, 31);

            BirthDate = new DateTime(year, month, day);

            this.SSN = new SSN();

            this.Phone = new Phone();
        }

        //Method to calculate a person age today
        public int GetAge()
        {
            var age = DateTime.Now - BirthDate;
            return age.Days / 365;
        }

        //Method to correctly format the output to the console 
        public override string ToString()
        {
            return
                $"-----------------------------------------\n" +
                $"First Name:\t{FirstName} \n" +
                $"Last Name: \t{LastName}\n" +
                $"Birthday:\t{BirthDate.ToShortDateString()}\n" +
                $"Age:\t\t{GetAge()}\n" +
                $"SSN:\t\t{SSN}\n" +
                $"Phone:\t\t{Phone.Number}\n" +
                $"-----------------------------------------\n";
        }
    }
}
