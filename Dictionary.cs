using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Dictionary<TKey, TValue>
    {
        private readonly List<TKey> key;                //field1
        private readonly List<TValue> value;            //field2
        public Dictionary()
        {
            key = new List<TKey>();
            value = new List<TValue>();
        }

        public void AddDictionary(TKey k, TValue v)
        {
            key.Add(k);
            value.Add(v);
        }
        public string this [int index] //простой индексатор
        {
            get { return key[index] + " " + value[index]; }
        }
        public string this[TKey index] // parametr
        {
            get
            {
                for (int i = 0; i<key.Count; i++)
                {
                    if ((string)(object)key[i] == (string)(object)index)
                    {
                        return "По ключу " + index.ToString().ToUpper() + " найдено значение: " + value[i].ToString().ToUpper();
                    }
                }
                return "По ключу " + index + " не найдено значения ";
            }
        }
        public int Length  // number records property 
        {
            get { return key.Count; }        
        }
        public override string ToString() // base class Object
        {
            string lineN = string.Empty;
            for (int i = 0; i < key.Count; i++)
            {
                lineN += key[i] + " " + value[i] + "\n";
            }
            if (lineN != null)
                return lineN;
            return "In dictionary not meaning";
        }

         public void ReplaceValue(int k, TValue newV)                               // method change record
         {
            value.RemoveAt(k);
            value.Insert(k, newV);
         }

    }
}
