using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    class Static
    {
        public int top { get; set; }
        public int max { get; set; }
        public int[] a { get; set; }
        public Static() {
            this.top = -1;
            this.max = 5;
            this.a=new int[this.max];
        }

        public void push(int item) {
            if (this.top == this.max - 1)
                Console.WriteLine("Stack Overflow");
            else {
                this.top ++;
                a[top] = item;
            }
        }

        public void pop() {
            if (this.top != -1)
                top--;
            else
                Console.WriteLine("Underflow");
        }
    }
}
