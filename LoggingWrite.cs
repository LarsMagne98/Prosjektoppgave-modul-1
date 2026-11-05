public class LoggingWrite
{
    const string report = "Report.txt";

    public void WriteToFile(string[] lines)
    {
        File.WriteAllLines(report, lines);
    }
}