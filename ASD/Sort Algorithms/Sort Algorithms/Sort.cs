using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Sort_Algorithms
{
    internal static class Sort
    {
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

        public static void MergeSort<T>(this T[] array, int start1 = 0, int finish1 = 0, int start2 = 0, int finish2 = 0, bool sigmented = false)
        where T : IComparable<T>
        {
            if (!sigmented)
            {
                int mid1 = (array.Length - 1) / 2;
                finish2 = array.Length - 1;
                finish1 = mid1;
                start2 = mid1 + 1;
                sigmented = true;
            }
            if (finish1 - start1 != 0)
            {
                int mid = (finish1 + start1 - 1) / 2;
                MergeSort(array, start1, mid, mid + 1, finish1, sigmented);

            }
            if (finish2 - start2 != 0)
            {
                int mid = (finish2 + start2 - 1) / 2;
                MergeSort(array, start2, mid, mid + 1, finish2, sigmented);
            }
            T[] oldArray = array.ToArray();
            int index = start1;
            while (start1 <= finish1 && start2 <= finish2)
            {
                if (oldArray[start1].LessThan(oldArray[start2])) array[index] = oldArray[start1++];
                else array[index] = oldArray[start2++];
                index++;
            }
            if (finish1 + 1 == start1)
            {
                for (int i = start2; i <= finish2; i++, index++)
                {
                    array[index] = oldArray[i];
                }
            }
            else
            {
                for (int i = start1; i <= finish1; i++, index++)
                {
                    array[index] = oldArray[i];
                }
            }
        }

        public static void QuickSort<T>(this T[] array, int finish = 0, int j = 0, int i = 0, int start = 0, bool defined = false)
            where T : IComparable<T>
        {
            if (!defined)
            {
                finish = j = array.Length - 1;
                defined = true;
            }
            int pivotIndex = (finish + start) / 2;
            T pivot = array[pivotIndex];
            if (array[i].LessThan(pivot) && i < pivotIndex)
            {
                if (array[j].MoreThan(pivot) && j > pivotIndex) QuickSort(array, finish, j - 1, i + 1, start, defined);
                else QuickSort(array, finish, j, i + 1, start, defined);
            }
            else
            {
                if (array[j].MoreThan(pivot) && j > pivotIndex) QuickSort(array, finish, j - 1, i, start, defined);
                else
                {
                    array.Swap(i, j);
                    if (i == pivotIndex && j == pivotIndex || finish - start == 1)
                    {
                        if (finish - start + 1 <= 3) return;
                        else
                        {
                            QuickSort(array, pivotIndex - 1, pivotIndex - 1, start, start, defined);
                            QuickSort(array, finish, finish, pivotIndex + 1, pivotIndex + 1, defined);
                        }
                    }
                    else
                    {
                        if (i == pivotIndex || j == pivotIndex)
                        {
                            QuickSort(array, finish, finish, start, start, defined);
                        }
                        else QuickSort(array, finish, j - 1, i + 1, start, defined);
                    }
                }
            }
        }

        public static int BinarySearch<T>(this T[] array, T value, int finish = 0, int start = 0, bool defined = false)
            where T : IComparable<T>
        {
            if (!defined)
            {
                finish = array.Length - 1;
                defined = true;
            }
            int pivotIndex = (finish + start) / 2;
            T pivot = array[pivotIndex];
            if (pivot.CompareTo(value) == 0) return pivotIndex;
            else if (finish - start == 0) return -1;
            else if (pivot.CompareTo(value) != 0)
            {
                if (value.LessThan(pivot)) BinarySearch(array, value, pivotIndex - 1, start, defined);
                else BinarySearch(array, value, finish, pivotIndex + 1, defined);
            }
            return -1;
        }

        public static int BinarySearch<T>(this T[] array, T value)
            where T : IComparable<T>
        {
            int finish = array.Length - 1;
            int start = 0;
            while (finish-start >= 0)
            {
                int pivotIndex = (finish + start) / 2;
                T pivot = array[pivotIndex];
                if (pivot.CompareTo(value) == 0) return pivotIndex;
                else
                {
                    if (value.LessThan(pivot)) finish = pivotIndex - 1;
                    else start = pivotIndex + 1;
                }
            }
            return -1;
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
