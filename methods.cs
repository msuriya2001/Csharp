using System;

/* the below code represent's the differnet types of methods */
// normal method 
// static method 

namespace methods
{
    class METHODS_PROGRAM
    {
        public void Normal_method()        // this method is callled by using creating an instance 
                                           // var p = nethods.METHODS_PROGRAM()
                                           // p.Noramal_method 
        {
            /* code */
        }

        public static void Static_method() // this can be called without any instance that is known as staitc method 
                                           // methods.METHODS_PROGRAM.Static_method();
        {
            /* code */
        }
    }



// using reference in methods 
// note that refernce and pointers are one the same  
// they act as pointer as the same 


/* different types of method parameters 
value parameter 
reference parameter 
out parameter 
parameter arrays
 */

class reference_methods
    {
        public void nonrefcall(int i)   
        {
            i = 30;
        }

        public void refcall(ref int i)
        {
            i = 30;
        }
    }


 class out_parameter // this out parameter is used to return sevral needed output at a time 
                     // mainly used when many output is needed to return'ed to the called function 
    {
               // void return type while using out method parameter 
        public void  out_call(int n , int m , out int total , out int product)   //  very important point is that even though it return two int value's the 
                                                                                 // func is still void in retrun type
        {
            total = n + m;
            product = m * n;
        }
    }


    class params_parameter
    {
        public void passing_array(int[] numbers)
        {
            Console.WriteLine(numbers); // this is simply passing an array
        }
        public void params_use(params int[] numbers) // here it acts as a *args in python where we can have multiple comma seperated inputs and function 
                                                     // gets it as a list .Also we can pass  list to it no problem 
                                                     // also note that paams is always a single dimensional array 
        {
            Console.WriteLine(numbers);
        }

        public void params_object_use(params object[] items) // here we can also pass the  objects list 
        {
            Console.WriteLine(items);


        }
    }
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    


    class main
    {
        static void Main()
        {
            var p = new methods.METHODS_PROGRAM(); // calling a normal method inside  a class 
            p.Normal_method();

            methods.METHODS_PROGRAM.Static_method(); // calling a static method inside a class no need to create an instance 

            /* ref and non ref calls */


            var calls = new reference_methods();
            int j = 20;
            calls.refcall(ref j); // this call outputs  30 the value of j get changed becauce here the i and j uses the same memory location 
            calls.nonrefcall(j); // this call outputs 20 


            /* method out parameter usage */
            // this helps in having multliple return's from a called function

            var out_para = new out_parameter();
            int total = 0;
            int product = 0;
            out_para.out_call(20, 30, out total, out product);
            Console.WriteLine(total);
            Console.WriteLine(product);

            /* params  parameter */
          
            var l = new params_parameter();
            l.params_use(1, 2, 3, 4, 5);

            l.passing_array(new int [] { 1, 2,3 , 4, 5 });

            l.params_object_use(1, "l", 2, "string");

            object[] obj = new object[] {1,"lo", 2, "sample" };
            
            
        
        }

    }
}

