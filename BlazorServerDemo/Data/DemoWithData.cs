namespace BlazorServerDemo;
public class DemoWithData: IDemoWithData
{
    private readonly int numberToRemember;

    public DemoWithData(int numberToRemember)
    {
        this.numberToRemember = numberToRemember;
    }

    public int GetData() => numberToRemember;
}
