using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExp
{
    internal class LinkedListSoru
    {
       
        internal class Program
        {
            class Block
            {
                public int data;
                public Block next;
                public Block prev;
            }
            static void Main(string[] args)
            {
                Block head = null;
                Block last = null;
                for (int i = 0; i < 10; i++)
                {
                    Block temp = new Block();
                    temp.data = i;
                    temp.next = null;
                    if(head==null)
                    {
                        head = temp;
                        last = temp;
                    }
                    else
                    {
                        last.next = temp;
                        temp.prev = last;
                        last = temp;
                    }


                }
              
            }
          
           
        }

    }
}
