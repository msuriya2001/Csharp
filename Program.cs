using System;

namespace suriya
{
    class suriya_1
    {
        public void Sample1()
        {
            Console.WriteLine("please enter your name Mr/Ms");
            string name = Console.ReadLine();
            Console.WriteLine("thank you \n {0}", name);
            Console.WriteLine("hello \""); // this help in printig the " instead of a special charater but as a string
            Console.WriteLine("this is used to \\ to mention the path of the system");  // because we need to print the path of a file like c\path\path  etc 

            // instead of doing in that way we can metntion @ at beginning of the string it act as  f string in python 

            string name1 = @"path\path\path";
            // read more about escape sequence 
            Console.WriteLine(name1);

            // terinary operation in c# 
            int number = 10;
            string trinary = number == 10 ? "yes the number is 10" : "no the number is not 10"; //  this is a terinary operator used insted of single if else statement 
            Console.WriteLine("{0}", trinary);
        }
    }
}

 //  in c# true and false is not in caps 

namespace NULL // null operation 
{
    class null_operation
    {
        public int NULL_OPERATOR()
        {
            int? my_number = 10; // it can also be int? my_number = null;
            int a  = my_number ?? 0; // it can also be written as (int)my_number or my_number.value they de - referrence the null operation
            return a;

        }

    }
}





  
class main_func
{
    static void Main()
    {
        var s = new suriya.suriya_1(); 
        s.Sample1();

        var N = new NULL.null_operation();
        N.NULL_OPERATOR();// 
        Console.WriteLine("\n");
        string sample = "ok fine";
        Console.WriteLine(N.GetType());

        Console.WriteLine("\n");
        Console.WriteLine(sample.GetType()==typeof(string));
        int n = 4;
        int[] number = new int[n];
    }
}



