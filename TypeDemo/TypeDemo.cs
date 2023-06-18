using System;

namespace TypeDemoApplication {

    class TypeDemo {
        public static void Main (string[] args) {
            int i = 1;
            Console.WriteLine("int i  = " + i);
            object o = i; // boxing
            Console.WriteLine("boxing object i  = " + o);
            int j = (int) i; //unboxing
            Console.WriteLine("unboxing int j  = " + j);
        }
    }
}