delegate void MessageDelegate(string message);
internal class ShowMessage
{
    private string v;

    public ShowMessage(string v)
    {
        this.v = v;
    }
    internal void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }
}