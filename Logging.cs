public class Logging
{
    public string? Level { get; set; }
    public string? Source { get; set; }
    public string? Message { get; set; }

    public Logging(string? level, string? source, string? message)
    {
        Level = level;
        Source = source;
        Message = message;
    }

}