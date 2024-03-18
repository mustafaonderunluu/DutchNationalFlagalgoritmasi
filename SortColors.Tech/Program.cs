using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortColors.Tech
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 1, 0, 1, 2, 0 };

            SortColors(nums);

            Console.WriteLine(string.Join(",",nums));

            Console.ReadLine();
        }

        static void SortColors(int[] nums) { 
        
        
        
        int low = 0;
            int high = nums.Length - 1;
            int mid = 0;


            while (mid <= high)
            {
                switch (nums[mid])
                {
                case 0:

                        Swap(nums, low, mid);
                        low++;
                        mid++;
                        break;
                        case 1:
                        mid++;
                        break;
                        case 2:
                        Swap(nums, mid,high);
                        high--;
                        break;
                        



                }


            }
        
        }
        static void Swap(int[] nums,int i , int j) { 
        
        int temp= nums[i];
            nums[i]= nums[j];
            nums[j]= temp;
        
        
        
        
        
        }


    }
}
