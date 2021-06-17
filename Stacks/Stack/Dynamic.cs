using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    class Dynamic
    {
        public int top { get; set; }
        public int max { get; set; }
        public int[] a { get; set; }
        public Dynamic() {
            this.top = -1;
            this.max = 5;
            this.a = new int[this.max];
        }
        //use the data structure linked list
    }
}
