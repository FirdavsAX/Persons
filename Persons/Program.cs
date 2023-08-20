using System.Threading.Channels;

namespace Persons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[10];
            
            for(int i = 0; i<5; i++)
            {
                persons[i] = new Person(i, 20+i, "Lyusi",15_000_000 ,"Female");
            }

            for (int i = 5; i<10; i++)
            {
                persons[i] = new Person(i, 20+i, "Luis", "Male");
            }

            Person olderPerson = Person.GetOlderPerson(persons[0], persons[9]);
            
            olderPerson.DisplaInfo();

            int femalesCount = Person.CountFemalePersons(persons);

            Console.WriteLine("Females count : "+ femalesCount);

        }
    }
}