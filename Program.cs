using System;

namespace Sortinganarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2,19, 17, 12, 14, 16 };
            int[] nums1 = { };
            Console.WriteLine("The smallest element of the array is ");
            FindMin f = new FindMin();
           // f.findmin(nums);
            f.findmin(nums1);
        }
    }
}
