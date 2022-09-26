namespace AlgorithmsAnalysis
{
    class Linal : IResercheable
    {
        public int Returning(int[] array)
        {
            return 1;
        }

        public void Run(int[] array, int value)
        {
            Returning(array);
        }

        public string Name
        {
            get => "Linal";
        }
    }
}