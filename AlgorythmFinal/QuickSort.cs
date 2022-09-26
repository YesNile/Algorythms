namespace AlgorithmsAnalysis
{
    public class QuickSort : IResercheable
    {
        private static int[] QuickSorting(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

            QuickSorting(array, minIndex, pivotIndex - 1);

            QuickSorting(array, pivotIndex + 1, maxIndex);

            return array;
        }

        private static int GetPivotIndex(int[] array, int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;

            for (int i = minIndex; i <= maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);

            return pivot;
        }

        private static void Swap(ref int leftItem, ref int rightItem)
        {
            int temp = leftItem;

            leftItem = rightItem;

            rightItem = temp;
        }

        public void Run(int[] array, int value)
        {
            int minIndex = 0;
            int maxIndex = array.Length - 1;
            QuickSorting(array,minIndex,maxIndex);
        }

        public string Name
        {
            get => "QuickSort";

        }
    }
}