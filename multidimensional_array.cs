// creating jagged array [[], [], []] 




//int[][] jaggedArray = new int[3][];
// jaggedArray[0] = new int[5];
// jaggedArray[1] = new int[4];
// jaggedArray[2] = new int[2];


// multidimensional jagged array 

// int[][,] JaggedArray = new int[6][,];
// JaggedArray[0] = new int[5,5];
//JaggedArray[1] = new int[5,5];


using System;

namespace Jagged_Array {

    class Jagged_Array_Creation{

        public void creation(int n){

            int[][] array = new int[n][]; //jagged array 
            Console.WriteLine("Enter the number of array that need");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i<n ; i++){
                array[i] = new int[5];
            }
        }
    }
}

namespace Multidimensional_Array {

    class Multidimensional_Array_Creation{

        public void creation(){
            int[,] array = new int[2, 2];
            Console.WriteLine("Start Entering the Numbers");
            for(int i=0; i<2; i++){
                for(int j=0; j<2; j++){
                    Console.WriteLine("{0} \t {1}", i,j);
                    array[i,j] = Convert.ToInt32(Console.ReadLine()); 
                }
                // bool K = array[0 ,0] == 12 ? true : false; // terinary operation
            }

            Console.WriteLine(array[1,1]);
        }
    }
}


class define{
    static void Main(){
    var class1 = new Multidimensional_Array.Multidimensional_Array_Creation();
    class1.creation();
}

}


