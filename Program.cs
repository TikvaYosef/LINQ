using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNum = new int[10];
            Random random = new Random();
            for (int i = 0; i < arrayOfNum.Length; i++)
            {
                arrayOfNum[i] = random.Next(0, 9);

            }

            //List<int> list = arrayOfNum.Where(item => item % 2 == 0).ToList();

            var listt = from item in arrayOfNum
                        where item % 2 == 0
                        select item;
            foreach (var item in listt)
            {
                Console.WriteLine(item);
            }

            //List<int> list2 = arrayOfNum.Where(item => item > 4).OrderBy(item=>item).ToList();
            //for (int i = 0; i < list2.Count; i++)
            //{
            //    Console.WriteLine(list2[i]);
            //}



            string[] arrayOfNames = new string[] { "ti", "keren", "ya", "eden", "shay" };
            //List<string> list3 = arrayOfNames.Where(item => item.Length > 3).OrderByDescending(item=>item).ToList();
            //for (int i = 0; i < list3.Count; i++)
            //{
            //    Console.WriteLine(list3[i]);
            //}

            //Person[] personArray = new Person[]{
            //    new Person("tikva", "yosef", 1996),
            //    new Person("ke", "hailu", 1994),
            //    new Person("eden", "genet", 1995),
            //    new Person("yafit", "samuel", 1996),};


            //List<Person> list4 = personArray.Where(item => item.Fname.Length > 3).OrderBy(item=>item.YearOfBirth).ToList();
            //Person sameYear = list4.Find(item => item.YearOfBirth == 1996);
            //Console.WriteLine(sameYear.Fname);

            //for (int i = 0; i < list4.Count; i++)
            //{
            //    Console.WriteLine($"{ list4[i].Fname} {list4[i].Lname} {list4[i].YearOfBirth}");
            //}

            //שאלה 1

            //string[] names = new string[] { "tikva", "akeren", "yafit", "eden", "Adva" };

            //List<string> listOfNames = names.Where(item => item[0] == 'A'/'a').ToList();

            //for (int i = 0; i < listOfNames.Count; i++)
            //{
            //    Console.WriteLine(listOfNames[i]);
            //}

            //שאלה 2

            //int[] arrayOfNum1 = new int[] { 15, 17, 89, 9, 4, 25, 13, 26, 89, 45 };
            //List<int> list6 = arrayOfNum1.Where(item => item > 18).ToList();

            //for (int i = 0; i < list6.Count; i++)
            //{
            //    Console.WriteLine(list6[i]);
            //}


            //שאלה 3
            Person[] personArray1 = new Person[]{
                new Person("tikva", "yosef", 1996,"lod"),
                new Person("ke", "hailu", 1994,"tel-aviv"),
                new Person("eden", "genet", 1995,"lod"),
                new Person("yafit", "yosef", 1996,"tel-aviv"),
                new Person ("shay" ,"yosef",2002,"lod"),
                new Person("fds","hailu",2001,"tel-aviv") };

            //List<Person> list7 = personArray1.Where(item => item.YearOfBirth > 2000).ToList();

            //for (int i = 0; i < list7.Count; i++)
            //{
            //    Console.WriteLine(list7[i].Fname);
            //}


            //שאלה 4

            //List<Person> list9 = personArray1.Where(item => item.Fname.Length > 4).ToList();

            //for (int i = 0; i < list9.Count; i++)
            //{
            //    Console.WriteLine(list9[i].Fname);
            //}

            //var filteredList = (from item in personArray1
            //                    group item by item.YearOfBirth);

            //foreach (var group in filteredList)
            //{
            //    Console.WriteLine($"group name: {group.Key}");
            //    foreach (Person personitem in group)
            //    {
            //        Console.WriteLine(personitem.Fname);
            //    }
            //}


            //שאלה 7+8

            //var lastnames = (from item in personArray1
            //                 group item by item.Lname);

            //foreach (var group in lastnames)
            //{
            //    Console.Write($"group name: {group.Key}");
            //    foreach (Person personitem in group)
            //    {
            //        Console.WriteLine(personitem.Lname);
            //    }
            //}


            //שאלה 9+10+11


            



        }
    }
}