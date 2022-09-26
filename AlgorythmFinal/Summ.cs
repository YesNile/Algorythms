namespace AlgorithmsAnalysis
{
    public class Summ : IResercheable
    {
        public void Run(int[] array, int value)
        {
            int sum = 0;
            foreach (int elem in array)
            {
                sum += elem;
            }
        }

        public string Name
        {
            get => "Summ";
        }
    }
}