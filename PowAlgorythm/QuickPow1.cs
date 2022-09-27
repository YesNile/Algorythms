﻿namespace PowAlgorythm;

public class QuickPow1 : PowTest
{
    // public int Steps;
    // public int Number;
    // public int Degree;
    public override long Run()
    {
        long res = 1;
        for (int i = 0; i < 2000; i++)
        {
            int count = 0;
            int number = Number;
            res = 1;
            int degree = i;

            while (degree != 0)
            {
                if (degree % 2 == 0)
                {
                    number *= number;
                    degree /= 2;
                    count+=2;
                }
                else
                {
                    res *= number;
                    degree--;
                    count += 2;

                }
            }
            Steps.Add(new Steps(degree:i,stepNumber:count));
            
        }
        

        return res;
    }

    public override string GetName()
    {
        return "QuickPow1";
    }
}