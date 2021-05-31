using System;
using System.Collections.Generic;

// namespace CookieClass
// {
//     public class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Cookie Object Task!");
//             Cookie CookieOne = new Cookie();
//             Console.WriteLine("CookieOne contains a mix of" + " " + CookieOne.red + " " + CookieOne.blue + " " + "colours");

//             Cookie CookieTwo = new Cookie();
//             Console.WriteLine("CookieTwo contains a mix of" + " " + CookieTwo.red + " " + CookieOne.green + " " + "colours");

//             Cookie CookieThree = new Cookie();
//             Console.WriteLine("CookieThree contains a mix of" + " " + CookieThree.blue + " " + CookieThree.green + " " + "colours");

//             Cookie CookieFour = new Cookie();
//             Console.WriteLine("CookieFour contains a mix of" + " " + CookieFour.blue + " " + CookieFour.green + " " + "colours");
//         }
//     }
// }
namespace PeopleClass
{
    class Program : Person
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.firstName = "Qui";
            person.surname = "Dang";
            person.dob = "11th of August 1997";
            person.height = 170;
            person.getFullName();
            person.id();

            Person personTwo = new Person();

            person.firstName = "Chris";
            person.surname = "Hemsworth";
            person.dob = "11th of August 1983";
            person.height = 190;
            person.getFullName();
            person.id();

            Person personThree = new Person();

            person.firstName = "Henry";
            person.surname = "Cavill";
            person.dob = "29th of February 1938";
            person.height = 185;
            person.getFullName();
            person.id();

            getHeightDifference(person.height,personTwo.height);

            List<string> personSubjectList = new List<string>();      

            personSubjectList.Add("Maths" + " ");
            personSubjectList.Add("English");

            person.addSubjects(personSubjectList);    

        }
    }
}
