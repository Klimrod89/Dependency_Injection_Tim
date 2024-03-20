namespace BlazorServerDemo;

public class ProcessDemo
{
    private readonly IDemo demo;

    public ProcessDemo(IDemo demo)
    {
        this.demo = demo;
    }

    public int GetDaysInMonth()
    {
        return demo.StartupTime.Month switch
        {
            1 => 31,
            2 => IsLeapYear(demo.StartupTime) ? 29 : 28,
            3 => 31,
            4 => 30,
            5 => 31,
            6 => 30,
            7 => 31,
            8 => 31,
            9 => 30,
            10 => 31,
            11 => 30,
            12 => 31,
            _ => throw new IndexOutOfRangeException()
        };
    }

    public bool IsLeapYear(DateTime dateTime)
    {
        bool output = true;
        int year = dateTime.Year;
        if(year % 4 != 0) return false;
        if(year % 100 == 0 && year % 400 != 0) return false;
        return output;
    }
}
