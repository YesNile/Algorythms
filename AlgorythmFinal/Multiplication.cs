namespace AlgorithmsAnalysis
{
    public class Multiplication : IResercheable
    {
        public void Run(int[] array, int value)
        {
            int difference = 1;
            foreach (int elem in array)
            {
                difference *= elem;
            }
        }
        public string Name
        {
            get => "Multiplication";
        }
    }
}