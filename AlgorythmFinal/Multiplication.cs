namespace AlgorithmsAnalysis
{
    public class Multiplication : IResercheable
    {
        public override void Run(int[] array, int value)
        {
            int difference = 1;
            foreach (int elem in array)
            {
                difference *= elem;
            }
        }
        public Multiplication(int size,string name) : base(size,name)
        {
        }
    }
}