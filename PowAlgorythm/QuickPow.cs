﻿namespace PowAlgorythm;

public class QuickPow : PowTest
{
    // public int Steps;
    // public int Number;
    // public int Degree;
    public override long Run()
    {
        long res=0;
        for (int i = 0; i < 2000; i++)
        {
            int count = 0;
            int number = Number;
            int degree = i;
            res = degree % 2 == 1 ? Number : 1;
            
            do
            {
                degree /= 2;
                number *= number;
                if (degree % 2 == 1)
                {
                    res *= number;
                    count++;
                }

                count += 2;
                
            } while (degree != 0);
            Steps.Add(new Steps(degree:i,stepNumber:count));
        }
        

        return res;
    }

    public override string GetName()
    {
        return "QuickPow";
    }
}