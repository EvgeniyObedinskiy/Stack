

using System;

namespace Stack.Model
{/// <summary>
/// Стэк на основе массива.
/// </summary>
/// <typeparam name="T"></typeparam>
    public class ArrayStack<T>
    {
        T[] items;
        public int Count => current + 1;
        private int current = -1;
        private readonly int size = 10;

        /// <summary>
        /// Конструктор пустого стэка
        /// </summary>
        /// <param name="size"></param>
        public ArrayStack(int size = 10)
        {
            items = new T[size];
            this.size = size;
        }
        /// <summary>
        /// Конструктор стэка с указанием первого элемента.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="size"></param>
        public ArrayStack(T data, int size = 10) : this(size) 
        {
            
            items[0] = data;
            current = 1; 
        }
        /// <summary>
        /// Добавление элемента в стэк.
        /// </summary>
        /// <param name="data"></param>
        public void Push(T data) 
        {
            if (current < size - 1)
            {
                current++;
                items[current] = data;
            }
            else 
            {
                throw new StackOverflowException("Stuck is full");
            }
        }
        /// <summary>
        /// Удаление элементе и возвращение его значения.
        /// </summary>
        /// <returns></returns>
        public T Pop() 
        {
            if (current >= 0) 
            {
                var item = items[current];
                items[current] = default(T);
                current--;
                return item;
            }
            else
            {
                throw new NullReferenceException("Stuck is empty");
            }
        }
        /// <summary>
        /// Возвращение значения элемента.
        /// </summary>
        /// <returns></returns>
        public T Peek() 
        {
            if (current >= 0) 
            {
                return items[current];
            }
            else
            {
                throw new NullReferenceException("Stuck is empty");
            }
        }
        public override string ToString()
        {
            return $"Elements in stack: {Count}";
        }
    }
}
