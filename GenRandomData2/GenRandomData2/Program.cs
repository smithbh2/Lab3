namespace GenRandomData2
{
    internal class Program
    {
        static List<Person> people = new List<Person>();
        static void Main(string[] args)
        {
            var option = 0;
            do
            {
                DisplayMenu();
                option = Int32.Parse(Console.ReadLine());
                MenuChoice(option);

                Console.WriteLine("\nHit Enter to return to menu...");
                Console.ReadLine();
                Console.Clear();
            } while (option != 0);
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("------ Menu ------");
            Console.WriteLine("1. Create a new Person");
            Console.WriteLine("2. View all people");
            Console.WriteLine("3. Create and View Random Phone");
            Console.WriteLine("4. Create and View Random Last Name");
            Console.WriteLine("5. Create and View Random SSN");
            Console.WriteLine("6. Delete a person from people");
            Console.WriteLine("0. Exit");
            Console.WriteLine("------------------");
        }

        public static void MenuChoice(int option)
        {
            Random random = new Random();
            switch (option)
            {
                case 1:
                    people.Add(new Person());
                    break;
                case 2:
                    {
                        if (people == null || people.Count==0)
                        {
                            people.Add(new Person());
                            Console.WriteLine(people[0]);
                        }
                        else
                        {
                            foreach (Person p in people)
                                Console.WriteLine(p);
                        }
                    }
                    break;
                case 3:
                    Person rando = people[random.Next(people.Count)];
                    Console.WriteLine(rando.Phone);
                    break;
                case 4:
                    Person rando3 = people[random.Next(people.Count)];
                    Console.WriteLine(rando3.LastName);
                    break;

                case 5:
                    Person rando2 = people[random.Next(people.Count())];
                    Console.WriteLine(rando2.SSN);
                    break;
                case 6:
                    Console.WriteLine("What person do you want to remove? (In order of appearance)");
                    int personToRemove = Convert.ToInt32(Console.ReadLine());
                    personToRemove = personToRemove - 1;
                    people.RemoveAt(personToRemove);
                    break;
                case 0:
                    Console.WriteLine("Good-bye.");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}