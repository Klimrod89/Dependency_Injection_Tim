namespace BlazorServerDemo;

public class Demo 
{
    public DateTime StartupTime { get; init; }   
    public Demo()
    {
        StartupTime = DateTime.Now;
    }
}
