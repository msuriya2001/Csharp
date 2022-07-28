using System;

/* performing loops 
 for loop
 foreach loop
 while loop
 do while loop 
 */


class For_loop
{
    int[][] numbers = new int[5][]; 
    public void For()
    {
        

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new int[5];

           

        }

    }
}

class ForEachLoop
{
    int [] numbers = new int[5];
    public void ForEach()
    {
        foreach(int i in numbers)
        {
            Console.WriteLine(i);
        }
    }
}

class DowhileLoop
{
    int i;
    public void DoWhileLoop()
    {
        do
        {
            /* code  */

        }while(i< 7);
    }
}

class WhileLoop
{
   public void WhileLOOP()
    {
        /* code */
    }
}

/* main add  */
