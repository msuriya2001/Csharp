// uni-dimensional array in c# 

namespace sample_class
{
  class sample{
    public void array_generation(int n){
        int[] numbers = new int[n];

        for(int i = 0; i<=n; i++){
            Console.WriteLine("enter the {0} number", i); 
            numbers[i] = Convert.ToInt32(Console.ReadLine()); // convert.Toint32 is important because it normally reads the input value as string like in python 
        }
        Console.WriteLine("Printing the values  for the stored array");
        
        Console.WriteLine(numbers[4]);
        }
    }
  }




class main{
    static void Main(){
        var n = new sample_class.sample();
        n.array_generation(5);
    }
}
