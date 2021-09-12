using System;
using System.Collections.Generic;
using System.Text;

namespace Sortinganarray
{
    class FindMin
    {

        public void findmin(int[] a)
        {
            try
            {
                if (a.Length <= 0)
                {
                    throw new IndexOutOfRangeException("Probably a null array");
                }

                int small = a[0];
                for (int i = 0; i < a.Length; i++)
                {
                    int curr = a[i];

                    if (curr < small)
                    {
                        small = curr;
                    }
                }

                Console.WriteLine(small);

            }
            
            
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
}
