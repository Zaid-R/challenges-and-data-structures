﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProject
{
    public class Node
    {
        public int value;
        public Node? next;
        public Node(int value)
        {
            this.value = value;
            next = null;
        }

        public override string ToString()
        {
            return $"{value}";
        }
    }
}
