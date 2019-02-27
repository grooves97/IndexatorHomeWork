using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexatorApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer range");
            IndexArr.lenght = int.Parse(Console.ReadLine());

            IndexArr iArr = new IndexArr();
            Random rand = new Random();

            for(int i=0;i<IndexArr.lenght;i++)
            {
                iArr[i] = rand.Next(10);
                
            }
            for (int i = 0; i < IndexArr.lenght; i++)
            {
                Console.WriteLine($"{iArr[i]}");
            }


            Console.ReadLine();
        }
    }
}
