using System;
using System.Collections.Generic;
namespace PeopleClass
{
    public class Person
    {
        public string firstName;
        public string surname;
        public string dob;
        public int height;
       
        public void getFullName()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Hi! My name is" + " " + firstName + " " + surname + " " + "and my height is" + " " + height + "cm");
        }

        public static void getHeightDifference(int x, int y)
        {
            int heightDifference = x - y;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(String.Format("The height difference between Qui and Chris are {0}cm", heightDifference));
        }

        public void id()
        {
            Random rd = new Random();
            int random_num = rd.Next(1000,9999);
            Console.WriteLine("And my number {0}",random_num);
        }

        public void addSubjects(List<string> subjectList)
        {
            Console.WriteLine(String.Format("The subjects for {0}",firstName));
            foreach(string subject in subjectList) {
                Console.Write("{0}", subject);  
            }
        }
    }
}
