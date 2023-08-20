using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    internal class Person
    {
        public int ID { get; private set; }
        public decimal Salary { get; private set; }
        public string FullName { get; private set; }
        public string Gender { get; private set; }
        public int Age { get; private set; }
        public static int MaxAge { get; private set; } = 80;
        public void DisplaInfo()
        {
            Console.WriteLine("Fullname : "+FullName);
            Console.WriteLine("ID : "+ID);
            Console.WriteLine("Salary : "+Salary);
            Console.WriteLine("Age : "+Age);
            Console.WriteLine();
        }
        public static Person GetOlderPerson(Person person1, Person person2)
        {
            return person1.Age > person2.Age ? person1
                : person2;
        }
        public static int CountFemalePersons(Person[] persons)
        {
            int sum = 0;
            foreach(Person human in persons)
            {
                if(human.Gender == "Female")
                {
                    sum++;
                }
            }
            return sum;
        }

        public Person(int id, int age, string fullName, decimal salary, string gender)
        {
            if (age > MaxAge)
            {
                return;
            }
            ID = id;
            Age = age;
            Salary = salary;
            FullName = fullName;
            Gender = gender;
        }
        public Person(int id, int age, string fullName, string gender)
            : this(id, age, fullName, 3_000_000, gender)
        {

        }
    }
}
