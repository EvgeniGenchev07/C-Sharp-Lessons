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

        static void Swap<T>(T[] array, int i, int j)
            where T : IComparable<T>
        {
            T value = array[j];
            array[j] = array[i];
            array[i] = value;
        }

        public static void Quick<T>(this T[] array, bool flag = true, int length = 0, int j = 0, int i = 0)
            where T : IComparable<T>
        {
            if (flag)
            {
                length = array.Length;
            }

            T pivot = array[length / 2];
            if (LessThan(array[i], pivot))
            {
                if (MoreThan(array[j], pivot)) Quick(array, j - 1, i + 1);
                else Quick(array, j, i + 1);
            }
            else
            {
                if (MoreThan(array[j], pivot)) Quick(array, j - 1, i);
                else
                {
                    Swap(array, i, j);
                    int pivotIndex = length / 2;
                    if (i == pivotIndex && j == pivotIndex)
                    {
                        if (pivotIndex <= 1) return;
                        else
                        {
                            Quick(array, pivotIndex, 0);
                            Quick(array, lenght, pivotIndex);
                        }
                    }
                    else if (i == pivotIndex || j == pivotIndex)
                    {
                        Quick(array, length, 0);
                    }
                    else Quick(array, j - 1, i + 1);
                }
            }
        }
    }
}
