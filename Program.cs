using System;

namespace Pine_Tree
{
  class Pine_Program
  {
    static void Main(string[] args)
    {
        // int j = 9, k, l;
        // for (int i = 1; i <= j; i++)
        // {  
        //     for (k = 1; k <= (j - i); k++) 
        //         Console.Write(" ");  
        //     for (l = 1; l <= i; l++)
        //         Console.Write(i);  
        //     for (l = (i - 1); l >= 1; l--)
        //         Console.Write(i);  
        //     Console.WriteLine();  
        // } 

        int j = 9, k;
        for (int i = 1; i <= j; i++)
        {
            for (k = 1; k <= i; k++)
                Console.Write(i);
            Console.WriteLine();
        }

        // Console.WriteLine("1");
        // Console.WriteLine("22");  
        // Console.WriteLine("333");  
        // Console.WriteLine("4444");  
        // Console.WriteLine("55555");  
        // Console.WriteLine("666666");  
        // Console.WriteLine("7777777");  
        // Console.WriteLine("88888888"); 
        // Console.WriteLine("999999999");  
    }
  }
}