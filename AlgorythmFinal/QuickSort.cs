namespace AlgorithmsAnalysis
{
    // public class QuickSort : IResercheable
    // {
    //     private static int[] QuickSorting(int[] array, int minIndex, int maxIndex)
    //     {
    //         if (minIndex >= maxIndex)
    //         {
    //             return array;
    //         }
    //
    //         int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);
    //
    //         QuickSorting(array, minIndex, pivotIndex - 1);
    //
    //         QuickSorting(array, pivotIndex + 1, maxIndex);
    //
    //         return array;
    //     }
    //
    //     private static int GetPivotIndex(int[] array, int minIndex, int maxIndex)
    //     {
    //         int pivot = minIndex - 1;
    //
    //         for (int i = minIndex; i <= maxIndex; i++)
    //         {
    //             if (array[i] < array[maxIndex])
    //             {
    //                 pivot++;
    //                 Swap(ref array[pivot], ref array[i]);
    //             }
    //         }
    //
    //         pivot++;
    //         Swap(ref array[pivot], ref array[maxIndex]);
    //
    //         return pivot;
    //     }
    //
    //     private static void Swap(ref int leftItem, ref int rightItem)
    //     {
    //         int temp = leftItem;
    //
    //         leftItem = rightItem;
    //
    //         rightItem = temp;
    //     }
    //
    //     public override void Run(int[] array, int value)
    //     {
    //         int minIndex = 0;
    //         int maxIndex = array.Length - 1;
    //         QuickSorting(array,minIndex,maxIndex);
    //     }
    //     public QuickSort(int size,string name) : base(size,name)
    //     {
    //     }
    // }
    
    // public class QuickSort : IResercheable
    // {
    //     public void Sort(int[] vector, int from, int to)
    //     {
    //         int pivot;
    //         if (from < to)
    //         {
    //             pivot = Partitioner(vector, from, to);
    //             if (pivot > 1)
    //             {
    //                 Sort(vector, from, pivot - 1);
    //             }
    //
    //             if (pivot + 1 < to)
    //             {
    //                 Sort(vector, pivot + 1, to);
    //             }
    //         }
    //     }
    //
    //     private int Partitioner(int[] vector, int from, int to)
    //     {
    //         int pivot = vector[from];
    //         while (true)
    //         {
    //             while (vector[from] < pivot)
    //             {
    //                 from++;
    //             }
    //
    //             while (vector[to] > pivot)
    //             {
    //                 to--;
    //             }
    //
    //             if (from < to)
    //             {
    //                 (vector[from], vector[to]) = (vector[to], vector[from]);
    //             }
    //             else
    //             {
    //                 return to;
    //             }
    //         }
    //     }
    //
    //     public QuickSort(int size, string name) : base(size, name)
    //     {
    //     }
    //
    //     public override void Run(int[] array, int value = 0)
    //     {
    //         Sort(array,0,array.Length-1);
    //     }
    //}
    
    public class QuickSort : IResercheable
    {
        public static int[] Calculate(int[] vector)
        {
            if (vector.Length <= 1) return vector;
            var randomNum = vector[new Random().Next(0, vector.Length)];

            int bigCount = 0;
            int lowCount = 0;
            int equalCount = 0;
            
            foreach(var element in vector)
            {
                if (element > randomNum) 
                    bigCount++;
                else if (element < randomNum) 
                    lowCount++;
                else 
                    equalCount++;
            }

            int[] bigElements = new int[bigCount];
            int[] lowElements = new int[lowCount];
            int[] equalElements = new int[equalCount];

            int lowindex = 0;
            int bigindex = 0;
            int equalindex = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                var element = vector[i];
                if (element > randomNum)
                    bigElements[bigindex++] = element;                  
                else if (element < randomNum)
                    lowElements[lowindex++] = element;
                else
                    equalElements[equalindex++] = element;
            }

            Calculate(lowElements);
            Calculate(bigElements);

            for(int i = 0; i < vector.Length; i++)
            {
                if (i < lowElements.Length)
                    vector[i] = lowElements[i];
                else if (i - lowElements.Length < equalElements.Length)
                    vector[i] = equalElements[i - lowElements.Length];
                else
                    vector[i] = bigElements[i - lowElements.Length - equalElements.Length];
            }
            return vector;
        }

        public QuickSort(int size, string name) : base(size, name)
        {
        }

        public override void Run(int[] array, int value = 0)
        {
            Calculate(array);
        }
    }
}