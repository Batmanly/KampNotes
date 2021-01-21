using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> // T = Type >> we can write what we want
    {
        T[] items; // T type array
        public MyList() // Constructor 
        {
            items = new T[0]; // we should make new from t[] items for not give exception 
        }
        public void Add(T item)
        {
            T[] tempArray = items; // temparray  will take items reference 
            items = new T[items.Length + 1]; // new refenrece for items

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;//items last item is equal item

        }
        public int Length
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }
        }   
           


    }
}
