using System;
using System.Collections.Generic;
using System.Linq;

namespace Libary
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            string[] classNames = new string[] { "Eyayo", "shimon", "oshri", "ascahlo", "yoni", "jacob", "yafit", "liel" };
            List<string> Enames = (from name in classNames
                                   where name[0] == 'E'
                                   select name).ToList();
            //foreach(string theName in Enames)
            //{
            //    Console.WriteLine(theName);
            //}
            //----------------------------------------
            //2

            int[] randomNum = new int[10];
            Random rd = new Random();
            for(int i = 0; i < randomNum.Length; i++)
            {
                randomNum[i] = rd.Next(30);          
            }
            List<int> theArr = (from age in randomNum 
                                where age > 20
                                select age).ToList();
            //foreach(int age in theArr)
            //{
            //    Console.WriteLine(age);
            //}

            //--------------------------------------
            //3+4+5
            Random random = new Random();
            Book[] books = new Book[]
            {
                new Book("night","smith",random.Next(500)),
                new Book("dayLigh","avner",random.Next(500)),
                new Book("11y","brith",random.Next(500)),
                new Book("potter","jacky",random.Next(500)),
                new Book("love me","dan",random.Next(500)),
                new Book("fight","nir",random.Next(2))
            };
            List<Book> theList = (from page in books
                                  where page.pages>200
                                  select page).ToList();
            //foreach (Book book in theList)
            //{
            //    Console.WriteLine(book.pages);
            //}
            //-----------------------------------------
            //6
            //List<Book> forLetterInName = books.Where(book => book.name.Length > 4).OrderBy(book => book.pages).ToList();
            //foreach(Book someBook in forLetterInName)
            //{
            //    Console.WriteLine(someBook.name);
            //}
            //---------------------------------------------------------------------------------------------------

            //7
            //Book firstbook = theList.Find(item => item.pages == 2);
            //Console.WriteLine(firstbook.name);

            ///8
            List<Book> remmoveFromList = (from book in theList
                                          where book.name[book.name.Length - 1] == 'y'
                                          select book).ToList();
            //foreach(Book delete in remmoveFromList)
            //{
            //    Console.WriteLine(delete.name);
            //}


            //9
            //TO ASK JACOB

            //10
            var filteredList = (from item in theList
                                group item by item.name);
            foreach(var group in filteredList)
            {
                Console.WriteLine($"group :{group.Key}");
                foreach(var eachBook in group)
                {
                    Console.WriteLine($"name : {eachBook.name}");
                }
                Console.WriteLine();
            }
        }
    }
}
