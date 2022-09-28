namespace MatrixTest;
public static class Helper
{
    public static void SaveResults(string results)
    {
        File.WriteAllText(Path.GetFullPath("./results.csv"), string.Empty);
        File.AppendAllText(Path.GetFullPath("./results.csv"), results);
    }
    public static void PrintArray(int[] arr)
    {
        foreach (var i in arr)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }
}