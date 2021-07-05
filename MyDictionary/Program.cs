using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {


            MyList<string> myList = new MyList<string>();
            myList.Add("ahmet");
            myList.Add("Veli");
            Console.WriteLine(myList.Count);


        }

    }


    class MyList<T>
    {
        T[] myarray;
        T[] temparray;

        public MyList()
        {

            myarray = new T[0]; //sıfır elemanlı dizi

        }





        public void Add(T item)
        {
            temparray = myarray;
            myarray = new T[myarray.Length + 1];

            myarray[myarray.Length - 1] = item; 


        }

        

        public int Count
        {
            get { return myarray.Length; }
            
        }

    }
}
