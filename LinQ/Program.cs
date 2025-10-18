using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace LinQ
{
    internal class Program
    {
        //LinQ
        static List<int> list = [1, 2, 3, 4, 5];

        static void Main(string[] args)
        {
            var a = list.Find(x => x > 3);
            var b = list.FindAll(x => x > 3);
            foreach (var x in b)
            { Console.WriteLine(x); }

            // Kiem tra list nay co chua so chan hay khong => co/khong
            var res = list.Any(x => x % 2 == 0);
            if (res) { Console.WriteLine("Co phan tu la so chan"); }

            // Where 
            var yourList = list.Where(x => x % 2 != 0).ToList();
            yourList.ForEach(x => Console.WriteLine(x)); //foreach linq

            // Viet tay
            List<int> tamChan = new List<int>();
            List<int> tamLe = new List<int>();
            foreach (var x in list)
            {
                if (x % 2 == 0)
                {
                    tamChan.Add(x);
                }
                else
                {
                    tamLe.Add(x);
                }
                
            }
            Console.WriteLine("Tam chan:");
            foreach (var x in tamChan)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Tam le:");
            foreach (var x in tamLe)
            {
                Console.WriteLine(x);
            }
        }


    }
}
