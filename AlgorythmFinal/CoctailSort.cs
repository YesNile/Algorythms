using System;

namespace AlgorithmsAnalysis
{
    class CoctailSort : IResercheable
    {
        public override void Run(int[] array, int value)
        {
            ShakerSort(array);
        }

        /* Шейкер-сортировка */
        static void ShakerSort(int[] array)
        {
            int left = 0,
                right = array.Length - 1,
                count = 0;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    count++;
                    if (array[i] > array[i + 1])
                        Swap(array, i, i + 1);
                }

                right--;

                for (int i = right; i > left; i--)
                {
                    count++;
                    if (array[i - 1] > array[i])
                        Swap(array, i - 1, i);
                }

                left++;
            }
        }

        /* Поменять элементы местами */
        static void Swap(int[] array, int i, int j)
        {
            int glass = array[i];
            array[i] = array[j];
            array[j] = glass;
        }

        public CoctailSort(int size,string name) : base(size,name)
        {
        }
    }
}