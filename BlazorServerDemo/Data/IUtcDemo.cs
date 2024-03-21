namespace BlazorServerDemo;

public interface IUtcDemo: IDemo
{
    DateTime StartupTime { get; init;}
}