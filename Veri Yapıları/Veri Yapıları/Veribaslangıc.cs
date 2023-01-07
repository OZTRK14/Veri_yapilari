using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapıları
{
    public class Block
    {
        public int data;
        public Block left; //sol göstericimiz
        public Block right; //sağ göstericimiz 

      

    }
    
   
    internal class Program
    {
        static void Main(string[] args)
        {

            Block b1 = new Block();
            b1.data = 5;
            Block b2 = new Block();
            b2.data = 55;
            Console.WriteLine(b2.data); //b2 nesnesinin datasını 55 belirlemiştik 55 çıktısı alırız
            b1.right = b2; // b1 in nesnesinin sağına b2 yi bağladık           
            b1.right.data = 10; // b2 nesnesinin datasına ulaşarak 55 olan datayı 10 la değiştirdik
            Console.WriteLine(b2.data); //Çıktı olarak 10 değerini aldık           
            Block b3 = new Block();
            b3.left = b2; //b3 nesnesinin soluna b2 nesnesini bağlıyoruz 
            Console.WriteLine(b3.left.data);  //çıktı olarak 10 değerini alırız          
            Console.ReadLine();
        }
    }
    
}
