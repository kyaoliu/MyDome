using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq;

namespace Repository.Student
{
    public class QuickSort
    {
        public void Sort<T1>(T1[] arr, int start, int end, Func<T1, T1, bool> fuc)
        {
            if (start < end)
            {
                var key = arr[start];
                int index = start;
                for (var i = start + 1; i <= end; i++)
                {
                    if (fuc(arr[i], key))
                    {
                        var temp = arr[++index];
                        arr[index] = arr[i];
                        arr[i] = temp;
                    }
                }
                arr[start] = arr[index];
                arr[index] = key;
                Sort(arr, start, index - 1, fuc);
                Sort(arr, index + 1, end, fuc);
            }
        }


        public void Sort(int[] arr, int start, int end)
        {
            if (end > start)
            {
                var key = arr[start];
                var index = start;
                for (int i = start + 1; i < end; i++)
                {
                    if (arr[i] > key)
                    {
                        index++;
                        var temp = arr[index];
                        arr[index] = arr[i];
                        arr[i] = temp;
                    }
                }
                arr[start] = arr[index];
                arr[index] = key;

                Sort(arr, start, index - 1);
                Sort(arr, index + 1, end);
            }
        }
    }
}