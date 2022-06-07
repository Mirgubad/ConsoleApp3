using System;

namespace ConsoleApp3
{
    public static class Extension
    {

        public static int[] Add(this int[] arr, int num)
        {
            arr=new int[arr.Length+1] ;
           Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = num;

            return arr;
        }

    }
}
