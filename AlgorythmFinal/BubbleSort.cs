namespace AlgorithmsAnalysis
{
    class BubbleSort : IResercheable
    {
        public BubbleSort(int size,string name) : base(size,name)
        {
        }

        public override void Run(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j + 1], array[j]) = (array[j], array[j + 1]);
                    }
                }
            }
        }
    }
}