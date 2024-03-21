namespace BlazorServerDemo;

public class UtcDemo :  IUtcDemo
{
    public DateTime StartupTime { get; init; }
    public UtcDemo()
    {
        StartupTime = DateTime.UtcNow;
    }
}
