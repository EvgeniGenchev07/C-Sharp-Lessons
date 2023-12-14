using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Sort_Algorithms
{
    internal static class Sort
    {
        public static void BubbleSort<T>(this T[] array)
            where T : IComparable<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].MoreThan(array[j + 1]))
                    {
                        array.Swap(j, j + 1);
                    }
                }
            }
        }

        public static void SelectionSort<T>(this T[] array)
            where T : IComparable<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i].MoreThan(array[j]))
                    {
                        array.Swap(i, j);
                    }
                }
            }
        }

        public static void InsertionSort<T>(this T[] array)
            where T : IComparable<T>
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (array[j].LessThan(array[j - 1]))
                    {
                        array.Swap(j, j - 1);
                    }
                }
            }
        }

        public static int DoubleSearch<T>(this T[] array, T value, int finish, int start = 0)
            where T : IComparable<T>
        {
            int pivotIndex = (finish + start) / 2;
            T pivot = array[pivotIndex];
            if (pivot.CompareTo(value) == 0) return pivotIndex;
            else
            {
                if (start - finish == 0) return -1;
                else
                {
                    if (value.LessThan(pivot)) DoubleSearch(array, value, pivotIndex - 1, start);
                    else DoubleSearch(array, value, finish, pivotIndex + 1);
                }
            }
        }

        public static void QuickSort<T>(this T[] array, int finish = 0, int j = 0, int i = 0, int start = 0)
            where T : IComparable<T>
        {
            int pivotIndex = (finish + start) / 2;
            T pivot = array[pivotIndex];
            if (array[i].LessThan(pivot) && i < pivotIndex)
            {
                if (array[j].MoreThan(pivot) && j > pivotIndex) QuickSort(array, finish, j - 1, i + 1, start);
                else QuickSort(array, finish, j, i + 1, start);
            }
            else
            {
                if (array[j].MoreThan(pivot) && j > pivotIndex) QuickSort(array, finish, j - 1, i, start);
                else
                {
                    array.Swap(i, j);
                    if (i == pivotIndex && j == pivotIndex || finish - start == 1)
                    {
                        if (finish - start + 1 <= 3) return;
                        else
                        {
                            QuickSort(array, pivotIndex - 1, pivotIndex - 1, start, start);
                            QuickSort(array, finish, finish, pivotIndex + 1, pivotIndex + 1);
                        }
                    }
                    else
                    {
                        if (i == pivotIndex || j == pivotIndex)
                        {
                            QuickSort(array, finish, finish, start, start);
                        }
                        else QuickSort(array, finish, j - 1, i + 1, start);
                    }
                }
            }
        }

        static bool LessThan<T>(this T arr1, T arr2)
            where T : IComparable<T>
        {
            return arr1.CompareTo(arr2) <= 0;
        }

        static bool MoreThan<T>(this T arr1, T arr2)
            where T : IComparable<T>
        {
            return arr1.CompareTo(arr2) >= 0;
        }

        static void Swap<T>(this T[] array, int i, int j)
            where T : IComparable<T>
        {
            T value = array[j];
            array[j] = array[i];
            array[i] = value;
        }

    }
}
