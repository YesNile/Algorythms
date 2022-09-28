using System.Text;

namespace PowAlgorythm;

public class Export
{
    public static void ExportAsCsvPow(PowTest pow)
    {
        string path =
            $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\{pow.GetName()}_{DateTime.Now.ToString("yyyy-M-dd")}.csv";

        Console.WriteLine($"File saved at: {path}");
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Tested algorithm:;{pow.GetName()}");
        sb.AppendLine($"Number;Degree;Steps");
        foreach (var step in pow.Steps)
        {
            sb.AppendLine($"{pow.Number};{step.Degree};{step.StepNumber}");
        }
        
        File.WriteAllText(path, sb.ToString());
    }
}