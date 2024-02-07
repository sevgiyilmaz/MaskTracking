
using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables();

            citizen Citizen1 = new citizen();
            Citizen1.Name = "Test"; // default private gelir, public ayarladık

            Say();

            string[] cities1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] cities2 = new[] {"Bursa", "Antalya", "Trabzon" };
            cities1 = cities2;
            cities1[0] = "Adana";
            Console.WriteLine(cities2[0]);

            List<string> cities3 = new List<string> { "Ankara1", "İstanbul1", "İzmir1" };
            cities3.Add("Adana1");

            foreach (string city in cities3) 
            {
                Console.WriteLine(city);
            }

            Person person1 = new Person();
            person1.FirstName = "Sevgi";
            person1.LastName = "Yılmaz";
            person1.DateOfBirthYear = 2001;
            person1.NationalIdentity = 123;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
        }

        static void Say(string name="noname")
        {
            Console.WriteLine("hii " + name );
        }



        private static void Variables()
        {
            bool isAuth = false;

            string name = "Sevgi";
            string lastname = "Yilmaz";
            int dateOfBirth = 2001;
            long tcNo = 12345678910;
        }
    }

    public class citizen
    {
        /* string name = "Sevgi";
        string lastname = "Yilmaz";
        int dateOfBirth = 2001;
        long tcNo = 12345678910;*/

        public string Name { get; set; }
        public string Lastname { get; set; }
        public int DateOfBirth { get; set; }
        public long TcNo { get; set; }

    }

}
