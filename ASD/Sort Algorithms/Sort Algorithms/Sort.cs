using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Sort_Algorithms
{
    internal static class Sort
    {
        public static IEnumerable<T> Merge<T>(IEnumerable<T> collection)
        {

            return new T[9].AsEnumerable();
        }
        public static void Bubble<T>(IEnumerable<T> collection)
            where T : IComparable<T>
        {
            for (int i = 0; i < collection.Count() - 1; i++)
            {
                while (true)
                {
                    if (LessThan<T>(collection.ElementAt(i), collection.ElementAt(i + 1)))
                    {

                    }
                    else break;
                }
            }
        }

        public static bool LessThan<T>(this T arr1, T arr2)
            where T : IComparable<T>
        {
            return arr1.CompareTo(arr2) < 0;
        }

        public static bool MoreThan<T>(T arr1, T arr2)
            where T : IComparable<T>
        {
            return arr1.CompareTo(arr2) > 0;
        }

        static void Swap<T>(this T[] array, int i, int j)
            where T : IComparable<T>
        {
            T value = array[j];
            array[j] = array[i];
            array[i] = value;
        }

        public static void Quick<T>(this T[] array, int length = 0, int j = 0, int i = 0,int start=0)
            where T : IComparable<T>
        {
            T pivot = array[(length / 2)+start];
            if (LessThan(array[i], pivot))
            {
                if (MoreThan(array[j], pivot)) Quick(array, length, j - 1, i + 1,start);
                else Quick(array,length, j, i + 1,start);
            }
            else
            {
                if (MoreThan(array[j], pivot)) Quick(array, length, j - 1, i,start);
                else
                {
                    array.Swap(i, j);
                    int pivotIndex = (length / 2) + start;
                    if (i == pivotIndex && j == pivotIndex)
                    {
                        if (length <= 4)
                        {
                            return;
                        }
                        else
                        {
                            Quick(array, pivotIndex - 1, pivotIndex-1, 0, 0);
                            Quick(array, length - pivotIndex, length, pivotIndex+1, pivotIndex+1);
                        }
                    }
                    else if (i == pivotIndex || j == pivotIndex)
                    {
                        Quick(array, length, start+length-1, start,start);
                    }
                    else Quick(array, length, j - 1, i + 1,start);
                }
            }
        }
    }
}
