using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>() { "Mark", "Paul", "Sandy", "Bill" };

            var firstName = names[0];
            var secondName = names[1];
            var finalName = names[3];

            Console.WriteLine(firstName);
            Console.WriteLine(names.Count);

            names.Add("George");
            Console.WriteLine(names.Count);

            names.Insert(2, "Frank");

            var scores = new List<int>();
            scores.Add(12);
            scores.Add(100);
            scores.Add(55);
            scores.Add(44);
            scores.Add(12);

            var lastIndex = scores.Count - 1;
            var lastScore = scores[lastIndex];

            var indexOfFiftyFive = scores.IndexOf(55);
            Console.WriteLine($"Found 55 at index {indexOfFiftyFive}");

            var indexOfFortyTwo = scores.IndexOf(42);
            Console.WriteLine($"Found 42 at index {indexOfFortyTwo}");

            var indexOfTwelve = scores.LastIndexOf(12);
            Console.WriteLine($"Found 12 at index {indexOfTwelve}");

            var playerScores = new Dictionary<string, int>();

            playerScores.Add("Robbie Lakeman", 1_234_567);
            playerScores["Robbie Lakeman"] = 3;
            playerScores["Gavin Stark"] = 42;


            var robbiePlayerScore = playerScores["Robbie Lakeman"];
            Console.WriteLine(robbiePlayerScore);

            var gavinScore = playerScores["Gavin Stark"];
            Console.WriteLine($"Gavin's score is {gavinScore}");

            var hasKey = playerScores.ContainsKey("Billy Mitchell");
            if (hasKey == true)
            {
                var billyScore = playerScores["Billy Mitchell"];
                Console.WriteLine(billyScore);
            }

            var students = new Queue<string>();
            students.Enqueue("Mary");
            students.Enqueue("Bill");
            students.Enqueue("Paul");
            students.Enqueue("Sandra");
            students.Enqueue("Thomas");

            var firstStudent = students.Dequeue();
            Console.WriteLine(firstStudent);

            //string student;
            foreach (var studentb in students)
            {
                Console.WriteLine($"Hello {studentb}");
            }

            var student = students.Dequeue();
            Console.WriteLine($"Goodbye {student}");
            Console.WriteLine($"There are now {students.Count} students in the queue.");

            student = students.Peek();
            Console.WriteLine($"You are up next {student}");

            Console.Write("What is your name? (typeof quit to end) ");
            var name = Console.ReadLine();

            while (name != "quit")
            {
                Console.WriteLine($"Hello {name}");

                Console.Write("What is your name? ");
                name = Console.ReadLine();
            }

            var counter = 0;




        }
    }
}
