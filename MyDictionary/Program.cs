using System;
using System.Collections.Generic;


namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var kullanici = new MyDictionary<int, string>();
            kullanici.Add(0, "Seda");
            kullanici.Add(1, "Eyüp");
            kullanici.Add(2, "İsmail");
        }
    }
    class MyDictionary<T,D>
    {
        T[] arrayKey;
        D[] arrayValue;

        public MyDictionary()
        {
            arrayKey = new T[0];
            arrayValue = new D[0];
        }

        
        public void Add(T key, D value)
        {
            T[] tempKey = arrayKey;
            D[] tempValue = arrayValue;

            arrayKey = new T[arrayKey.Length + 1];
            arrayValue = new D[arrayValue.Length + 1];

            for (int i = 0 ; i < tempKey.Length ; i++)
            {
                arrayKey[i] = tempKey[i];
                arrayValue[i] = tempValue[i];
            }

            arrayKey[arrayKey.Length - 1] = key;
            arrayValue[arrayValue.Length - 1] = value;

            Show(arrayKey, arrayValue);
        }

        public void Show(T[] arrayKey , D[] arrayValue)
        {
            for (int i = 0 ; i < arrayKey.Length ; i++)
            {
                Console.WriteLine("Key: "+ arrayKey[i] +" Value: "+ arrayValue[i]);
                
            }
        }
    }
    
}
