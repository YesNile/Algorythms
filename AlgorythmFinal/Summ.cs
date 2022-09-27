namespace AlgorithmsAnalysis
{
    public class Summ : IResercheable
    {
        public override void Run(int[] array, int value)
        {
            int sum = 0;
            foreach (int elem in array)
            {
                sum += elem;
            }
        }
        public Summ(int size,string name) : base(size,name)
        {
        }
    }
}