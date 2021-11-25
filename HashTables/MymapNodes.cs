using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    public struct KeyValue<k, v>
    {
        public k Key { get; set; }
        public v Value { get; set; }
    }
    public class MymapNodes<K,V>
    {
        private readonly int size;
        private  LinkedList<KeyValue<K, V>>[] items;

        public MymapNodes(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
        protected int GetArrayaposition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }
        public V Get(K key)
        {
            int position = GetArrayaposition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach ( KeyValue<K, V> items in linkedList)
            {
                if (items.Key.Equals(key))
                {
                    return items.Value;
                }

            }
            return default(V);
        }
        public void Add(K key, V value)
        {
            int position = GetArrayaposition(key);

            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() {Key  = key, Value  = value };
            linkedList.AddLast(item);

        }
        public void Remove(K key)                                                    //the remove method
        {
            int position = GetArrayaposition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            bool itemFound = false;                                                  //declaring itemfound variable to be boolean false.
            KeyValue<K, V> foundItem = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> item in linkedList)                          //checking if the input key is already present.
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;                                                //if yes, change the boolean to false 
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                linkedList.Remove(foundItem);
            }

        }

        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)         //this class takes the input as the integer position in range of array items indexes.    
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];             //checks whether there exist any value in that psoition. assigned to linkedlist obj.
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();                   // if there isn't any value, then create the linked list obj in that respective position
                items[position] = linkedList;
            }
            return linkedList;                                                       //return the linkeddlist obj.

        }
        public bool Exists(K key)                                       //check if a key exist in the array's linked list.
        {
            int position = GetArrayaposition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    return true;
                }
            }
            return false;
        }

        public void Display()                         //simple display method that displays the linked lsit object variables inside of the item array.
        {
            foreach (var linkedList in items)
            {
                if (linkedList != null)
                {
                    foreach (var element in linkedList)
                    {
                        string res = element.ToString();
                        if (res != null)
                            Console.WriteLine(element.Key + " " + element.Value);
                            
                    }
                }
            }
        }
    }
    
}
