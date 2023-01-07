using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekliLinkedList
{
    class Block
    {
        public int Data; 
        public Block next;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Block head = null; //Head tekli listenin ilk elamanına bakar 
            Block last=null; //last tekli listenin son elemnına next ile baktırılır
            for (int i = 0; i < 10; i++)
            {
                Block tmp = new Block(); //tmp isimli nesnemiz oluşturulur
                tmp.Data = i;            //datası verilir
                tmp.next = null;                 
                if (head == null)
                {
                    head = tmp;   //önce buraya girer(sadece 1 defa) ve head tmpye bakar tekli listeniz ilk elamanı tmp ye eşitlenir
                    
                }
                else
                {
                   
                    last.next = tmp; //last.next tmpye eşitlenir bu adıma gelmeden önce i=0 ken last tmp ye eşit olduğu için last.next bu adım öncesinde tmp.next e yani null değere eşittir
                 
                  
                }

                last = tmp; //last tmpye bakar ve tmp listenin son eleamanına eşitlenir eğer öncesinde else bloğuna girmişse tmp daha öncesinde last.next e eşitlendiğinden last, last.next e eşitlenmiş olur 
          



            }
            Console.ReadLine();
        }
    }
}
