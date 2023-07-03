using System;

namespace Acme.Collections {
    public class Stack<T>
    {
        Entry _top;

        public void Push(T data)
        {
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

            return result;
        }

        class Entry
        {
            public Entry Next { 
                get
                {
                    return Next; 
                }
                set
                {
                    this.Next = Next;
                }
            }
            public T Data { 
                get
                {
                    return Data;
                }
                set
                {
                    this.Data = Data;
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