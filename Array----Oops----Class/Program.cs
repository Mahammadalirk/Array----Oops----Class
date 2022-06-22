using System;

namespace Array____Oops____Class
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] numbers = new int[6];
            //numbers[0] = 3;
            //numbers[1] = 5;
            //numbers[2] = 100;


            //Array.Resize(ref numbers, 20);
            //int[] nums = { 1, 2, 5, 6, 7, 55, 25 };
            //Array.Sort(nums);

            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}


            //int[,] arr = {
            //       {1,2 },
            //       {3,4 },
            //       {5,6 },

            //};
            //Console.WriteLine(nums.Rank);


            //    numbers[10] = 66; 

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}


            string name1 = "Orxan";
            string surname1 = "Akberov";
            int age1 = 26;

            string name2 = "Emil";
            string surname2 = "Abdullayev";
            int age2 = 20;


            string name3 = "Huseyn";
            string surname3 = "Jafarov";
            int age3 = 24;


            Console.WriteLine(name1 + "  " + surname1);




            var obj1 = new
            {

                name = "Orxan",
                surname = "Akberov",
                age = 26,
            };

            var obj2 = new
            {

             name2 = "Huseyn",
             surname2 = "Jafarov",
             age2 = 24,
        };

            Console.WriteLine(obj2.name2 + "  " + obj2.surname2);




            Student st1 = new Student();
            st1.name = "Orxan";
            st1.surname = "Akberov";
            at1.age = 20;

            Console.WriteLine(st1.name);


     class Student

            public string name;
        public string surname;
        public int age;


            }

    }

}



