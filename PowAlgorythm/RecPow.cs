namespace PowAlgorythm;

public class RecPow : PowTest
{
    // public int Steps;
    // public int Degree;
    // public int Number;
    public override long Run()
    {
        for (int i = 0; i < 2000; i++)
        {
            RecAlgorithm(i);
        }

        return 0;
    }

    public override string GetName()
    {
        return "RecPow";
    }

    private long RecAlgorithm(int degree)
    {
        int count = 0;
        if (degree == 0)
            {
                count++; 
                return 1;
            }
               
            long res = RecAlgorithm(degree / 2);
            if (degree % 2 == 1)
            {
                count++;
                return res * res * 2;
            }
                
            count++;
            Steps.Add(new Steps(degree:degree,stepNumber:count));
            return res * res;
    }
}