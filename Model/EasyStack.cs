using System;
using System.Collections.Generic;
using System.Linq;


namespace Stack.Model
{
    class EasyStack<T> : ICloneable
    {
        private List<T> items = new();
        public bool IsEmpty => items.Count == 0;
        public int Count => items.Count;
        public void Push(T item) 
        {
            items.Add(item);
        }
        public T Pop() 
        {
            if (!IsEmpty)
            {
                var item = items.LastOrDefault();
                items.Remove(item);
                return item;
            }
            else 
            {
                throw new NullReferenceException("Stack is empty");
            }
        }
        public void Clear() 
        {
            items.Clear();
        }
        public T Peek() 
        {
            if (!IsEmpty)
            {
                return items.LastOrDefault(); ;
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }

        public override string ToString()
        {
            return $"Elements in stack: {Count}";
        }

        public object Clone()
        {
            var newStack = new EasyStack<T>
            {
                items = new List<T>(items)
            };
            return newStack;
        }
    }
}
