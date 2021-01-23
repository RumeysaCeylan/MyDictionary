using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> dictionary = new Dictionary<string, string>();
            //dictionary.Add("hello","merhaba");
            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine(item.Key+" "+item.Value);
            //}

            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();
            dictionary.Add("school","okul");
            dictionary.Add("hello", "merhaba");
            dictionary.Add("book", "kitap");

            dictionary.Show();
            Console.WriteLine("add new words to dictionary ");

            string word = Console.ReadLine();
            string mean = Console.ReadLine();
            while (true)
            {
            
            dictionary.Add(word, mean);
            Console.WriteLine("add new words to dictionary if do you want stop press 9 ");
            
            word = Console.ReadLine();
                if (word == "9" )
                    break;

            mean = Console.ReadLine();
                if (mean == "9")
                    break;

            }
           
            dictionary.Show();


        }

    }
    class MyDictionary<T,K>
    {
        T[] key;
        K[] value;
        T[] tempK;
        K[] tempV;
        public MyDictionary()
        {
            key = new T[0];
            value = new K[0];
        }
        public void Add(T item1,K item2)
        {
            tempK = key;
            tempV = value;
            key = new T[key.Length + 1];
            value = new K[value.Length + 1];

            for (int i = 0; i < tempK.Length; i++)
            {
                key[i] = tempK[i];
            }
            for (int j = 0; j < tempV.Length; j++)
            {
                value[j] = tempV[j];
            }
            key[key.Length - 1] = item1;
            value[value.Length - 1] = item2;

        }
        public int Count
        {
            get{ return key.Length; }
        }
       
        public void Show()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(i+1+") "+key[i] + " " + value[i]);
            }
        }
    }
}
