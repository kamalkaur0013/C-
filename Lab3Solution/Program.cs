using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Solution
    
{
    class Program
        
    {
        
        static int[] intArray = {17,  166,  288,  324,  531,  792,  946,  157,  276,  441, 533, 355, 228, 879, 100, 421, 23, 490, 259, 227,
                                 216, 317, 161, 4, 352, 463, 420, 513, 194, 299, 25, 32, 11, 943, 748, 336, 973, 483, 897, 396,
                                 10, 42, 334, 744, 945, 97, 47, 835, 269, 480, 651, 725, 953, 677, 112, 265, 28, 358, 119, 784,
                                 220, 62, 216, 364, 256, 117, 867, 968, 749, 586, 371, 221, 437, 374, 575, 669, 354, 678, 314, 450,
                                 808, 182, 138, 360, 585, 970, 787, 3, 889, 418, 191, 36, 193, 629, 295, 840, 339, 181, 230, 150 };


        static void Main(string[] args)
        
        {
            Console.WriteLine("Unsorted array: ");
            PrintArray(intArray);
            Console.ReadLine();

            
            Console.Write("Enter an interger,please ");
            // convert string to integer
            int userName= int.Parse(Console.ReadLine());
            
            //linear
            Console.WriteLine("-------------------------");
            int numOfComparison = 0;
            int indexNum = LinearSearch(intArray, userName, ref numOfComparison);//to call linear search
            Console.WriteLine("Search successful");
            Console.WriteLine("Element {0} found at index {1} with {2} comparisons \n", userName, indexNum, numOfComparison );

            //bubble
            Console.WriteLine("-------------------------");
            int numOfSwaps = BubbleSort(intArray);
            Console.WriteLine("Bubble sort made {0} swaps to sort this array \n", numOfSwaps);
            Console.WriteLine("sorted array is: \n");

            PrintArray(intArray);
            Console.ReadLine();

            //BinarySearch 
            Console.Write("Enter an interger,please ");
            // convert string to integer
            int userName2 = int.Parse(Console.ReadLine());
            int numOfComparison2 = 0;
            int indexNum2 = BinarySearch(intArray, userName2, ref numOfComparison2);
            if (indexNum2 != -1)
            {
                Console.WriteLine("The value {0} is found at index {1} and it made {2} comparisons \n", userName2, indexNum2, numOfComparison2);

            }
            else
            {
                Console.WriteLine("This took{0} comparisons to find the value \n ", numOfComparison2);
            }
            Console.ReadLine();

        }// End of Main

        //This method returns the index of a given niddle (an int) in the haystack (an int array)
        //by using linear search. It also returns the value of the number of comparison used to 
        //find the given niddle through the reference parameter numOfComparison.
        static int LinearSearch(int[] haystack, int niddle, ref int numOfComparison)
        {
            int niddleIndex = -1;
            numOfComparison = 0;
       
            for (int count = 0; count < haystack.Length; count++)
            {
                numOfComparison++;
                if (haystack[count]==niddle)
                {
                    niddleIndex = count;
                    break;
                    
                    
                }
                   
                
            }

            
            return niddleIndex;
            

            //Here you search the niddle in the haystack.

            
        }
       
        
        static int BubbleSort(int[] arr)
       {
         

            int numOfSwaps = 0;
           int temp;
            
            for (int write = 0; write < arr.Length; write++)
            {
             
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                        numOfSwaps++;

                    }
                    
                }//
                
            }//

            
            //Here you implement the bubble sort to sort the integer array arr.

           return numOfSwaps;
        }

        //This method returns the index of a given niddle (an int) in the haystack (an int array)
        //by using binary search. It also returns the value of the number of comparison used to 
        //find the given niddle through the reference parameter numOfComparison.
        static int BinarySearch(int[] haystack, int niddle, ref int numOfComparison)
        {
            int niddleIndex = -1;

            //Here you implement the binary search to find the niddle in the haystack.

            int first = 0;
            int last = haystack.Length - 1;
            int numOfCamparison = 0;

            do
            {
                int mid = (first + last) / 2;

                if (haystack[mid] == niddle)
                {
                    numOfComparison++;
                    niddleIndex = mid;
                    break;
                }
                else
                {
                    numOfComparison++;

                    if(niddle > haystack[mid])
                    {
                        first = mid + 1;
                    }
                    else
                    {
                        last = mid - 1;
                    }
                }

            } while (first <= last);

            return niddleIndex;     

        } // End of BinarySearch 

        //call this method to print an integer array to the console.
        static void PrintArray(int[] arr)
        {
            for(int i=0; i< arr.Length; i++)
            {
                if (i != arr.Length - 1)
                {
                    Console.Write("{0},", arr[i]);
                }
                else
                {
                    Console.Write("{0},", arr[i]);
                }
            }
            Console.WriteLine();
          
        }//end of print array fun


    }//end of class
}//end of name space
