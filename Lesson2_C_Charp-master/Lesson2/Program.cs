using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson2
{
    internal class Program
    {

           static List<Person> ask_N_Times(int n)
        {
           
            var ans = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                ans.Add(CreatePerson());
            }
            return ans;
        }
        static Person  CreatePerson()
        {
            
            string name;
            int age = 0;
            Console.WriteLine("Enter a name");
            name = Console.ReadLine();
            do
            {
                //Console.WriteLine("Enter an Age");
                try
                {
                    Console.WriteLine("Enter an Age");
                    age = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("Age is incorrect");
                }
            } while (age <= 0);
            var person = new Person(name);
            person.Age = age;
            return person;
        }


        static void Main(string[] args)
        {
            int num = 0;
            //Person person = new Person("Bilgo Baggins");
            //person.Age = 20;
            //person.Print();
            Console.Write("Enter");
            num =int.Parse( Console.ReadLine());
            var PersonList = ask_N_Times(num);
            foreach(Person person in PersonList)
            {
                Console.WriteLine($"Имя {person.Name} и возраст {person.Age}") ;
            }
            Console.ReadKey();
        }
    }
}
