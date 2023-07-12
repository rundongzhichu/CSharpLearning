using System;

namespace Acme.Collections {
    public class Stack<T>
    {
        Entry _top;

        public void Push(T data)
        {
            Console.WriteLine("push data {0}", data);
            _top = new Entry(_top, data);
        }

        public T Pop()
        {
            if (_top == null)
            {
                throw new InvalidOperationException();
            }
            T result = _top.Data;
            _top = _top.Next;
            Console.WriteLine("pop data {0}", result);
            return result;
        }

        class Entry
        {

            private Entry next;
            private T data;

            public Entry Next { 
                get
                {
                    return next; 
                }
                set
                {
                    this.next = value;
                }
            }
            public T Data { 
                get
                {
                    return data;
                }
                set
                {
                    this.data = value;
                }
            }

            public Entry(Entry next, T data)
            {
                Next = next;
                Data = data;
            }
        }
    }
}