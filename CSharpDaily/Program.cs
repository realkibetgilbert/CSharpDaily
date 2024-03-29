﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
namespace CSharpDaily
{
    class Program
    {
        static void Main(string[] args)
        {

            IList<STUDENT> listofstudents = new List<STUDENT>()
            {
                new STUDENT(){studentid=12,studentname="albert",age=23},
                new STUDENT(){studentid=13,studentname="kibet",age=24},
                new STUDENT(){studentid=14,studentname="bett",age=25},
                new STUDENT(){studentid=15,studentname="muthomi",age=26,
            } };

            var STUDENTS = from s in listofstudents
                           select new
                           {
                               Id = s.studentid,
                               Name = s.studentname,
                               Age = s.age

                           };


            foreach (var stud in STUDENTS)
            {
                Console.WriteLine(stud.Id + "-" + stud.Name);
            }
            //first linq query


            //WORKING WITH NUMBERS

            //INTERGER AND FLOATING  POINT NUMBERS
            //INT ARE WHOLE NUMBERS CAN BE POSITIVE OR NEGATIVE
            //FLOATING POINT NUMBERS WITH ONE OR MORE DECIMAL



            //Console.WriteLine("Hello World!");
            //DEFAULT VALUES IN C#

            // int x = default;
            //int i = 10, j = 20;

            //if (i < j)

            //{
            //    //Console.WriteLine("this is true");
            //}

            //YOU CAN CALL A METHOD THAT RETURN A BOOLEAN INSIDE AN IF STATEMENT



            //static bool IsGreater(int x, int y)
            //{
            //    return x > y;
            //}

            //if(IsGreater(10, 20))
            //{
            //    Console.WriteLine("THIS IS TRUE");
            //}
            //else
            //{
            //    Console.WriteLine("THIS IS FALSE");
            //}
            //if (i == j)
            //{

            //    Console.WriteLine("i is equal to j");

            //}

            //else if (
            //    i > j)
            //{
            //    Console.WriteLine("I IS GREATER THAN J");
            //}

            //else
            //{
            //    Console.WriteLine("I IS LESS THAN J");
            //}

            //terniary operator
            //condition?statetement1:statement2;  ?: ?:  start with boolena condition if true execute first statement
            //otherwise second 

            //you declare a variable

            //var outPut = i < j ? "i is less than j" : "i is greater than j";

            //Console.WriteLine(outPut);

            //switch (i)
            //{
            //    case 0:
            //        Console.WriteLine("IS IS ZERO");
            //        break;
            //    case 10:
            //        Console.WriteLine("The value of i is 10");
            //        break;
            //    default:
            //        Console.WriteLine("This is unknown values");
            //        break;
            //}

            //STRING BUILDER IN C#

            string message = "Hello World";

            StringBuilder stringBuilder = new StringBuilder(message);

            //String builder is not a string so you can retrieve a string using ToString();

            var stringMessage = stringBuilder.ToString();

            Console.WriteLine(stringMessage);


            //to append a string to the end use AppendMethod


            //STRING BUILDER METHODS

            StringBuilder myname = new StringBuilder("Gilbert");

            myname.Append("kibet");

            Console.WriteLine(myname.ToString());

            // insert to insert a stringto

            myname.Insert(5, "korir");

            Console.WriteLine(myname.ToString());


            //remove is used to remove
            myname.Remove(0, 2);
            Console.WriteLine(myname.ToString());


            //you can replace string 

            myname.Replace("korir", "simon");
            Console.WriteLine(myname.ToString());



            ///Accessing enum values

            Console.WriteLine(WeekDays.Friday);

            //to get intergral type we used explicit typecasting

            int friday = (int)WeekDays.Monday;

            Console.WriteLine(friday);

            var WK = (WeekDays)6;

            Console.WriteLine(WK);

            //WORKING WITH DATETIME IN C#  CREATE AN INSTANCE OF DATETIME STRUCT
            DateTime dt = new DateTime();

            Console.WriteLine(dt);

            //assing year month and date

            DateTime today = new DateTime(2023, 03, 05);
            Console.WriteLine(today);



            //assigns year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 20);
            Console.WriteLine(dt3);
            //assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2015, 12, 31, 5, 10, 20, DateTimeKind.Utc);

            Console.WriteLine(dt4);

            //CONVERTING STRING TO DATETIME VALID DATETIME IN STRING  CAN BE CONVERTED TO DATETIME USING PARSE()PARSEEXACT(),TRYPARSE(),TRYPARSEXACT()

            var str = "5/12/2020";

            DateTime DTT;

            var isValidDate = DateTime.TryParse(str, out DTT);

            if (isValidDate)
                Console.WriteLine(dt);
            else
                Console.WriteLine($"{str} is not a valid date string");


            //Accessing enums


            //ANONYMOUS TYPES IN C# class without a name contain public readonly properties cannot contains fields events and methods we use var and new 
            //to declare anonymous objects

            //CREATING ANONYMOUS TYPE STUDENT CONTAININ ID FIRSTNAME AND LASTNAME there are readonly and cannot be initialized with null anonymousfunction
            //pointertype
            var student = new
            {
                Id = 1,
                FirstName = "Gilbert",
                LastName = "Kibet"
            };

            //accessing

            Console.WriteLine(student.FirstName);
            //it can contain other anonymous type
            var student1 = new
            {
                Id = 1,
                FirstName = "Gilbert",
                LastName = "Kibet",
                address = new
                {
                    Id = 1,
                    City = "Nairobi",
                    Country = "Kenya"
                }
            };

            Console.WriteLine(student1.address.Country);
            //you can create array of anonymous type
            var students = new[] {
            new { Id = 1, FirstName = "James", LastName = "Bond" },
            new { Id = 2, FirstName = "Steve", LastName = "Jobs" },
            new { Id = 3, FirstName = "Bill", LastName = "Gates" }
    };

            //creating list of students

            //LEARNING AND UNDERSTANDING NULLLABLE TYPES

            //int age= null; //throws error value types cannot be assigned to null
            int? myAge = null;
            Nullable<int> i = null;
            bool hasV = i.HasValue;
            double? d = null;


            //ASSINGNING NULLABLE TYPE TO NONNULL USING ??  otherwise it will throw run time exception


            int j = myAge ?? 0;

            Console.WriteLine(j);


            //use nullable.Com


            int? iii = null;
            int ji = 10;

            if (Nullable.Compare<int>(i, j) < 0)
                Console.WriteLine("i < j");
            else if (Nullable.Compare<int>(i, j) > 0)
                Console.WriteLine("i > j");
            else
                Console.WriteLine("i = j");

            //LEARNING AND  UNDERSTANDING LISTS IN C#

            List<int> primeNumbers = new List<int>();

            primeNumbers.Add(1);

            primeNumbers.Add(2);

            Console.WriteLine(primeNumbers[0]);

            //using var keyword
            var cities = new List<string>();

            cities.Add("Nairobi");
            cities.Add("Kisumu");
            cities.Add("Nakuru");
            cities.Add("Mombasa");

            //using collection initilizer syntx

            var bigCities = new List<string>()
            {
                "Nairobi",
                "Mombasa"
            };


            //list of anonymous objects

            var studentsList = new List<STUDENT>()
            {

             new STUDENT(){studentid=123,age=23,studentname="gilbert kibet"},
             new STUDENT(){studentid=123,age=23,studentname="gilber korir"},
             new STUDENT(){studentid=123,age=23,studentname="gilbe tonui"},
             new STUDENT(){studentid=123,age=23,studentname="gilb bett"},


            };

            foreach (STUDENT stud in studentsList)
            {
                var studentNames = stud.studentname;
                Console.WriteLine(studentNames);
            };

            //you can add array to list usinf addrange

            var citiees = new string[2] { "eee", "rrrr" };

            List<string> ccc = new List<string>();
            ccc.AddRange(citiees);

            ///inserting elements in a list

            List<int> numbersss = new List<int>() { 1, 3, 4, 5, 6, 7, 8, 9, 10 };

            numbersss.Insert(1, 2);

            Console.WriteLine(numbersss[1]);

            //remove elements in a list
            // numbersss.RemoveAt(1);
            numbersss.Remove(3);

            foreach (int ii in numbersss)
            {
                Console.WriteLine(ii);
            }

            //LEARNING AND UNDERSTANDING DICTIONARY IN C#

            //DICTIONARY<TKEY,TVALUE> STOREKEY VALUE PAIRS  SYTEM COLLECTIONS GENERIC  IDictionary<tkey,tvalue>
            //keys can never be null and unique  ...values can be accesed by passing associated key in indexere
            //myDictionary[key]

            IDictionary<int, string> numberNames = new Dictionary<int, string>();

            numberNames.Add(1, "one");
            numberNames.Add(2, "two");
            numberNames.Add(3, "Three");

            //
            Dictionary<int, string> countryNames = new Dictionary<int, string>();
            //ADD  ITEMS TO A DICTIONATU
            countryNames.Add(254, "Kenya");
            countryNames.Add(213, "Algeria");
            countryNames.Add(20, "Egypt");
            countryNames.Add(255, "Uganda");

            ///country having value key 254

            string kk = countryNames[254];
            //adding elements to dictionary using collection initilaizerr sytn
            var mySongs = new Dictionary<string, string>()
            {
                {"diamond" ,"zuwena"},
                {"alikiba" ,"mahaba"}
            };
            //changing valuesof a dictionary
            mySongs["diamond"] = "kwangaru";

            //acesinf element of dictionary using 
            //removing songs

            mySongs.Remove("diamond");
            var diomondsong = mySongs["diamond"];
            //we can also loop through the elements of dictionary using for each loop

            foreach (KeyValuePair<string, string> songs in mySongs)
            {
                Console.WriteLine("{0}:{1}", songs.Key, songs.Value);
            }
      



        }
    }
    //Class student

    public class STUDENT
    {
        public int studentid { get; set; }

        public string studentname { get; set; }

        public int age { get; set; }

    };
    public enum WeekDays
    {

        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

}
