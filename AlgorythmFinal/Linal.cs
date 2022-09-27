namespace AlgorithmsAnalysis
{
    class Linal : IResercheable
    {
        public int Returning(int[] array)
        {
            return 1;
        }

        public override void Run(int[] array, int value)
        {
            Returning(array);
        }
        public Linal(int size,string name) : base(size,name)
        {
        }
    }
}