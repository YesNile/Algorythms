namespace PowAlgorythm;

public abstract class PowTest
{
    public int Number { get; set; } = 3;
    public List<Steps> Steps { get; set; } = new List<Steps>();

    public abstract long Run();

    public abstract string GetName();
}